using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 1f;

    [SerializeField]
    private int _popBubbleIncreaseScore = 5;
    void Start()
    {
        Reset();
    }

    ScoreKeeper _scoreKeeper;
    void Awake() 
    {
        _scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
    }
    // Update is called once per frame
    void Update()
    {
        float upperLimit = 8f;
        transform.Translate(Vector3.up * Time.deltaTime * _moveSpeed);
        if (transform.position.y > upperLimit)
        {
            Reset();
        }
    }

    void Reset()
    {
        float randomHeight = Random.Range(-2f, -8f);
        transform.position = new Vector3(transform.position.x, randomHeight, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameManager.OtherIsTheFish(other))
        {
            _scoreKeeper.increaseScoreBy(_popBubbleIncreaseScore);
            Reset();
        }
    }
}
