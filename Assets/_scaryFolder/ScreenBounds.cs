using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    Vector2 _screenBounds;

    void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    void LateUpdate()
    {
        Vector3 viewPosition  = transform.position;
        viewPosition.x = Mathf.Clamp(viewPosition.x, _screenBounds.x * -1, _screenBounds.x);
        transform.position = viewPosition;
    }
}
