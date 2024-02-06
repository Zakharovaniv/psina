using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Game : MonoBehaviour
{
    
    [SerializeField] private GameObject _ObjectToInstantiate;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _camera;
   
    private List<GameObject> _objectToDestroy = new();
    public void Update()
    {
       if (Input.GetKeyDown(KeyCode.Alpha1))
       {
          if (_objectToDestroy.Count > 0)
         {
          Destroy(_objectToDestroy[0]);
          _objectToDestroy.RemoveAt(index:0);
         } 
       }
        if (Input.GetKeyDown(KeyCode.Alpha2))
       {
          GameObject go =  Instantiate(_ObjectToInstantiate, _spawnPoint.position, _spawnPoint.rotation);
          Dog component = go.GetComponent<Dog>();
          if (component != null)
          {
               component.SetCamera(_camera);
          }
          Register(go);
       }

    }
    public void Register(GameObject ObjectToDestroy)
    {
     _objectToDestroy.Add(ObjectToDestroy);
    }
}
