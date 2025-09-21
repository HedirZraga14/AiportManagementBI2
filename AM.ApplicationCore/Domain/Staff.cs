using System;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Staff : Passenger 
{
	public Staff()
	{
		public DateTime EmployementDate { get; set; }
		public string Function { get; set; }
		public float Salary { get; set; }

    }
	public override string ToString()
    {
        return base.ToString();
    }
}
