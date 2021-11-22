using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField]
    private float _scrollSpeed = 3f;
    // Update is called once per frame
    Vector2 _currentTextureOffset;
    void Awake()
    {

        _currentTextureOffset = this.GetComponent<Renderer>().material.GetTextureOffset("_MainTex");
    }
    void Update()
    {
        float distanceToScrollLeft = Time.deltaTime * _scrollSpeed;
        float newTextureOffset_X = _currentTextureOffset.x + distanceToScrollLeft;
        _currentTextureOffset = new Vector2(newTextureOffset_X, _currentTextureOffset.y);
        this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", _currentTextureOffset);
    }
}
