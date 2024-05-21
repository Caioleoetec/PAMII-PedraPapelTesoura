using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura.Models
{
    internal class Player
    {
        private string Name {  get; set; }
        private EnumChoice choice;
        private int score { get; set; }
        
        void play() {
            // 1 - Paper; 2 - Scissors; 3 - Rock 
            int escolha = Random.Shared.Next(3);
            if(escolha == 1){
                choice = EnumChoice.PAPER;
            }
            if(escolha == 2)
            {
                choice = EnumChoice.SCISSORS;
            }
            if(escolha == 3) {
                choice = EnumChoice.ROCK;
            }
        }
        void play(EnumChoice choice) { this.choice = choice;}
    }
}
