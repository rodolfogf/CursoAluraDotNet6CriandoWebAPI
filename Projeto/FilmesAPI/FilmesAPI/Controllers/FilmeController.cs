using Microsoft.AspNetCore.Mvc;
using FilmesAPI.Models;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {
        filmes.Add(filme);
        Console.Write($"{filme.Titulo} | ");
        Console.Write($"{filme.Genero} | ");
        Console.Write($"{filme.Duracao} min"); 
    }

    [HttpPost]
    public IEnumerable<Filme> RecuperaFilmes()
    {
        return filmes;
    }
}