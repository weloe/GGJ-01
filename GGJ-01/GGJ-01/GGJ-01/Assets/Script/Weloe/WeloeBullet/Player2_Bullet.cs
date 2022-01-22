using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Bullet : MonoBehaviour
{
    public GameObject uiManager;
    public GameObject enemyHPManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UIManager ui = uiManager.GetComponent<UIManager>();
        EnemyHP enemyHP = enemyHPManager.GetComponent<EnemyHP>();

        switch (collision.tag)
        {
            case "Player1":
                //1��-2
                ui.player1_HPLoss();//��Ѫ->����
                Destroy(gameObject);
                break;


            case "Enemy":
                ui.player2_DefeatNumChange();//���2 ɱ�����仯
                enemyHP.EnemyHPLoss();//��Ѫ->����
                Destroy(gameObject);
                break;

            //������ɫ��1��Ѫ
            case "RedLove":
                collision.SendMessage("RedDisappear");//������ʧ
                ui.player1_HPIncrease();//��� 1 ��Ѫ
                Destroy(gameObject);
                break;

            default:
                break;
        }
    }
}
