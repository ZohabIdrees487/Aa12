using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public  Image timebar;
    public  GameObject sadEmoji;
    public float maxtime = 60f;
    float timeleft;
    public GameObject GameOverPopUp;
    public GameObject dfa;
    
    // Start is called before the first frame update
    void Start()
    {
        timebar = GetComponent<Image>();
        timeleft = maxtime;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timebar.fillAmount = timeleft / maxtime;
        }
        else
        {
            GameOverPopUp.SetActive(true);
            sadEmoji.SetActive(true);
            dfa.SetActive(false);
            
            Time.timeScale = 0;
        }
    }
}
