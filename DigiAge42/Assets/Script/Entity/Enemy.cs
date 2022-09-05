using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Entity
{
    public class Enemy
    {
        public string Name { get; set; }
        public bool IsGround { get; set; }
        public float Speed { get; set; }
        public float JumpHeight { get; set; }
    }
}
