using static System.Net.Mime.MediaTypeNames;
using System.Text;
using Boat;
using System.Runtime.InteropServices;

namespace Boat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Container container = new Container(11,true, "blue");
            Boat boat = new Boat("charle",12,12);

            container.AddMerchandise("pull");
            container.ViewContent();
            boat.LoadContainer(container);
            boat.Start();

            
        }
    }
}