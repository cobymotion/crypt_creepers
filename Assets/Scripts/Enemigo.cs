using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] int salud = 1; 
    [SerializeField] float velocidad = 1;
    Transform player;  

    public void disminuirSalud() {
        salud--;
    }
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>().transform; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = player.position - transform.position; 
        transform.position += (Vector3) movimiento.normalized * Time.deltaTime * velocidad;
    }
}
