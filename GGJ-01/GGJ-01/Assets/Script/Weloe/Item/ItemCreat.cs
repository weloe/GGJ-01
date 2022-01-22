using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreat : MonoBehaviour
{
    //装饰初始化地图所需物体的数组
<<<<<<< Updated upstream
    //1.蓝心 2.红心
    public GameObject[] item;
=======
    //1.红心 2.蓝心
    public GameObject[] item;
    
>>>>>>> Stashed changes

    //已经有东西的位置列表
    private List<Vector3> itemPositionList = new List<Vector3>();
    // Start is called before the first frame update
    private void Awake()
    {
        InitMap();//调用
    }

    private void InitMap()
    {
<<<<<<< Updated upstream
              
        //初始化玩家
        
=======

        //初始化玩家

>>>>>>> Stashed changes

        


<<<<<<< Updated upstream
        //实例化地图 
        for (int i = 0; i < 60; i++)
        {
            CreatItem(item[1], CreatRandomPosition(), Quaternion.identity);
        }
        for (int i = 0; i < 20; i++)
        {
            CreatItem(item[2], CreatRandomPosition(), Quaternion.identity);
        }
        for (int i = 0; i < 20; i++)
        {
            CreatItem(item[4], CreatRandomPosition(), Quaternion.identity);
        }
        for (int i = 0; i < 20; i++)
        {
            CreatItem(item[5], CreatRandomPosition(), Quaternion.identity);
        }
=======
        //实例化道具
        //for (int i = 0; i < 60; i++)
        //{
        //    CreatItem(item[0], CreatRandomPosition(-9,10,-7,8), Quaternion.identity);
        //}
        //for (int i = 0; i < 20; i++)
        //{
        //    CreatItem(item[1], CreatRandomPosition(-9, 10, -7, 8), Quaternion.identity);
        //}

>>>>>>> Stashed changes
    }

    void Start()
    {
<<<<<<< Updated upstream

=======
        
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {

    }
<<<<<<< Updated upstream
=======

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



>>>>>>> Stashed changes
    private void CreatItem(GameObject createGameObject, Vector3 creatPosition, Quaternion creatRotation)
    {
        GameObject itemGo = Instantiate(createGameObject, creatPosition, creatRotation);
        itemGo.transform.SetParent(gameObject.transform);//把当前物体设为父级
        itemPositionList.Add(creatPosition);
    }

    //产生随机位置的方法
    private Vector3 CreatRandomPosition()
    {
        
        while (true)
        {
<<<<<<< Updated upstream
            Vector3 creatPosition = new Vector3(Random.Range(-9, 10), Random.Range(-7, 8), 0);
=======
            Vector3 creatPosition = new Vector3(Random.Range(-8, -3), Random.Range(-3, 1), 0);
>>>>>>> Stashed changes
            if (!HasThePosition(creatPosition))
            {
                return creatPosition;
            }
        }
    }

    //判断这个位置是否已经在位置列表里
    private bool HasThePosition(Vector3 creatPos)
    {
        for (int i = 0; i < itemPositionList.Count; i++)
        {
            if (creatPos == itemPositionList[i])
            {
                return true;
            }
        }
        return false;//没有相等的
    }

   
}
