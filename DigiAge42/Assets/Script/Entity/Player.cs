using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Entity
{
    public class Player: IEntity
    {
        public bool isGrounded;
        public float healty;
        public float speed = 2.0f;
        public float jumpHeight = 1.0f;
        public Vector3 velocity;
    }
}
