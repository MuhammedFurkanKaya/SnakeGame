using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zehir : MonoBehaviour
{
    public TMPro.TextMeshProUGUI azaltpuani;
    elma elmaSkor;
    hareket hizlandir;
    // Start is called before the first frame update
    void Start()
    {
        elmaSkor = GameObject.Find("elma").GetComponent<elma>();
       hizlandir = GameObject.Find("Sphere").GetComponent<hareket>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Sphere")
        {
            hizlandir.hiz += 5f;
            elmaSkor.skor -= 10;
            elmaSkor.skorTextt.text = "SKOR " + elmaSkor.skor; 
           
            
        }
    }



    
   
}
