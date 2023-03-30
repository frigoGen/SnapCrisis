using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraGun : MonoBehaviour
{
    public UnityEvent OnShoot;
    public float CoolDown;
    // Start is called before the first frame update
    private float CurrentCooldown;
    void Start()
    {
        CurrentCooldown = CoolDown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            if (CurrentCooldown <= 0f) {
                OnShoot?.Invoke();
                CurrentCooldown = CoolDown;
            }
        }
        CurrentCooldown -= Time.deltaTime;
    }
}
