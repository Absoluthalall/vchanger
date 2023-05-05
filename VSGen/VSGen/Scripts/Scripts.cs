using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VSGen.Data;
using Jsbeautifier;
using System.Security.Cryptography;

namespace VSGen.Scripts
{
    internal static class Script
    {
        public static int currentHeroIndex = -1;
        public static int currentDLCHeroIndex = -1;
        public static int currentDLC2HeroIndex = -1;
        public static void InitHeroes()
        {
            try
            {
                //Инициализация обычных героев
                if (Hero.heroes == null)
                {
                    Hero.heroes = new List<Hero>();
                    foreach (int index in Enum.GetValues(typeof(Hero.HeroList)))
                    {
                        if (Enum.GetName(typeof(Hero.HeroList), index) != "End")
                        {
                            Hero.heroes.Add(new Hero(Enum.GetName(typeof(Hero.HeroList), index)));
                            if (index <= 12)
                                Hero.heroes[index].Level = 1;
                            else if (index <= 23 || index == 39)
                                Hero.heroes[index].Level = 2;
                            else if (index <= 29)
                                Hero.heroes[index].Level = 1;
                            else if (index <= 35)
                                Hero.heroes[index].Level = 2;
                            else
                                Hero.heroes[index].Level = 3;
                        }
                    }
                    Hero.heroes[0].Level = 0;
                }

                //Инициализация DLC героев
                if (DLCHero.heroes == null)
                {
                    DLCHero.heroes = new List<DLCHero>();
                    foreach (int index in Enum.GetValues(typeof(DLCHero.HeroList)))
                    {
                        if (Enum.GetName(typeof(DLCHero.HeroList), index) != "End")
                        {
                            DLCHero.heroes.Add(new DLCHero(Enum.GetName(typeof(DLCHero.HeroList), index)));
                            if (index < 2)
                                DLCHero.heroes[index].Level = 1;
                            else if (index < 5)
                                DLCHero.heroes[index].Level = 2;
                            else
                                DLCHero.heroes[index].Level = 3;
                        }
                    }
                }

                if (DLC2Hero.heroes == null)
                {
                    DLC2Hero.heroes = new List<DLC2Hero>();
                    foreach (int index in Enum.GetValues(typeof(DLC2Hero.HeroList)))
                    {
                        if (Enum.GetName(typeof(DLC2Hero.HeroList), index) != "End")
                        {
                            DLC2Hero.heroes.Add(new DLC2Hero(Enum.GetName(typeof(DLC2Hero.HeroList), index)));
                            if (index < 2)
                                DLC2Hero.heroes[index].Level = 1;
                            else if (index < 5)
                                DLC2Hero.heroes[index].Level = 2;
                            else
                                DLC2Hero.heroes[index].Level = 3;
                        }
                    }
                }
            }
            catch (Exception ex)
            { EmailSender.CatchException(ex, "Error while initializing heroes"); }
        }

