using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceOnNoChildren : MonoBehaviour
{
    public Animator targetAnimator;
    public Animator targetAnimator1;
    public GameObject player;
    private Vector3 positions = new Vector3(-1.894279f, 0.144f, 43.28852f);
    private void Start()
    {
        targetAnimator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        targetAnimator1 = GameObject.FindGameObjectWithTag("LomoCam").GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        targetAnimator1.SetBool("Fermo", false);
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount <= 0 )
        {
            targetAnimator1.SetBool("Fermo", false);
            targetAnimator1.SetTrigger("clear");
            targetAnimator.SetTrigger("Advance");
            
        }
        else if(targetAnimator.GetCurrentAnimatorStateInfo(targetAnimator.GetLayerIndex("Base Layer")).IsName("Action"))
        {
            targetAnimator1.SetBool("Fermo", true);
            targetAnimator1.SetTrigger("Point");
            /*if (player.transform.position == positions) {
                targetAnimator.SetBool("cohii", true);
            }*/

        }
    }
}
