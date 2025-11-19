using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField]
    UnityEvent buttonPressed, buttonJustPressed, buttonReleased, buttonJustReleased;
    [SerializeField]
    SliderJoint2D sliderJoint2D;
    [SerializeField]
    SpringJoint2D springJoint2D;
    [SerializeField]
    Rigidbody2D myRigidbody2D;
    bool wasPressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if pressed
        // invoke j
    }

    void handleInput()
    {
        // if is currently pressed
            // invoke buttonPressde
            // if was pressed == false
                // invoke buttonJustPressed
    }
}
