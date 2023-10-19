using Estacionamento.Entities;

namespace EstacionamentoTests
{
    public class VeiculoTeste
    {
        [Fact]
        public void TesteAcelerarVeiculo()
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Acelerar(10);
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TesteFreiaVeiculo()
        {
            Veiculo veiculo=new Veiculo();
            veiculo.Acelerar(3);
            veiculo.Frear(2);
            Assert.Equal(0, veiculo.VelocidadeAtual);
        }
    }
}