using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //getting wheel collider for each wheel 
    public WheelCollider FrontLeftWheel;
    public WheelCollider FrontRightWheel;
    public WheelCollider BackLeftWheel;
    public WheelCollider BackRightWheel;

    // accessesing Transfom of each Wheel 
    public Transform FLW; //FrontLeftWheel
    public Transform FRW; //FrontRightWheel
    public Transform BLW; //BackLeftWheel
    public Transform BRW; //BackRightWheel

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
