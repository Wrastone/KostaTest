using System.Windows.Forms;

namespace Test
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tabControl = new System.Windows.Forms.TabControl();
      this.employTab = new System.Windows.Forms.TabPage();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.clearButton = new System.Windows.Forms.Button();
      this.deleteButton = new System.Windows.Forms.Button();
      this.updateButton = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.departComboBox = new System.Windows.Forms.ComboBox();
      this.positionTextBox = new System.Windows.Forms.TextBox();
      this.docNumberTextBox = new System.Windows.Forms.TextBox();
      this.docSeriesTextBox = new System.Windows.Forms.TextBox();
      this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.patronTextBox = new System.Windows.Forms.TextBox();
      this.surNameTextBox = new System.Windows.Forms.TextBox();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tabControl.SuspendLayout();
      this.employTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.employTab);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(949, 557);
      this.tabControl.TabIndex = 0;
      // 
      // employTab
      // 
      this.employTab.Controls.Add(this.treeView1);
      this.employTab.Controls.Add(this.clearButton);
      this.employTab.Controls.Add(this.deleteButton);
      this.employTab.Controls.Add(this.updateButton);
      this.employTab.Controls.Add(this.saveButton);
      this.employTab.Controls.Add(this.departComboBox);
      this.employTab.Controls.Add(this.positionTextBox);
      this.employTab.Controls.Add(this.docNumberTextBox);
      this.employTab.Controls.Add(this.docSeriesTextBox);
      this.employTab.Controls.Add(this.dateTimePicker);
      this.employTab.Controls.Add(this.patronTextBox);
      this.employTab.Controls.Add(this.surNameTextBox);
      this.employTab.Controls.Add(this.firstNameTextBox);
      this.employTab.Controls.Add(this.label8);
      this.employTab.Controls.Add(this.label7);
      this.employTab.Controls.Add(this.label6);
      this.employTab.Controls.Add(this.label5);
      this.employTab.Controls.Add(this.label4);
      this.employTab.Controls.Add(this.label3);
      this.employTab.Controls.Add(this.label2);
      this.employTab.Controls.Add(this.label1);
      this.employTab.Controls.Add(this.dataGridView1);
      this.employTab.Location = new System.Drawing.Point(4, 22);
      this.employTab.Name = "employTab";
      this.employTab.Padding = new System.Windows.Forms.Padding(3);
      this.employTab.Size = new System.Drawing.Size(941, 531);
      this.employTab.TabIndex = 1;
      this.employTab.Text = "Employes";
      this.employTab.UseVisualStyleBackColor = true;
      // 
      // treeView1
      // 
      this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.treeView1.Location = new System.Drawing.Point(576, 6);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(326, 209);
      this.treeView1.TabIndex = 21;
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // clearButton
      // 
      this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.clearButton.Location = new System.Drawing.Point(210, 221);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(146, 23);
      this.clearButton.TabIndex = 20;
      this.clearButton.Text = "Clear fileds";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // deleteButton
      // 
      this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.deleteButton.Location = new System.Drawing.Point(467, 111);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(75, 23);
      this.deleteButton.TabIndex = 19;
      this.deleteButton.Text = "Delete";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // updateButton
      // 
      this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.updateButton.Location = new System.Drawing.Point(467, 82);
      this.updateButton.Name = "updateButton";
      this.updateButton.Size = new System.Drawing.Size(75, 23);
      this.updateButton.TabIndex = 18;
      this.updateButton.Text = "Update";
      this.updateButton.UseVisualStyleBackColor = true;
      this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
      // 
      // saveButton
      // 
      this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.saveButton.Location = new System.Drawing.Point(467, 53);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(75, 23);
      this.saveButton.TabIndex = 17;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // departComboBox
      // 
      this.departComboBox.FormattingEnabled = true;
      this.departComboBox.Location = new System.Drawing.Point(143, 194);
      this.departComboBox.Name = "departComboBox";
      this.departComboBox.Size = new System.Drawing.Size(282, 21);
      this.departComboBox.TabIndex = 16;
      // 
      // positionTextBox
      // 
      this.positionTextBox.Location = new System.Drawing.Point(143, 167);
      this.positionTextBox.MaxLength = 50;
      this.positionTextBox.Name = "positionTextBox";
      this.positionTextBox.Size = new System.Drawing.Size(282, 20);
      this.positionTextBox.TabIndex = 15;
      // 
      // docNumberTextBox
      // 
      this.docNumberTextBox.Location = new System.Drawing.Point(143, 139);
      this.docNumberTextBox.MaxLength = 6;
      this.docNumberTextBox.Name = "docNumberTextBox";
      this.docNumberTextBox.Size = new System.Drawing.Size(282, 20);
      this.docNumberTextBox.TabIndex = 14;
      this.docNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.docNumberTextBox_KeyPress);
      // 
      // docSeriesTextBox
      // 
      this.docSeriesTextBox.Location = new System.Drawing.Point(143, 113);
      this.docSeriesTextBox.MaxLength = 4;
      this.docSeriesTextBox.Name = "docSeriesTextBox";
      this.docSeriesTextBox.Size = new System.Drawing.Size(282, 20);
      this.docSeriesTextBox.TabIndex = 13;
      // 
      // dateTimePicker
      // 
      this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
      this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTimePicker.Location = new System.Drawing.Point(143, 85);
      this.dateTimePicker.Name = "dateTimePicker";
      this.dateTimePicker.Size = new System.Drawing.Size(282, 20);
      this.dateTimePicker.TabIndex = 12;
      // 
      // patronTextBox
      // 
      this.patronTextBox.Location = new System.Drawing.Point(143, 58);
      this.patronTextBox.MaxLength = 50;
      this.patronTextBox.Name = "patronTextBox";
      this.patronTextBox.Size = new System.Drawing.Size(282, 20);
      this.patronTextBox.TabIndex = 11;
      // 
      // surNameTextBox
      // 
      this.surNameTextBox.Location = new System.Drawing.Point(143, 32);
      this.surNameTextBox.MaxLength = 50;
      this.surNameTextBox.Name = "surNameTextBox";
      this.surNameTextBox.Size = new System.Drawing.Size(282, 20);
      this.surNameTextBox.TabIndex = 10;
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(143, 6);
      this.firstNameTextBox.MaxLength = 50;
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(282, 20);
      this.firstNameTextBox.TabIndex = 9;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(3, 193);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(102, 18);
      this.label8.TabIndex = 8;
      this.label8.Text = "Department*";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(3, 166);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(77, 18);
      this.label7.TabIndex = 7;
      this.label7.Text = "Position*";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(3, 138);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(103, 18);
      this.label6.TabIndex = 6;
      this.label6.Text = "Doc Number";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(3, 115);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(92, 18);
      this.label5.TabIndex = 5;
      this.label5.Text = "Doc Series";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(3, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(110, 18);
      this.label4.TabIndex = 4;
      this.label4.Text = "Date of Birth*";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 57);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(93, 18);
      this.label3.TabIndex = 3;
      this.label3.Text = "Patronymic";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(3, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 18);
      this.label2.TabIndex = 2;
      this.label2.Text = "Last Name*";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(98, 18);
      this.label1.TabIndex = 1;
      this.label1.Text = "First Name*";
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(8, 261);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.Size = new System.Drawing.Size(925, 262);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(949, 557);
      this.Controls.Add(this.tabControl);
      this.Name = "Form1";
      this.Text = "Kostatest";
      this.tabControl.ResumeLayout(false);
      this.employTab.ResumeLayout(false);
      this.employTab.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage employTab;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox departComboBox;
    private System.Windows.Forms.TextBox positionTextBox;
    private System.Windows.Forms.TextBox docNumberTextBox;
    private System.Windows.Forms.TextBox docSeriesTextBox;
    private System.Windows.Forms.DateTimePicker dateTimePicker;
    private System.Windows.Forms.TextBox patronTextBox;
    private System.Windows.Forms.TextBox surNameTextBox;
    private System.Windows.Forms.TextBox firstNameTextBox;
    private System.Windows.Forms.Label label8;
    private Button clearButton;
    private Button deleteButton;
    private Button updateButton;
    private Button saveButton;
    private TreeView treeView1;
  }
}

