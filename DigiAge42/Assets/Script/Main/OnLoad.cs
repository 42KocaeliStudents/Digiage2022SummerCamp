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
        private PlayerStatus _playerStatus;
        public OnLoad()
        {
            _player = new Player() { jumpHeight = 250, speed = 5, rotateSpeed = 15, isGrounded = false};
            _playerStatus = new PlayerStatus { energy = 100, healty = 100 , level = 0};
        }

        public Player GetPlayer()
        {
            return (Player)_player;
        }

        public void SetPlayer(Player player) 
        {
            _player = player;
        }

        public PlayerStatus GetPlayerStatus() 
        {
            return (PlayerStatus)_playerStatus;
        }
        public void SetPlayer(PlayerStatus playerStatus) 
        {
            _playerStatus = playerStatus;
        }
    }
}
