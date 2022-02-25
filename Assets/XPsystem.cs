using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPsystem : MonoBehaviour
{
    public int level = 0; 
    //laps
    public float curEXP = 0f; 
    //curLapProgress
    public float reqEXP = 100f; 
    //reqLapProgress


    //Stats
    public float health = 100;
    public float defense = 10;
    public float speed = 5;
    public float attack = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitialStats(float earnedEXP)
    {
        //This is called by button presses, should grant diff amount of exp
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GainXP(speed);
        }
    }

    public void GainXP(float gain)
    {
        //gain exp, probably something to do with our curEXP
        curEXP += gain;
        Debug.Log("EXP Gained : " + gain);
        Debug.Log("Current EXP Gained : " + curEXP);
    }

    public void Levelup()
    {
        //increase our level
        
        
    }

    public void IncreaseStats()
    {
        //increase our various stats
    }
}
