using UnityEngine;
using TMPro;

public class CubesBehavior : MonoBehaviour
{
    [SerializeField] GameObject cubeObstacle;
    [SerializeField] ParticleSystem vfxExplosion;

    ScoreKeeper scoreKeeper;

    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        vfxExplosion.Pause();
    }
    void OnTriggerEnter(Collider other)
    {
        scoreKeeper.Score -= 1;
        vfxExplosion.Play();
        Destroy(cubeObstacle, 0.3f);
    }
}
