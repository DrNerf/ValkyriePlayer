using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValkyriePlayer.Classes
{
    public static class Navigator
    {
        private static Dictionary<Type, UserControl> m_RegisteredViews { get; set; }

        private static Action<UserControl> m_SetView;

        public static void Init(Action<UserControl> setView)
        {
            m_SetView = setView;
            m_RegisteredViews = new Dictionary<Type, UserControl>();
        }

        public static void RegisterView(Type view)
        {
            m_RegisteredViews.Add(view, Activator.CreateInstance(view) as UserControl);
        }

        public static void Navigate(Type view)
        {
            UserControl value;
            if (!m_RegisteredViews.TryGetValue(view, out value))
            {
                value = Activator.CreateInstance(view) as UserControl;
                m_RegisteredViews.Add(view, value);
            }
            m_SetView(value);
        }
    }
}
