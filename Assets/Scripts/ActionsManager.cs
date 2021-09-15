using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsManager : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    public void SetSpeed(float speed){
        anim.SetFloat("speed", speed);
    }

    public void Attack() {
        anim.SetBool("attack", true);
        Invoke("StopAttack", 2f);
    }

    public void StopAttack() {
        anim.SetBool("attack", false);
    }

}
