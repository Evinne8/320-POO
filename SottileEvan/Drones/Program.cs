using System.Security.Cryptography.X509Certificates;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Random rmds = new Random();



            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    Drone drone = new Drone("Joe", rmds.Next(400), rmds.Next(400));
                    fleet.Add(drone);
                }
                if (fleet.Count > 10)
                {
                    throw new Exception("Pablo");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet));

            
        }
    }
}