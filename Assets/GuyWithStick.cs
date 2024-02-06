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
            TouchedBySword();
        }
    }

    private void TouchedBySword()
    {
        Collider2D[] myColliders = Physics2D.OverlapCircleAll(transform.position, 4f);
        if (myColliders != null)
        {
            foreach (Collider2D collider in myColliders)
            {
                collider.gameObject.GetComponent<ICutable>().Cut();
            }
        }
    }
}
