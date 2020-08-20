using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class map : MonoBehaviour
{
    public GameObject hexagon;
    // Start is called before the first frame update

    int width = 2;
    int height = 2;
    void Start()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                 var i = Instantiate(hexagon, new Vector3(x+2, y, 0), Quaternion.identity);
                 i.transform.parent = this.transform;
                 //i.transform.position += new Vector3(x, y, 0);
                i.gameObject.GetComponentInChildren<Text>().text = i.transform.GetSiblingIndex().ToString();
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
