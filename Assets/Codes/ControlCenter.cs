//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.Threading;
//using System.Threading.Tasks;
//using System;

//public class ControlCenter : MonoBehaviour
//{
//    public List<GameObject> Sem1;
//    public List<GameObject> Sem2;
//    public List<GameObject> Sem3;
//    public List<GameObject> Sem4;
//    public bool Uno_3;
//    public bool Dos_4;



//    void Start()
//    {
//        allOff();
//        StartCoroutine(trafficLightIEnumerator());
       
//    }


//    private void Update()
//    {
       
//    }

//    async void trafficLightAsync()
//    {
//        while (true)
//        {

//            SemaforoVerde_1_3();

//            await Task.Delay(TimeSpan.FromSeconds(1f));
//            Semaforo1Amarillo_1_3();

//            await Task.Delay(TimeSpan.FromSeconds(1f));
//            SemaforoVerde_2_4();

//            await Task.Delay(TimeSpan.FromSeconds(1f));
//            SemaforoAmarillo_2_4();

//            await Task.Delay(TimeSpan.FromSeconds(1f));

//        }
//    }



//    IEnumerator trafficLightIEnumerator()
//    {
//        while (true)
//        {

//            SemaforoVerde_1_3();

//            yield return new WaitForSeconds(1f);
//            Semaforo1Amarillo_1_3();

//            yield return new WaitForSeconds(1f);
//            SemaforoVerde_2_4();

//            yield return new WaitForSeconds(1f);
//            SemaforoAmarillo_2_4();

//            yield return new WaitForSeconds(1f);

//        }
//    }




//    void SemaforoVerde_1_3()
//    {
//        Sem1[0].SetActive(true);
//        Sem1[1].SetActive(false);
//        Sem1[2].SetActive(false);

//        Sem2[0].SetActive(false);
//        Sem2[1].SetActive(false);
//        Sem2[2].SetActive(true);

//        Sem3[0].SetActive(true);
//        Sem3[1].SetActive(false);
//        Sem3[2].SetActive(false);

//        Sem4[0].SetActive(false);
//        Sem4[1].SetActive(false);
//        Sem4[2].SetActive(true);

//        Uno_3 = true;
//        Dos_4 = false;
//    }

//    void Semaforo1Amarillo_1_3()
//    {
//        Sem1[0].SetActive(false);
//        Sem1[1].SetActive(true);
//        Sem1[2].SetActive(false);

//        Sem2[0].SetActive(false);
//        Sem2[1].SetActive(false);
//        Sem2[2].SetActive(true);

//        Sem3[0].SetActive(false);
//        Sem3[1].SetActive(true);
//        Sem3[2].SetActive(false);

//        Sem4[0].SetActive(false);
//        Sem4[1].SetActive(false);
//        Sem4[2].SetActive(true);

//        Uno_3 = true;
//        Dos_4 = false;
//    }



//    void SemaforoVerde_2_4()
//    {
//        Sem1[0].SetActive(false);
//        Sem1[1].SetActive(false);
//        Sem1[2].SetActive(true);

//        Sem2[0].SetActive(true);
//        Sem2[1].SetActive(false);
//        Sem2[2].SetActive(false);

//        Sem3[0].SetActive(false);
//        Sem3[1].SetActive(false);
//        Sem3[2].SetActive(true);

//        Sem4[0].SetActive(true);
//        Sem4[1].SetActive(false);
//        Sem4[2].SetActive(false);

//        Uno_3 = false;
//        Dos_4 = true;
//    }

//    void SemaforoAmarillo_2_4()
//    {
//        Sem1[0].SetActive(false);
//        Sem1[1].SetActive(false);
//        Sem1[2].SetActive(true);

//        Sem2[0].SetActive(false);
//        Sem2[1].SetActive(true);
//        Sem2[2].SetActive(false);

//        Sem3[0].SetActive(false);
//        Sem3[1].SetActive(false);
//        Sem3[2].SetActive(true);

//        Sem4[0].SetActive(false);
//        Sem4[1].SetActive(true);
//        Sem4[2].SetActive(false);

//        Uno_3 = false;
//        Dos_4 = true;
//    }


//    void allOff()
//    {
//        //Sem1
//        Sem1[0].SetActive(false);
//        Sem1[1].SetActive(false);
//        Sem1[2].SetActive(false);

//        //Sem2
//        Sem2[0].SetActive(false);
//        Sem2[1].SetActive(false);
//        Sem2[2].SetActive(false);

//        //Sem3
//        Sem3[0].SetActive(false);
//        Sem3[1].SetActive(false);
//        Sem3[2].SetActive(false);

//        //Sem4
//        Sem4[0].SetActive(false);
//        Sem4[1].SetActive(false);
//        Sem4[2].SetActive(false);
//    }
//}
