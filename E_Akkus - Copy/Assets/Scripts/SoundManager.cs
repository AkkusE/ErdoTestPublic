using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip jumpSound;
    static AudioSource audioSrc;

    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jumbo");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "jumbo":
                audioSrc.PlayOneShot(jumpSound);
                break;


        }

    }
}
