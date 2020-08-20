using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMoveUp : MonoBehaviour
{
    public GameObject thisText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        thisText.transform.Translate(Vector2.up * Time.deltaTime, Space.World);
    }
}
