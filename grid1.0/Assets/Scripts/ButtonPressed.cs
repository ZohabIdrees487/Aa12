using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonPressed : MonoBehaviour
{
    public void buttonpress()
    {
        PlayerPrefs.SetInt("Button"+this.transform.GetSiblingIndex(), 1);
        if(Level4.level4.input.Length %2 == 0 && Level4.level4.currentstate == 0)
        {
            Level4.level4.input = "";
            Level4.level4.currentstate = 0;
        }
        if(this.transform.GetSiblingIndex()%6 == 0)
        {
            if (!PlayerPrefs.HasKey("Button" + (this.transform.GetSiblingIndex() - 6)))
            {
                for (int i = 0; i < this.transform.GetSiblingIndex(); i++)
                {
                    PlayerPrefs.DeleteKey("Button" + i);
                }
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Level4.level4.states[j].transform.GetChild(i).gameObject.GetComponent<Image>().color = Color.yellow;
                    }
                }
                Level4.level4.input = "";
                Level4.level4.currentstate = 0;
            }
        }
        else if(!PlayerPrefs.HasKey("Button"+ (this.transform.GetSiblingIndex() - 1)) && !PlayerPrefs.HasKey("Button" + (this.transform.GetSiblingIndex() - 6)))
        {
            for(int i =0; i< this.transform.GetSiblingIndex(); i++)
            {
                PlayerPrefs.DeleteKey("Button" + i);
            }
            for(int j=0;j< 4;j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    Level4.level4.states[j].transform.GetChild(i).gameObject.GetComponent<Image>().color = Color.yellow;
                }
            }
            Level4.level4.input = "";
            Level4.level4.currentstate = 0;            
        }
        Level4.level4.getinput(this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
