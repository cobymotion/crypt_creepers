using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 
    public int tiempo = 30; 
    // Start is called before the first frame update
    
    private void Awake()
    {
      if(Instance==null){
        Instance = this; 
      }   
    }

    IEnumerator cuentaTiempo(){
        while(tiempo>0){
            yield return new WaitForSeconds(1); 
            tiempo --; 
        }
        /// Aqui hay otro game over 
        print("Se termino el juego");
    }
    
    void Start()
    {
        StartCoroutine(cuentaTiempo());
    }

}
