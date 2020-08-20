using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level6edit : MonoBehaviour
{
    //public Text input1;
    public Button inputBtn1;
    public Button inputBtn2;
    public Button inputBtn3;
    public Button inputBtn4;
    public Button inputBtn5;
    public Button inputBtn6;
    public Button inputBtn7;
    public Button inputBtn8;
    public Button inputBtn9;
    /* public Button inputBtn10;
     public Button inputBtn11;*/

    
    public GameObject inputBtn13;
    public GameObject inputBtn14;

    public GameObject inputBtn10;
    public GameObject inputBtn11;

    public Text Gettext1, Gettext2, Gettext3, Gettext4;
    bool check1, check2, check3, check4;

    public GameObject [] image;
    string Checkorder;

    public Button AS0R1;
    public Button AS1R3;
    public Button R10AS;
    public Button R11R2;
    public Button R31R1;
    public Button R20R3;
    public Button R30R2;
    public Button R31AS;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void arrowColorChangeAS0R1()
    {
        //arraow.GetComponent<Image>().color = new Color32(255, 20, 0, 255);

        ColorBlock colors = AS0R1.colors;
        colors.normalColor = Color.red;
      // colors.highlightedColor = new Color32(255, 100, 100, 255);
        AS0R1.colors = colors;
        /*Gettext1 = inputBtn1.GetComponent<Text>();
        Debug.Log(Gettext1);

        Gettext1 = inputBtn1.GetComponentInChildren<Text>().text;*/

        string getword = inputBtn13.gameObject.GetComponentInChildren<Text>().text;
        Debug.Log(getword);

        /* if (GameObject.Find("Button11").GetComponentInChildren<Text>().text=="0")
        {
            check1 = true;
        }*/

       check1 = true;
        Checkorder = "a";

    }
    public void arrowColorChangeAS1R3()
    {
        //arraow.GetComponent<Image>().color = new Color32(255, 20, 0, 255);

        ColorBlock colors = AS1R3.colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        AS1R3.colors = colors;
        Gettext1 = inputBtn14.GetComponent<Text>();
    }
    public void arrowColorChangeR10AS()
    {
        //arraow.GetComponent<Image>().color = new Color32(255, 20, 0, 255);

        ColorBlock colors = R10AS.colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        R10AS.colors = colors;


        Gettext1 = inputBtn14.GetComponent<Text>();

        check2 = true;
        
        Debug.Log(Checkorder);
    }
    
     public void arrowColorChangeR11R2()
    {
        //arraow.GetComponent<Image>().color = new Color32(255, 20, 0, 255);

        ColorBlock colors = R11R2.colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        R11R2.colors = colors;
        Gettext1 = inputBtn1.GetComponent<Text>();
    }
    public void arrowColorChangeR31R1()
    {
        //arraow.GetComponent<Image>().color = new Color32(255, 20, 0, 255);

        ColorBlock colors = R31R1.colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        R31R1.colors = colors;
        Gettext1 = inputBtn1.GetComponent<Text>();
    }
    public void arrowColorChangeR20R3()
    {
        //arraow.GetComponent<Image>().color = new Color32(255, 20, 0, 255);

        ColorBlock colors = R20R3.colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        R20R3.colors = colors;
        Gettext1 = inputBtn1.GetComponent<Text>();
        check3 = true;
    }
    public void arrowColorChangeR30R2()
    {
        //arraow.GetComponent<Image>().color = new Color32(255, 20, 0, 255);

        ColorBlock colors = R30R2.colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        R30R2.colors = colors;
        Gettext1 = inputBtn1.GetComponent<Text>();
    }
    public void arrowColorChangeR31AS()
    {
        //arraow.GetComponent<Image>().color = new Color32(255, 20, 0, 255);

        ColorBlock colors = R31AS.colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        R31AS.colors = colors;
        //Gettext1 = inputBtn1.GetComponent<Text>();
        check4 = true;
    }
   

    /*public void OnEnable11()
    {
        inputBtn1.onClick.AddListener(() => arrowColorChange11());
        Gettext1 = inputBtn1.GetComponent<Text>();

        *//*if (gameObject == inputBtn[0])
        {
            arrowColorChange();
        }
        else if (gameObject == inputBtn[1])
        {
            arrowColorChange();
        }*//*


    }*/
    public void Destroy00()
    {
        Invoke("delayArrowColor00", 2);

       

        if (check1 && check2)   //(check1==true && check2 == true)
        {
            Destroy(inputBtn13);
            Destroy(inputBtn14);
            Debug.Log("destry");

        }
    }
    public void Destroy11()
    {
        Invoke("delayArrowColor11", 2);

        if (check3 && check4)
        {
            Destroy(inputBtn10);
            Destroy(inputBtn11);
        }
    }

    public void delayArrowColor00()
    {
        ColorBlock colors = AS0R1.colors;
        colors.normalColor = Color.yellow;
        AS0R1.colors = colors;

        ColorBlock colors1 = R10AS.colors;
        colors.normalColor = Color.yellow;
        R10AS.colors = colors;
    }
    public void delayArrowColor11()
    {
        ColorBlock colors = AS0R1.colors;
        colors.normalColor = Color.yellow;
        AS0R1.colors = colors;

        ColorBlock colors1 = R10AS.colors;
        colors.normalColor = Color.yellow;
        R10AS.colors = colors;
    }
}

