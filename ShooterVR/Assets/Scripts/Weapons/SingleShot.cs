using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class SingleShot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float fireSpeed = 60;

    public AudioSource fireSound;

    private void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);

    }

   

    public void FireBullet(ActivateEventArgs arg)
    {
        BulletCount();
        fireSound.Play();

        GameObject spawnBullet = Instantiate(bullet);
        spawnBullet.transform.position = spawnPoint.position;
        spawnBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        //Destroy(spawnBullet, 5);
        
    }

    public void BulletCount()
    {
        GameManager.instance.amoutOfBullets++;
    }

}
