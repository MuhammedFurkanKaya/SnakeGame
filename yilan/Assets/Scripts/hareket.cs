using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hareket : MonoBehaviour
{
    public GameObject kuyruk;
    List<GameObject> kuyruklar = new List<GameObject>();

    Vector3 eskiKoordinat;
    GameObject eskiKuyruk;

    public float hiz = 20.0f;
    public GameObject oyunSonu;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "duvar")
        {
            oyunSonu.SetActive(true);
            Time.timeScale = 0.0f;
        }
      
    }

    public void tekrarOyna()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("oyun");
    }



    void Start()
    {

       
        for ( int i=0; i<5; i++)
        {
            GameObject yeniKuyruk = Instantiate(kuyruk, transform.position, Quaternion.identity);
            kuyruklar.Add(yeniKuyruk);
        }

        InvokeRepeating("hareket_et", 0.0f, 0.08f);
    }


    void hareket_et()
    {
        eskiKoordinat = transform.position;
        transform.Translate(0, 0,hiz*Time.deltaTime);
        kuyruk_takip();
    }

    public void kuyrukArttir()
    {
        GameObject yeniKuyruk = Instantiate(kuyruk, transform.position, Quaternion.identity);
        kuyruklar.Add(yeniKuyruk);
    }

    void kuyruk_takip()
    {
        kuyruklar[0].transform.position = eskiKoordinat;
        eskiKuyruk = kuyruklar[0];
        kuyruklar.RemoveAt(0);
        kuyruklar.Add(eskiKuyruk);
    }


    public void dondur(float aci)
    {
      
            transform.Rotate(0, aci, 0);
        
    }

    




}
