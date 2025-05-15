using System;

namespace TicketsTestApp.Services
{
    public class ThemeService
    {
        public event Action OnThemeChange;
        private bool _isDarkTheme;

        public bool IsDarkTheme
        {
            get => _isDarkTheme;
            set
            {
                _isDarkTheme = value;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnThemeChange?.Invoke();
    }
}