using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiSystem : MonoBehaviour
{
    //find random waypoint 
    //pick up passenger on waypoint 
    //Find Destination and drop off passenger 
    //Start over

    [SerializeField] Transform[] Waypoints;

    GameObject PickupWaypoint;
    GameObject DestinationWaypoint; 

    void Start()
    {
        PickupWaypoint = GetRandomWaypoints();
        Debug.Log("go to " + PickupWaypoint); 
        //DestinationWaypoint = GetRandomWaypoints();
    }



    public void PassengerPickUp(GameObject passingerPoint)
    {
        if (passingerPoint == PickupWaypoint)
        {
            Debug.Log("passenger picked up");
            DestinationWaypoint = GetRandomWaypoints();
            Debug.Log("go to " + DestinationWaypoint);
        }

        else if (passingerPoint == DestinationWaypoint)
        {
            //add time and score
            Debug.Log("passenger droped"); 
            PickupWaypoint = GetRandomWaypoints();
            Debug.Log("go to " + PickupWaypoint);
        }
    }

    private GameObject GetRandomWaypoints()
    {
        Transform selectedWaypoint;
        int rand = Random.Range(0, Waypoints.Length);
        selectedWaypoint = Waypoints[rand];
        return selectedWaypoint.gameObject; 
    }

}
