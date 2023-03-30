using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour
{
    public float alpha = 0.5f;//half transparency
    public GameObject bullet;
    public GameObject gib;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator waiter()
    {
        /*//Rotate 90 deg
        gameObject.transform.Rotate(new Vector3(90, 0, 0), Space.World);

        //Wait for 4 seconds
        yield return new WaitForSeconds(4);

        //Rotate 40 deg
        transform.Rotate(new Vector3(40, 0, 0), Space.World);

        //Wait for 2 seconds
        yield return new WaitForSeconds(2);

        //Rotate 20 deg
        transform.Rotate(new Vector3(20, 0, 0), Space.World);*/
        Instantiate(gib, GameObject.FindGameObjectWithTag("GHOST").transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        yield return new WaitForSeconds(7);
        Destroy(gib);
        Destroy(bullet);
    }
    void OnCollisionEnter()
    {
        StartCoroutine(waiter());
        
    }
    /*void Update()
    {
        ChangeAlpha(gameObject.GetComponent<Renderer>().material, alpha);
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);

    }*/
    // Update is called once per frame
    
}
