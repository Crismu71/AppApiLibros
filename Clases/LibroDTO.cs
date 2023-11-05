// nombre de espacio de espacio 
namespace AppApiLibros;

// DTO para definir los atributos de un libro
class LibroDTO
{
    public int id { get; set; }
    public string titulo { get; set; }
    public string resumen { get; set; }
    public int AutorId { get; set; }
}