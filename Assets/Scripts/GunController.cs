using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float sensetive = 2;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensetive;
        vertical = Input.GetAxis("Mouse Y") * sensetive;

        transform.Rotate(0, horizontal, 0);
        transform.Rotate(0, 0, vertical);
    }
}
