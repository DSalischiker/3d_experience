using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : NPCState
{
    int distanceStopFollow = 18;
    int limit = 4;
    public float speed = 2;
    Character character;


    public override void Init()
    {
        /* character = npc.character; */
    }
    private void Update()
    {
        if (npc.character == null)
        {
            print("character null");
            /* npc.SetNewState(states.IDLE); */
            return;
        }
        float distanceToCharacter = Vector3.Distance(transform.position, npc.character.transform.position);
        if (npc.isHelper)
        {

        }
        else
        {
            print("dc: " + distanceToCharacter);
            if (distanceToCharacter > distanceStopFollow)
                Alert();
            else if (distanceToCharacter < limit) {
              print("talk");
              npc.SetNewState(states.TALK);
            }
        }
        /* transform.Translate(Vector3.forward * speed * Time.deltaTime); */
    }

    public override void OnCharacterEnterViewZone(Character character) {
      /* npc.lookAtTarget.LookAt(character); */
    }

    public override void OnCharacterExitViewZone(Character character) {
      /* npc.lookAtTarget.LookAt(null); */
      npc.SetNewState(states.IDLE);
    }

    void Alert()
    {
        print("alert");
        npc.SetNewState(states.ALERT);
    }
}
