using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float mHor;
    float mVer;
    bool gunLoaded=true; 
    Vector3 moveDirection;
    Vector2 facingMovement; 
    [SerializeField]Transform aim; 
    [SerializeField] int speed=3;
    [SerializeField] Camera camera; 
    [SerializeField] Transform bullet; 
    [SerializeField]float fireRate=1; 
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
        
        // Movimiento de la mira
        facingMovement = camera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        aim.position = transform.position + (Vector3)facingMovement.normalized;

        if(Input.GetMouseButton(0) && gunLoaded){
            gunLoaded = false; 
            float angle = Mathf.Atan2(facingMovement.y, facingMovement.x) * Mathf.Rad2Deg; 
            Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Instantiate(bullet, transform.position, targetRotation);
            StartCoroutine(ReloadGun());
        }

    }

    IEnumerator ReloadGun() {
        if(fireRate==0)
            fireRate=0.1f;
        yield return new WaitForSeconds(1/fireRate); 
        gunLoaded =true;  
    }

}
