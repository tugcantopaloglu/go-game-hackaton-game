using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class TrashPickUp : MonoBehaviour
{
    private bool mIsKneel;
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
            mIsKneel = true;
            TriggerItem();
        }
    }

    public void TriggerItem()
    {
        _otherAnimator.Play("kneel");
        parentObject.SetActive(false);

    }
}
