using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    private void Update()
    {
        //so that the paddle can move up or down
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            _direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            _direction = Vector2.down;
        } else {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0 ){
            _rigidBody.AddForce(_direction * this.speed);
        }
    }
}

