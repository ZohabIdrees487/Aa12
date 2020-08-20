using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level4 : MonoBehaviour
{
    public static Level4 level4;
    public string input;
    public GameObject[] states;
    public int currentstate;
    // Start is called before the first frame update
    void Start()
    {
        level4 = this;
        currentstate = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void getinput(string str)
    {
        for(int i = 0; i < 2; i++)
        {
            if (states[currentstate].transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text == str)
            {
                
                states[currentstate].transform.GetChild(i).gameObject.GetComponent<Image>().color = Color.red;
                if (i == 0 && currentstate>0)
                {
                    currentstate--;
                }
                else if(currentstate == 3 && i == 1)
                {
                    currentstate = 0;
                }
                else if (currentstate == 0 && i == 1)
                {
                    currentstate = 3;
                }
                else
                {
                    currentstate++;
                }
                input += str;
                break;
            }
        }
        
    }
}
