using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float mHor;
    float mVer;
    Vector3 moveDirection;
    [SerializeField] int speed=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        mHor = Input.GetAxis("Horizontal");
        mVer = Input.GetAxis("Vertical");
        moveDirection.x = mHor;
        moveDirection.y = mVer;
        transform.position += moveDirection * Time.deltaTime * speed;
        
    }
}
