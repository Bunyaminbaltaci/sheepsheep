using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    [SerializeField] private ObjectPoller objectpool;

    public koyun_control koyunkont;
    public GameObject engeller;         

    void Start()
    {
        StartCoroutine(nameof(Spawobject));
    }

    
    public IEnumerator Spawobject()
    {
        while (!koyunkont.isdead)
        {
            var obj=objectpool.GetPooledObject(0);
            obj.transform.position = new Vector2(15.5f,0);
            yield return new WaitForSeconds(Random.Range(2, 5));

        }
    }
}
