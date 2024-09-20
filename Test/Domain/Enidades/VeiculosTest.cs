using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculosTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange -- Criacao de variaveis --
        var veiculo = new Veiculo();

        //Act -- realizacao da acao de teste --
        veiculo.Id = 1;
        veiculo.Nome = "Fiesta";
        veiculo.Marca = "Ford";
        veiculo.Ano = 2008;

        //Assert -- validacao dos testes --
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Fiesta", veiculo.Nome);
        Assert.AreEqual("Ford", veiculo.Marca);
        Assert.AreEqual(2008, veiculo.Ano);
    }
}