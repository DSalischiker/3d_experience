using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* [RequireComponent(typeof(AudioSource))] */

public class Key : InteractiveObject
{
  public override void OnInteract(Character character)
  {
    soundMachine.makeSound("key");
    base.OnInteract(character);
    print("played audio");
  }
}
