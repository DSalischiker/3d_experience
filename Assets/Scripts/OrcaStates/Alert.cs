using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : NPCState
{
    int distanceToFollow = 15;

    // Update is called once per frame
    private void Update()
    {
        if (npc != null && npc.character != null) {
            npc.lookAtTarget.LookAt(npc.character);
            float distanceToCharacter = Vector3.Distance(transform.position, npc.character.transform.position);
            if (distanceToCharacter < distanceToFollow){
                npc.SetNewState(states.FOLLOW);
            }
        } else {
            npc.SetNewState(states.IDLE);
        }
    }

    public override void Init() {
        /* npc.anim.Play("Dizzy"); */
    }
    public override void OnCharacterExitViewZone(Character character){
        npc.SetNewState(states.IDLE);
    }
}
