using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu_SceneChnge : MonoBehaviour
{
    public string level1;
    public GameObject OptionsScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void level1DFa()
    {
        SceneManager.LoadScene(level1);
        Debug.Log("ok");
    }
    public void OpenOption()
    {
        OptionsScreen.SetActive(true);
    }
    public void CloseOptions()
    {
        OptionsScreen.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
