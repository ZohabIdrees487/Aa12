using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menue_Controller : MonoBehaviour
{
    public void MainMen2()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// This is for DFA game
    /// </summary>

    public void DFALevel1()
    {
        SceneManager.LoadScene(2);
    }

    public void DFALevel2()
    {
        SceneManager.LoadScene(3);
    }
    public void DFALevel3()
    {
        SceneManager.LoadScene(4);
    }
    public void DFALevel4()
    {
        SceneManager.LoadScene(5);
    }
    /// <summary>
    /// this is for Regx Game level
    /// </summary>
    public void RELevel1()
    {
        SceneManager.LoadScene(4);
    }
    public void RELevel2()
    {
        SceneManager.LoadScene(5);
    }
    public void RELevel3()
    {
        SceneManager.LoadScene(3);
    }




    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
