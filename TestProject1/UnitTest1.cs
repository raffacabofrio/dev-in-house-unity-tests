using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveReprovarAluno()
        {
            var deywid = new Aluno { Nome = "Deywid Felipe Lemes Chaves" };
            deywid.NotaProjeto1 = 1;
            deywid.NotaProjeto2 = 1;
            deywid.NotaProjeto3 = 1;
            deywid.NotaProjeto4 = 1;
            deywid.NotaProjeto5 = 1;
            deywid.NotaProjeto6 = 1;

            Avaliador.AvaliarAluno(deywid);

            var resultadoEsperado = false;

            Assert.AreEqual(deywid.Aprovado, resultadoEsperado);

        }


        [TestMethod]
        public void DeveAprovarAluno()
        {
            var deywid = new Aluno { Nome = "Deywid Felipe Lemes Chaves" };
            deywid.NotaProjeto1 = 10;
            deywid.NotaProjeto2 = 10;
            deywid.NotaProjeto3 = 10;
            deywid.NotaProjeto4 = 10;
            deywid.NotaProjeto5 = 10;
            deywid.NotaProjeto6 = 10;

            Avaliador.AvaliarAluno(deywid);

            var resultadoEsperado = true;

            Assert.AreEqual(deywid.Aprovado, resultadoEsperado);

        }
    }
}