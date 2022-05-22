using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreTXT;
    int _score;

    private void Start()
    {
        _score = 0;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public int GetScore()
    {
        return _score;
    }

    void Update()
    {
        _scoreTXT.text = "your score:" + _score;

        //if (FindObjectsOfType<FallBall>() != null)
        //{
        //    var daBalls = FindObjectsOfType<FallBall>();

        //    foreach (var ball in daBalls)
        //    {
        //        ball.PointsUp += AddPoints;
        //        ball.PointsDown += SubPoints;
        //    }
        //}
    }

    //void AddPoints()
    //{
    //    _score++;
    //}

    //void SubPoints()
    //{
    //    _score--;
    //}
}
