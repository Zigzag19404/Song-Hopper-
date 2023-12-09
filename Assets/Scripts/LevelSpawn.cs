using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawn : MonoBehaviour
{
    public GameObject levelSpawn;
    public GameObject songPause;
    public float dropLimit;
    public Vector2 startSpot;
    public Vector2 resetSpot;
    [SerializeField] private bool spawnReset;

    

    // Start is called before the first frame update
    void Start()
    {
        levelSpawn.SetActive(false);
        spawnReset = false;
        songPause.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        // changes the  spawn position when you  hit the end note 
        if (spawnReset && transform.position.y <= -7)
        {
            transform.position = resetSpot;
        }

        if (!spawnReset && transform.position.y <= -7)
        {
            transform.position = startSpot;
        }
        


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("EndNote"))
        {
            spawnReset = true;
            levelSpawn.SetActive(true);
            songPause.SetActive(true);
            
            
           
        }

    }


}
