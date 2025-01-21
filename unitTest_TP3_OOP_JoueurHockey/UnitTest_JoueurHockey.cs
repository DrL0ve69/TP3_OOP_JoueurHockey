using TP3_OOP_JoueurHockey;
using unitTest_TP3_OOP_JoueurHockey;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace unitTest_TP3_OOP_JoueurHockey
{
    public class UnitTest_JoueurHockey
    {
        //Arrange
        string[] stringArray = {"Bob", "Graton-Thibeault", "robert", "PIERRE", "hector aime les babanes", "3", "?@(", "" };
        int[] intArray = {-1, 0, 1, 100, 10293756, -124734578 };
        [Fact]
        public void TestConstructeurJH1()
        {
            //Act
            JoueursHockey j1 = new(stringArray[0], stringArray[2], intArray[3]);
            
            //Assert
            Assert.Equal(stringArray[0], j1.Nom);
            Assert.Equal(stringArray[2], j1.Prenom);
            Assert.Equal(intArray[3], j1.Numero);
        }

        [Fact]
        public void TestConstructeurJH2()
        {
            //Act
            JoueursHockey j1 = new(stringArray[5], stringArray[7], intArray[3], stringArray[6], intArray[0], intArray[5]);

            //Assert
            Assert.Equal(stringArray[5], j1.Nom);
            Assert.Equal(stringArray[7], j1.Prenom);
            Assert.Equal(intArray[3], j1.Numero);
            Assert.Equal(stringArray[6], j1.Position);
            Assert.Equal(intArray[0], j1.NbButs);
            Assert.Equal(intArray[5], j1.NbPartiesJouees);
        }

        [Fact]
        public void TestToString()
        {
            //Arrange
            JoueursHockey joueur1 = new("Richard", "Maurice", 9);
            JoueursHockey joueur2 = new("Dupot", "Yvan", 69, "Gardien", 420, 42069);
            string expected = $"\nRichard, Maurice :\n" +
                $"Numéro: 9\n" +
                $"Position: Donnée non-disponible, Nombre de buts : 0, Nombre de parties jouées : 0\n" +
                $"-----------------------------------------------------------------------------------------------";
            string expected2 = $"\nDupot, Yvan :\n" +
                $"Numéro: 69\n" +
                $"Position: Gardien, Nombre de buts : 420, Nombre de parties jouées : 42069\n" +
                $"-----------------------------------------------------------------------------------------------";
            //Act
            string result = joueur1.ToString();
            string result2 = joueur2.ToString();

            //Assert
            Assert.Equal(expected, result);
            Assert.Equal(expected2, result2);
        }

        [Fact]
        public void TestCopierJoueur ()
        {
            //Arrange
            JoueursHockey oldPlayer = new("Dupot", "Yvan", 69, "Gardien", 420, 42069);
            //Act
            JoueursHockey newPlayer = oldPlayer.CopierJoueur();
            //Assert
            Assert.Equal(oldPlayer.Nom, newPlayer.Nom);
            Assert.Equal(oldPlayer.Prenom, newPlayer.Prenom);
            Assert.Equal(oldPlayer.Position, newPlayer.Position);
            Assert.Equal(oldPlayer.Numero, newPlayer.Numero);
            Assert.Equal(oldPlayer.NbPartiesJouees, newPlayer.NbPartiesJouees);
            Assert.Equal(oldPlayer.NbButs, newPlayer.NbButs);
        }

        [Fact]
        public void TestEquals()
        {
            //Arrange
            
            JoueursHockey oldPlayer = new("Dupot", "Yvan", 69, "Gardien", 420, 42069);
            JoueursHockey newPlayer = new("Dupot", "Yvan", 69, "Gardien", 420, 42069);
            JoueursHockey badPlayer = new("Dupot", "Yvn", 69, "Gardien", 420, 42069);

            //Act

            bool isSame = oldPlayer.Equals(newPlayer);
            bool isSame2 = oldPlayer.Equals(badPlayer);

            //Assert

            Assert.True(isSame); // True
            Assert.False(isSame2); // False
        }





    }
}