using UnityEngine;

public class Ball : MonoBehaviour
{
    //VARIABLES (always at the very top)
    private Rigidbody2D _rigidBody;
    public float speed = 100.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        //floating number, ex: 5.6, 4.7, 3.2
        float x = 0.0f;
        float y = 0.0f;

        if(Random.value < 0.5f) x = -1.0f; //will make the ball go left
        else x = 1.0f;

        if(Random.value<0.5f) y = -1.0f; //f is needed for float numbers
        else y = 1.0f;

        y = y * Random.Range(0.5f,0.9f);

        Vector2 direction = new Vector2(x, y);

        _rigidBody.AddForce(direction*speed); //this adds force in order to move the ball

    }
}
