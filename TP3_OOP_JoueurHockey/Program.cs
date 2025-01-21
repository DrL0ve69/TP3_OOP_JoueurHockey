using TP3_OOP_JoueurHockey;

Console.WriteLine("TP3-JoueurHockey____________________________________________________________________\n");

// Déclaration des variables (JoueursHockey)
JoueursHockey joueur1 = new("Richard", "Maurice", 9);
JoueursHockey joueur2 = new("Béliveau", "Jean", 4);
JoueursHockey joueur3 = new("Dupot", "Yvan", 69, "Gardien",420, 42069);
JoueursHockey joueur4 = new("Bozo", "LeClown", 99, "Centre", 1, 1000);

// Liste de Joueurs
List<JoueursHockey> listeJoueurs = new List<JoueursHockey>{ joueur1, joueur2, joueur3, joueur4 };

// Test de la méthode ToString() :

foreach(JoueursHockey joueur in listeJoueurs)Console.WriteLine(joueur.ToString());

// Test de la méthode Copy() :

JoueursHockey joueur1Prime = joueur1.CopierJoueur();
Console.WriteLine($"Voici la copie du joueur 1 : {joueur1Prime}");

Console.WriteLine($"Modifications du joueurPrime, et vérifier si cela affecte aussi la copie originale : \n");

joueur1Prime.Position = "Centre"; joueur1Prime.NbPartiesJouees = 666; joueur1Prime.NbButs = 1000;

Console.WriteLine($"Voici les modifications du joueurPrime suivi du joueur1 :\n" +
    $"{joueur1Prime}{joueur1}");

// Test des valeurs pour la méthode Equal()

Console.WriteLine($"Le joueur 1 devrait être = au joueurPrime . Vérifions :\n" +
    $"Réponse : {joueur1.Equals(joueur1Prime)}\n");

Console.WriteLine("Vérifions avec les autres :" + "\n");

foreach(JoueursHockey joueur in listeJoueurs)Console.WriteLine($"Réponse : {joueur1.Equals(joueur)}\n");