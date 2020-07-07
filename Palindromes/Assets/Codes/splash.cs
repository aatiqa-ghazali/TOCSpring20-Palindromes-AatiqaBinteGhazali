using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class splash : MonoBehaviour
{
    public static int scene_number=0;
    // Start is called before the first frame update
    void Start()
    {
        if(scene_number==0)
        {
            StartCoroutine(ToSceneOne());
        }
        if (scene_number == 1)
        {
            StartCoroutine(ToSceneTwo());
        }
    }
   IEnumerator ToSceneOne()
    {
        yield return new WaitForSeconds(1);
       scene_number = 1;
        SceneManager.LoadScene(0);

    }
    IEnumerator ToSceneTwo()
    {
        yield return new WaitForSeconds(5);
        scene_number = 1;
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
