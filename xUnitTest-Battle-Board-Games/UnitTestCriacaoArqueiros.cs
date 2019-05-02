using System;
using Xunit;
using BattleBoardGame.Model.Factory;
using BattleBoardGame.Model;

namespace xUnitTest_Battle_Board_Games
{
    public class UnitTestCriacaoArqueiros
    {
        [Fact]
        public void CriacaoExercitoIndianoTest()
        {
            AbstractFactoryExercito factoryExercito =
                 AbstractFactoryExercito.CriarFactoryExercito(
                     AbstractFactoryExercito.Nacao.India);

            Arqueiro arqueiro = factoryExercito.CriarArqueiro();
            Assert.IsType<ArqueiroIndiano>(arqueiro);
        }
        [Fact]
        public void CriacaoExercitoPersaTest()
        {
            AbstractFactoryExercito factoryExercito =
                 AbstractFactoryExercito.CriarFactoryExercito(
                     AbstractFactoryExercito.Nacao.Persia);

            Arqueiro arqueiro = factoryExercito.CriarArqueiro();
            Assert.True(arqueiro != null);
            Assert.IsType<ArqueiroPersa>(arqueiro);
        }
        [Fact]
        public void CriacaoExercitoEgipicioTest()
        {
            AbstractFactoryExercito factoryExercito =
                 AbstractFactoryExercito.CriarFactoryExercito(
                     AbstractFactoryExercito.Nacao.Egito);

            Arqueiro arqueiro = factoryExercito.CriarArqueiro();
            Assert.IsType<ArqueiroEgipicio>(arqueiro);
        }

    }
}
