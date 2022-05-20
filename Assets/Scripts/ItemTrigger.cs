using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ItemTrigger : MonoBehaviour
{

    private Animator _animator;
    [SerializeField] private bool triggerActive = false;
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
            TriggerItem();
        }
    }

    public void TriggerItem()
    {
        _animator.SetBool("open", true);
    }
}
