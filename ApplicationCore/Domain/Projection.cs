using System;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Projection
{
	public Projection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	public DateTime dateProjection { get; set; }
	public string typeProjection { get; set; }
    public virtual Film film { get; set; }
    public virtual Salle salle { get; set; }
	[ForeignKey("Salle")]
	public int salleFk { get; set; }
    [ForeignKey("Film")]
    public int filmFk { get; set; }	
}
