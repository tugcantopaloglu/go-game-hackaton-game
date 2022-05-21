using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class TrashPickUp : MonoBehaviour
{
    public static bool isQuest1Done = false;
    public static int quest1Counter = 0;
    public static bool isQuest3Done = false;
    public static int quest3Counter = 0;
    public static bool isQuest4Done = false;
    public static int quest4Counter = 0;
    private Animator _animator;
    [SerializeField] private bool triggerActive = false;
    public GameObject otherObject;
    private Animator _otherAnimator;
    public GameObject parentObject;




    private void Awake()
    {
        _otherAnimator = otherObject.GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }

    private void Update()
    {
        if (triggerActive && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            StartCoroutine(TriggerItem());
            if (parentObject.CompareTag("Quest1"))
            {
                quest1Counter += 1;
                if (quest1Counter == 10)
                {
                    isQuest1Done = true;
                }
            }
            else if (parentObject.CompareTag("Quest3"))
            {
                quest3Counter += 1;
                if (quest3Counter == 5)
                {
                    isQuest3Done = true;

                }
            }
            else if (parentObject.CompareTag("Quest4"))
            {
                quest4Counter += 1;
                if (quest4Counter == 4)
                {
                    isQuest4Done = true;
                }
            }
        }
    }

    IEnumerator TriggerItem()
    {
        _otherAnimator.Play("kneel");
        PlayerMovementInputController.canMove = false;
        yield return new WaitForSeconds(2);
        PlayerMovementInputController.canMove = true;
        parentObject.SetActive(false);

    }
}
