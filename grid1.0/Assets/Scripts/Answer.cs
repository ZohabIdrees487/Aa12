using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer: MonoBehaviour
{
    public string value, value1;
    public InputField inputField, inputField1;
    public GameObject display_text;
    public bool correct,incorrect, correct1, incorrect1;
    public GameObject popUpPannel, popUpPannel2;

    public void check()
    {
        if(inputField.text=="A")
        {
            correct = true;
        }
        else
        {
            incorrect = true;
        }
        value = inputField.text;
        //display_text = inputField.GetComponent<Text>().text = "this " + value + " this is input";

        if (inputField1.text == "A")
        {
            correct1 = true;
        }
        else
        {
            incorrect1 = true;
        }
        value1 = inputField1.text;

        validate();
    }

  
    public void validate()
    {   if (correct == true && correct1 == true)
        {
            //Debug.Log("asdas");
            popUpPannel.SetActive(true);

        }
        //value = inputField.text;
        //display_text = inputField.GetComponent<Text>().text = "this " + value + " this is input";
        else
        {
            popUpPannel2.SetActive(true);
        }

    }
    


}
