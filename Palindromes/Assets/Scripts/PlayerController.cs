using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public AudioSource ticksource;
   // public Text countText;
    //public Text winText;
    public float speed;
    private Rigidbody rb;
   // private int count;
    //from the script we need to add foorce to the rigid body component so we want to access this component from the script for that we created a refrence variable above and from that variable we will acees our component
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ticksource = GetComponent<AudioSource>();
        //count = 0;
      //  SetCountText();
        //winText.text = "";
    }
    //called before rendering a frame and this is where our most of the game object code will go
    void Update()
    {

    }
    //This is called before perform performing any physics calculations 
    //we will moce our ball by applying force to the rigid body(physics)
    void FixedUpdate()
    {
        //grab input from player through the keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //our player gameobject needs the rigid body and interects with physics engine
        //vector3 holds 3 decimal values in one container as here we need value of force from each X,Y nad Z axis.
        //as we acces the component(Rigid body) in start function so we will now add force here
        //but how will hold two value(horizontal and vertical in vector3) so lets first create a new varivale vector first
        //y=0 because we dont want to move up
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

    }
    //When a GameObject collides with another GameObject, Unity calls OnTriggerEnter.
    void OnTriggerEnter(Collider other)
    {
        //Our player can collide with walls floow or something else we have to make sure to perfrom functionality on pickup objects(right objects ) only
        //set active will deactiveate pickups when set to false
        //this code is called every time when our player collides with a trigger collider and we have given reference of the  tags  and test the tags if the tags are pick up then deactivate that object
        if (other.gameObject.CompareTag("Pick Up"))
        {
            ticksource.Play();
            other.gameObject.SetActive(false);

            //increment count
            //count = count + 1;
            //SetCountText();

        }
    }
    //after testing this code we have seen that we are still bouncing off the pick up the cubes rather them picking them up just like bouncing off the walls .Its beacuse the phsyics system of unity
    //set the collider to the trigger  we areusing on triggerEnter rather than on collision enter wso we need to change our collider volumes into our trigger volumes.
    //so check the is trigger property in prefab pickup and it will work fine
    //any gameobject with rigid body and collider isdynamic but the one with collider and no rigid body is static .currently our pickup objects have no rigid body for optimization purposes we will do so to make them dynamic so unity dont have to recalculate every time the colume for rotation
    //so our subes will be dynamic colliders then
    //disable gravity in rigid body else all cubes will drown down in the ground but still it can responsd to physics
    //oone better  solution is to check the iskinematic an gravity which will diable physics an dour component will move only by transform
    //static rgid bodies are moved by tranform kinematic rigid bodeis can be moved by tranform

    //-----------------------
    //in order to optimize code so that we may not dupiliate same code in one script we will make this function and will call it when needed
    //void SetCountText()
    //{
      //  countText.text = "Count:" + count.ToString();
        //total no of pickups
        //if(count >=12)
        //{
          //  winText.text = "You Win";
        //}

   // }
} 