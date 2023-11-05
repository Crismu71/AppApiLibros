// nombre de espacio de espacio 
namespace AppApiLibros;

// Interfaz para definir todos los metodos de la app
interface IBooks
{
    //Metodos de Autores
    //1. Para CrearAutor
    public void CrearAutor(AutorDTO autor);

    //2. Para ObtenerAutorPorId
    public AutorDTO ObtenerAutorPorId(int id);

    //3. Para ActualizarAutor
    public void ActualizarAutor(int id, AutorDTO autor);

    //4. Para EliminarAutor
    public void EliminarAutor(int id);

    //5. Para mostrar todos los autores
    public List<AutorDTO> ObtenertodoAutor();


    //Metodos de Libros
    //1. Para CrearLibro
    public void CrearLibro(LibroDTO libro);

    //2. Para ObtenerLibroPorId
    public LibroDTO ObtenerLibroPorId(int id);

    //3. Para ActualizarLibro
    public void ActualizarLibro(int id, LibroDTO libro);

    //4. Para EliminarLibro
    public void EliminarLibro(int id);

    //5. Para mostrar todo los libros
    public List<LibroDTO> ObtenertodoLibro();  

}