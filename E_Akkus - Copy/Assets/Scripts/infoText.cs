using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class infoText : MonoBehaviour
{
    public GameObject UiObject;

    public GameObject Paper;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }

    //void OnCollisionEnter2D(Collision other)
    //{

    //    if (other.gameObject.tag == "Player")
    //    {
    //        UiObject.SetActive(true);
    //        Debug.Log("TouchDown");
    //    }

    //}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
            Debug.Log("TouchDown");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(false);
        }
    }
}
