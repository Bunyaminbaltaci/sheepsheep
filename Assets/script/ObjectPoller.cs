using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoller : MonoBehaviour
{

    [System.Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledobject;
      
        public GameObject ObjectPrefab;
        public int poolsize;
    }

    [SerializeField] private Pool[] pools=null; 



    private void Awake()
    {
        for (int j = 0; j < pools.Length; j++)
        {
            pools[j].pooledobject = new Queue<GameObject>();
            for (int i = 0; i < pools[j].poolsize; i++)
            {
                GameObject obj = Instantiate(pools[j].ObjectPrefab);
                obj.SetActive(false);
                pools[j].pooledobject.Enqueue(obj);
            }
        }

    }
   
    public GameObject GetPooledObject(int objecttype)
    {
        if (objecttype>=pools.Length)
        {
            return null;
        } 
        GameObject obj = pools[objecttype].pooledobject.Dequeue();
        obj.SetActive(true);
        pools[objecttype].pooledobject.Enqueue(obj);
        return obj;
    }
   
}
