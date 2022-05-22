using UnityEngine;

public class FallBall : MonoBehaviour
{
    ScoreCounter _scoreCounter;

    void Start()
    {
        _scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            _scoreCounter.SetScore(_scoreCounter.GetScore() + 1);
        }

        if (collision.gameObject.tag == "shredder")
        {
            Destroy(gameObject);
            _scoreCounter.SetScore(_scoreCounter.GetScore() - 1);
        }
    }
}
