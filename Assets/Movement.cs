using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;

    [SerializeField]
    private bool _changeYPosition = false;
    // Update is called once per frame
    void Update()
    {
        float screenLeftEdgeX = -10f;
        float screenRightEdgeX = 10f;
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (transform.position.x < screenLeftEdgeX)
        {
            float YPosition = _changeYPosition ? UnityEngine.Random.Range(0, 3) : transform.position.y;
            transform.position = new Vector3(screenRightEdgeX, YPosition, transform.position.z);
        }
    }
}
