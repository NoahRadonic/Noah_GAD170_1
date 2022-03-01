using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPsystem : MonoBehaviour
{
    public int level = 0; 
    //laps
    public float curEXP = 0f; 
    //curLapProgress
    public float reqEXP = 1000f; 
    //reqLapProgress


    //Stats
    public float health = 100;
    public float defense = 1;
    public float speed = 5;
    public float attack = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This is called by button presses, should grant diff amount of exp
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GainXP(speed);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            GainXP(attack);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            GainXP(defense);
        }

    }

    public void InitialStats(float earnedEXP)
    {
       //stats, levels and xp !
    }

    public void GainXP(float gain)
    {
        //gain exp, probably something to do with our curEXP
        curEXP += gain;
        Debug.Log("EXP Gained : " + gain);
        Debug.Log("Current EXP Gained : " + curEXP);

        Levelup();
    }

    public void Levelup()
    {
        //increase our level
        if (curEXP >= reqEXP)
        {
            IncreaseStats();
            Debug.Log("U FOOKIN LEVELED THE UP"); 
        }
    }

    public void IncreaseStats()
    {
        //increase our various stats
        //Need increase level, reset xp, and increase reqxp peepee
        level += 1;
        curEXP = 0;
        reqEXP *= 10;

        health += 5f * (0.5f * (level ^ 2));
        defense += 1f * (0.5f * (level ^ 2));
        speed += 5f * (0.5f * (level ^ 2));
        attack += 5f * (0.5f * (level ^ 2));
        Debug.Log("You are now Level :" + level + "!!!");
    }
}
