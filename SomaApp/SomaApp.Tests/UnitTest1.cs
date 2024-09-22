using NUnit.Framework;
using SomaApp; // Referência ao namespace do projeto principal
namespace SomaApp.Tests 
{ 
    public class ProgramTests 
    { 
        [Test] 
        public void Soma_AdicionaDoisNumeros_RetornaSoma() 
        { 
            // Arrange
            int a = 5; 
            int b = 10; 
            int expected = 15; 
            // Act
            int result = Program.Soma(a, b); 
            // Assert
            Assert.AreEqual(expected, result); 
        } 
    } 
}