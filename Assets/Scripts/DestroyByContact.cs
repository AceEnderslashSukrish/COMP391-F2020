using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public int scoreValue = 10;
    public GameObject explosion;

    private GameController gameControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController"); // Refers to the entire thing called Game Controller

        if(gameControllerObject != null)
        {
            gameControllerScript = gameControllerObject.GetComponent<GameController>(); // Refers to only the script part of the component called Game Controller
        }
        if(gameControllerScript == null)
        {
            Debug.Log("Cannot find game controller script on GameController Object");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Something has collided
        if (other.gameObject.CompareTag("Player"))
        {
            // Collided with player
            Instantiate(explosion, other.transform.position, other.transform.rotation);

            // Initiate Game Over
            gameControllerScript.GameOver();
        }

        // Create an explosion
        Instantiate(explosion, transform.position, transform.rotation);
        gameControllerScript.AddToScore(scoreValue);

        // We are destroying these in this order because destroying 'this' object first would destroy this script before the 'other' object is destroyed
        // Delete the "other" object
        Destroy(other.gameObject);
        // Delete this object
        Destroy(this.gameObject);
    }
}
