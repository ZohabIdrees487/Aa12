using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEditorInternal;
using UnityEngine.Analytics;

public class GamePlayScript : MonoBehaviour
{
    public GameObject sadEmoji;
    public GameObject Timer;
    public GameObject dfa;
    public static GamePlayScript gps;
    public string getword, getword2;
    public Text[] text, text2;
    public Text wrong;
    public Image[] image;
    public bool check1, check2, check3;
    public int counter;
    public string wrongans;
    public GameObject pop_up_game_finish;
    public GameObject[] btn;    // Start is called before the first frame update
    public GameObject gameoverpopup;

    public int Score = 0;
   

    void Start()
    {
        counter = 0;
        gps = this;

       //static referce of gamePlayScript
    }
    public void prin(int i)
    {
        if (i == 0)
        {
            Reset();
        }
        PlayerPrefs.SetInt("button" + i, i);

        //Debug.Log(this.transform.GetSiblingIndex());
        //getword += btn[i].gameObject.GetComponentInChildren<Text>().text;
        if (i > 0)
        {
            if (PlayerPrefs.HasKey("button" + (i - 1)))
            {
                getword += btn[i].gameObject.GetComponentInChildren<Text>().text;
                image[i - 1].gameObject.SetActive(true);
             
            }

            else
            {
                Reset();
                gameover(i);
            }
        }
        else
        {
            getword = btn[i].gameObject.GetComponentInChildren<Text>().text;
        }
    }
    public void prin2(int i)
    {
        if (i == 5)
        {
            Reset();
        }
        PlayerPrefs.SetInt("button" + i, i);
        //Debug.Log(this.transform.GetSiblingIndex());
        //getword2 += btn[i].gameObject.GetComponentInChildren<Text>().text;

        if (PlayerPrefs.HasKey("button" + (i - 3)) && i == 8)
        {
            getword2 += btn[i].gameObject.GetComponentInChildren<Text>().text;
            image[2].gameObject.SetActive(true);

        }
        else if (i == 5)
        {
            getword2 = btn[i].gameObject.GetComponentInChildren<Text>().text;
        }
        else
        {
            Reset();
            gameover(i);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (check1 && check2)
        {
            Invoke("pause_pop", 2f);
        }
        else if (check3)
        {
            Invoke("pause_pop", 2f);
        }
    }
    public void gameover(int i)
    {
        counter++;
        wrongans += btn[i].gameObject.GetComponentInChildren<Text>().text;
        if (counter == 3)
        {
            counter = 0;
            gameoverpopup.SetActive(true);
            dfa.SetActive(false);
            sadEmoji.SetActive(true);
            Timer.GetComponent<TimerScript>().enabled = false;
            Timer.SetActive(false);
            wrong.text = wrongans;
            wrongans = "";
        }
    }

    public void RetunMainMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(5);
    }
    public void Reset()
    {

        //counter = 0;
        getword = "";
        getword2 = "";
        for (int i = 0; i < 3; i++)
        {
            if (image[i] != null && image[i].gameObject.activeSelf == true)
                image[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < 4; i++)
        {
            text[i].gameObject.GetComponentInParent<Image>().color = Color.yellow;
        }
        PlayerPrefs.DeleteAll();
    }
    public void click(string str)
    {


        for (int i = 0; i < text.Length; i++)
        {

            if (str == "1")
            {
                if (text[i].text == str)
                {
                    text[i].gameObject.GetComponentInParent<Image>().color = Color.red;
                    if (i > 0)
                    {
                        if (!PlayerPrefs.HasKey("button" + (i - 1)))
                        {
                            StartCoroutine(colordelay(i));
                        }
                    }
                    break;
                }
            }
            else if (str == "0")
            {
                if (text2[i].text == str)
                {
                    text2[i].gameObject.GetComponentInParent<Image>().color = Color.red;
                    if (i > 0)
                    {
                        if (!PlayerPrefs.HasKey("button" + (i - 1)))
                        {
                            StartCoroutine(colordelay(i));
                        }
                    }
                    break;
                }
            }
        }
        for (int i = 0; i < text.Length; i++)
        {
            if (str == "1")
            {
                if (text[i].text == str)
                {
                    text[i].gameObject.GetComponentInParent<Image>().color = Color.red;
                    if (i > 0)
                    {
                        if (!PlayerPrefs.HasKey("button" + (i - 1)))
                        {
                            StartCoroutine(colordelay(i));
                        }
                    }
                    break;
                }
            }
            else if (str == "0")
            {
                if (text2[i].text == str)
                {
                    text2[i].gameObject.GetComponentInParent<Image>().color = Color.red;
                    if (i > 0)
                    {
                        if (!PlayerPrefs.HasKey("button" + (i - 1)))
                        {
                            StartCoroutine(colordelay(i));
                        }
                    }
                    break;
                }
            }

        }

    }

    public void retry()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void colordelaytime(int i)
    {
        text[i].gameObject.GetComponentInParent<Image>().color = Color.red;
        StartCoroutine(colordelay(i));
        Invoke("Reset", 2f);
    }
    IEnumerator colordelay(int i)
    {
        Debug.Log(i);
        yield return new WaitForSeconds(2f);
        text[i].gameObject.GetComponentInParent<Image>().color = Color.yellow;
    }
    public void pause_pop()
    {

        pop_up_game_finish.gameObject.SetActive(true);

    }
}

