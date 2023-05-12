using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Salle
{
	public Salle()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	[Key]
	public int idSalle { get; set; }
	[Required(ErrorMessage ="num salle obligatoire")]
	public int numero { get; set; }
	[Range(1,50)]
	public int nbPlaces { get; set; }
    public virtual ICollection<Film> films { get; set; }
	public virtual Cinema cinema { get; set; }		
}
