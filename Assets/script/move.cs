using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float arkap_hiz;
    public GameObject bitisbolgesi, baslangicbolgesi;
    private Vector3 konum;
    public Rigidbody2D rb;


    private void awake()
    {
        rb.GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        rb.velocity = new Vector2(-1.0f,0f)*arkap_hiz;
        //hareket hýz kodu
       // transform.position += Vector3.left * arkap_hiz * Time.deltaTime;

        //*

    }
    void FixedUpdate()
    {
      
       

        //yerdeðiþtire 
        if (transform.position.x <= bitisbolgesi.transform.position.x)
        {
           
            transform.position = new Vector3(baslangicbolgesi.transform.position.x,transform.position.y,0);
        }
        //*


            
    }


}
