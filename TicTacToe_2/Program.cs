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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GameView());
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Windows.Forms;
//using System.Reflection;

//namespace WinFormsThemeSwitcher
//{
//    public abstract class Theme
//    {
//        public abstract Color BackgroundColor { get; }
//        public abstract Color ForegroundColor { get; }
//        public abstract string Name { get; }
//    }

//    public class LightTheme : Theme
//    {
//        public override Color BackgroundColor => Color.White;
//        public override Color ForegroundColor => Color.Black;
//        public override string Name => "Light";
//    }

//    public class DarkTheme : Theme
//    {
//        public override Color BackgroundColor => Color.Black;
//        public override Color ForegroundColor => Color.White;
//        public override string Name => "Dark";
//    }

//    public class BlueTheme : Theme
//    {
//        public override Color BackgroundColor => Color.LightBlue;
//        public override Color ForegroundColor => Color.DarkBlue;
//        public override string Name => "Blue";
//    }

//    public abstract class ThemeFactory
//    {
//        public abstract Theme CreateTheme();
//    }

//    public class LightThemeFactory : ThemeFactory
//    {
//        public override Theme CreateTheme() => new LightTheme();
//    }

//    public class DarkThemeFactory : ThemeFactory
//    {
//        public override Theme CreateTheme() => new DarkTheme();
//    }

//    public class BlueThemeFactory : ThemeFactory
//    {
//        public override Theme CreateTheme() => new BlueTheme();
//    }

//    public class ThemeManager
//    {
//        private List<ThemeFactory> themeFactories = new List<ThemeFactory>();
//        private int currentThemeIndex = 0;

//        public ThemeManager()
//        {
//            LoadThemes();
//        }

//        private void LoadThemes()
//        {
//            // In a real application, this could load from a configuration file or use reflection
//            // to find all classes that implement ThemeFactory in the current assembly
//            var assembly = Assembly.GetExecutingAssembly();
//            foreach (Type type in assembly.GetTypes())
//            {
//                if (typeof(ThemeFactory).IsAssignableFrom(type) && !type.IsAbstract)
//                {
//                    themeFactories.Add((ThemeFactory)Activator.CreateInstance(type));
//                }
//            }
//        }

//        public Theme GetCurrentTheme()
//        {
//            return themeFactories[currentThemeIndex].CreateTheme();
//        }

//        public Theme SwitchToNextTheme()
//        {
//            currentThemeIndex = (currentThemeIndex + 1) % themeFactories.Count;
//            return GetCurrentTheme();
//        }
//    }

//    public partial class MainForm : Form
//    {
//        private ThemeManager themeManager;
//        private TextBox textBox;

//        public MainForm()
//        {
//            InitializeComponent();
//            themeManager = new ThemeManager();
//            ApplyTheme();
//        }

//        private void InitializeComponent()
//        {
//            this.SuspendLayout();

//            this.ClientSize = new System.Drawing.Size(300, 200);
//            this.Text = "Theme Switcher";

//            Button switchButton = new Button
//            {
//                Text = "Switch Theme",
//                Location = new Point(100, 120),
//                Size = new Size(100, 30)
//            };
//            switchButton.Click += SwitchTheme;

//            textBox = new TextBox
//            {
//                Location = new Point(50, 50),
//                Size = new Size(200, 20),
//                Text = "Type something here..."
//            };

//            this.Controls.Add(switchButton);
//            this.Controls.Add(textBox);
//            this.ResumeLayout(false);
//        }

//        private void SwitchTheme(object sender, EventArgs e)
//        {
//            themeManager.SwitchToNextTheme();
//            ApplyTheme();
//        }

//        private void ApplyTheme()
//        {
//            var currentTheme = themeManager.GetCurrentTheme();
//            this.BackColor = currentTheme.BackgroundColor;
//            this.ForeColor = currentTheme.ForegroundColor;
//            foreach (Control control in this.Controls)
//            {
//                control.BackColor = currentTheme.BackgroundColor;
//                control.ForeColor = currentTheme.ForegroundColor;
//            }
//            this.Text = $"Theme Switcher - {currentTheme.Name} Theme";
//        }
//    }

//    static class Program
//    {
//        [STAThread]
//        static void Main()
//        {
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new MainForm());
//        }
//    }
//}