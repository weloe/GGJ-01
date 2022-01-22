using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreat : MonoBehaviour
{
    //װ�γ�ʼ����ͼ�������������
    //1.���� 2.����
    public GameObject[] item;
    

    //�Ѿ��ж�����λ���б�
    private List<Vector3> itemPositionList = new List<Vector3>();
    // Start is called before the first frame update
    private void Awake()
    {
        InitMap();//����
    }

    private void InitMap()
    {

        //��ʼ�����


        


        //ʵ��������
        //for (int i = 0; i < 60; i++)
        //{
        //    CreatItem(item[0], CreatRandomPosition(-9,10,-7,8), Quaternion.identity);
        //}
        //for (int i = 0; i < 20; i++)
        //{
        //    CreatItem(item[1], CreatRandomPosition(-9, 10, -7, 8), Quaternion.identity);
        //}

    }

    void Start()
    {
        CreatRedItem();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreatRedItem()
    {
        for (int i = 0; i < 3; i++)
        {
            CreatItem(item[0], CreatRandomPosition(), Quaternion.identity);
        }
            
    }
    public void CreatBlueItem()
    {
        for (int i = 0; i < 3; i++)
        {
            CreatItem(item[1], CreatRandomPosition(), Quaternion.identity);
        }
    }



    private void CreatItem(GameObject createGameObject, Vector3 creatPosition, Quaternion creatRotation)
    {
        GameObject itemGo = Instantiate(createGameObject, creatPosition, creatRotation);
        itemGo.transform.SetParent(gameObject.transform);//�ѵ�ǰ������Ϊ����
        itemPositionList.Add(creatPosition);
    }

    //�������λ�õķ���
    private Vector3 CreatRandomPosition()
    {
        
        while (true)
        {
            Vector3 creatPosition = new Vector3(Random.Range(-8, -3), Random.Range(-3, 1), 0);
            if (!HasThePosition(creatPosition))
            {
                return creatPosition;
            }
        }
    }

    //�ж����λ���Ƿ��Ѿ���λ���б���
    private bool HasThePosition(Vector3 creatPos)
    {
        for (int i = 0; i < itemPositionList.Count; i++)
        {
            if (creatPos == itemPositionList[i])
            {
                return true;
            }
        }
        return false;//û����ȵ�
    }

   
}
