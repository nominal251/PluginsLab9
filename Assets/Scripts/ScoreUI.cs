using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TextMeshPro scoreText;

    void OnEnable()
    {
        scoreManager.ScoreChanged += UpdateText;
        UpdateText(scoreManager.Score);
    }

    void OnDisable() => scoreManager.ScoreChanged -= UpdateText;

    void UpdateText(int score) => scoreText.text = $"Score: {score}";
}