using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    // Start is called before the first frame update
    public float _movementSpeed;
    public float _rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _movementSpeed);
        }
         if (Input.GetKey(KeyCode.A))
        {
           transform.Rotate(Vector3.up * -_rotationSpeed);
        } 
        if (Input.GetKey(KeyCode.S))
        {
           transform.Translate(Vector3.back * _movementSpeed);
        } 
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * _rotationSpeed);
        }
    }
    public void SetGame(Game value)
    {
        value.Register(gameObject);
    }
}
