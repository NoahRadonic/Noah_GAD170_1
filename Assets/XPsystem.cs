using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPsystem : MonoBehaviour
{
    public int level; //laps
    public float curEXP; //curLapProgress
    public float reqEXP; //reqLapProgress
    //Stats
    public float health;
    public float defense;
    public float speed;
    public float attack;

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
    }

    public void GainXP(float gain)
    {
        //gain exp, probably something to do with our curEXP
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
