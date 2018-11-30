using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
  public class EmployeeInfo
  {
      public decimal ID { get; set; }
      public string Имя { get; set; }
      public string Фамилия { get; set; }
      public string Отчество { get; set; }
      public System.DateTime ДатаРождения { get; set; }
      public int Лет { get; set; }
      public string DocSeries { get; set; }
      public string DocNumber { get; set; }
      public string Должность { get; set; }
      public System.Guid DepartmentID { get; set; }

  }
}
