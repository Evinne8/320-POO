using Drones.Helpers;

namespace Drones
{
    
    public enum EvacuationState
    {
        Free,           // No limits applied
        Evacuating,     // Limits known, moving out of the zone
        Evacuated       // Limits known, out of the zone
    }

    public interface IExpellable
    {
        // Signal the limits of the no-fly zone 
        // Return true if the drone is already outside the zone
        public bool Evacuate(Rectangle zone);

        // Terminate the no-fly zone
        public void FreeFlight();

        // Interrogate the drone
        public EvacuationState GetEvacuationState();
    }


    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        Random alea = new Random();

        public static int maxCharge;                    // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x ;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private int _i = 0;
        private Pen noFlyBrush = new Pen(new SolidBrush(Color.Red), 5);

        public Drone(string nom, int X, int Y) 
        { 
            _name = nom;
            _x = X;
            _y = Y;
            maxCharge = GlobalHelper.charge.Next(1000);
        }
        public bool Evacuate(Rectangle zone)
        {
            
            if (_x > zone.X && _x < zone.X+zone.Width && _y > zone.Y && _y < zone.Y+zone.Width)
            {
                while (_x > zone.X && _x < zone.X + zone.Width)
                {
                    _x--;
                }
            }
            return false;
        }


        public void FreeFlight()
        {
            
        }
        public EvacuationState GetEvacuationState()
        {
            _i++;
            if (_i == 2)
                return EvacuationState.Evacuating;
            return EvacuationState.Free;
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
