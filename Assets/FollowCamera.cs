using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Update is called once per frame
    void Update()
    {
        //move camera away from the top of the cars roof, os you could see everything from top better. 
        transform.position = thingToFollow.transform.position + new Vector3 (0,0, -10);
    }
}
