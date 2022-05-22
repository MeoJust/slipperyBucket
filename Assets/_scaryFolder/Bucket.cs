using UnityEngine;

public class Bucket : MonoBehaviour
{
    [SerializeField] float _speed;

    void Update()
    {
        float moving = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        transform.Translate(moving, 0, 0);
    }
}