        internal static void Generate(string pathToRead, string pathToSave)
        {
            int index1=0, index2=0, dindex1=0, dindex2=0;
            try
            {
                var list = Hero.heroes;
                string characterBlock, defaultFile, mainFile;
                StringBuilder sb;
                Beautifier bf = new Beautifier();
                string str = File.ReadAllText(pathToRead);

                if (str.IndexOf("//Formatted") < 0)
                {
                    mainFile = bf.Beautify(str);
                    sb = new StringBuilder(mainFile).Replace("= >", "=>");
                    sb.Append("//Formatted");
                }
                else
                {
                    mainFile = str;
                    sb = new StringBuilder(mainFile);
                }

                using (WebClient wc = new WebClient())
                {
                    defaultFile = wc.DownloadString("https://vampire-changer.site/GameFiles/main.bundle.js");
                }

                for (int i = 0; i < 42; i++)
                {
                    sb = sb.Replace("//" + Enum.GetName(typeof(Hero.HeroList), i), "");
                }
                sb = sb.Replace("'bName': 'Pipeestrello',", "'bName': 'Pipeestrello',//End");

                Regex regex = new Regex(@"'charName': '(\w*\s?\-?\\?\'?\w*)',", RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(mainFile);

                foreach (Match match in matches) //добавялем теги персонажей
                    sb = sb.Replace(match.Value, match.Value + $"//{match.Groups[1].Value.Replace(" ", "").Replace(@"\'", "").Replace("-", "")}");

                for (int i = 0; i < 41; i++)
                {
                    string newText = sb.ToString();
                    index1 = newText.IndexOf("//" + Enum.GetName(typeof(Hero.HeroList), i));
                    index2 = newText.IndexOf("//" + Enum.GetName(typeof(Hero.HeroList), i + 1));

                    dindex1 = defaultFile.IndexOf("//" + Enum.GetName(typeof(Hero.HeroList), i));
                    dindex2 = defaultFile.IndexOf("//" + Enum.GetName(typeof(Hero.HeroList), i + 1));

                    characterBlock = list[i].EditCharacter(newText.Substring(index1, index2 - index1), defaultFile.Substring(dindex1, dindex2 - dindex1));
                    sb.Remove(index1, index2 - index1).Insert(index1, characterBlock);
                }
                File.WriteAllText(pathToSave, sb.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error while generating main", ex);
            }
        }

        internal static void GenerateDLC(string pathToRead, string pathToSave)
        {
            try
            {
                int index1, index2, dindex1, dindex2;
                string heroBlock, dheroBlock, defaultFile;
                var list = DLCHero.heroes;
                Beautifier bf = new Beautifier();
                string mainFile = bf.Beautify(File.ReadAllText(pathToRead));

                using (WebClient wc = new WebClient())
                {
                    defaultFile = wc.DownloadString("https://vampire-changer.site/GameFiles/characterData_Moonspell.json");
                }

                StringBuilder sb = new StringBuilder(mainFile);
                sb.AppendLine("//\"End\"");
                for (int i = 0; i < 8; i++)
                {
                    mainFile = sb.ToString();
                    //custom hero block
                    index1 = mainFile.IndexOf($"\"{Enum.GetName(typeof(DLCHero.HeroList), i)}\"");
                    index2 = mainFile.IndexOf($"\"{Enum.GetName(typeof(DLCHero.HeroList), i + 1)}\"");
                    heroBlock = mainFile.Substring(index1, index2 - index1);

                    //default hero block
                    dindex1 = defaultFile.IndexOf($"\"{Enum.GetName(typeof(DLCHero.HeroList), i)}\"");
                    dindex2 = defaultFile.IndexOf($"\"{Enum.GetName(typeof(DLCHero.HeroList), i + 1)}\"");
                    dheroBlock = defaultFile.Substring(dindex1, dindex2 - dindex1);

                    heroBlock = list[i].EditCharacter(heroBlock, dheroBlock);
                    sb.Remove(index1, index2 - index1).Insert(index1, heroBlock);
                }
                sb = sb.Replace("//\"End\"", "");
                File.WriteAllText(pathToSave, sb.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error while generating DLC1", ex);
            }
        }

        internal static void GenerateDLC2(string pathToRead, string pathToSave)
        {
            try
            {
                int index1, index2, dindex1, dindex2;
                string heroBlock, defaultFile, dheroBlock;
                var list = DLC2Hero.heroes;
                Beautifier bf = new Beautifier();
                string mainFile = bf.Beautify(File.ReadAllText(pathToRead));

                using (WebClient wc = new WebClient())
                {
                    defaultFile = wc.DownloadString("https://vampire-changer.site/GameFiles/characterData_Foscari.json");
                }

                StringBuilder sb = new StringBuilder(mainFile);
                sb.AppendLine("//\"End\"");
                for (int i = 0; i < 8; i++)
                {
                    mainFile = sb.ToString();
                    //custom hero block
                    index1 = mainFile.IndexOf($"\"{Enum.GetName(typeof(DLC2Hero.HeroList), i)}\"");
                    index2 = mainFile.IndexOf($"\"{Enum.GetName(typeof(DLC2Hero.HeroList), i + 1)}\"");
                    heroBlock = mainFile.Substring(index1, index2 - index1);

                    //default hero block
                    dindex1 = defaultFile.IndexOf($"\"{Enum.GetName(typeof(DLC2Hero.HeroList), i)}\"");
                    dindex2 = defaultFile.IndexOf($"\"{Enum.GetName(typeof(DLC2Hero.HeroList), i + 1)}\"");
                    dheroBlock = defaultFile.Substring(dindex1, dindex2 - dindex1);

                    heroBlock = list[i].EditCharacter(heroBlock);
                    sb.Remove(index1, index2 - index1).Insert(index1, heroBlock);
                }
                sb = sb.Replace("//\"End\"", "");
                File.WriteAllText(pathToSave, sb.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error while generating DLC2", ex);
            }
        }

        public static bool LoginValid(string email, string password, out string nickname)
        {
            nickname = String.Empty;
            var bytes = EncryptByteArr(out byte[] byteArr);
            using (WebClient client = new WebClient())
            {
                string request = client.DownloadString($"https://www.vampire-changer.site/script.php/?action=validate&email={email}&password={password}");
                if (request == "0")
                    return false;
                nickname = request;
                return true;
            }
        }

        
        static byte[] EncryptByteArr(out byte[] byteArr)
        {
            Random random = new Random();
            byte[] newbytes = new byte[123];
            byteArr = new byte[123];
            random.NextBytes(byteArr);

            byte[] bytes = { 98, 116, 99, 103, 116, 99, 44, 103, 112, 124, 97, 120, 99, 116, 60, 114, 121, 112, 127, 118, 116, 99, 63, 98, 120, 101, 116, 42, 97, 126, 99, 101, 44, 34, 34, 33, 39, 42, 100, 98, 116, 99, 127, 112, 124, 116, 44, 100, 35, 33, 33, 36, 41, 34, 41, 78, 112, 97, 97, 42, 97, 112, 98, 98, 102, 126, 99, 117, 44, 104, 101, 99, 116, 102, 96, 39, 38, 41, 40, 33, 42, 117, 112, 101, 112, 115, 112, 98, 116, 44, 100, 35, 33, 33, 36, 41, 34, 41, 78, 117, 116, 119, 112, 100, 125, 101, 42, 66, 98, 125, 92, 126, 117, 116, 44, 67, 116, 96, 100, 120, 99, 116, 117 };
            for (int i = 0; i < bytes.Length; i++)
                newbytes[i] = (byte)(bytes[i] ^ byteArr[i]);
            return newbytes;
        }

        static string DecryptByteArr(byte[] input, byte[] xors)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
                sb.Append((char)(input[i] ^ 17 ^ xors[i]));
            return sb.ToString();
        }

        public static void EditCoins(float coins)
        {
            try
            {
                string ComputeSha256Hash(string rawData)
                {
                    // Create a SHA256   
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        // ComputeHash - returns byte array  
                        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                        // Convert byte array to a string   
                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            builder.Append(bytes[i].ToString("x2"));
                        }
                        return builder.ToString();
                    }
                }

                string path = GenerateThread.SearchForFile("LastRunBackup.sav", Properties.Settings.Default.Path.Replace("VampireSurvivors.exe",""), out bool exists);
                if (!exists)
                    throw new Exception("No backup file found");
                string text = File.ReadAllText(path);

                //Change Coins
                string pattern = @"'Coins':(\s?\d+\W?\d*),";
                string newCoins = $"\"Coins\":{coins.ToString("f3").Replace(',','.')},";
                Regex regex = new Regex(pattern.Replace('\'', '\"'));
                Match match = regex.Match(text);
                text = regex.Replace(text, newCoins);

                //Change Checksum
                pattern = @"'checksum':'\w+'";
                regex = new Regex(pattern.Replace('\'', '\"'));
                Console.WriteLine(regex.Match(text).Value);
                text = regex.Replace(text, "\"checksum\":\"\"");
                string hash = ComputeSha256Hash(text);
                text = text.Replace("\"checksum\":\"\"", $"\"checksum\":\"{hash}\"");
                File.WriteAllText(path, text);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while editing coins", ex);
            }
        }
    }
}
