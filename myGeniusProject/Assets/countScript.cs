using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countScript : MonoBehaviour
{
    public Text CountTxt;
    public colScript CntScript;
    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        CountTxt.text = "Score: " + CntScript.score;
    }
}
