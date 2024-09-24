using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
        Random alea = new Random();

        public static int maxCharge;                    // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x ;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien

        public Drone(string nom, int X, int Y) 
        { 
            _name = nom;
            _x = X;
            _y = Y;
            maxCharge = GlobalHelper.charge.Next(1000);
        }

        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y += alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            maxCharge--;                                // Il a dépensé de l'énergie
        }

    }
}
