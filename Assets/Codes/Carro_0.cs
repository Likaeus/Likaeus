using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro_0 : MonoBehaviour
{
    public float speed;
    public bool avant;
    public GameObject Carro;

    void Start()
    {
        transform.position = new Vector2(-4.42f, -0.62f);
        transform.Rotate(0f, 0f, -90f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("SEMCON").GetComponent<SEMCON>().Semaforo_unotres_verde || avant)
        {
            transform.Translate(new Vector2(0f, speed * Time.deltaTime));
        }

        else if (!GameObject.Find("SEMCON").GetComponent<SEMCON>().Semaforo_unotres_verde || !avant)
        {
            gameObject.transform.position = gameObject.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D der)
    {
        if (der.tag == "colision_der")
        {
            Destroy(this.gameObject);
        }

        else if (der.tag == "FREEZE")
        {
            avant = true;
            
        }


    }
   

}
