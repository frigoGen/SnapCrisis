using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePic : MonoBehaviour
{
    public Rigidbody bullet;
    public Light flash;
    public float force = 10.0f;
    public ForceMode forceMode;
    public string fireButton = "Fire1";
    public float delayOnDestroy = 2.0f;
    public float delayOnFlash = 0.5f;
    public GameObject puntatore;
   //This implies a delay of 2 seconds.

    void Start()
    {
        flash.intensity = 0f;
        
    }
    IEnumerator turnOff()
    {
        
        yield return new WaitForSeconds(delayOnFlash);
        flash.intensity = 0f;
        
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Rigidbody instance = Instantiate(bullet, puntatore.transform.position, puntatore.transform.rotation) as Rigidbody;
            flash.intensity = 5000.0f;
            
            instance.AddForce(transform.forward * force, forceMode);


            Destroy(instance, delayOnDestroy);
            //flash.intensity = 0f;
            StartCoroutine(turnOff());

        }
                
            
        

    }
   
}