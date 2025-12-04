using UnityEngine;

public class TriangleLogic : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void updateColor(Color inputColor)
    {
        
    }

    public void doJustPressed()
    {
        spriteRenderer.color = Color.aliceBlue;
        Debug.Log("Triangle reaction!");
        transform.position = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
