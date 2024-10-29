using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Boat : IBoat
    {
        // Propriétés du bateau
        public string Name { get; }
        public float MaxCargoWeight { get; }
        public int MaxSpeed { get; }

        private float _weight = 0;
        private int _speed = 0;

        public Boat(string name, float maxWeight, int maxSpeed)
        {
            Name = name;
            MaxCargoWeight = maxWeight;
            MaxSpeed = maxSpeed;
        }

        public void Start()
        {
            _speed = MaxSpeed;
        }

        public bool LoadContainer(IContainer container) 
        { 
            if (_weight + container.Weight  <= MaxCargoWeight) 
            { 
                _weight += container.Weight;
                return true;
            }
            else
                return false;
        }
        public bool UnloadContainer(IContainer container)
        {
            if (_weight - container.Weight <= MaxCargoWeight)
            {
                _weight -= container.Weight;
                return true;
            }
            else
                return false;
        }

    }

}