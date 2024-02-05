using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyWithStick : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetTrigger("Swing");
            GameObject getCutable = TouchedBySword();
            if (getCutable != null)
            {

                var interactable = TouchedBySword().GetComponent<ICutable>();
                if (interactable == null) return;
                interactable.Cut();
            }
        }
        else
        {
            return;
        }

    }

    private GameObject TouchedBySword()
    {
        Collider2D[] myColliders = Physics2D.OverlapCircleAll(transform.position, 4f);
        if (myColliders != null)
        {
            foreach (Collider2D collider in myColliders)
            {
                if (collider.CompareTag("myCircle"))
                {
                    return collider.gameObject;
                }
                else if (collider.CompareTag("grass"))
                {
                    return collider.gameObject;
                }
                return collider.gameObject;
            }
        }
        return null;
    }
}
