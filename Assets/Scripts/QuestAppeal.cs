using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class QuestAppeal : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;
    [SerializeField] private GameObject[] questItems;
    [SerializeField] private GameObject[] lights;

    public static bool isGameOver = false;

    private void Start()
    {

        StartCoroutine(WaitForGameStart());
        RenderSettings.fog = false;
        RenderSettings.fogDensity = 0.1f;

    }
    private void FixedUpdate()
    {
        if (QuestTake.isQuest1Taken == true)
        {
            buttons[0].transform.DOMoveX(1700, 1);
            questItems[0].SetActive(true);
        }
        if (QuestTake.isQuest2Taken == true)
        {
            buttons[1].transform.DOMoveX(1700, 1);
            questItems[1].SetActive(true);
            RenderSettings.fog = true;
            
        }
        if (QuestTake.isQuest3Taken == true)
        {
            buttons[2].transform.DOMoveX(1700, 1);
            questItems[2].SetActive(true);
        }
        if (QuestTake.isQuest4Taken == true)
        {
            buttons[3].transform.DOMoveX(1700, 1);
            questItems[3].SetActive(true);
        }
        if (QuestTake.isQuest1Taken == true && QuestTake.isQuest2Taken == true && QuestTake.isQuest3Taken == true && QuestTake.isQuest4Taken == true)
        {
            buttons[4].transform.DOMoveX(-220, 1);
        }

        if (TrashPickUp.isQuest1Done == true)
        {
            buttons[0].transform.DOMoveX(-1700, 1);
            lights[3].SetActive(true);
        }
        if (ItemTrigger.isQuest2Done == true)
        {
            buttons[1].transform.DOMoveX(-1700, 1);
            lights[2].SetActive(true);
        }
        if (TrashPickUp.isQuest3Done == true)
        {
            buttons[2].transform.DOMoveX(-1700, 1);
            lights[1].SetActive(true);
        }
        if (TrashPickUp.isQuest4Done == true)
        {
            buttons[3].transform.DOMoveX(-1700, 1);
            lights[0].SetActive(true);
        }
        if (TrashPickUp.isQuest1Done == true && ItemTrigger.isQuest2Done == true && TrashPickUp.isQuest3Done == true && TrashPickUp.isQuest4Done == true)
        {
            lights[4].SetActive(true);
            isGameOver = true;
        }

    }

    IEnumerator WaitForGameStart()
    {
        yield return new WaitForSeconds(3);
        buttons[4].transform.DOMoveX(220, 1);

    }

}
