using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : NPCState
{
    int distanceStopFollow = 18;
    int limit = 4;
    public float speed = 2;
    Character character;

    public override void Init() {
        /* Move */
        character = npc.character;
    }

    // Update is called once per frame
    private void Update()
    {
        if (character == null) {
            Alert();
            return;
        }
        npc.lookAtTarget.LookAt(character);
        float distanceToCharacter = Vector3.Distance(transform.position, character.transform.position);
        if (npc.isHelper)
        {

        } else {
            if (distanceToCharacter > distanceStopFollow)
            {
                Alert();
            } else if (distanceToCharacter < limit) {
                npc.SetNewState(states.TALK);
            }
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void Alert() {
        /* npc.SetNewState(states.ALERT); */
    }
}
