using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wom_Weapon : MonoBehaviour
{
    public float waitTime = 0.02f;
    public int BulletCnt = 5;
    private float invokeTime;
    public Transform FirePoint;
    public GameObject BulletPrefabs;
    private Rigidbody2D rig;
    private Collider2D coll;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot(BulletPrefabs));
        }

    }

    IEnumerator Shoot(GameObject Bullet)
    {
        int cnt = BulletCnt;
        while(cnt > 0)
        {
            Instantiate(BulletPrefabs, FirePoint.position, FirePoint.rotation);
            yield return new WaitForSeconds(waitTime);  //ÑÓ³Ùºó¼ÌÐøÖ´ÐÐ
            cnt -= 1;
        }
    }
}
