using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ItemTrigger : MonoBehaviour
{
    private bool mIsOpen;
    private Animator _animator;
    [SerializeField] private bool triggerActive = false;

    private int isBoxClosed = 0;
    private void Start()
    {
        _animator = GetComponentInParent<Animator>();
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
            mIsOpen = !mIsOpen;
            TriggerItem();
            isBoxClosed += 1;
        }
    }

    public void TriggerItem()
    {
        if (isBoxClosed == 0)
        {
            _animator.SetBool("open", mIsOpen);

        }
        else if (isBoxClosed == 1)
        {
            _animator.SetBool("open", mIsOpen);
            RenderSettings.fog = false;
        }


    }
}
