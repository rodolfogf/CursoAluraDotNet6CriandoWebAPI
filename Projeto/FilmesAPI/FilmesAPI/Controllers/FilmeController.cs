using Microsoft.AspNetCore.Mvc;
using FilmesAPI.Models;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        Console.Write($"{filme.Titulo} | ");
        Console.Write($"{filme.Genero} | ");
        Console.WriteLine($"{filme.Duracao} min"); 
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes()
    {
        return filmes;
    }

    [HttpGet("{id}")]
    public Filme? RecuperarFilmePorId(int id)
    {
        return filmes.FirstOrDefault(filme => filme.Id == id);
    }
}