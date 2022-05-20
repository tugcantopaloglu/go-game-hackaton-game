using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class QuestAppeal : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;
    [SerializeField] private GameObject[] questItems;

    private void Start()
    {

        StartCoroutine(WaitForGameStart());

    }
    private void FixedUpdate()
    {
        if (QuestTake.isQuest1Taken == true)
        {
            buttons[0].transform.DOMoveX(1700, 1);
        }
        if (QuestTake.isQuest2Taken == true)
        {
            buttons[1].transform.DOMoveX(1700, 1);
        }
        if (QuestTake.isQuest3Taken == true)
        {
            buttons[2].transform.DOMoveX(1700, 1);
        }
        if (QuestTake.isQuest4Taken == true)
        {
            buttons[3].transform.DOMoveX(1700, 1);
        }
        if (QuestTake.isQuest1Taken == true && QuestTake.isQuest2Taken == true && QuestTake.isQuest3Taken == true && QuestTake.isQuest4Taken == true)
        {
            buttons[4].transform.DOMoveX(-220, 1);
        }
    }

    IEnumerator WaitForGameStart()
    {
        yield return new WaitForSeconds(3);
        buttons[4].transform.DOMoveX(220, 1);
    }
}
