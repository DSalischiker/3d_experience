using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState : MonoBehaviour
{
    public NPC npc;
    public states state;
    public enum states {
        IDLE,
        ALERT,
        TALK,
        FOLLOW
    };

    void Awake() {
        npc = GetComponent<NPC>();
    }
    // Start is called before the first frame update
    private void Start()
    {

    }

    public virtual void Init() {}

    public virtual void OnCharacterEnterViewZone(Character character){
        print("entro y soy NPCState: " + character);
    }

    public virtual void OnCharacterExitViewZone(Character character){
        print("entro y soy NPCState: " + character);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
