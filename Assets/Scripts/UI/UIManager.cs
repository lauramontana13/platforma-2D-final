using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("UI")]
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }

    public void UpdateScore(int score)
    {
        PlayerStats.score += score;
        scoreText.text = "Score = "+ PlayerStats.score.ToString();
    }
}