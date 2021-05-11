using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infrastructureSystem : MonoBehaviour
{
    public void newRoad(Segment[] segments )
    {

    }
}

public class Segment
{
    Vector2[] points { get; set; } // Points along the length of the road
    float curveAngle { get; set; }
    int laneCount { get; set; } // The number of lanes the road segment has
    bool isJunction { get; set; } // Is true if segent contains junction 
    GameObject gameObject { get; set; }
}

public class Road
{
    Segment[] segments { get; set; } // List of segments in the road
    string roadName { get; set; } // The name of the road
    bool isAllowedCar { get; set; } 
    bool isAllowedBus { get; set; }
    bool isAllowedTruck { get; set; }
    bool isAllowedBin { get; set; }
    int speedLimit { get; set; } 
    GameObject gameObject { get; set; }
}