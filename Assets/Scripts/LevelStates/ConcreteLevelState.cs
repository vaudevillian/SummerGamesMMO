using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Assets.Scripts.LevelStates
{
    public class ConcreteLevelState : AbstractLevelState
    {
        private bool mIsInitialized;
        private Timer mTimer;

        public override void Start()
        {
            Console.WriteLine("Started");

            var onSuccess = new Action<object>( ( state ) => 
            {
                mIsInitialized = true;
                Timer t = (Timer)state;
                t.Dispose();
            });

            mTimer = new Timer(new TimerCallback(onSuccess));
            mTimer.Change(2000, 0);
        }

        public override void Stop()
        {
            Console.WriteLine("Stopped");
        }

        public override bool Update()
        {
            if( !mIsInitialized )
            {
                return false;
            }

            return true;
        }
    }
}
