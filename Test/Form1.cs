using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
  public partial class Form1 : Form
  {
    private List<string> currentDeparts;
    private Dictionary<string, string> translateColumns;
    private List<string> banList;

    public Form1()
    {
      InitializeComponent();
      currentDeparts = new List<string>();
      translateColumns = new Dictionary<string, string>
      {
        {"FirstName", "Имя"},
        {"SurName", "Фамилия"},
        {"Patronymic", "Отчество"},
        {"DateOfBirth", "Дата рождения"},
        {"Years", "Полных лет"},
        {"Position", "Должность"},
      };
      banList = new List<String> { "ID", "DocSeries", "DocNumber", "DepartmentID" };
      using (var _entity = new TestDBEntities())
      {
        foreach (var entityDepartment in _entity.Departments)
        {
          departComboBox.Items.Add(entityDepartment.Name);
        }
      }

      fillDepartStructure();
      fillEmployes();
      
    }

    

    private void fillDepartStructure()
    {
      using (var _entity = new TestDBEntities())
      {
        _entity.Departments.ToList().ForEach(depart => {
        if (depart.ParentDepartmentID == null)
        {
          treeView1.Nodes.Add(depart.Name);
          addSubNode(treeView1.Nodes[0], depart.Department1 as HashSet<Department>);
        }
      });
      }

    }

    private void fillEmployes()
    {
      using (var _entity = new TestDBEntities())
      {
        List<EmployeeInfo> _employeeList = new List<EmployeeInfo>();
        _employeeList = _entity.Empoyees
          .Where(x => currentDeparts.Contains(x.DepartmentID.ToString()))
          .Select(x => new EmployeeInfo
        {
          ID = x.ID,
          Имя = x.FirstName,
          Фамилия = x.SurName,
          Отчество = x.Patronymic,
          ДатаРождения = x.DateOfBirth,
          DocSeries = x.DocSeries,
          DocNumber = x.DocNumber,
          Лет = 0,
          Должность = x.Position,
          DepartmentID = x.DepartmentID
        }).ToList();

        _employeeList.ForEach(x =>
        {
          DateTime nowDate = DateTime.Today;
          int age = nowDate.Year - x.ДатаРождения.Year;
          if (x.ДатаРождения > nowDate.AddYears(-age)) age--;
          x.Лет = age;
        });

        dataGridView1.DataSource = _employeeList;
      }

      foreach (DataGridViewTextBoxColumn col in dataGridView1.Columns)
      {
        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        col.ReadOnly = true;
      }

      banList.ForEach(ban => dataGridView1.Columns[ban].Visible = false);
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      updateButton.Enabled = true;
      deleteButton.Enabled = true;
      using (var _entity = new TestDBEntities())
      {
        if (dataGridView1.Rows.Count > 0)
        {
          firstNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
          surNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          patronTextBox.Text = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
          dateTimePicker.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
          docSeriesTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
          docNumberTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
          positionTextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
          var departID = dataGridView1.CurrentRow.Cells[9].Value.ToString();
          departComboBox.SelectedItem = _entity.Departments
            .First(x => x.ID.ToString() == departID)
            .Name;
        }
      }
    }

    private void docNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
      {
        e.Handled = true;
      }

      if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
      {
        e.Handled = true;
      }

    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      clearFieleds();
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      currentDeparts.Clear();
      currentDeparts.Add(getDepartID(treeView1.SelectedNode.Text));
      if (treeView1.SelectedNode.Nodes.Count != 0)
      {
        addCurrentDepart(treeView1.SelectedNode.Nodes);
      }
      fillEmployes();
    }

    #region Save

    private void saveButton_Click(object sender, EventArgs e)
    {
      using (var _entity = new TestDBEntities())
      {
        if (checkFiled())
        {
          var newEmployee = new Empoyee
          {
            FirstName = firstNameTextBox.Text,
            SurName = surNameTextBox.Text,
            Patronymic = patronTextBox.Text,
            DateOfBirth = dateTimePicker.Value,
            DocSeries = docSeriesTextBox.Text,
            DocNumber = docNumberTextBox.Text,
            Position = positionTextBox.Text,
            DepartmentID = _entity.Departments
              .First(x => x.Name == departComboBox.SelectedItem.ToString())
              .ID
          };

          bool result = SaveEmployee(newEmployee);
          ShowStatus(result, "Save", "");

        }
      }
    }

    public bool SaveEmployee(Empoyee emp)
    {
      bool result = false;
      using (var _entity = new TestDBEntities())
      {
        _entity.Empoyees.Add(emp);
        _entity.SaveChanges();
        result = true;
      }
      return result;
    }

    #endregion

    #region Update

    private void updateButton_Click(object sender, EventArgs e)
    {
      using (var _entity = new TestDBEntities())
      {
        if (checkFiled())
        {
          var newEmployee = new Empoyee
          {
            ID = (decimal)dataGridView1.CurrentRow.Cells[0].Value,
            FirstName = firstNameTextBox.Text,
            SurName = surNameTextBox.Text,
            Patronymic = patronTextBox.Text,
            DateOfBirth = dateTimePicker.Value,
            DocSeries = docSeriesTextBox.Text,
            DocNumber = docNumberTextBox.Text,
            Position = positionTextBox.Text,
            DepartmentID = _entity.Departments
              .First(x => x.Name == departComboBox.SelectedItem.ToString())
              .ID
          };

          bool result = UpdateEmployee(newEmployee);
          ShowStatus(result, "Update", "");
        }
      }
    }

    public bool UpdateEmployee(Empoyee emp)
    {
      using (var _entity = new TestDBEntities())
      {
        var _student = _entity.Empoyees.First(x => x.ID == emp.ID);
        _student.FirstName = emp.FirstName;
        _student.SurName = emp.SurName;
        _student.Patronymic = emp.Patronymic;
        _student.DateOfBirth = emp.DateOfBirth;
        _student.DocSeries = emp.DocSeries;
        _student.DocNumber = emp.DocNumber;
        _student.Position = emp.Position;
        _student.DepartmentID = emp.DepartmentID;
        _entity.SaveChanges();
        return true;
      }
    }

    #endregion

    #region Delete

    private void deleteButton_Click(object sender, EventArgs e)
    {
      if (checkFiled() && dataGridView1.CurrentRow != null)
      {
        var id = dataGridView1.CurrentRow.Cells[0].Value;
        bool result = DeleteStudentDetails((decimal)id);
        ShowStatus(result, "Delete", "");
      }
    }

    public bool DeleteStudentDetails(decimal id)
    {
      using (var _entity = new TestDBEntities())
      {
        var _employee = _entity.Empoyees.Where(x => x.ID == id).Select(x => x).FirstOrDefault();
        _entity.Empoyees.Remove(_employee);
        _entity.SaveChanges();
        return true;
      }
    }

    #endregion
    
    #region Extension Functions

    private void addSubNode(TreeNode node, HashSet<Department> depSet)
    {
      var count = 0;
      foreach (var dep in depSet)
      {
        node.Nodes.Add(dep.Name);
        if (dep.Department1.Count != 0)
        {
          addSubNode(node.Nodes[count], dep.Department1 as HashSet<Department>);
        }
        count++;
      }
    }

    private string getDepartID(string name)
    {
      using (var _entity = new TestDBEntities())
      {
        return _entity.Departments.First(x => x.Name == name).ID.ToString();
      }
    }

    private void addCurrentDepart(TreeNodeCollection nodes)
    {
      for (int i = 0; i < nodes.Count; i++)
      {
        currentDeparts.Add(getDepartID(nodes[i].Text));
        if (nodes[i].Nodes.Count != 0)
        {
          addCurrentDepart(nodes[i].Nodes);
        }
      }
    }

    private void clearFieleds()
    {
      updateButton.Enabled = false;
      deleteButton.Enabled = false;
      firstNameTextBox.Text = "";
      surNameTextBox.Text = "";
      patronTextBox.Text = "";
      dateTimePicker.Value = DateTime.Now;
      docSeriesTextBox.Text = "";
      docNumberTextBox.Text = "";
      positionTextBox.Text = "";
      departComboBox.SelectedIndex = -1;
    }

    public void ShowStatus(bool result, string Action, string errorText)
    {
      if (result)
      {
        if (Action.ToUpper() == "SAVE")
        {
          MessageBox.Show("Запись успешно сохранена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (Action.ToUpper() == "UPDATE")
        {
          MessageBox.Show("Запись успешно обнавлена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          MessageBox.Show("Запись успешно удалена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      else
      {
        MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      clearFieleds();
      fillEmployes();
    }

    private bool checkFiled()
    {
      var result = true;
      if (firstNameTextBox.Text.Length == 0)
      {
        result = false;
        ShowStatus(result, "Error", "Не заполнено обязательное поле \"Имя\"");
        return result;
      }
      if (surNameTextBox.Text.Length == 0)
      {
        result = false;
        ShowStatus(result, "Error", "Не заполнено обязательное поле \"Фамилия\"");
        return result;
      }
      if (positionTextBox.Text.Length == 0)
      {
        result = false;
        ShowStatus(result, "Error", "Не заполнено обязательное поле \"Должность\"");
        return result;
      }
      if (departComboBox.SelectedIndex == -1)
      {
        result = false;
        ShowStatus(result, "Error", "Не заполнено обязательное поле \"Отдел\"");
        return result;
      }
      
        
      

      return result;
    }

    #endregion

  }

}
