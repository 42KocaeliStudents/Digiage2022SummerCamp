using Assets.Script.Abstract;
using Assets.Script.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Concrete
{
    public class JumpManager : IJump
    {
        private Ground _ground;
        private Rigidbody _body;
        private Player _player;
        private AnimatorManager _animatorManager;

        public JumpManager(Ground ground, Rigidbody body, Player player, AnimatorManager animatorManager)
        {
            _ground = ground;
            _body = body;
            _player = player;
            _animatorManager = animatorManager;
        }

        public bool IsJump(Ground _ground)
        {
            return (_ground.IsGround);
        }

        public void Jump(Vector3 tempVect)
        {
            bool j = Input.GetKey(KeyCode.Space);
            if (j && _ground.IsGround)
            {
                _animatorManager.SetAnim("Speed", -1);
                _body.velocity = Vector3.zero;
                _body.AddForce(Vector3.up * _player.jumpHeight);
            }
        }
    }
}
