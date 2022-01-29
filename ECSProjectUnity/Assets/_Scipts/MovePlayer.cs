using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePlayer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private float _speed;
    private float _speedX;
    private float _speedY;

    private Camera _camera;
    private Vector2 _screenBounds;
    private Vector2 _direction;

    private void Start()
    {
        _camera = Camera.main;
        _screenBounds = _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, _camera.transform.position.z));
        _direction = new Vector2();
        _speedX = _speed;
        _speedY = _speed;
    }

    private void Update()
    {
        _direction.x = _speedX * Time.deltaTime;
        _direction.y = _speedY * Time.deltaTime;

        if (transform.position.x >= _screenBounds.x - 0.5)
        {
            Debug.Log("Правый край");
            _speedX *= -1;
        }

        if (transform.position.x <= -_screenBounds.x)
        {
            Debug.Log("Левый край");
            _speedX *= -1;
        }

        if (transform.position.y >= _screenBounds.y - 0.5)
        {
            Debug.Log("Верхний край");
            _speedY *= -1;
        }

        if (transform.position.y <= -_screenBounds.y)
        {
            Debug.Log("Нижний край");
            _speedY *= -1;
        }
        transform.Translate(_direction);
        Debug.Log(_direction);
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(gameObject.name);
    }
}
