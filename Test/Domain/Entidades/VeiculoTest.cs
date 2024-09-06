using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculosTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var veiculo = new Veiculo();

        // Act
        veiculo.Id = 1;
        veiculo.Nome = "Fielder";
        veiculo.Marca = "Toyota";
        veiculo.Ano = 2008;

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Fielder", veiculo.Nome);
        Assert.AreEqual("Toyota", veiculo.Marca);
        Assert.AreEqual(2008, veiculo.Ano);
    }
}