using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _Rb; // Поле типа Rigidbody2D для работы с ним и его компонентами 
    private Animator _Anium; // Поле для Аниматора
    private float _Speed = 4.0f; // Полсе скорости
    private Vector2 _MoveVector; // Поле типа Vector2 для работы с векторами в 2D
    void Start()
    {
        _Rb = GetComponent<Rigidbody2D>(); //Получаем компонент Rigidbody2D в наше поле _Rb
        _Anium = GetComponent<Animator>(); // Получаем компонент 
    }

    void Update()
    {
        _MoveVector.x = Input.GetAxisRaw("Horizontal"); //Читаем изменение по Х позиции
        _MoveVector.y = Input.GetAxisRaw("Vertical"); //Читаем изменение по Y позиции
        _MoveVector.Normalize();
    }
    void FixedUpdate()
    {
        _Rb.linearVelocity = _MoveVector * _Speed; // Само движение, где мы изменение позиции умнодаем на скорость 
        AnimControl();
    }
    private void AnimControl() // Работаем с анимациями
    {
        _Anium.SetFloat("velX", _MoveVector.x); // Передаем значение 
        _Anium.SetFloat("velY", _MoveVector.y); // Передаем значение 
    }
}
