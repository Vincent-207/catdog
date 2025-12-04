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
    bool wasPressed = false;

    [SerializeField] float pressThreshold;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        handleInputs();
    }
    void handleInputs()
    {
        if(sliderJoint2D.jointTranslation <= pressThreshold)
        {
                Debug.Log("PRESSED");
            buttonPressed.Invoke();
            if(!wasPressed)
            {
                buttonJustPressed.Invoke();
                Debug.Log("JUST PRESSED");
            }

            wasPressed = true;
        }
        else
        {
            buttonReleased.Invoke();

            if(wasPressed)
            {
                buttonJustReleased.Invoke();
            }

            wasPressed = false;
        }
        
    }

    void OnDrawGizmos()
    {
    }
}
