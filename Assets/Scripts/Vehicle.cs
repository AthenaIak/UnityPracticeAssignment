using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // ENCAPSULATION
    private float _speed;
    public float speed { 
        get { return _speed; } 
        protected set { _speed = value; } 
    }

    // ABSTRACTION: The default methods are defined in this parent class
    void Update()
    {
        MoveForward();
    }

    protected virtual void MoveForward()
    {
        gameObject.transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
    }
}
