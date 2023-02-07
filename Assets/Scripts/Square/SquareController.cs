using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    [SerializeField]
    private float _rotationPower;
    [SerializeField]
    private float _speed;
    
    private Vector2 _direction;
    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rotationPower *= GetRandomSign();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _rigidbody.rotation += _rotationPower;
        _rigidbody.velocity = _direction * _speed;
    }
    
    private int GetRandomSign()
    {
        var randomNumber = Random.Range(0, 2);
        return randomNumber == 1 ? 1 : -1;
    }
    
    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }
}
