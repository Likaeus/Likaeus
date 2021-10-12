using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generate : MonoBehaviour
{

    public GameObject Carro; 
    public GameObject Carro2;
    public GameObject Carro3;
    public GameObject Carro4;

    void Start()
    {
        InvokeRepeating("spawn", 2f, 0f);
    }

    public void spawn()
    {
        if (GameObject.Find("SEMCON").GetComponent<SEMCON>().Semaforo_unotres_verde)
        {

            Instantiate(Carro, transform.position, Quaternion.identity);
            Instantiate(Carro2, transform.position, Quaternion.identity);
            


        }
        if (GameObject.Find("SEMCON").GetComponent<SEMCON>().Semaforo_doscuatro_verde)
        {
            Instantiate(Carro3, transform.position, Quaternion.identity);
            Instantiate(Carro4, transform.position, Quaternion.identity);
        }


    }
}
