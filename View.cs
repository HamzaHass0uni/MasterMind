using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterM
{
    class View
    {
        public string DisplayWelcomeMenu()
        {
            string toDisplay = "\n";
            toDisplay += "******************************************\n";
            toDisplay += "**   Welcome to the MASTERMIND Game     **\n";
            toDisplay += "******************************************\n";
            toDisplay += "Choose a difficulty level between 0 and 3...\n";
            Console.WriteLine(toDisplay);
            return Console.ReadLine();
        }
        public string AskPlayerName()
        {
            string toDisplay = "\n";
            toDisplay += ">>>  Introduisez votre nom...   \n";
            toDisplay += ">>>     \n";
            Console.WriteLine(toDisplay);
            return Console.ReadLine();
        }
        public void DisplayStart(string playerName)
        {
            string toDisplay = "***  " + playerName + ", *** \n";
            toDisplay += ">>>   Le systeme a choisi une combinaison...     \n";
            Console.WriteLine(toDisplay);
        }
        public string AskProposition()
        {
            string toDisplay = "";
            toDisplay += ">>>   Faites votre proposition:     \n";
            toDisplay += ">>>\n";
            return Console.ReadLine();
            
        }
        public void DisplayResult(int wellPlaced, int notWellPlaced, int round)
        {
            string toDisplay = ">>> Tour " + round + "\n";
            toDisplay += ">>> Vous avez "+wellPlaced + " pions bien placés et " + notWellPlaced +" pions pas bien placés.\n";
            Console.WriteLine(toDisplay);
        }
        public void DisplayGameFinished(int round){
            Console.WriteLine("BRAVO, vous avez terminé en " + round + " coups!!!!\n");
        }
    }
}
