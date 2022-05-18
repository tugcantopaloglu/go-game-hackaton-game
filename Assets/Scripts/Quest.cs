using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quest : MonoBehaviour
{
    
    public GameObject questItem;
    public GameObject completedColor;
    public GameObject activeColor;

    public QuestArrow arrow;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            FinishQuest();
            Destroy(gameObject);
        }
    }

    void FinishQuest(){
        questItem =completedColor;
    }
}
