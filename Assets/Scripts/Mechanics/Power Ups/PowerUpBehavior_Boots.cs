using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior_Boots : MonoBehaviour
{
    public AudioSource audioSource;
    public BoxCollider2D boxCollider;
    public SpriteRenderer sprite;
    private bool isActive = true;




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
            audioSource.Play();
            isActive = false;
            collider.enabled = GetComponent<Renderer>().enabled = false;
        }
    }
    void Update()
    {
        if (isActive)
        {

        }
        else
        {
            if (!audioSource.isPlaying)
                Destroy(gameObject);
        }
    }
}