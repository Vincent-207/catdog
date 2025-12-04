using UnityEngine;
using UnityEngine.InputSystem;

public class followMouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 placePos = new Vector2(mousePos.x, mousePos.y);
        transform.position = placePos;
    }
}
