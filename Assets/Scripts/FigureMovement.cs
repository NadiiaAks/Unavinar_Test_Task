using UnityEngine;

public class FigureMovement : MonoBehaviour
{
    [SerializeField] float figureSpeed;
    [SerializeField] GameObject reloadCanvas;

    bool isStop;

    ScoreKeeper scoreKeeper;

   void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Update()
    {
        MoveForward();
    }
    public bool IsStop { get { return isStop; } }
    public float FigureSpeed 
    { 
        set { figureSpeed = value; }
        get { return figureSpeed; }
    }
    void MoveForward()
    {
        transform.Translate(0f, 0f, figureSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Stop")
        {
            isStop = true;
            figureSpeed = 0;
            Time.timeScale = 0f;
            reloadCanvas.SetActive(true);
        }
        if (other.tag == "Obstacle")
        {
            scoreKeeper.Score = scoreKeeper.Score + 10;
            Debug.Log("Obstacle triggered");
        }
    }
}
