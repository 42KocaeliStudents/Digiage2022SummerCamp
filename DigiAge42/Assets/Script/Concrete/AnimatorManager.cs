using Assets.Script.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Concrete
{
    public class AnimatorManager : MonoBehaviour, IAnimator
    {
        private Animator _animator;
        public AnimatorManager(Animator animator)
        {
            _animator = animator;
        }
        public void AnimRun(string animName, Vector3 vector)
        {
            if (vector != Vector3.zero)
            {
                SetAnim(animName, 1);
            }
            else
            {
                SetAnim(animName, -1);
            }
        }

        public void SetAnim(string animName, float value)
        {
            _animator.SetFloat(animName, value);
        }
    }
}
