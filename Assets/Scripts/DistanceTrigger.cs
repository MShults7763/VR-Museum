using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DistanceTrigger : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float activationDistance = 3.0f;
    [SerializeField] private float resetDelay = 10.0f;
    private float timer;

    float distance;


    private Animator anim;
    private AudioSource audioSource;
    void Start()
    {
        anim = this.GetComponent<Animator>();
        audioSource = this.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, target.position);
        if (distance < activationDistance && timer <=0)
        {
            Activate();
        }
        if(timer > 0) timer -= Time.deltaTime;
    }

    void Activate(){
        anim.Play("iPi Default Take");

        if (audioSource != null){
            audioSource.Play();
        }

        timer = resetDelay;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, activationDistance);
    }
}
