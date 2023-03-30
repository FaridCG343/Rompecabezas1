namespace Rompecabezas1
{
    internal static class Program
    {
        public static FormInicio formInicio = new ();
        public static FormJuegoP formJuego;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(formInicio);
        }
    }
}