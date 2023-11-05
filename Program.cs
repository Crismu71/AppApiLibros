//usar namespase de la app
using AppApiLibros;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
AppBooks book = new AppBooks();

//creación de rutas con el crud

//1. Para CrearAutor 
app.MapPost("/api/v1/autores", (AutorDTO autor) =>
{
    book.CrearAutor(autor);
    return Results.Ok("Se agrego un nuevo Autor Correctamente");
});

 //2. Para ObtenerAutorPorId
app.MapGet("/api/v1/autores/{id}", (int id) =>
{
    return Results.Ok(book.ObtenerAutorPorId(id));
});

//3. Para ActualizarAutor
app.MapPut("/api/v1/autores/{id}", (AutorDTO autor, int id) => {
    book.ActualizarAutor(id,autor);
    return  Results.Ok("Se Actualizaron los datos de un autor");
});


//4. Para EliminarAutor
app.MapDelete("/api/v1/autores/{id}", (int id) => {
    book.EliminarAutor(id); 
    return  Results.Ok("Si el Autor ya estaba, se Elimino el del id: "+id);
});

//5. Para mostrar todos los autores

app.MapGet("/api/v1/obtenertodoautores", () =>
{
    return Results.Ok(book.ObtenertodoAutor());
});

//1. Para CrearLibro 
app.MapPost("/api/v1/libros", (LibroDTO libro) =>
{
    book.CrearLibro(libro);
    return Results.Ok("Se agrego un nuevo Libro Correctamente");
});

//2. Para ObtenerLibroPorId
app.MapGet("/api/v1/libros/{id}", (int id) =>
{
    return Results.Ok(book.ObtenerLibroPorId(id));
});

//3. Para ActualizarLibro
app.MapPut("/api/v1/libros/{id}", (LibroDTO libro, int id) => {
    book.ActualizarLibro(id,libro);
    return  Results.Ok("Se Actualizaron los datos de un libro");
});

//4. Para EliminarLibro
app.MapDelete("/api/v1/libros/{id}", (int id) => {
    book.EliminarLibro(id); 
    return  Results.Ok("Si el libro ya estaba, se Elimino el del id: "+id);
});

//5. Para mostrar todos los libros
app.MapGet("/api/v1/obtenertodolibros", () =>
{
    return Results.Ok(book.ObtenertodoLibro());
});


app.Run();
/*
--------Datos de Json de libro y autor-----------

{
  "id": 1,
  "nombre": "Gabriel García Márquez",
  "nacionalidad": "Colombia"
}

{
  "id": 1,
  "titulo": "Cien años de soledad",
  "resumen": "Cien años de soledad es una novela del escritor colombiano Gabriel García Márquez. Fue publicada en 1967 y es considerada una de las obras más importantes de la literatura en español del siglo XX.",
  "AutorId": 1
}



{
  "id": 2,
  "titulo": "Crimen y castigo",
  "resumen": "Crimen y castigo es una novela del escritor ruso Fiódor Dostoyevski. Fue publicada por primera vez en 1866 y es considerada una de las obras maestras de la literatura universal.",
  "AutorId": 2
}

{
  "id": 2,
  "nombre": "Fiódor Dostoyevski",
  "nacionalidad": "Rusia"
}




*/