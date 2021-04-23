﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCalculator : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            gameManager.goal++;
            gameManager.goalText.text = gameManager.goal.ToString();

            if (gameManager.Target==gameManager.goal)
            {
                gameManager.GameComplete();
            }
            Destroy(gameObject, 0.25f);
        }
    }
}
