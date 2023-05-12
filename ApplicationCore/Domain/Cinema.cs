using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Cinema
{
	public Cinema()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	public int cinemaId { get; set; }
	public string nom { get; set; }
	public string localisation { get; set; }
    public virtual ICollection<Salle> salles { get; set; }
}
