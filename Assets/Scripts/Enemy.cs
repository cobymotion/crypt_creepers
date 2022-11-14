using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform player; 
    [SerializeField]int health = 1; 
    // Start is called before the first frame update
    [SerializeField]float speed = 1;
    public void Start(){
        player = FindObjectOfType<Player>().transform; 
    }

    public void Update(){
        Vector2 direction = player.position - transform.position; 
        transform.position += (Vector3)direction.normalized * Time.deltaTime * speed;
    }

    public void TakeDamage(){
        health--; 
        if(health==0)
        {
            Destroy(gameObject);
        }
    }

    
}
