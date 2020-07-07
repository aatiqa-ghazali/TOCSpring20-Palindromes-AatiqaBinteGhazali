using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeze_rotation : MonoBehaviour
{
    public Transform childObject;

    void FixedUpdate()
    {
        Quaternion savedRotation = childObject.rotation;
        // Put parent rotation code here...
        childObject.rotation = savedRotation;
    }
}
