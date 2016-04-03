using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.LevelStates
{
    public abstract class AbstractLevelState
    {
        public abstract void Start();
        public abstract void Stop();
        public abstract bool Update();
    }

}
