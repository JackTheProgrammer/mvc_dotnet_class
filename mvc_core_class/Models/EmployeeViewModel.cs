using System;
namespace mvc_core_class.Models
{
	public class Employee
	{
		public string employeeName { set; get; } = "";
		public Guid empGuid = Guid.NewGuid();
		public long contactNo { get; set; }
		public string empAddress { set; get; } = "";

		public Employee(
			string empName,
			long empContactNumb,
			string employeeAddress
		)
		{
			this.employeeName = empName;
			this.contactNo = empContactNumb;
			this.empAddress = employeeAddress;
		}
	}
}

