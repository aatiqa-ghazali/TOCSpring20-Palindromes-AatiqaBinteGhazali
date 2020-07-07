
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner_ : MonoBehaviour
{
    public GameObject[] collectables;

    private GameObject g;

    public static int total = 0;

    int randEnemy;

    void Start()
    {

        add();


    }

    public void add()
     {
         //for 10 cubes
         for (int i = 0; i < 10; i++)
         {

             GameObject gameobject;
            

            randEnemy = Random.Range(0, 4);
             float x = Random.Range(-10,10);
             float z = Random.Range(-9,9);
             //y is set to 1
             Vector3 spawnPosition = new Vector3(x, 1, z);
          //generate random no between 0 and 2
             int r = Random.Range(0, 2);
            // Debug.Log(r);

             //generate random no between 9 and 15
             int size = Random.Range(9, 15);
             //Debug.Log(size);
             string putTheText = "";
             //if generate no is zero then a  string made up of x,a,1  is added inside a varibale nn
             if (r == 0)
             {           
                 putTheText = "" + RandomString(size);
             }
             //if generated no is not zero 1 or 2 then in the string we will add the palindrome
             else
             {
                total = total + 1;

                putTheText = "" + randpalindrom(size);
               
             }
             //here the spawner is spawing the cubes at random position
              gameobject = Instantiate(collectables[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

             g = gameobject;
            //the value of text-string is added on a string x decalred in rorate.cs file
              gameobject.GetComponent<Rotate_>().x = putTheText;
             //the string in whihc either the palindrom or not a palindrom no is added is adjusted on the text on cube
             g.GetComponentInChildren<TextMesh>().text = putTheText;
         }       
     }
     //we have to generate the random number between 9 and 15 so in the function the integare size have a random no between 9 to 15
         private string RandomString(int size)
     {
         //my string
         string my_name = "xa1";
        //char abc= _chars[Random.Range(0, 3)];
         //Debug.Log(abc);
         //an array of characters is created 
         char[] place = new char[size];
         //here we are foricng the random no function to generate the random number from x or a or 1  and it will do it for the number of times between 9 to 15 then make an array of these number with in the range of 9 to 15 and return it as a string and wew will get a zero number a the top it will show that string whihc is not surely a palindrome upon the cube as text

         int i;
         for ( i = 0; i < size; i++)
         {
             //let say 0 is generated and in the array of _chars  x is at the first location so in te array  x will go 
             place[i] = my_name[Random.Range(0, 3)];

         }

         return new string(place);
     }
    //the case when we got a random number 1 or 2 
     public string randpalindrom(int size)
     {
         char[] place_palindrome = new char[size];
         place_palindrome[0] = 'a';
         place_palindrome[size - 1] = 'a';
         //in 2 blocks of array x is add endis no of  blocks left to fill
         int end = size - 2;
         int i = 1;
         for (i = 1; i < size; i++)
         {
             int decide = Random.Range(1, 2);
             if (decide == 1)
             {
                 place_palindrome[i] = 'x';
                 place_palindrome[end] = 'x';
             }
             else if (decide == 2)
             {
                 place_palindrome[i] = '1';
                 place_palindrome[end] = '1';

             }
             //one block is filled again now end will be decremented
             end--;
             //array is filled
             if (end <= i)
             {
                 break;
             }
         }

         return new string(place_palindrome);
     }
    public int NoOfPalind()
    {
        return total;
    }
}