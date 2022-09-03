using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Abstract
{
    public interface IAnimator
    {
        void SetAnim(string animName,float value);
        void AnimRun(string animName, Vector3 vector);
    }
}
