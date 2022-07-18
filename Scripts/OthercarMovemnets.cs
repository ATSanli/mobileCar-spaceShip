using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class OthercarMovemnets : MonoBehaviour
{
    [SerializeField] float OthercarSpeed;

    Vector3 _moveVec;


    void Start()
    {
        
    }

    void Update()
    {
        _moveVec += transform.forward * OthercarSpeed * Time.deltaTime;
        transform.position += _moveVec * Time.deltaTime;
    }
}
