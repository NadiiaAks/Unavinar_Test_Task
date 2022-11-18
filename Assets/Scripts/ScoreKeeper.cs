using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    int score = 0;

    public int Score 
    { 
        get { return score; }
        set { score = value; }
    }

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }

}
