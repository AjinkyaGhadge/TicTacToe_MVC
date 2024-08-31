using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using View.ThemeLogic;

namespace View
{
    public class ThemeManager
    {
        private List<AbstractThemeFactory> themeFactories = new List<AbstractThemeFactory>();
        private int currentThemeIndex = 0;

        public ThemeManager()
        {
            LoadThemes();
        }

        private void LoadThemes()
        {
            // In a real application, this could load from a configuration file or use reflection
            // to find all classes that implement ThemeFactory in the current assembly
            var assembly = Assembly.GetExecutingAssembly();
            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(AbstractThemeFactory).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    themeFactories.Add((AbstractThemeFactory)Activator.CreateInstance(type));
                }
            }
        }

        public AbstractTheme GetCurrentTheme()
        {
            return themeFactories[currentThemeIndex].CreateTheme();
        }

        public AbstractTheme SwitchToNextTheme()
        {
            currentThemeIndex = (currentThemeIndex + 1) % themeFactories.Count;
            return GetCurrentTheme();
        }
    }

}
