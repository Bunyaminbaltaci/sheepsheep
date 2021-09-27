using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    
    public koyun_control koyunkont;
    public GameObject engeller;         

    void Start()
    {
        StartCoroutine(Spawobject());
    }

    
    public IEnumerator Spawobject()
    {
        while (!koyunkont.isdead)
        {
            Instantiate(engeller, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(2, 5));

        }
    
        
       


    }
}
