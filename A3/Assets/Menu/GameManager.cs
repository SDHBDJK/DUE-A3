using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int targetScore = 10;

    public TextMeshProUGUI scoreText;
    public GameObject successPanel;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateScoreUI();
        successPanel.SetActive(false);
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();

        if (score >= targetScore)
        {
            successPanel.SetActive(true);
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
