using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public GameObject[] tetrisObjects;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", 6f, 9f);
    }

    public void SpawnRandom()
    {
        int index = Random.Range(0, tetrisObjects.Length);
        var v = Instantiate(tetrisObjects[index], transform.position, Quaternion.identity) as GameObject;
        //v.transform.parent = this.transform;
        //.transform.position = new Vector3(v.transform.position.x,v.)
    }

}
