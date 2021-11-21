using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField]
    private float _forceMultiplyer = 100f;


    private bool _pressedFireButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _pressedFireButton = Input.GetButton("Fire1");
    }

    void FixedUpdate()
    {
        Flap();
    }

    void Flap()
    {
        float upperLimit = 6f;
        float lowerLimit = -6f;
        if (_pressedFireButton)
        {
            Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
            rigidBody.velocity = Vector3.zero;
            rigidBody.AddForce(Vector3.up * _forceMultiplyer);

            if (transform.position.y > upperLimit || transform.position.y < lowerLimit)
            {
                GameLoop.onDeath();
            }
        }
    }
}
