using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elma : MonoBehaviour
{
    public TMPro.TextMeshProUGUI skorTextt;
    public int skor = 0;
    hareket kuyrukOlustur;
    zehir puanAzalt;
    private void Start()
    {
        kuyrukOlustur = GameObject.Find("Sphere").GetComponent<hareket>();
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            skor += 10;
            
            skorTextt.text = "SKOR " + skor;

            koordinatDegistir();
            kuyrukOlustur.kuyrukArttir();

        }

        if (other.gameObject.tag == "kuyruk")
        {
            koordinatDegistir();
        }
    }


    void koordinatDegistir()
    {
        float x = Random.Range(-13.0f, 15.0f);
        float z = Random.Range(-8.0f, 10.0f);

        transform.position = new Vector3(x, 0.5f, z);
    }
}
