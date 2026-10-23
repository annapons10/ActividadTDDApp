using ActividadTDDApp;


namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(-2, -1)]
        [DataRow(5, 120)]
        [DataRow(1, 1)]


        public void CalcularFactorial_DiferentesCasos(int n, long esperado)
        {
            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(resultado, esperado); 
        }
    }
}
