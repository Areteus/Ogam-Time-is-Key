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

    public float gasPower = 100f;
    public float maxSteer = 20f;


    public void Update()
    {
        Vector3 Pos = transform.position; //setting temp variable to vector3.zero
        Quaternion rot = transform.rotation; // setting temp variable to Quaternion.identity 

        FrontLeftWheel.GetWorldPose(out Pos, out rot); //gets Position and rotation of the wheel collider's tranforms in world space
        FLW.position = Pos; // sets Position of the wheel collider
        FLW.rotation = rot; // sets rotation of the wheel collder 

        FrontRightWheel.GetWorldPose(out Pos, out rot);
        FRW.position = Pos;
        FRW.rotation = rot * Quaternion.Euler(0, 180, 0);

        BackLeftWheel.GetWorldPose(out Pos, out rot);
        BLW.position = Pos;
        BLW.rotation = rot;

        BackRightWheel.GetWorldPose(out Pos, out rot);
        BRW.position = Pos;
        BRW.rotation = rot * Quaternion.Euler(0, 180, 0); 
    }

    public void FixedUpdate()
    {
        //applying motorTorque to the back wheel of the car so it can move forward and backward with gasPower
        BackLeftWheel.motorTorque = Input.GetAxis("Vertical") * gasPower;
        BackRightWheel.motorTorque = Input.GetAxis("Vertical") * gasPower;
        //applying steer angle to front of the wheel so it can turn left and right with max steer
        FrontLeftWheel.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
        FrontRightWheel.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
    }

}
