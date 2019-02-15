using NetCoreGui.Utility;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Drawing
{
    public static class Colors
    {
        public static Color Default { get { return new Color(254,254,254,0); } }
        public class Red
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#FFEBEE");
            public static Color L100 = ColorUtil.GetSfmlColor("#FFCDD2");
            public static Color L200 = ColorUtil.GetSfmlColor("#EF9A9A");
            public static Color L300 = ColorUtil.GetSfmlColor("#E57373");
            public static Color L400 = ColorUtil.GetSfmlColor("#EF5350");
            public static Color L500 = ColorUtil.GetSfmlColor("#F44336");
            public static Color L600 = ColorUtil.GetSfmlColor("#E53935");
            public static Color L700 = ColorUtil.GetSfmlColor("#D32F2F");
            public static Color L800 = ColorUtil.GetSfmlColor("#C62828");
            public static Color L900 = ColorUtil.GetSfmlColor("#B71C1C");
        }

        public class Pink
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#FCE4EC");
            public static Color L100 = ColorUtil.GetSfmlColor("#F8BBD0");
            public static Color L200 = ColorUtil.GetSfmlColor("#F48FB1");
            public static Color L300 = ColorUtil.GetSfmlColor("#F06292");
            public static Color L400 = ColorUtil.GetSfmlColor("#EC407A");
            public static Color L500 = ColorUtil.GetSfmlColor("#E91E63");
            public static Color L600 = ColorUtil.GetSfmlColor("#D81B60");
            public static Color L700 = ColorUtil.GetSfmlColor("#C2185B");
            public static Color L800 = ColorUtil.GetSfmlColor("#AD1457");
            public static Color L900 = ColorUtil.GetSfmlColor("#880E4F");
        }

        public class Purple
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#F3E5F5");
            public static Color L100 = ColorUtil.GetSfmlColor("#E1BEE7");
            public static Color L200 = ColorUtil.GetSfmlColor("#CE93D8");
            public static Color L300 = ColorUtil.GetSfmlColor("#BA68C8");
            public static Color L400 = ColorUtil.GetSfmlColor("#AB47BC");
            public static Color L500 = ColorUtil.GetSfmlColor("#9C27B0");
            public static Color L600 = ColorUtil.GetSfmlColor("#8E24AA");
            public static Color L700 = ColorUtil.GetSfmlColor("#7B1FA2");
            public static Color L800 = ColorUtil.GetSfmlColor("#6A1B9A");
            public static Color L900 = ColorUtil.GetSfmlColor("#4A148C");
        }

        public class DeepPurple
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#EDE7F6");
            public static Color L100 = ColorUtil.GetSfmlColor("#D1C4E9");
            public static Color L200 = ColorUtil.GetSfmlColor("#B39DDB");
            public static Color L300 = ColorUtil.GetSfmlColor("#BA68C8");
            public static Color L400 = ColorUtil.GetSfmlColor("#7E57C2");
            public static Color L500 = ColorUtil.GetSfmlColor("#673AB7");
            public static Color L600 = ColorUtil.GetSfmlColor("#5E35B1");
            public static Color L700 = ColorUtil.GetSfmlColor("#512DA8");
            public static Color L800 = ColorUtil.GetSfmlColor("#4527A0");
            public static Color L900 = ColorUtil.GetSfmlColor("#311B92");
        }

        public class Indigo
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#E8EAF6");
            public static Color L100 = ColorUtil.GetSfmlColor("#C5CAE9");
            public static Color L200 = ColorUtil.GetSfmlColor("#9FA8DA");
            public static Color L300 = ColorUtil.GetSfmlColor("#BA68C8");
            public static Color L400 = ColorUtil.GetSfmlColor("#5C6BC0");
            public static Color L500 = ColorUtil.GetSfmlColor("#3F51B5");
            public static Color L600 = ColorUtil.GetSfmlColor("#3949AB");
            public static Color L700 = ColorUtil.GetSfmlColor("#303F9F");
            public static Color L800 = ColorUtil.GetSfmlColor("#283593");
            public static Color L900 = ColorUtil.GetSfmlColor("#1A237E");
        }
        
        public class Blue
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#E3F2FD");
            public static Color L100 = ColorUtil.GetSfmlColor("#BBDEFB");
            public static Color L200 = ColorUtil.GetSfmlColor("#90CAF9");
            public static Color L300 = ColorUtil.GetSfmlColor("#64B5F6");
            public static Color L400 = ColorUtil.GetSfmlColor("#42A5F5");
            public static Color L500 = ColorUtil.GetSfmlColor("#2196F3");
            public static Color L600 = ColorUtil.GetSfmlColor("#1E88E5");
            public static Color L700 = ColorUtil.GetSfmlColor("#1976D2");
            public static Color L800 = ColorUtil.GetSfmlColor("#1565C0");
            public static Color L900 = ColorUtil.GetSfmlColor("#0D47A1");
        }

        public class LightBlue
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#E1F5FE");
            public static Color L100 = ColorUtil.GetSfmlColor("#B3E5FC");
            public static Color L200 = ColorUtil.GetSfmlColor("#81D4FA");
            public static Color L300 = ColorUtil.GetSfmlColor("#4FC3F7");
            public static Color L400 = ColorUtil.GetSfmlColor("#29B6F6");
            public static Color L500 = ColorUtil.GetSfmlColor("#03A9F4");
            public static Color L600 = ColorUtil.GetSfmlColor("#039BE5");
            public static Color L700 = ColorUtil.GetSfmlColor("#0288D1");
            public static Color L800 = ColorUtil.GetSfmlColor("#0277BD");
            public static Color L900 = ColorUtil.GetSfmlColor("#01579B");
        }

        public class Cyan
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#E0F7FA");
            public static Color L100 = ColorUtil.GetSfmlColor("#B2EBF2");
            public static Color L200 = ColorUtil.GetSfmlColor("#80DEEA");
            public static Color L300 = ColorUtil.GetSfmlColor("#4DD0E1");
            public static Color L400 = ColorUtil.GetSfmlColor("#26C6DA");
            public static Color L500 = ColorUtil.GetSfmlColor("#00BCD4");
            public static Color L600 = ColorUtil.GetSfmlColor("#00ACC1");
            public static Color L700 = ColorUtil.GetSfmlColor("#0097A7");
            public static Color L800 = ColorUtil.GetSfmlColor("#00838F");
            public static Color L900 = ColorUtil.GetSfmlColor("#006064");
        }

        public class Teal
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#E0F2F1");
            public static Color L100 = ColorUtil.GetSfmlColor("#B2DFDB");
            public static Color L200 = ColorUtil.GetSfmlColor("#80CBC4");
            public static Color L300 = ColorUtil.GetSfmlColor("#4DB6AC");
            public static Color L400 = ColorUtil.GetSfmlColor("#26A69A");
            public static Color L500 = ColorUtil.GetSfmlColor("#009688");
            public static Color L600 = ColorUtil.GetSfmlColor("#00897B");
            public static Color L700 = ColorUtil.GetSfmlColor("#00796B");
            public static Color L800 = ColorUtil.GetSfmlColor("#00695C");
            public static Color L900 = ColorUtil.GetSfmlColor("#004D40");
        }

        public class Green
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#E8F5E9");
            public static Color L100 = ColorUtil.GetSfmlColor("#C8E6C9");
            public static Color L200 = ColorUtil.GetSfmlColor("#A5D6A7");
            public static Color L300 = ColorUtil.GetSfmlColor("#81C784");
            public static Color L400 = ColorUtil.GetSfmlColor("#66BB6A");
            public static Color L500 = ColorUtil.GetSfmlColor("#4CAF50");
            public static Color L600 = ColorUtil.GetSfmlColor("#43A047");
            public static Color L700 = ColorUtil.GetSfmlColor("#388E3C");
            public static Color L800 = ColorUtil.GetSfmlColor("#2E7D32");
            public static Color L900 = ColorUtil.GetSfmlColor("#1B5E20");
        }

        public class LightGreen
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#F1F8E9");
            public static Color L100 = ColorUtil.GetSfmlColor("#DCEDC8");
            public static Color L200 = ColorUtil.GetSfmlColor("#C5E1A5");
            public static Color L300 = ColorUtil.GetSfmlColor("#AED581");
            public static Color L400 = ColorUtil.GetSfmlColor("#9CCC65");
            public static Color L500 = ColorUtil.GetSfmlColor("#8BC34A");
            public static Color L600 = ColorUtil.GetSfmlColor("#7CB342");
            public static Color L700 = ColorUtil.GetSfmlColor("#689F38");
            public static Color L800 = ColorUtil.GetSfmlColor("#558B2F");
            public static Color L900 = ColorUtil.GetSfmlColor("#33691E");
        }
        public class Lime
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#F9FBE7");
            public static Color L100 = ColorUtil.GetSfmlColor("#F0F4C3");
            public static Color L200 = ColorUtil.GetSfmlColor("#E6EE9C");
            public static Color L300 = ColorUtil.GetSfmlColor("#DCE775");
            public static Color L400 = ColorUtil.GetSfmlColor("#D4E157");
            public static Color L500 = ColorUtil.GetSfmlColor("#CDDC39");
            public static Color L600 = ColorUtil.GetSfmlColor("#C0CA33");
            public static Color L700 = ColorUtil.GetSfmlColor("#AFB42B");
            public static Color L800 = ColorUtil.GetSfmlColor("#9E9D24");
            public static Color L900 = ColorUtil.GetSfmlColor("#827717");
        }

        public class Yellow
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#FFFDE7");
            public static Color L100 = ColorUtil.GetSfmlColor("#FFF9C4");
            public static Color L200 = ColorUtil.GetSfmlColor("#FFF59D");
            public static Color L300 = ColorUtil.GetSfmlColor("#FFF176");
            public static Color L400 = ColorUtil.GetSfmlColor("#FFEE58");
            public static Color L500 = ColorUtil.GetSfmlColor("#FFEB3B");
            public static Color L600 = ColorUtil.GetSfmlColor("#FDD835");
            public static Color L700 = ColorUtil.GetSfmlColor("#FBC02D");
            public static Color L800 = ColorUtil.GetSfmlColor("#F9A825");
            public static Color L900 = ColorUtil.GetSfmlColor("#F57F17");
        }

        public class Amber
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#FFF8E1");
            public static Color L100 = ColorUtil.GetSfmlColor("#FFECB3");
            public static Color L200 = ColorUtil.GetSfmlColor("#FFE082");
            public static Color L300 = ColorUtil.GetSfmlColor("#FFD54F");
            public static Color L400 = ColorUtil.GetSfmlColor("#FFCA28");
            public static Color L500 = ColorUtil.GetSfmlColor("#FFC107");
            public static Color L600 = ColorUtil.GetSfmlColor("#FFB300");
            public static Color L700 = ColorUtil.GetSfmlColor("#FFA000");
            public static Color L800 = ColorUtil.GetSfmlColor("#FF8F00");
            public static Color L900 = ColorUtil.GetSfmlColor("#FF6F00");
        }

        public class Orange
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#FFF3E0");
            public static Color L100 = ColorUtil.GetSfmlColor("#FFE0B2");
            public static Color L200 = ColorUtil.GetSfmlColor("#FFCC80");
            public static Color L300 = ColorUtil.GetSfmlColor("#FFB74D");
            public static Color L400 = ColorUtil.GetSfmlColor("#FFA726");
            public static Color L500 = ColorUtil.GetSfmlColor("#FF9800");
            public static Color L600 = ColorUtil.GetSfmlColor("#FB8C00");
            public static Color L700 = ColorUtil.GetSfmlColor("#F57C00");
            public static Color L800 = ColorUtil.GetSfmlColor("#EF6C00");
            public static Color L900 = ColorUtil.GetSfmlColor("#E65100");
        }

        public class DeepOrange
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#FBE9E7");
            public static Color L100 = ColorUtil.GetSfmlColor("#FFCCBC");
            public static Color L200 = ColorUtil.GetSfmlColor("#FFAB91");
            public static Color L300 = ColorUtil.GetSfmlColor("#FF8A65");
            public static Color L400 = ColorUtil.GetSfmlColor("#FF7043");
            public static Color L500 = ColorUtil.GetSfmlColor("#FF5722");
            public static Color L600 = ColorUtil.GetSfmlColor("#F4511E");
            public static Color L700 = ColorUtil.GetSfmlColor("#E64A19");
            public static Color L800 = ColorUtil.GetSfmlColor("#D84315");
            public static Color L900 = ColorUtil.GetSfmlColor("#BF360C");
        }

        public class Brown
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#EFEBE9");
            public static Color L100 = ColorUtil.GetSfmlColor("#D7CCC8");
            public static Color L200 = ColorUtil.GetSfmlColor("#BCAAA4");
            public static Color L300 = ColorUtil.GetSfmlColor("#A1887F");
            public static Color L400 = ColorUtil.GetSfmlColor("#8D6E63");
            public static Color L500 = ColorUtil.GetSfmlColor("#795548");
            public static Color L600 = ColorUtil.GetSfmlColor("#6D4C41");
            public static Color L700 = ColorUtil.GetSfmlColor("#5D4037");
            public static Color L800 = ColorUtil.GetSfmlColor("#4E342E");
            public static Color L900 = ColorUtil.GetSfmlColor("#3E2723");
        }

        public class Grey
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#FAFAFA");
            public static Color L100 = ColorUtil.GetSfmlColor("#F5F5F5");
            public static Color L200 = ColorUtil.GetSfmlColor("#EEEEEE");
            public static Color L300 = ColorUtil.GetSfmlColor("#E0E0E0");
            public static Color L400 = ColorUtil.GetSfmlColor("#BDBDBD");
            public static Color L500 = ColorUtil.GetSfmlColor("#9E9E9E");
            public static Color L600 = ColorUtil.GetSfmlColor("#757575");
            public static Color L700 = ColorUtil.GetSfmlColor("#616161");
            public static Color L800 = ColorUtil.GetSfmlColor("#424242");
            public static Color L900 = ColorUtil.GetSfmlColor("#212121");
        }

        public class BlueGrey
        {
            public static Color L50 = ColorUtil.GetSfmlColor("#ECEFF1");
            public static Color L100 = ColorUtil.GetSfmlColor("#CFD8DC");
            public static Color L200 = ColorUtil.GetSfmlColor("#B0BEC5");
            public static Color L300 = ColorUtil.GetSfmlColor("#90A4AE");
            public static Color L400 = ColorUtil.GetSfmlColor("#78909C");
            public static Color L500 = ColorUtil.GetSfmlColor("#607D8B");
            public static Color L600 = ColorUtil.GetSfmlColor("#546E7A");
            public static Color L700 = ColorUtil.GetSfmlColor("#455A64");
            public static Color L800 = ColorUtil.GetSfmlColor("#37474F");
            public static Color L900 = ColorUtil.GetSfmlColor("#263238");
        }

        public class Palette
        {
            public class ArmorFalls
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#bfd6f6");
                public static Color _2 = ColorUtil.GetSfmlColor("#8dbdff");
                public static Color _3 = ColorUtil.GetSfmlColor("#64a1f4");
                public static Color _4 = ColorUtil.GetSfmlColor("#4a91f2");
                public static Color _5 = ColorUtil.GetSfmlColor("#3b7dd8");
            }

            public class SpaceGray
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#343d46");
                public static Color _2 = ColorUtil.GetSfmlColor("#4f5b66");
                public static Color _3 = ColorUtil.GetSfmlColor("#65737e");
                public static Color _4 = ColorUtil.GetSfmlColor("#a7adba");
                public static Color _5 = ColorUtil.GetSfmlColor("#c0c5ce");
            }

            public class SkinTones
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#8d5524");
                public static Color _2 = ColorUtil.GetSfmlColor("#c68642");
                public static Color _3 = ColorUtil.GetSfmlColor("#e0ac69");
                public static Color _4 = ColorUtil.GetSfmlColor("#f1c27d");
                public static Color _5 = ColorUtil.GetSfmlColor("#ffdbac");
            }

            public class PurpleSkyline
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#2e003e");
                public static Color _2 = ColorUtil.GetSfmlColor("#3d2352");
                public static Color _3 = ColorUtil.GetSfmlColor("#3d1e6d");
                public static Color _4 = ColorUtil.GetSfmlColor("#8874a3");
                public static Color _5 = ColorUtil.GetSfmlColor("#e4dcf1");
            }

            public class OfficeRoom
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#84c1ff");
                public static Color _2 = ColorUtil.GetSfmlColor("#add6ff");
                public static Color _3 = ColorUtil.GetSfmlColor("#d6eaff");
                public static Color _4 = ColorUtil.GetSfmlColor("#eaf4ff");
                public static Color _5 = ColorUtil.GetSfmlColor("#f8fbff");
            }

            public class ProgramCatalog
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#edc951");
                public static Color _2 = ColorUtil.GetSfmlColor("#eb6841");
                public static Color _3 = ColorUtil.GetSfmlColor("#cc2a36");
                public static Color _4 = ColorUtil.GetSfmlColor("#4f372d");
                public static Color _5 = ColorUtil.GetSfmlColor("#00a0b0");
            }

            public class NeverDoubt
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#eeeeee");
                public static Color _2 = ColorUtil.GetSfmlColor("#dddddd");
                public static Color _3 = ColorUtil.GetSfmlColor("#cccccc");
                public static Color _4 = ColorUtil.GetSfmlColor("#bbbbbb");
                public static Color _5 = ColorUtil.GetSfmlColor("#29a8ab");
            }

            public class Greyso
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#6f7c85");
                public static Color _2 = ColorUtil.GetSfmlColor("#75838d");
                public static Color _3 = ColorUtil.GetSfmlColor("#7e8d98");
                public static Color _4 = ColorUtil.GetSfmlColor("#8595a1");
                public static Color _5 = ColorUtil.GetSfmlColor("#8c9da9");
            }

            public class MetroUi
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#d11141");
                public static Color _2 = ColorUtil.GetSfmlColor("#00b159");
                public static Color _3 = ColorUtil.GetSfmlColor("#00aedb");
                public static Color _4 = ColorUtil.GetSfmlColor("#f37735");
                public static Color _5 = ColorUtil.GetSfmlColor("#ffc425");
            }

            public class PastelRainbow
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#a8e6cf");
                public static Color _2 = ColorUtil.GetSfmlColor("#dcedc1");
                public static Color _3 = ColorUtil.GetSfmlColor("#ffd3b6");
                public static Color _4 = ColorUtil.GetSfmlColor("#ffaaa5");
                public static Color _5 = ColorUtil.GetSfmlColor("#ff8b94");
            }

            public class RainbowDash
            {
                public static Color _1 = ColorUtil.GetSfmlColor("#ee4035");
                public static Color _2 = ColorUtil.GetSfmlColor("#f37736");
                public static Color _3 = ColorUtil.GetSfmlColor("#fdf498");
                public static Color _4 = ColorUtil.GetSfmlColor("#7bc043");
                public static Color _5 = ColorUtil.GetSfmlColor("#0392cf");
            }
        }
    }
}
