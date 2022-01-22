using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man_Weapon : MonoBehaviour
{
    public float waitTime = 0.02f;
    public int BulletCnt = 5;
    public float coolDown = 1.0f;
    private float currentCoolDown;
    public Transform FirePoint;
    public GameObject BulletPrefabs;

    private void Start()
    {
        currentCoolDown = coolDown;
    }

    void Update()
    {
        if (currentCoolDown < coolDown)
        {
            currentCoolDown += Time.deltaTime;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            StartCoroutine(Shoot(BulletPrefabs));
        }

    }

    IEnumerator Shoot(GameObject Bullet)
    {
        if (currentCoolDown >= coolDown)
        {
            currentCoolDown = 0;
            int cnt = BulletCnt;
            while (cnt > 0)
            {
                Instantiate(BulletPrefabs, FirePoint.position, FirePoint.rotation);
                yield return new WaitForSeconds(waitTime);  //ÑÓ³Ùºó¼ÌÐøÖ´ÐÐ
                cnt -= 1;
            }
        }
    }
}
