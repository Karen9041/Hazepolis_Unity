using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public string sceneName; //�U�@�ӳ���
    [SerializeField]private string newScenePassword; //�q���K�y

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Eammon.instance.scenePassWord = newScenePassword;
            SceneManager.LoadScene(sceneName); 
        }
    }
}
