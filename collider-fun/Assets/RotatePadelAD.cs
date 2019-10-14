using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePadelAD : MonoBehaviour
{
    public int rotateSpeed = 5;

    // Update is called once per frame
    private void OnMouseDrag()
    {
        Debug.Log("Rotation: " + transform.eulerAngles);

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = Vector3.forward * (rotateSpeed + transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = Vector3.forward * (-1*rotateSpeed + transform.eulerAngles.z);
        }
        Debug.Log("RotationEuler: " + transform.eulerAngles);
    }
}
