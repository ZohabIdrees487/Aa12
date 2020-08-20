using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject textdisplay;
    public int secondsLeft = 30;
    public bool takingAway = false;

    void Start()
    {
        textdisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    void Update()
    {
        if(takingAway==false && secondsLeft>0)
        {
            StartCoroutine(TimeTake());
        }
    }
    IEnumerator TimeTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft += -1;
        textdisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        takingAway = false;
    }
}
