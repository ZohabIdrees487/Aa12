using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class line1 : MonoBehaviour
{
    public string Result = "RED";
    public string Result2 = "UD";
    public string Result3 = "YES";
    public bool r1, r2,r3;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(this.transform.GetSiblingIndex());
    }
    
    public void prin2()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.getword == Result && r1)
        {
            Invoke("des1", 1.5f);
            GameManager.instance.check1 = true;
        }
        else if (GameManager.instance.getword2 == Result2 && r2)
        {
            Invoke("des2", 1.5f);
            GameManager.instance.check2 = true;
            
        }
        else if (GameManager.instance.getword == Result3 && r3)
        {
            Invoke("des3", 1.5f);
            GameManager.instance.check3 = true;

        }
    }
    public void des1()
    {
        GameManager.instance.image[0].gameObject.SetActive(false);
        GameManager.instance.image[1].gameObject.SetActive(false);
        if (this.gameObject.GetComponentInChildren<Text>().text == "R")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "E")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "D")
        {
            Destroy(this.gameObject);
        }
    }
    public void des2()
    {
        GameManager.instance.image[2].gameObject.SetActive(false);
        if (this.gameObject.GetComponentInChildren<Text>().text == "U")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "D")
        {
            Destroy(this.gameObject);
        }
    }
    public void des3()
    {
        GameManager.instance.image[0].gameObject.SetActive(false);
        GameManager.instance.image[1].gameObject.SetActive(false);
        if (this.gameObject.GetComponentInChildren<Text>().text == "Y")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "E")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "S")
        {
            Destroy(this.gameObject);
        }
    }

}
