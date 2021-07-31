using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InvisibleHuman.BodyTracking
{
    public class HumanoidTracker : MonoBehaviour
    {
        private Animator animator;
        private Animator origin;

        private void Start()
        {
            animator = this.GetComponent<Animator>();
        }

        private void Update()
        {
            origin = BoneHandler.animator;
            if (origin == null) return;

            var originalHandler = new HumanPoseHandler(origin.avatar, origin.transform);
            var targetHandler = new HumanPoseHandler(animator.avatar, animator.transform);

            HumanPose humanPose = new HumanPose();
            originalHandler.GetHumanPose(ref humanPose);
            targetHandler.SetHumanPose(ref humanPose);

            animator.rootPosition = origin.rootPosition;
            animator.rootRotation = origin.rootRotation;
            this.transform.position = origin.transform.position;
            this.transform.rotation = origin.transform.rotation;
            this.transform.localScale = origin.transform.lossyScale * 2;
        }
    }

}