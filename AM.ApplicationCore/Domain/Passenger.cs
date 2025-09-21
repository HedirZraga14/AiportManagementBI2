using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Passenger
{
	public Passenger()
	{
		public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
		public string EmailAddress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int TelNumber { get; set; }
	public ICollection<Flight> Flights { get; set; } = new List<Flights>();
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
}
