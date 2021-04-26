using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scores;
    [SerializeField] private int score;

    public void GameScore()
    {
        score += 1;
        scores.text = score.ToString();
    }
}
