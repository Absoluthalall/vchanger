using System;
using System.Collections.Generic;
using System.Text;
using VSGen.Data;

namespace VSGen.Config
{
    public static class UserConfig
    {
        public enum Subcriptions
        {
            Free,
            Pro,
            Premium,
            God
        }

        internal static List<Hero> Heroes = new List<Hero>();
        internal static List<DLCHero> DLCHeroes = new List<DLCHero>();
        internal static List<DLC2Hero> DLC2Heroes = new List<DLC2Hero>();

        public static float DPI { get; set; }
        public static string Nickname { get; set; }
        public static int Subscription { get; set; }
        public static DateTime Expires { get; set; }
        public static bool HasDLC1 { get; set; }
        public static bool HasDLC2 { get; set; }
        public static bool HasBackup { get; set; }

        public static void EncryptPassword(string password)
        {
            StringBuilder sb = new StringBuilder();
            var Key = new byte[password.Length];
            new Random().NextBytes(Key);
            for (int i = 0; i < password.Length; i++)
                sb.Append((char)((byte)password[i] ^ Key[i]));
            Properties.Settings.Default.Key = new byte[Key.Length];
            Key.CopyTo(Properties.Settings.Default.Key,0);
            Properties.Settings.Default.Password = sb.ToString();
            Properties.Settings.Default.Save();
        }

        public static string DecryptPassword()
        {
            if (Properties.Settings.Default.Key == null || Properties.Settings.Default.Key.Length == 0)
                return String.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Properties.Settings.Default.Password.Length; i++)
                sb.Append((char)(Properties.Settings.Default.Password[i] ^ Properties.Settings.Default.Key[i]));
            return sb.ToString();        }
    }
}
