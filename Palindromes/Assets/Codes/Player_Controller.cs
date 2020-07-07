using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
   
    public float speed ;
    private Rigidbody rb;
    public int count = 0;
    public TextMesh countText;
    // public Text textview;
    public AudioSource ticksource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ticksource = GetComponent<AudioSource>();
        //   textview.text = count.ToString();
        countText.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(mov * speed);
    }
    void OnTriggerEnter(Collider other
        )
    {
        string n = other.GetComponent<Rotate_>().x;
        Spawner_ ss = new Spawner_();
        if (IsPalindrome(n))
        {
            count++;
            SetCountText(ss.NoOfPalind());
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
           
            
        }
        else if(!(IsPalindrome(n)))
        {
           

            ticksource.Play(0);
            Debug.Log("started");

        }



    }
    public bool IsPalindrome(string original)
    {

        string reverse = "";
        int Length = 0;
        //we will get here the refrence of the cube whihc is colided with player the string on that cube in the form of array

        Length = original.Length - 1;
        //reverse the string we got
        while (Length >= 0)
        {
            reverse = reverse + original[Length];
            Length--;
        }

        if (original.Equals(reverse))
        {
            //yayy a palindrome
            return true;
        }
        else
        {
            return false;
        }
    }

    void SetCountText(int palind)
    {
        if (palind == count)
        {
            countText.text = "All Palindromes are eaten."+"\n"+"The number of eaten palidromes is" + " " + palind.ToString();
        }
        
    }
}
