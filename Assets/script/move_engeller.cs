using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_engeller : MonoBehaviour
{
    public float arkap_hiz;
    
    public GameObject koyun;
    void Update()
    {
       
        transform.position =new Vector2(transform.position.x-(arkap_hiz*Time.deltaTime),-2.65f);
      


        if (transform.position.x <= koyun.transform.position.x )
        {
            Destroy(gameObject,2);


        }
           
    }
   
}
