using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    public AudioSource song;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        song.loop = true;
        song.Play();
    }



}
