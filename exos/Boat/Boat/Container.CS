using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Container : IContainer
    {
        public int Id { get; }
        public float Weight { get; }
        public bool IsRefrigerated { get; }
        public List<string> Merchandise { get; }
        public string Color { get; }
        private int _id = 0;

        public Container(float weight, bool isRef, string color)
        {
            _id++;
            Id = _id;
            Weight = weight;
            IsRefrigerated = isRef;
            Color = color;
            Merchandise = new List<string>();
        }

        public void ViewContent()
        {
            foreach (var content in Merchandise)
            {
                Console.WriteLine(content);
            }
        }
        public void AddMerchandise(string item)
        {
            Merchandise.Add(item);
        }
    }
}