using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    //offset is the difference between camera and player its private beacuse we will set it here in the script
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //as script is attched with camera so transform.position is the position of camera
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + offset;
        //this means when we move player with the key then when fram updates camera moves to a new position alligned with the position of players but we will wite the code  commented here in lateupdate

    }
    private void LateUpdate()
    {
        //IT RUNS LIKE UPDATE BUT IT IS GUAREENTED TO RUN AFTER ALL ITEMS ARE PROCESSED IN UNITY
        //test and run and attach the player object with the sceipt component gameobject now the camera will move with the player with out rotating
        transform.position = player.transform.position + offset;
    }
}
