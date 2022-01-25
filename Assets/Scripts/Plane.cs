using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Plane : Vehicle
{
    private float wiggleRangeY = 2f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // POLYMORPHISM
    protected override void MoveForward()
    {
        gameObject.transform.Translate(
            speed * Time.deltaTime, 
            Random.Range(-wiggleRangeY,wiggleRangeY) * Time.deltaTime, 
            0, 
            Space.World);
    }
}
