using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    private int totalScore;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int scoreToAdd)
    {
        totalScore += scoreToAdd;
        
    }

    public int GetTotalScore()
    {
        return totalScore;
    }
}
