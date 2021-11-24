using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : NPCState
{
    public override void Init() {
        /* npc.anim.Play("Idle_Battle"); */
    }
    /* public override void OnTryToAttack() {

    } */

    public override void OnCharacterEnterViewZone(Character character) {
        if (npc.isHelper)
        {
            npc.SetNewState(states.FOLLOW);
        } else {
            npc.SetNewState(states.ALERT);
        }
    }
}
