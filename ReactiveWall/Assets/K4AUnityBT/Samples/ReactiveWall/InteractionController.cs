using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using AzureKinect.Unity.BodyTracker.Sample;
using AzureKinect.Unity.BodyTracker;

public class InteractionController : MonoBehaviour
{
    public GameObject LeftHandProxy;

    // We poll the Kinect Controller singleton for currently tracked skeletons. If there are more than zero,
    // we get the position of the left hand from the first tracked skeleton (index 0). We set this position
    // to `LeftHandProxy`, which is the yellow sphere that visualizes the left hand in the scene. 
    // Lastly, we grab the point light for the left hand (`LeftHandPointLight`) from the Unity scene graph
    // and set the position identically. 
    void FixedUpdate()
    {
        if (Controller.Instance.activeBodies.Length > 0)
        {
            var leftHand = Controller.Instance.activeBodies[0].body.skeleton.joints[(int)JointIndex.HandLeft];
            LeftHandProxy.transform.localPosition = new Vector3(leftHand.position.x * -1f, leftHand.position.y * -1f, leftHand.position.z) / 1000f;
            GameObject.Find("LeftHandPointLight").transform.position = LeftHandProxy.transform.position;
        }
    }
}
