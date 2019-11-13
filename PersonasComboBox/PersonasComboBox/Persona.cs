using System.Collections.ObjectModel;

public class Persona
{ 
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Foto { get; set; }
    public string Sexo{ get; set; }

    public Persona(int id, string nombre, string foto, string sexo)
    {
        Id = id;
        Nombre = nombre;
        Foto = foto;
        Sexo = sexo;
    }

    public static ObservableCollection<Persona> GetPersonas()
    {
        ObservableCollection<Persona> lista = new ObservableCollection<Persona>();

        lista.Add(new Persona(1, "Pepe", "Recursos\\1.jpg", "Hombre"));
        lista.Add(new Persona(2, "Antonio", "Recursos\\2.jpg", "Hombre"));
        lista.Add(new Persona(3, "Sara", "Recursos\\3.jpg", "Mujer"));

        return lista;
    }
}
