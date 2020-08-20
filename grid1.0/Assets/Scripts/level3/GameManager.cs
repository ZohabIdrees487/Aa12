using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager1 : MonoBehaviour
{
    public static GameManager1 instance;
    public string getword, getword2;
    public Text[] text;
    public Image[] image;
    public bool check1, check2,check3;
    public GameObject pop_up_game_finish;
    public GameObject[] btn;    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void prin(int i)
    {
        PlayerPrefs.SetInt("button" + i, i);
        //Debug.Log(this.transform.GetSiblingIndex());
        getword += btn[i].gameObject.GetComponentInChildren<Text>().text;
        if (PlayerPrefs.HasKey("button" + (i - 1)))
        {
            image[i-1].gameObject.SetActive(true);
        }
    }
    public void prin2(int i)
    {
        PlayerPrefs.SetInt("button" + i, i);
        //Debug.Log(this.transform.GetSiblingIndex());
        getword2 += btn[i].gameObject.GetComponentInChildren<Text>().text;
        if (PlayerPrefs.HasKey("button" + (i - 3)) && i== 8)
        {
            image[2].gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (check1 && check2)
        {
            Invoke("pause_pop", 2f);
        }
        else if(check3)
        {
            Invoke("pause_pop", 2f);
        }
    }
    public void click(string str)
    {
        for(int i = 0; i <3; i++)
        {
            if (text[i].text == str)
            {
                text[i].gameObject.GetComponentInParent<Image>().color = Color.red;
            }
        }
        
    }

    public void pause_pop()
    {
        
        pop_up_game_finish.gameObject.SetActive(true);
        
    }
    
}
