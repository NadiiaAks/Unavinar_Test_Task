using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonsManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreTxt;

    ScoreKeeper scoreKeeper;

    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Update()
    {
        finalScoreTxt.text = "Your score: " + scoreKeeper.Score;
    }
    public void ReloadBtn()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void ExitBtn()
    {
        Application.Quit();
    }
}
