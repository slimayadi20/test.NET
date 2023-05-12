using System;

/// <summary>
/// Summary description for Class1
/// </summary>
///
public enum TypeFilm
{
	FICTION,ACTION,COMEDIE,AUTRE
}
public class Film
{
	

		//
		// TODO: Add constructor logic here
		public int filmId { get; set; }
		public string titre { get; set; }
		public double duree { get; set; }
		public DateTime dateRealisation { get; set; }
		public double prix { get; set; }
		public TypeFilm typeFilm { get; set; }
    public virtual ICollection<Salle> salles { get; set; }

    public Film	() {
	}	


}
