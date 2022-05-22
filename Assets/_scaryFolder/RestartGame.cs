using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] Button _restartBTN;

    void Start()
    {
        _restartBTN.onClick.AddListener(Restart);
    }

    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
