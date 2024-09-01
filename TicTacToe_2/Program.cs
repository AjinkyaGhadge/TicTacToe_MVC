using Controller;
using Model;
using System.Reflection;
using View.ThemeLogic;
namespace TicTacToe_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new GameView());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GameView gameView = new GameView();
            List<IGridObserver> observerList = new List<IGridObserver>();
            observerList = LoadViews(observerList);
            Controller.Controller controller = new Controller.Controller(gameView, observerList);
            gameView.SetController(controller);
            Application.Run(gameView);
        }

        private static List<IGridObserver> LoadViews(List<IGridObserver> observerList)
        {
            // In a real application, this could load from a configuration file or use reflection
            // to find all classes that implement ThemeFactory in the current assembly
            var assembly = Assembly.GetExecutingAssembly();
            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(IGridObserver).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    observerList.Add((IGridObserver)Activator.CreateInstance(type));
                }
            }

            return observerList;
        }
    }
}
