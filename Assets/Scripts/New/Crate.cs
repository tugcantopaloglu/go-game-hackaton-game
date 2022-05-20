using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : InteractableItemBase {

    private bool mIsOpen = false;

    public override void OnInteract()
    {
        InteractText = "F'ye basın ";

        mIsOpen = !mIsOpen;
        InteractText += mIsOpen ? "kapamak için" : "açmak için";

        GetComponent<Animator>().SetBool("open", mIsOpen);
    }
}
