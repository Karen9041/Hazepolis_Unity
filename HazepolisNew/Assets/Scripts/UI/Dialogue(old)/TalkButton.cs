using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TalkButton : MonoBehaviour
{
    public GameObject Button;
    public GameObject DialogUI;

    public QuestGiver questgiver;

    //�a��NpC��ܹ�ܲŸ�
    private void OnTriggerEnter2D(Collider2D other)
    {
        Button.SetActive(true);//DialogUI.SetActive(true);

        DialogueSystem.Instance.currentQuestgiver = questgiver;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Button.SetActive(false);//DialogUI.SetActive(false);

        DialogueSystem.Instance.currentQuestgiver = null;

    }

    void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.T))
        {
            DialogUI.SetActive(true);
            //trigger.StartDialog();

            Debug.Log("Conversation");
            if (this.tag == "Interactable")
            {
                this.GetComponent<Interactable>().Interact();
            }
        }
    }
}
