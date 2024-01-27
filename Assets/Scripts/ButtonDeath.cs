using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDeath : MonoBehaviour
{
    public string triggerName = "Death";
    Animator anim;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void Death()
    {
        anim.SetTrigger(triggerName);
    }
}
