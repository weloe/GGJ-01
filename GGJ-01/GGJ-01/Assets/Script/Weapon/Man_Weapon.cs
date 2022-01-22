using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man_Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefabs;
    private Rigidbody2D rig;
    private Collider2D coll;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        //P1Éä»÷Âß¼­
        Instantiate(BulletPrefabs, FirePoint.position, FirePoint.rotation);
    }
}
