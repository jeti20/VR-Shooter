using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class AutoShot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float fireSpeed = 40;

    private XRGrabInteractable grabbable;
    private bool isFiring = false;

    private void Start()
    {
        grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(StartFiring);
        grabbable.deactivated.AddListener(StopFiring);
    }

    private void Update()
    {
        if (isFiring)
        {
            FireBullet();
        }
    }

    public void StartFiring(ActivateEventArgs arg)
    {
        isFiring = true;
    }

    public void StopFiring(DeactivateEventArgs arg)
    {
        isFiring = false;
    }

    public void FireBullet()
    {
        BulletCount();
        Debug.Log(GameManager.instance.amoutOfBullets);
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
