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
        private Transform _transform;
        private AnimatorManager _animatorManager;

        public JumpManager(Ground ground, Rigidbody body, Player player, AnimatorManager animatorManager, Transform transform)
        {
            _ground = ground;
            _body = body;
            _player = player;
            _animatorManager = animatorManager;
            _transform = transform;
        }

        public bool IsJump(Ground _ground)
        {
            return (_ground.IsGround);
        }

        public void Jump(Vector3 tempVect)
        {
            _animatorManager.SetAnim("Speed", -1);
            _body.velocity = Vector3.zero;
            _body.AddForce(_transform.up * _player.jumpHeight);
        }
    }
}
