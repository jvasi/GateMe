using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDirection : MonoBehaviour {

    public Quaternion targetRot;        // The rotation of the device camera from  Frame.Pose.rotation
    public GameObject arrow;            // The direction indicator on the person indicator

    void LateUpdate()
    {
        //float rotationSmoothingSpeed = 1.0f;  // TODO Krasi
        //Vector3 targetEulerAngles = targetRot.eulerAngles;
        //float rotationToApplyAroundY = targetEulerAngles.y;
        //float newCamRotAngleY = Mathf.LerpAngle(arrow.transform.eulerAngles.y,
        //   rotationToApplyAroundY, rotationSmoothingSpeed * Time.deltaTime);
        //Quaternion newCamRotYQuat = Quaternion.Euler(0, newCamRotAngleY, 0);
        //arrow.transform.rotation = newCamRotYQuat;
        //Debug.Log("=== newCamRotYQuat:" + newCamRotYQuat);
        //Debug.Log("=== arrow:" + arrow);
        //Debug.Log("=== targetRot:" + targetRot);
    }
}
