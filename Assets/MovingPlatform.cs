using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    Vector3[] movePositions;
    [SerializeField] Vector3 idealPos;
    [SerializeField] float allowedDistanceError, moveSpeed;
    public void SetPosition(int posIndex)
    {
        idealPos = movePositions[posIndex];
        
    }

    void Start()
    {
        idealPos = movePositions[0];
    }

    void Update()
    {
        Vector3 toPos = (idealPos - transform.position);
        if(toPos.magnitude > allowedDistanceError)
        {
            transform.position += toPos.normalized * moveSpeed * Time.deltaTime;
        }

    }
}
