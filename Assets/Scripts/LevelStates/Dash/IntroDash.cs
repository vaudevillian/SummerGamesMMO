using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.LevelStates.Dash
{
    public class IntroDash : ConcreteLevelState
    {
        public override void Start()
        {
            base.Start();
            Debug.Log("Started");
        }
        public override void Stop()
        {
            Debug.Log("Stopped");
        }

        public override bool Update()
        {
            if( base.Update() )
            {
                return true;
            }

            return false;
        }

    }
}
