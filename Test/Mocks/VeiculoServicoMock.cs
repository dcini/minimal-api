using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.DTOs;

namespace Test.Mocks;

public class VeiculoServicoMock : IVeiculoServico
{
    private static List<Veiculo> veiculos = new List<Veiculo>(){
        new Veiculo{
            Id = 1,
            Nome = "Fielder",
            Marca = "Toyota",
            Ano = 2008
        },
        new Veiculo{
            Id = 2,
            Nome = "Fiesta",
            Marca = "Ford",
            Ano = 2006
        }
    };

    public void Apagar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public Veiculo? BuscaPorId(int id)
    {
        return veiculos.Find(a => a.Id == id);
    }

    public void Incluir(Veiculo veiculo)
    {
        veiculo.Id = veiculos.Count() + 1;
        veiculos.Add(veiculo);
    }


    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        return veiculos;
    }
}