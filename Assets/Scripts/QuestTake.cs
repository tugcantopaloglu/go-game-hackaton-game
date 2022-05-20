using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTake : MonoBehaviour
{
    public static bool isQuest1Taken = false;
    public static bool isQuest2Taken = false;
    public static bool isQuest3Taken = false;
    public static bool isQuest4Taken = false;
    public GameObject parent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (parent.CompareTag("Quest1"))
            {
                isQuest1Taken = true;
                Debug.Log(isQuest1Taken);
            }
            else if (parent.CompareTag("Quest2"))
            {
                isQuest2Taken = true;
            }
            else if (parent.CompareTag("Quest3"))
            {
                isQuest3Taken = true;
            }
            else if (parent.CompareTag("Quest4"))
            {
                isQuest4Taken = true;
            }

        }
    }
}
