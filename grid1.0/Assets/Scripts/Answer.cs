using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer: MonoBehaviour
{
    public string value, value1;
    public InputField inputField, inputField1, inputField2, inputField3;
    public GameObject display_text;
    private bool correct,incorrect, correct1, incorrect1;
    public GameObject GameWinpopUp, GameLosepopUp;

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

        //validate();
    }

  
    public void validate()
    {   if (correct == true && correct1 == true)//(correct && correct1  && correct2 && correct3)
        {
            //Debug.Log("asdas");
            GameWinpopUp.SetActive(true);

        }
        //value = inputField.text;
        //display_text = inputField.GetComponent<Text>().text = "this " + value + " this is input";
        else
        {
            GameLosepopUp.SetActive(true);
        }

    }
    


}
