using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Talk : NPCState
{
    public ChatUI chatUI;
    Character character;
    int limit = 5;
    public SpeachData[] speach;
    /* int id; */

    [Serializable]
    public class SpeachData {
        /* public int id; */
        public int goToId;
        public string text;
        public moods mood;
        public MultipleChoiceData[] multipleChoice;
    }

    [Serializable]
    public class MultipleChoiceData {
        public string text;
        public int goToId;
    }
    public enum moods {
        idle,
        angry,
        happy
    }

    public override void Init(){
        /* id = 0; */
        character = npc.character;
        chatUI.Init(speach, this);
    }
    // Update is called once per frame
    private void Update()
    {
        if (character == null)
        {
            return;
        }

        npc.lookAtTarget.LookAt(character);
        float distanceToCharacter = Vector3.Distance(transform.position, character.transform.position);
        if (distanceToCharacter > limit)
        {
            npc.SetNewState(states.FOLLOW);
            chatUI.Hide();
        }
    }

    public void Idle() {
        /* anim idle */
    }

    public void ChangeMood(moods mood) {
        /* switch(mood)
        {
            case moods.idle:
                enemy.anim.Play("Idle_Battle");
                break;
            case moods.happy:
                enemy.anim.Play("GetHit");
                break;
            case moods.angry:
                enemy.anim.Play("Defend");
                break;
        } */
    }
}
