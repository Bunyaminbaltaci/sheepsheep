using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_engeller : MonoBehaviour
{
    public float arkap_hiz;
  
    public GameObject koyun;
    public Rigidbody2D rb;


    private void awake()
    {
        rb.GetComponent<Rigidbody2D>();

    }

    // Start is called before the first frame update


    // Update is called once per frame  


    void Update()
    {

        rb.velocity = new Vector2(-1f, 0f)* arkap_hiz;

        if (transform.position.x <= koyun.transform.position.x )
        {
            Destroy(gameObject,2);


        }
           
    }
   
}
