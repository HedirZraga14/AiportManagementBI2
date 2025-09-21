using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Flight
{
	public Flight()
	{
		public String destination { get; set; }
		public String Departure { get; set; }
		public DateTime FlightDate { get; set; }
		public int FlightId { get; set; }
		public String EffectiveArrival { get; set; }
		public DateTime EstimatedDuration { get; set; }
        public int Plane Plane { get; set; }
		public ICollection <Passenger> Passengers { get; set; } = new List<Passengers>();
    public Plane? Plane { get; set; }

    //
    // TODO: Add constructor logic here
    //
}
  public override string ToString()
    {
        return base.ToString();
    }
}
