using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float time;
    public float i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(i.ToString("#") == time.ToString("#"))
        {
            this.transform.position += new Vector3(0f, -0.5f, 0f);

            i +=1f ;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(-0.5f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(0.5f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(0f, 0f, 90f));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(0f, 0f, -90f));
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.64f, 2.64f), Mathf.Clamp(transform.position.y, -7f, 3.27f));
    }
    
}
