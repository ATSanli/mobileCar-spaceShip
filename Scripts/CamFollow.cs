using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public Transform Target;
    public Vector3 offset;


    void Start()
    {
        
    }

    void Update()
    {
        transform.position=Vector3.Lerp(transform.position,Target.position+offset,Time.deltaTime*3);    

    }
}
