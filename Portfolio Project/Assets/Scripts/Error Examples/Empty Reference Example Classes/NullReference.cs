using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullReference : MonoBehaviour
{
    [SerializeField] GameObject objReference;
    [SerializeField] ExampleClass eClass;

    private void Start()
    {
        //print(objReference.name);
       // print(eClass.name); 
    }
}
