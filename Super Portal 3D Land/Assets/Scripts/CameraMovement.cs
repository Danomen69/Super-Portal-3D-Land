using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement: MonoBehaviour
{

    public Vector3 rot;
    public Vector3 camRot;
    public Transform cam;



    // Update is called once per frame
    void Update()
    {
        //get input:
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        //Stop mouse X in de Y van de body: 
        rot.y = x;

        //Stop mouse Y in de X van de camera:
        camRot.x = -y;

        //Draai de body:
        transform.Rotate(rot);
        //Draai de Camera: 
        cam.Rotate(camRot);
    }
}
