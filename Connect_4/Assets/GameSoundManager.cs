using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSoundManager : MonoBehaviour
{
    public static AudioClip gameStart,gamebuttons,gameEnd;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        gamebuttons = Resources.Load<AudioClip>("buttonsounds");
        gameStart = Resources.Load<AudioClip>("CrazyFrogMusic");
        gameEnd = Resources.Load<AudioClip>("pend");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound1()
    {
        audioSrc.PlayOneShot(gameStart,0.4F);
    }
    public static void StopSound1()
    {
       audioSrc.Stop();
    }
    public static void PlaySound2()
    {
        audioSrc.PlayOneShot(gamebuttons, 0.9F);
    }
    public static void PlaySound3()
    {
        audioSrc.PlayOneShot(gameEnd, 0.9F);
    }

}
