using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Abstract
{
    public interface IJump
    {
        bool IsJump(Ground _ground);
        void Jump(Vector3 tempVect);
    }
}
