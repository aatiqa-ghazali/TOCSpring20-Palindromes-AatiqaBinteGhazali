using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Update is called once per frame
    //the values we set in rotate fields at an angle of 45,45 and 45 will not change by themselves else we have to do this in this script
        void Update()
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    
}
