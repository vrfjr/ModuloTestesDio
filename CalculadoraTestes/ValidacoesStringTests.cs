using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {

        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

         [Fact]
         public void DeveContar3CaracteresEmOlaERetornar3()
         {
            // Given ou Arrange
            string texto = "Ola";
         
            // When ou Act
         int resultado = _validacoes.ContarCaracteres(texto);

            // Then ou Assert
            Assert.Equal(3, resultado);
         }


    }

}