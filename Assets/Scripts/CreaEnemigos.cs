using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaEnemigos : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject enemigo; 
    [Range(1,10)][SerializeField] float tiempoAparece = 3; 
    void Start()
    {
        StartCoroutine(creaEnemigo()); 
    }

    IEnumerator creaEnemigo() {
        while(true){
            yield return new WaitForSeconds(3/tiempoAparece); 
            Instantiate(enemigo); 
        }
    }
}
