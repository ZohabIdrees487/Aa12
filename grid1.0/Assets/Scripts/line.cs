using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
//using Unity.UNetWeaver;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Experimental.XR.Interaction;
using UnityEngine.UI;
public class line : MonoBehaviour
{
    public string Result = "RED";
    public string Result2 = "UD";
    public string Result3 = "YES";
    public bool r1, r2,r3;
    public bool r;
    public bool ud;
    public GameObject ScoreRedPrefab;
    public GameObject ScoreUdPrefab;
    public GameObject dfa;
    public GameObject HappyEmoji;
    public GameObject GameWonPopUp;
    public GameObject Timer;


    // Start is called before the first frame update
    void Start()
    {
        r = false;
        ud = false;
        ScoreScript.scoreValue = 0;
        
        
    //Debug.Log(this.transform.GetSiblingIndex());
}
    
    public void prin2()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if (ScoreScript.scoreValue == 50)
        {
            dfa.SetActive(false);
            GameWonPopUp.SetActive(true);
            HappyEmoji.SetActive(true);
            Timer.GetComponent<TimerScript>().enabled = false;
            Timer.SetActive(false);

        }

        else if (GamePlayScript.gps.getword == Result && r1)
            {
                
                Invoke("des1", 1.5f);
                GamePlayScript.gps.check1 = true;
                if(!r)
                {
                Invoke("score", 1.5f);
                ScoreRedPrefab.SetActive(true);
                r = true;
                }

            }
       

       else if (GamePlayScript.gps.getword2 == Result2 && r2)
        {
            Invoke("des2", 1.5f);
            GamePlayScript.gps.check2 = true;
            if (!ud)
            {
                Invoke("score", 1.5f);
                ScoreUdPrefab.SetActive(true);
                ud = true;
            }
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
    
    GamePlayScript.gps.image[2].gameObject.SetActive(false);
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
        GamePlayScript.gps.image[0].gameObject.SetActive(false);
        GamePlayScript.gps.image[1].gameObject.SetActive(false);
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

   public void score()
    {
        ScoreScript.scoreValue += 10;
    }

}
