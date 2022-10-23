using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/// ScoreManager.cs 
/// Lucas Gurney
/// 101313633 
/// October 23 2022 1:20 PM
/// Used for keeping track of both the score and the players health

[System.Serializable]
public class ScoreManager : MonoBehaviour
{
    private TMP_Text healthLable;
    private int health;

    private TMP_Text scoreLabel;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreLabel = GameObject.Find("ScoreLabel").GetComponent<TMP_Text>();
        healthLable = GameObject.Find("Health").GetComponent<TMP_Text>();
        SetHealth(3);
        SetScore(0);
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int newScore)
    {
        score = newScore;
        UpdateScoreLabel();
    }
    public void SetHealth(int newHealth)
    {
        health = newHealth;
        UpdateHealthLabel();
    }

    public void AddPoints(int points)
    {
        score += points;
        UpdateScoreLabel();
    }

    public void UpdateScoreLabel()
    {
        scoreLabel.text = $"Score: {score}";
    }

    public void RemoveHealth(int points)
    {
        health -= points;
        UpdateHealthLabel();
    }

    public void UpdateHealthLabel()
    {
        healthLable.text = $"Health: {health}";
        if (health == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
