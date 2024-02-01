using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    public string triggerName = "RockBlock";
    Animator anim;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void RockBlock()
    {
        anim.SetTrigger(triggerName);
    }
}
