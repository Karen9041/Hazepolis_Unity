using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestNameButton : MonoBehaviour
{
    public Text questNameText;
    public Text questBtnName;
    public Quest currentData;
    public Text questContentText;
    public Text questRequirement;
    public Text questReward;

    public void SetupNameButton(Quest  quesData)
    {
        currentData = quesData;

        //if (quesData.isComplete)
            questNameText.text = quesData.QuestName + "(����)";
        //else
            questNameText.text = quesData.QuestName;
    }

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(UpdateQuestContent);
    }
    void UpdateQuestContent()
    {
        questContentText.text = currentData.Description;
        questNameText.text = currentData.QuestName;
        questBtnName.text = currentData.QuestName;

        questReward.text = currentData.QuestReward;
        questRequirement.text = currentData.QuestRequire;
        //QuestUI.Instance.SetupRequireList(currentData);

        //foreach (Transform item in QuestUI.Instance.rewardTransform)
        //{
        //    Destroy(item.gameObject);
        //}


        //foreach (var item in currentData.rewards)//���y�i�ण��@�өҥH�ݭn�`���C��
        //{
        //    QuestUI.Instance.SetupRewardItem(item.itemData, item.amount);
        //}
    }
}