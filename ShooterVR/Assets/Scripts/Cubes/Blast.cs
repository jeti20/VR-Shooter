using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    public GameObject blastEffect;
    public float offSet;
    public int amountOfDestroyed = 0;


    public AudioClip clip;

    private void Start()
    {
        GameManager.instance.source = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GameManager.instance.source.PlayOneShot(clip);
            GameManager.instance.score += 1;
            Vector3 spawnPosition = new Vector3(transform.position.x, offSet, transform.position.z);
            Instantiate(blastEffect, transform.position, blastEffect.transform.rotation);        
            Destroy(gameObject); 
        }
    }
}
