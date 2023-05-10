using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public string sceneName; //�U�@�ӳ���
    [SerializeField] private bool isLocked; //�q���K�y
    [SerializeField]private string newScenePassword; //�q���K�y
    [SerializeField] private string KeyPassword; //�q���K�y

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if (isLocked)
            {
                if (KeyPassword == Eammon.instance.KeyPassword)
                {
                    Eammon.instance.scenePassWord = newScenePassword;
                    SceneManager.LoadScene(sceneName);
                }
            }
            else
            {
                Eammon.instance.scenePassWord = newScenePassword;
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
