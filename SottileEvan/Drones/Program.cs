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

            List<Building> buildings= new List<Building>();

            Drone drone = new Drone("Joe",100,100);
            Building building = new Building(100, 50, 8, 10, "Blue");

            fleet.Add(drone);
            buildings.Add(building);

            // Démarrage

            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}