// nombre de espacio de espacio 
namespace AppApiLibros;

// clase que usa la interfaz con los metodos que seran usados o requeridos para la implemnetación
class AppBooks : IBooks
{
    //Crear base de datos en memoria
    private List<AutorDTO> memoriaAutor;
    private List<LibroDTO> memoriaLibro;
    public AppBooks()
    {
        this.memoriaAutor = new List<AutorDTO>();
        this.memoriaLibro = new List<LibroDTO>();
    }

    //Implemento los metodos de la interfaz IBooks
    //1. Para CrearAutor
    public void CrearAutor(AutorDTO autor)
    {
        this.memoriaAutor.Add(autor);
    }

    //2. Para ObtenerAutorPorId
    public AutorDTO ObtenerAutorPorId(int id)
    {
        //mostrar solo el objeto que cumpla con id
        AutorDTO opten1 = this.memoriaAutor.Single(autor => autor.id == id);
        return opten1;
    }

    //3. Para ActualizarAutor
    public void ActualizarAutor(int id, AutorDTO autor)
    {
        AutorDTO autorUpdate = this.memoriaAutor.Single(autor => autor.id == id);
        // Actualizar los campos de un autorUpdate con los valores del nuevo
        autorUpdate.nombre = autor.nombre;
        autorUpdate.nacionalidad = autor.nacionalidad;

        //actualizo el autor en memoria
        this.memoriaAutor[id - 1] = autorUpdate;
    }

    //4. Para EliminarAutor
    public void EliminarAutor(int id)
    {   //elimina el objeto que lleve ese id
        this.memoriaAutor.RemoveAll(autor => autor.id == id);
    }

    //5. Para mostrar todos los autores
    public List<AutorDTO> ObtenertodoAutor()
    {
        return this.memoriaAutor;
    }

    //implementar metodos para Libros 
    //1. Para CrearLibro
    public void CrearLibro(LibroDTO libro)
    {
        this.memoriaLibro.Add(libro);
    }

    //2. Para ObtenerLibroPorId
    public LibroDTO ObtenerLibroPorId(int id)
    {
        //mostrar solo el objeto que cumpla con id
        LibroDTO opten1 = this.memoriaLibro.Single(libro => libro.id == id);
        return opten1;
    }

    //3. Para ActualizarLibro
    public void ActualizarLibro(int id, LibroDTO libro)
    {
        LibroDTO libroUpdate = this.memoriaLibro.Single(libro => libro.id == id);
        // Actualizar los campos de un libroUpdate con los valores del nuevo
        libroUpdate.titulo = libro.titulo;
        libroUpdate.resumen = libro.resumen;

        //actualizo el libro en memoria
        this.memoriaLibro[id - 1] = libroUpdate;
    }

    //4. Para EliminarLibro
    public void EliminarLibro(int id)
    {   //elimina el objeto que lleve ese id
        this.memoriaLibro.RemoveAll(libro => libro.id == id);
    }

    //5. Para mostrar todos los libros
    public List<LibroDTO> ObtenertodoLibro()
    {
        return this.memoriaLibro;
    }

}