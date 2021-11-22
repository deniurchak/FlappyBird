using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField]
    private float _forceMultiplyer = 100f;


    private bool _pressedFireButton;

    Rigidbody2D _rigidBody;
    void Awake()
    {

        _rigidBody = GetComponent<Rigidbody2D>();
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
            _rigidBody.velocity = Vector3.zero;
            _rigidBody.AddForce(Vector3.up * _forceMultiplyer);

            if (transform.position.y > upperLimit || transform.position.y < lowerLimit)
            {
                GameManager.onDeath();
            }
        }
    }
}
