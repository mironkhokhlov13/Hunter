using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimals : MonoBehaviour
{

    private int speed = 2;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
