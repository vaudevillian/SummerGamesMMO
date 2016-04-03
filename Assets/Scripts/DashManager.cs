using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.LevelStates;
using Assets.Scripts.LevelStates.Dash;

public class DashManager : MonoBehaviour {

    private enum ELevelState : int
    {
        NONE,
        INTRO,
        PLAYER_PREPARE,
        LEVEL_STARTED,
        OUTRO,
        NUM_STATES
    }

    //private List<ConcreteLevelState> mStates = new List<ConcreteLevelState>((int)ELevelState.NUM_STATES);
    private Dictionary<ELevelState, ConcreteLevelState> mDicStates = new Dictionary<ELevelState, ConcreteLevelState>();
    private ELevelState mCurrentState = ELevelState.NONE;
    
	void Start ()
    {
	
	}
	
	void Update ()
    {
        if( Input.GetKeyUp( KeyCode.F1 ) )
        {
            SetState(ELevelState.INTRO);
        } 	

        if( mCurrentState != ELevelState.NONE )
        {
            GetState(mCurrentState).Update();
        }
	}

    private void SetState( ELevelState state )
    {
        if( state != mCurrentState )
        {
            if( mCurrentState != ELevelState.NONE )
            {
                GetState(mCurrentState).Stop();
            }
        }

        mCurrentState = state;
        GetState(mCurrentState).Start();
    }

    private ConcreteLevelState GetState( ELevelState eState )
    {
        if( !mDicStates.ContainsKey( eState ) )
        {
            ConcreteLevelState stateInstance = null;
            switch( eState )
            {
                case ELevelState.INTRO:
                    stateInstance = new IntroDash();
                    break;
            }

            mDicStates[ eState] = stateInstance;
        }

        return mDicStates[ eState] as ConcreteLevelState;
    }

    void ProcessIntro()
    {

    }
}