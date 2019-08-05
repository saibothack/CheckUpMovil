using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace CheckUpMovil.Helpers
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        private const string SettingsShowIntroKey = "SettingsShowIntroKey";
        private static readonly bool SettingsShowIntroDefault;

        private const string SettingsIsLoginKey = "SettingsIsLoginKey";
        private static readonly bool SettingsIsLoginDefault;

        #endregion


        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }

        public static bool isShowIntro
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsShowIntroKey, SettingsShowIntroDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsShowIntroKey, value);
            }
        }

        public static bool isLogin
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsIsLoginKey, SettingsIsLoginDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsIsLoginKey, value);
            }
        }
        
    }

}
