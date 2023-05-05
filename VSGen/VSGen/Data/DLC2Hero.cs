using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VSGen.Data
{
    public class DLC2Hero
    {
        public static List<DLC2Hero> heroes;
        public enum HeroList
        {
            ELEANOR,
            VICTOR,
            KEIRA,
            LUMINAIRE,
            GENEVIEVE,
            MEGAGENEVIEVE,
            CTRPCAKE,
            GHOUL,
            End
        }

        public string MaxHp = "\"maxHp\": 99999999999999,";
        static string MaxRegen = "\"regen\": 999999999999,";
        static string MaxSpeed = "\"moveSpeed\": 6,";
        static string MaxPower = "\"power\": 99999999999999,";
        static string MaxArea = "\"area\": 3,";
        static string MaxLuck = "\"luck\": 100,";
        static string MaxGrowth = "\"growth\": 255,";
        static string MaxMagnet = "\"magnet\": 100,";

        public string Name { get; set; }
        public bool Hp { get; set; }
        public bool Regen { get; set; }
        public bool Movespeed { get; set; }

        public bool Power { get; set; }
        public bool Area { get; set; }
        public bool Luck { get; set; }
        public bool Growth { get; set; }
        public bool Magnet { get; set; }
        public bool Unlocked { get; set; }
        public int Level { get; set; }

        public DLC2Hero(string name)
        {
            Name = name;
            Hp = false;
            Regen = false;
            Movespeed = false;
            Power = false;
            Area = false;
            Luck = false;
            Magnet = false;
            Growth = false;
            Unlocked = false;
        }

        public string EditCharacter(string characterBlock)
        {
            Regex regexHp = new Regex(@"'maxHp': (\w*\.?\w*),".Replace('\'', '\"'));
            Regex regexRegen = new Regex(@"'regen': (\w*\.?\w*),".Replace('\'', '\"'));
            Regex regexSpeed = new Regex(@"'moveSpeed': (\w*\.?\w*),".Replace('\'', '\"'));
            Regex regexPower = new Regex(@"'power': (\w*\.?\w*),".Replace('\'', '\"'));
            Regex regexArea = new Regex(@"'area': (\w*\.?\w*),".Replace('\'', '\"'));
            Regex regexLuck = new Regex(@"'luck': (\w*\.?\w*),".Replace('\'', '\"'));
            Regex regexMagnet = new Regex(@"'magnet': (\w*\.?\w*),".Replace('\'', '\"'));
            Regex regexGrowth = new Regex(@"'growth': (\w*\.?\w*),".Replace('\'', '\"'));
            Regex regexBought = new Regex(@"'isBought': (\w*),".Replace('\'', '\"'));
            Regex regexHidden = new Regex(@"'hidden': (\w*),".Replace('\'', '\"'));

            if (Hp)
                characterBlock = characterBlock.Replace(regexHp.Match(characterBlock).Value, MaxHp);
            if (Regen)
                characterBlock = characterBlock.Replace(regexRegen.Match(characterBlock).Value, MaxRegen);
            if (Movespeed)
                characterBlock = characterBlock.Replace(regexSpeed.Match(characterBlock).Value, MaxSpeed);
            if (Power)
                characterBlock = characterBlock.Replace(regexPower.Match(characterBlock).Value, MaxPower);
            if (Area)
                characterBlock = characterBlock.Replace(regexArea.Match(characterBlock).Value, MaxArea);
            if (Luck)
                characterBlock = characterBlock.Replace(regexLuck.Match(characterBlock).Value, MaxLuck);
            if (Magnet)
                characterBlock = characterBlock.Replace(regexMagnet.Match(characterBlock).Value, MaxMagnet);
            if (Growth)
                characterBlock = characterBlock.Replace(regexGrowth.Match(characterBlock).Value, MaxGrowth);
            if (Unlocked)
            {
                if (regexBought.Match(characterBlock).Value.Length != 0)
                    characterBlock = characterBlock.Replace(regexBought.Match(characterBlock).Value, "\"isBought\": true,");
                if (regexHidden.Match(characterBlock).Value.Length != 0)
                    characterBlock = characterBlock.Replace(regexHidden.Match(characterBlock).Value, "\"hidden\": false,");
            }
            return characterBlock;
        }

        public void EnableAllStats()
        {
            Hp = true;
            Regen = true;
            Movespeed = true;
            Power = true;
            Area = true;
            Luck = true;
            Magnet = true;
            Growth = true;
            Unlocked = true;
        }
    }
}
