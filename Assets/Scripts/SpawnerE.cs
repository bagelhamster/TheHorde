using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerE : MonoBehaviour
{
    bool detected;
    GameObject player1;
    public Transform enemy;

    public GameObject bullet;
    public Transform Gun;

    public float BulletSpeed = 10f;
    public float FireRate = 1.3f;
    float oTime;

    void Start()
    {
        oTime = FireRate;
    }


    void Update()
    {
        if (detected)
        {
            enemy.LookAt(player1.transform);
        }
    }

    private void FixedUpdate()
    {
        if (detected)
        {
            FireRate -= Time.deltaTime;

            if (FireRate < 0)
            {
                ShootPlayer();

                FireRate = oTime;
            }
        }
    }
    /*When the player enters the area near the enemy*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = true;

            player1 = other.gameObject;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = false;

            player1 = other.gameObject;
        }
    }

    private void ShootPlayer()
    {
        GameObject currentBullet = Instantiate(bullet, Gun.position, Gun.rotation);
        Rigidbody rig = currentBullet.GetComponent<Rigidbody>();

        rig.AddForce(transform.forward * BulletSpeed, ForceMode.VelocityChange);
    }
}
