using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    [Header("����Ѫ��")]
    public Slider enemyHP;
    // Start is called before the first frame update
    void Start()
    {
        enemyHP.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.K))
        //{
        //    EnemyHPLoss();
        //}
    }

    //���˿�Ѫ
    public void EnemyHPLoss()
    {
        enemyHP.value -= 0.333f;

        //��������
        if (enemyHP.value <= 0)
        {
            Destroy(gameObject);
            //����
        }
    }
}
