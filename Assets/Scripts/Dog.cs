using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] Transform _cameraMount;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *Input.GetAxis("Vertical")* _movementSpeed);
        transform.Rotate(Vector3.up, _rotationSpeed * Input.GetAxis("Horizontal"));
        
    }
    public void SetCamera(GameObject cam)
    {
    
        cam.transform.SetParent(_cameraMount, false);
     
    }
}
