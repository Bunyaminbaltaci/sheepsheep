using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float arkap_hiz;
    public GameObject bitisbolgesi, baslangicbolgesi;
    private Vector2 konum;
  
    public Vector2 targetPosition;



    void Update()
    {

        transform.position = new Vector2(transform.position.x - (arkap_hiz * Time.deltaTime), transform.position.y);
       
      
        //yerdeðiþtire 
        if (transform.position.x <= bitisbolgesi.transform.position.x)
        {
           
            transform.position = new Vector2(baslangicbolgesi.transform.position.x,transform.position.y);
        }
        //*


            
    }


}
