using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Target = 3;
    public int goal = 0;
    public Text targetText, goalText;
    public GameObject GoalPanel;
    // Start is called before the first frame update
    void Start()
    {
        
        if (SceneManager.GetActiveScene().name == "GamePlay")
        {
            GoalPanel.SetActive(false);
            targetText.text = Target.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Home()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GameComplete()
    {
        GoalPanel.SetActive(true);
    }
}
