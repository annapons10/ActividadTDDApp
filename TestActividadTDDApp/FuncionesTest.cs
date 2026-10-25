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

        [TestMethod]
        [DataRow(null, false)]            
        [DataRow("", false)]             
        [DataRow("ab#1", false)]         
        [DataRow("abcdefgh", false)]      
        [DataRow("abcdefg#", true)]       
        [DataRow("abcd#efghij", true)]    
        public void EsContrasenyaValida_DiferentesCasos(string? contrasenya, bool esperado)
        {
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(esperado, resultado);
        }
    }
}
