using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    public Animator player;
    public Animator ghost;
    public Transform Father;
    public Vector3 targetPosition;
    public float smoothTime = 0.5f;
    public float speed = 10;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("LomoCam").GetComponent<Animator>();
        Father = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        ghost = GameObject.FindGameObjectWithTag("GHOST").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetBool("Fermo"))
        {
            if (transform.position == targetPosition)
            {
                ghost.SetTrigger("Attacked");
                Destroy(gameObject, 1.0f);
            }
            else
            {
                targetPosition = Father.position;
                transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);
            }
        }
    }
}
