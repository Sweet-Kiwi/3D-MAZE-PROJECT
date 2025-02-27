using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //float is a number with a point. it requires an f to let cshark tag it as float with a point
    public Transform target;
    public float transitionSpeed = 10;
    private Vector3 offset;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Calculates how far the camera is from the target (player)
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //check if player exists
        // = that means assigning smt == it means comparasion
        if (target == null)
        {
            enabled = false;
            return;
        }
        //- is backwards + is forward
        Vector3 targetPosition = target.position - offset;
        //this is where the camera should go
        transform.position = Vector3.MoveTowards(transform.position,targetPosition, transitionSpeed * Time.deltaTime);
    }
}
