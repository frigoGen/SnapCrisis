using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimScript1 : MonoBehaviour
{
    
    public Animator targetAnimator1;
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 0){
            if (targetAnimator1 == null)
            {
                targetAnimator1 = GameObject.FindGameObjectWithTag("LomoCam").GetComponent<Animator>();
            }
            targetAnimator1.SetTrigger("Point");
        }
        else {
            
            if (targetAnimator1 == null)
            {
                targetAnimator1 = GameObject.FindGameObjectWithTag("LomoCam").GetComponent<Animator>();
            }
            targetAnimator1.SetTrigger("clear");
        }
        
    }
}
