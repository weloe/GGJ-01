using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Bullet : MonoBehaviour
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
            case "Player2":
                //1-��2 1��2���
                ui.player2_HPLoss();//��Ѫ->����
                Destroy(gameObject);                
                break;

            case "Enemy":
                ui.player1_DefeatNumChange();
                enemyHP.EnemyHPLoss();//��Ѫ->����
                Destroy(gameObject);
                break;
            
            //������ɫ��2��Ѫ
            case "BlueLove":
                collision.SendMessage("BlueDisappear");//������ʧ
                ui.player2_HPIncrease();
                Destroy(gameObject);
                break;

            default:
                break;
        }
    }

}
