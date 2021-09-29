using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float arkap_hiz;
    public GameObject bitisbolgesi, baslangicbolgesi;
    private Vector3 konum;
 


  
    void Update()
    {

        transform.position = new Vector3((transform.position.x - (arkap_hiz * Time.deltaTime)), transform.position.y, 0);
        //yerdeðiþtire 
        if (transform.position.x <= bitisbolgesi.transform.position.x)
        {
           
            transform.position = new Vector3(baslangicbolgesi.transform.position.x,transform.position.y,0);
        }
        //*


            
    }


}
