using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_engeller : MonoBehaviour
{
    public float arkap_hiz;
  
    public GameObject koyun;




    private void awake()
    {
      

    }

    // Start is called before the first frame update


    // Update is called once per frame  


    void Update()
    {

        transform.position = new Vector3((transform.position.x-arkap_hiz * Time.deltaTime), -2.15f, 0);

        if (transform.position.x <= koyun.transform.position.x )
        {
            Destroy(gameObject,2);


        }
           
    }
   
}
