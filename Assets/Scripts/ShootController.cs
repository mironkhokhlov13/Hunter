using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrel;
    private Quaternion bulletRotation;
    // Update is called once per frame
    void Update()
    {
        bulletRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 270);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, barrel.position, bulletRotation);
        }

    }
}
