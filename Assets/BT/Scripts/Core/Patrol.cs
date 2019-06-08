﻿using UnityEngine;

namespace BT
{
    [SearchTaskPath("Action/Patrol")]
    [CustomNodeDrawer(typeof(AAction))]
    public class Patrol : AAction
    {
        protected override void OnFirstTick()
        {
            base.OnFirstTick();
            Debug.Log("Initialized Patrol Action");
        }

        protected override TaskStatus Update()
        {
            Debug.Log("Tick Patrol Action");
            return base.Update();
        }

        protected override void OnTerminate(TaskStatus taskStatus)
        {
            Debug.Log("Terminate Patrol Action");
            base.OnTerminate(taskStatus);
        }
    }
}