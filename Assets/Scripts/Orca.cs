using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orca : MonoBehaviour
{
    // Start is called before the first frame update
    public enum states {
        IDLE,
        ALERT,
        FOLLOW,
        TURN
    }

    public List<OrcaState> allStates;
    public states state;
    public void SetNewState(states state){
        this.state = state;
    }
}
