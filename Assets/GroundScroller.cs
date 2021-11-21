using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField]
    private float _scrollSpeed = 3f;
    // Update is called once per frame
    void Update()
    {
        Vector2 currentTextureOffset = this.GetComponent<Renderer>().material.GetTextureOffset("_MainTex");
        float distanceToScrollLeft = Time.deltaTime * _scrollSpeed;
        float newTextureOffset_X = currentTextureOffset.x + distanceToScrollLeft;
        currentTextureOffset = new Vector2(newTextureOffset_X, currentTextureOffset.y);
        this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", currentTextureOffset);
    }
}
