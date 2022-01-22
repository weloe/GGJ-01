using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    


    [Header("���Ѫ������")]
    public int player1_HP=5;
    public int player2_HP=5;
    public bool player1_isHPLoss;
    public bool player2_isHPLoss;

    public GameObject[] player1_HPImage;
    public GameObject[] player2_HPImage;

    [Header("���Ѫ������")]
    public bool player1_isHPIncrease;
    public bool player2_isHPIncrease;



    [Header("���ɱ����")]
    public Text player1_TextNum;
    public Text player2_TextNum;
    public int player1_DefeatNum;
    public int player2_DefeatNum;

    

    public void Awake()
    {
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //����
<<<<<<< Updated upstream
        if (Input.GetKeyDown(KeyCode.E))
        {
            player1_HPLoss();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            player1_HPIncrease();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            player1_DefeatNumChange();
        }
=======
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    player1_HPLoss();
        //}
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    player1_HPIncrease();
        //}

        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    player1_DefeatNumChange();
        //}
>>>>>>> Stashed changes
    }

    


    



    //��� 1 ��Ѫ
    public void player1_HPLoss()
    {

        if (player1_HP <= 5 && player1_HP > 0)
        {
            player1_HP--;
            if (player1_HPImage[player1_HP] == null)
            {
                return;
            }
            player1_HPImage[player1_HP].SetActive(false);

        }

        //p1����
<<<<<<< Updated upstream
        if (player1_HP == 0 )
        {

            Time.timeScale = 0;
        }
=======
        //if (player1_HP == 0 )
        //{

        //    Time.timeScale = 0;
        //}
>>>>>>> Stashed changes

    }


    //��� 2 ��Ѫ
    public void player2_HPLoss()
    {
        
        if (player2_HP <= 5 && player2_HP > 0)
        {
            player2_HP--;
            if (player2_HPImage[player2_HP] == null)
            {
                return;
            }
<<<<<<< Updated upstream
            player1_HPImage[player2_HP].SetActive(false);
=======
            player2_HPImage[player2_HP].SetActive(false);
>>>>>>> Stashed changes

        }

        //p2����
<<<<<<< Updated upstream
        if (player2_HP == 0)
        {


            Time.timeScale = 0;
        }
=======
        //if (player2_HP == 0)
        //{

        //    Time.timeScale = 0;
        //}
>>>>>>> Stashed changes
    }





    //��� 1 Ѫ������
    public void player1_HPIncrease()
    {
         if(player1_HP==5)
        {
            return;
        }

         player1_HP++;
         player1_HPImage[player1_HP-1].SetActive(true);
        

        
    }

    //��� 2 Ѫ������
    public void player2_HPIncrease()
    {
        if (player2_HP == 5)
        {
            return;
        }

        player2_HP++;
        player2_HPImage[player2_HP-1].SetActive(true);

    }





    //��� 1 ɱ��������
    public void player1_DefeatNumChange()
    {
        player1_DefeatNum++;
        player1_TextNum.text = player1_DefeatNum.ToString();

    }

    //��� 2 ɱ��������
    public void player2_DefeatNumChange()
    {

        player2_DefeatNum++;
        player2_TextNum.text = player2_DefeatNum.ToString();
    }

<<<<<<< Updated upstream

=======
    public void DieOrNot()
    {
        if (player1_HP == 0 && player2_HP == 0)
        {

            Time.timeScale = 0;
        }
        
    }
>>>>>>> Stashed changes

}
