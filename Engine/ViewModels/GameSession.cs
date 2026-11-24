using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
      public class GameSession
    {
        public Player CurrentPlayer {  get; set; }

        //Constructer
        public GameSession()
        {
           CurrentPlayer = new Player();
            CurrentPlayer.Name = "Anashya";
            CurrentPlayer.Class = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperienceLevel = 0;
            CurrentPlayer.Level = 1;

        }

    }
}
