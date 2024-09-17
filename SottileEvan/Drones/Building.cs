using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    class Building
    {
        protected int x;
        protected int y;
        protected int largeur;
        protected int profondeur;
        protected string couleur;

        
        public Building(int positionX, int positionY, int dlargeur, int dprofondeur, string ccouleur)
        {
            x = positionX ;
            y = positionY ;
            largeur = dlargeur ;
            profondeur = dprofondeur ;
            couleur = ccouleur ;
        }
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(x, y, largeur, profondeur));
        }

        public void testBuil()
        {
            Console.WriteLine("immeuble crée");
        }
    }
}
