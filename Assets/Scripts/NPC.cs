using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public bool isHelper;
    // Start is called before the first frame update
    public enum states {
        IDLE,
        ALERT,
        TALK,
        FOLLOW
    }

    public List<NPCState> allStates;
    NPCState currentState;
    public Character character;
    public LookAtTarget lookAtTarget;

    private void Start(){
        SetNewState(NPCState.states.IDLE);
    }
    //Solo puede ser llamado desde un estado
    public void SetNewState(NPCState.states stateType){
        foreach (NPCState npcState in allStates)
        {
            if (npcState.state == stateType)
            {
                this.currentState = npcState;
                currentState.enabled = true;
                currentState.Init();
            } else {
                npcState.enabled = false;
            }
        }
    }

    private void Update() {
        /* if (Input.GetKeyDown(KeyCode.P))
        {
            currentState.OnTryToAttack();
        } */
    }

    public void OnCharacterEnterViewZone(Character character) {
        this.character = character;
        if (character == null)
        {
            currentState.OnCharacterExitViewZone(character);
        } else {
            currentState.OnCharacterEnterViewZone(character);
        }
    }
}
