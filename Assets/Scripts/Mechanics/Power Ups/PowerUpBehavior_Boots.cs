using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior_Boots : MonoBehaviour
{
    public AudioSource audioSource;
    public BoxCollider2D boxCollider;
    public SpriteRenderer sprite;
    private bool isActive = true;
    public bool has_shoes;
   




    public BoxCollider2D collider;


    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {

        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            c2d.GetComponent<PlayerController>().ActivateDoubleJump();
            has_shoes = true;
            audioSource.Play();
            isActive = false;
            collider.enabled = GetComponent<Renderer>().enabled = false;
            boxCollider.enabled = GetComponent<BoxCollider2D>().enabled = false;
            


        }
    }
    void Update()
    {
        if (isActive)
        {
          //  Debug.Log(has_shoes);
        }
        else
        {
            if (!audioSource.isPlaying)
                Destroy(gameObject);
        }
    }
}