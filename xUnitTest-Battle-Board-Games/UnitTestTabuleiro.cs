using BattleBoardGame.Model;
using BattleBoardGame.Model.Factory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnitTest_Battle_Board_Games
{
    public class UnitTestTabuleiro
    {
        [Fact]
        public void PecasTabuleiroTest()
        {
            Tabuleiro tabuleiro = new Tabuleiro();
            tabuleiro.Altura = 8;
            tabuleiro.Largura = 8;

            AbstractFactoryExercito factoryExercito1 =
                 AbstractFactoryExercito.CriarFactoryExercito(
                     AbstractFactoryExercito.Nacao.India);

            AbstractFactoryExercito factoryExercito2 =
                 AbstractFactoryExercito.CriarFactoryExercito(
                     AbstractFactoryExercito.Nacao.Egito);

            for(int i = 0; i<8;i++)
            {
                ElementoDoExercito elementoDoExercito1 = null;
                ElementoDoExercito elementoDoExercito2 = null;

                switch (i%3)
                {
                    case 0:
                        elementoDoExercito1 =
                            factoryExercito1.CriarGuerreiro();
                        elementoDoExercito2 =
                            factoryExercito1.CriarGuerreiro();
                        break;
                    case 1:
                        elementoDoExercito1 =
                            factoryExercito1.CriarArqueiro();
                        elementoDoExercito2 =
                            factoryExercito1.CriarGuerreiro();
                        break;
                    case 2:
                        elementoDoExercito1 =
                            factoryExercito1.CriarCavalaria();
                        elementoDoExercito2 =
                            factoryExercito1.CriarGuerreiro();
                        break;

                }
                tabuleiro.ElementosDoExercito.Add(elementoDoExercito1);
            }

            Assert.True(tabuleiro.ElementosDoExercito.Count == 16);
        }
    }
}
