using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
     class GameSession
    {
        Player CurrentPlayer {  get; set; }

        //Constructer
        public GameSession()
        {
           CurrentPlayer = new Player();
            CurrentPlayer.Name = "Anashya";
            CurrentPlayer.Gold = 1000000;


        }

    }
}
