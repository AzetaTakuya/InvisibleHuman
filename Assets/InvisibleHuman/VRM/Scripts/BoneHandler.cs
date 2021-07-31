using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InvisibleHuman.BodyTracking
{
    public class BoneHandler : MonoBehaviour
    {
        public static Animator animator { get; private set; }

        void OnEnable()
        {
            animator = this.GetComponent<Animator>();
        }
    }
}

