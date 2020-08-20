using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay4 : MonoBehaviour
{
    public string Result = "0101";
    public string Result2 = "11";
    public string Result3 = "00";
    public bool r1, r2, r3;
    public GameObject gameWinPopup;

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
        if (GamePlayScript.gps.getword == Result && r1)
        {
            Invoke("des1", 1.5f);
            GamePlayScript.gps.check1 = true;
        }
        else if (GamePlayScript.gps.getword2 == Result2 && r2)
        {
            Invoke("des2", 1.5f);
            GamePlayScript.gps.check2 = true;

        }
        else if (GamePlayScript.gps.getword == Result3 && r3)
        {
            Invoke("des3", 1.5f);
            GamePlayScript.gps.check3 = true;

        }
    }
    public void des1()
    {
        GamePlayScript.gps.image[0].gameObject.SetActive(false);
        GamePlayScript.gps.image[1].gameObject.SetActive(false);
        GamePlayScript.gps.image[5].gameObject.SetActive(false);
        GamePlayScript.gps.image[8].gameObject.SetActive(false);
        GamePlayScript.gps.image[7].gameObject.SetActive(false);
        GamePlayScript.gps.image[10].gameObject.SetActive(false);
        
        
        if (this.gameObject.GetComponentInChildren<Text>().text == "0")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "1")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "0")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "1")
        {
            Destroy(this.gameObject);
        }
    }
    public void des2()
    {
        GamePlayScript.gps.image[3].gameObject.SetActive(false);
        GamePlayScript.gps.image[9].gameObject.SetActive(false);
        if (this.gameObject.GetComponentInChildren<Text>().text == "1")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "1")
        {
            Destroy(this.gameObject);
        }
    }
    public void des3()
    {
        GamePlayScript.gps.image[11].gameObject.SetActive(false);
        if (this.gameObject.GetComponentInChildren<Text>().text == "0")
        {
            Destroy(this.gameObject);
        }
        if (this.gameObject.GetComponentInChildren<Text>().text == "0")
        {
            Destroy(this.gameObject);
        }
        
    }
    public void gamewinpopup()
    {
        if (r1& r2 & r3)
        {
            gameWinPopup.SetActive(true);
        }
    }
}
