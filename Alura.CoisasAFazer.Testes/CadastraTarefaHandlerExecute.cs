using Alura.CoisasAFazer.Core.Commands;
using Alura.CoisasAFazer.Core.Models;
using Alura.CoisasAFazer.Services.Handlers;
using System;
using System.Linq;
using Xunit;

namespace Alura.CoisasAFazer.Testes
{
    public class CadastraTarefaHandlerExecute
    {
        [Fact]
        public void DadaTarefaComInfoValidasDeveIncluirNoBD()
        {

            //arrange 

            var comando = new CadastraTarefa("Estudar Xunit", new Categoria("Estudo"), DateTime.Now);

               var repo = new RepositorioFake();

            var handler = new CadastraTarefaHandler(repo);


            // act
            handler.Execute(comando); // Sut >> CadastraTarefaHandlerExecute

            var tarefa = repo.ObtemTarefas(t => t.Titulo == "Estudar Xunit").FirstOrDefault();


            // assert
            Assert.NotNull(tarefa);



            //criar comando
            // executar comando
        }
    }
}
