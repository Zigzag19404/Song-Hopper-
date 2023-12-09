using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //song one variables 
    public AudioSource drums;
    public AudioSource bells;
    public AudioSource viola;
    public AudioClip Drums;
    public AudioClip Bells;
    public AudioClip Viola;
    public bool songOne;

    //song two variables 
    public bool songTwo;
    // Guitar
    public AudioSource guitar;
    public AudioClip Guitar;
    //Piano
    public AudioSource piano;
    public AudioClip Piano;
    //DrumsTwo
    public AudioSource drumsTwo;
    public AudioClip DrumsTwo;
    //LightBells
    public AudioSource lightBells;
    public AudioClip LightBells;
    // BitSound
    public AudioSource bitSound;
    public AudioClip BitSound;

    // Song Three
    public bool songThree;
    public AudioSource pianoThree;
    public AudioSource drumsThree;
    public AudioSource dulcimer;
    public AudioSource marimba;
    public AudioSource violin;
    public AudioClip PianoThree;
    public AudioClip DrumsThree;
    public AudioClip Dulcimer;
    public AudioClip Marimba;
    public AudioClip Violin;






    void Start()
    {
        // Song One 
        drums = gameObject.AddComponent<AudioSource>();
        bells = gameObject.AddComponent<AudioSource>();
        viola = gameObject.AddComponent<AudioSource>();
        songOne = true;

        //Song Two 
        songTwo = true;
        guitar = gameObject.AddComponent<AudioSource>();
        piano = gameObject.AddComponent<AudioSource>();
        drumsTwo = gameObject.AddComponent<AudioSource>();
        lightBells = gameObject.AddComponent<AudioSource>();
        bitSound = gameObject.AddComponent<AudioSource>();

        // Song Three 
        songThree = true;
        pianoThree = gameObject.AddComponent<AudioSource>();
        drumsThree = gameObject.AddComponent<AudioSource>();
        marimba = gameObject.AddComponent<AudioSource>();
        dulcimer = gameObject.AddComponent<AudioSource>();
        violin = gameObject.AddComponent<AudioSource>();
    }
    void Update()
    {
        // song one shut off bool
        if (!songOne)
        {
            viola.Stop();
        }
        if (!songTwo)
        {
            bitSound.Stop();
        }
        if (!songThree)
        {
            violin.Stop();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (songOne)
        {
            if (collision.collider.CompareTag("Drums"))
            {
                drums.loop = true;
                drums.clip = Drums;
                drums.Play();
            }
            else if (collision.collider.CompareTag("Bells"))
            {
                drums.Stop();
                bells.clip = Bells;
                bells.loop = true;
                bells.Play();
            }
            else if (collision.collider.CompareTag("viola"))
            {
                bells.Stop();
                viola.loop = true;
                viola.clip = Viola;
                viola.Play();
            }


        }

        if (songTwo)
        {
            if (collision.collider.CompareTag("Guitar"))
            {
                guitar.clip = Guitar;
                guitar.loop = true;
                guitar.Play();

            }
            else if (collision.collider.CompareTag("Piano"))
            {
                guitar.Stop();
                piano.loop = true;
                piano.clip = Piano;
                piano.Play();
            }
            else if (collision.collider.CompareTag("Drums2"))
            {
                piano.Stop();
                drumsTwo.loop = true;
                drumsTwo.clip = DrumsTwo;
                drumsTwo.Play();
            }
            else if (collision.collider.CompareTag("LightBells"))
            {
                drumsTwo.Stop();
                lightBells.loop = true;
                lightBells.clip = LightBells;
                lightBells.Play();
            }
            else if (collision.collider.CompareTag("BitSound"))
            {
                lightBells.Stop();
                bitSound.loop = true;
                bitSound.clip = BitSound;
                bitSound.Play();
            }
        }

        if (songThree)
        {
            if (collision.collider.CompareTag("Piano3"))
            {
                pianoThree.loop = true;
                pianoThree.clip = PianoThree;
                pianoThree.Play();
            }
            else if (collision.collider.CompareTag("Drums3"))
            {
                pianoThree.Stop();
                drumsThree.loop = true;
                drumsThree.clip = DrumsThree;
                drumsThree.Play();
            }
            else if (collision.collider.CompareTag("Dulcimer"))
            {
                drumsThree.Stop();
                dulcimer.loop = true;
                dulcimer.clip = Dulcimer;
                dulcimer.Play();
            }
            else if (collision.collider.CompareTag("Marimba"))
            {
                dulcimer.Stop();
                marimba.loop = true;
                marimba.clip = Marimba;
                marimba.Play();
            }
            else if (collision.collider.CompareTag("Violin"))
            {
                marimba.Stop();
                violin.loop = true;
                violin.clip = Violin;
                violin.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("SongPause"))
        {
            songOne = false;
            songTwo = false;
            songThree = false;
            Debug.Log("Song Pause");
        }

    }

}
