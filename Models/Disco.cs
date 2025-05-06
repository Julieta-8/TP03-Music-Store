namespace TP3_Usoz.Models;

public class Disco{
   public int DNI{ get; private set; }
    public string nombre{ get; private set; }
    public string artista{ get; private set; }
   public string productor{ get; private set; }
  public  string genero{ get; private set; }
    public  string foto{ get; private set; }

 public List<Tema> temas { get; private set; }
 public Disco(int DNI,string nombre,string artista, string productor, string genero, string foto, List<Tema> temas){
    this.DNI = DNI;
    this.nombre = nombre;
    this.artista = artista;
    this.productor = productor;
    this.genero = genero;
     this.foto = foto;
    this.temas = temas;
 }
}