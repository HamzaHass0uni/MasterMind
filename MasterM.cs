using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterM
{
    class MasterM
    {
        // Les pions possibles: r-red, g-green, b-blue, y-yellow, w-white, o-orange
        private List<char> pegs = new List<char> {'r','g','b','y','w','o' };
        // Difficulte 0 - 3
        // Difficulte 3: le systeme peut choisir plusieurs pions de meme couleur
        private int difficulty;
        // Combinaison a trouver
        private char[] toFind;
        private char[] found;
        private int round;
        private View view;
        private string player;

        public MasterM(int difficulty)
        {
            if (difficulty > 0 && difficulty < 4)
            {
                this.difficulty = difficulty;
            }
            switch(difficulty){
                case 0: toFind = new char[4];
                    break;
                case 1: toFind = new char[5];
                    break;
                case 2: toFind = new char[6];
                    break;
                case 3: toFind = new char[5];
                    break;
                default: toFind = new char[4];
                    break;
            }
        }
        public MasterM()
        {
            toFind = new char[4];
        }

        public void ConfigureGame()
        {           
            // Demander le niveau de difficulte au joueur
            // Demander le nom du joueur
            // Generer une combinaison de pions en fonction de la difficulte
            // Commencer le jeu 
        }
        public void StartGame()
        {
            view.DisplayStart(player);
            bool finished = false;
            while (!finished)
            {
                string userInput = view.AskProposition();
                finished = HandleUserInput(userInput);
            }
            view.DisplayGameFinished(round);
            ScoreSaver.SaveScore(this);
        }

        public bool HandleUserInput(string userInput)
        {
            bool finished = false;
            // Il faut verifier ce que l'utilisateur a tapé. 
            // On ne prend en considération que les x premiers caracteres (x = nombre de pions à trouver).
            // On compare les caracteres avec la combinaison à trouver et on envoie le résultat à l'utilisateur
            return finished;
        }
        public int GetRounds()
        {
            return round;
        }
        public string GetPlayer()
        {
            return player;
        }
    }
}
