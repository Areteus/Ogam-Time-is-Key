using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform carTransform;
    [SerializeField] private float translateSpeed;
    [SerializeField] private float rotaionSpeed; 

    private void FixedUpdate()
    {
        HandleTransition();
        HandleRotation(); 
    }

    public void HandleTransition()
    {
        //get world position from the local position of the targeted transform
        var targetPosition = carTransform.TransformPoint(offset);
        //interpolate between target position and current camera position by translation speed
        transform.position = Vector3.Lerp(transform.position, targetPosition, translateSpeed * Time.deltaTime); //can also try using SmoothDamp() if camera is jittery and not smooth
    }

    public void HandleRotation()
    {
        //find direction from our position to the target position 
        var direction = carTransform.position - transform.position;
        //Convert to Quaternion to use lookRotation with the y-axis as the up direction 
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        //interpolate between targets rotation and current camera rotation by rotation speed
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotaionSpeed * Time.deltaTime); 
    }


}
