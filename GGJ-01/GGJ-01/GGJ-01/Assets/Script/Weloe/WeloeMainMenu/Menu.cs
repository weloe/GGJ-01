using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenu;
    


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void UIEnabled()
    {
        //Ŀ¼��ʽ�ҵ��ļ�,�ַ��ͷ�ʽ��
        GameObject.Find("Canvas/MainMenu/UI").SetActive(true);

    }

    //��ͣ
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;//����ʱ�����
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;//�ָ�����
    }
}
