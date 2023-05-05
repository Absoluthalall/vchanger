using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VSGen.Data
{
    public class Hero
    {
        public static List<Hero> heroes;

        public enum HeroList
        {
            Antonio,
            Imelda,
            Pasqualina,
            Gennaro,
            Arca,
            Porta,
            Lama,
            Poe,
            Clerici,
            Dommario,
            Krochi,
            Christine,
            Pugnala,
            Giovanna,
            Poppea,
            Concetta,
            Mortaccio,
            Cavallo,
            Ramba,
            OSole,
            Ambrojoe,
            Gallo,
            Divano,
            ZiAssunta,
            Exdash,
            Toastie,
            SmithIV,
            Random,
            Marrabbio,
            Avatar,
            Minnah,
            Leda,
            Cosmo,
            Peppino,
            Trouser,
            missingN,
            Gains,
            Gyorunton,
            RedDeath,
            Sigma,
            ScorejOni,
            End
        }

        static readonly string MaxHp = "'maxHp': 0x999999999999,";
        static readonly string MaxRegen = "'regen': 0x9999999999,";
        static readonly string MaxSpeed = "'moveSpeed': 0x6,";
        static readonly string MaxPower = "'power': 0x999999999999,";
        static readonly string MaxArea = "'area': 0x3,";
        static readonly string MaxLuck = "'luck': 0x64,";
        static readonly string MaxGrowth = "'growth': 0xff,";
        static readonly string MaxMagnet = "'magnet': 0x100,";
        static readonly string IsBought = "'isBought': !0x0,";

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

        public Hero(string name)
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
            Unlocked = name == "Antonio";
        }

        public string EditCharacter(string characterBlock, string dheroBlock)
        {
            Regex regexHp = new Regex(@"'maxHp': (\w*\.?\w*),");
            Regex regexRegen = new Regex(@"'regen': (\w*\.?\w*),");
            Regex regexSpeed = new Regex(@"'moveSpeed': (\w*\.?\w*),");
            Regex regexPower = new Regex(@"'power': (\w*\.?\w*),");
            Regex regexArea = new Regex(@"'area': (\w*\.?\w*),");
            Regex regexLuck = new Regex(@"'luck': (\w*\.?\w*),");
            Regex regexMagnet = new Regex(@"'magnet': (\w*\.?\w*),");
            Regex regexGrowth = new Regex(@"'growth': (\w*\.?\w*),");
            Regex regexBought = new Regex(@"'isBought': (\!?\w*),");
            Regex regexHidden = new Regex(@"'hidden': (\!?\w*),");
            Regex regexBoughtNoSpace = new Regex(@"'isBought': (\!?\w*),");
            Regex regexHiddenNoSpace = new Regex(@"'hidden': (\!?\w*),");

            if (Hp)
                characterBlock = characterBlock.Replace(regexHp.Match(characterBlock).Value, MaxHp);
            else
                characterBlock = characterBlock.Replace(regexHp.Match(characterBlock).Value, regexHp.Match(dheroBlock).Value);

            if (Regen)
                characterBlock = characterBlock.Replace(regexRegen.Match(characterBlock).Value, MaxRegen);
            else
                characterBlock = characterBlock.Replace(regexRegen.Match(characterBlock).Value, regexRegen.Match(dheroBlock).Value);

            if (Movespeed)
                characterBlock = characterBlock.Replace(regexSpeed.Match(characterBlock).Value, MaxSpeed);
            else
                characterBlock = characterBlock.Replace(regexSpeed.Match(characterBlock).Value, regexSpeed.Match(dheroBlock).Value);

            if (Power)
                characterBlock = characterBlock.Replace(regexPower.Match(characterBlock).Value, MaxPower);
            else
                characterBlock = characterBlock.Replace(regexPower.Match(characterBlock).Value, regexPower.Match(dheroBlock).Value);

            if (Area)
                characterBlock = characterBlock.Replace(regexArea.Match(characterBlock).Value, MaxArea);
            else
                characterBlock = characterBlock.Replace(regexArea.Match(characterBlock).Value, regexArea.Match(dheroBlock).Value);

            if (Luck)
                characterBlock = characterBlock.Replace(regexLuck.Match(characterBlock).Value, MaxLuck);
            else
                characterBlock = characterBlock.Replace(regexLuck.Match(characterBlock).Value, regexLuck.Match(dheroBlock).Value);

            if (Magnet)
                characterBlock = characterBlock.Replace(regexMagnet.Match(characterBlock).Value, MaxMagnet);
            else
                characterBlock = characterBlock.Replace(regexMagnet.Match(characterBlock).Value, regexMagnet.Match(dheroBlock).Value);

            if (Growth)
                characterBlock = characterBlock.Replace(regexGrowth.Match(characterBlock).Value, MaxGrowth);
            else
                characterBlock = characterBlock.Replace(regexGrowth.Match(characterBlock).Value, regexGrowth.Match(dheroBlock).Value);
            if (Unlocked)
            {
                if (regexBought.Match(characterBlock).Value.Length != 0)
                    characterBlock = characterBlock.Replace(regexBought.Match(characterBlock).Value, "'isBought': !0x0,");
                else if (regexBoughtNoSpace.Match(characterBlock).Value.Length != 0)
                    characterBlock = characterBlock.Replace(regexBoughtNoSpace.Match(characterBlock).Value, "'isBought':!0x0,");
                if (regexHidden.Match(characterBlock).Value.Length != 0)
                    characterBlock = characterBlock.Replace(regexHidden.Match(characterBlock).Value, "'hidden': !0x1,");
                else if (regexHiddenNoSpace.Match(characterBlock).Value.Length != 0)
                    characterBlock = characterBlock.Replace(regexHiddenNoSpace.Match(characterBlock).Value, "'hidden':!0x1,");
            }
            else
            {
                if (regexBought.Match(characterBlock).Value.Length != 0)
                    characterBlock = characterBlock.Replace(regexBought.Match(characterBlock).Value, "'isBought': !0x1,");
                else if (regexBoughtNoSpace.Match(characterBlock).Value.Length != 0)
                        characterBlock = characterBlock.Replace(regexBoughtNoSpace.Match(characterBlock).Value, "'isBought':!0x1,");
                if (regexHidden.Match(characterBlock).Value.Length != 0)
                    characterBlock = characterBlock.Replace(regexHidden.Match(characterBlock).Value, "'hidden': !0x0,");
                else if (regexHiddenNoSpace.Match(characterBlock).Value.Length != 0)
                    characterBlock = characterBlock.Replace(regexHiddenNoSpace.Match(characterBlock).Value, "'hidden':!0x0,");
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
