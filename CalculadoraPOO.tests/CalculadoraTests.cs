using System.Runtime.CompilerServices;
using CalculadoraPOO;
using Xunit;
using Xunit.Abstractions;

namespace CalculadoraPOO.tests
{
    public class CalculadoraTests
    {
        private readonly double _numero1;
        private readonly double _numero2;
        private readonly Calculadora _calculadora;
        private readonly ITestOutputHelper _output;
        public CalculadoraTests(ITestOutputHelper output){

            _output = output;
            Random random = new Random();
            _numero1 = random.Next(1, 100);
            _numero2 = random.Next(1, 100);
            _calculadora = new Calculadora(_numero1, _numero2);

        }

        [Fact]
        public void Soma_DeveRetornarSomaCorreta(){

            var resultado = _calculadora.Soma();
            _output.WriteLine($"Soma: {_numero1} + {_numero2} = {resultado}");
            Assert.Equal(_numero1 + _numero2, resultado);
        }

        [Fact]
        public void Subtracao_DeveRetornarSubtracaoCorreta(){

            var resultado = _calculadora.Subtracao();
            _output.WriteLine($"Subtração: {_numero1} - {_numero2} = {resultado}");
            Assert.Equal(_numero1 - _numero2, resultado);
        }

        [Fact]
        public void Multiplicacao_DeveRetornarMultiplicacaoCorreta(){
            
            var resultado = _calculadora.Multiplicacao();
            _output.WriteLine($"Multiplicação: {_numero1} * {_numero2} = {resultado}");
            Assert.Equal(_numero1 * _numero2, resultado);
        }

        [Fact]

        public void Divisao_DeveRetornarDivisaoCorreta(){

            var resultado = _calculadora.Divisao();
            _output.WriteLine($"Divisão: {_numero1} / {_numero2} = {resultado}");
            Assert.Equal(_numero1 / _numero2, resultado, precision: 3);

        }
    }
}