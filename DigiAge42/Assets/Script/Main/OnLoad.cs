using Assets.Script.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.Main
{
    public class OnLoad
    {
        private Player _player;
        public OnLoad()
        {
            _player = new Player() { jumpHeight = 250, speed = 5, isGrounded = false};
        }

        public Player GetPlayer()
        {
            return (Player)_player;
        }

        public void SetPlayer(Player player) 
        {
            _player = player;
        }
    }
}
