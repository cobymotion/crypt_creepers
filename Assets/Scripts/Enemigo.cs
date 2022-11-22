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
        if(salud<=0){
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>().transform; 
        /// posicionarlo 
        GameObject[] posiciones = 
               GameObject.FindGameObjectsWithTag("PuntoEnemigo");
        int index = Random.Range(0,posiciones.Length); 
        gameObject.transform.position = posiciones[index]
                                        .transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = player.position - transform.position; 
        transform.position += (Vector3) movimiento.normalized * Time.deltaTime * velocidad;
    }

    private void OnTriggerEnter2D(Collider2D colision) {
        
        colision.GetComponent<Player>().disminuirSalud(); 

    }
}
