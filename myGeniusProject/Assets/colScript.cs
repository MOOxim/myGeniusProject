using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colScript : MonoBehaviour
{
    public int score = 100;
    public void OnCollisionEnter()
    {
        Debug.Log("it works 0_0");
        score -= 1;
    }

    void Start()
    {
    }
    
    void Update()
    {
        
    }
}
