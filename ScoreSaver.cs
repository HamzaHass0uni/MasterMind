using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterM
{
    class ScoreSaver
    {
        public static void SaveScore(MasterM mm){
            // Le fichier scores.txt doit etrre structuré comme suit:
            // David : 5 rounds (11/05/2017)
            // Carmelo : 8 rounds (13/05/2017)
            // Albert : 2 rounds (13/05/2017)
            // David : 8 rounds (15/05/2017)
            System.IO.Directory.CreateDirectory("c:/temp/MM");
        }
    }
}
