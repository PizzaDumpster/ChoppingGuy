using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyWithStick : MonoBehaviour
{

    Animator anim;
    [SerializeField] Animator GrassAnim;
    [SerializeField] ParticleSystem myParticalSystem;
    [SerializeField] bool grassIsLong;
    [SerializeField] GameObject myGrass; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        grassIsLong = true;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] myColliders = Physics2D.OverlapCircleAll(transform.position, 4f); 

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            anim.SetTrigger("Swing");
            foreach(Collider2D collider in myColliders)
            {
                if (collider.CompareTag("myCircle"))
                {
                    Destroy(collider.gameObject); 
                }else if (collider.CompareTag("grass"))
                {
                    if (grassIsLong)
                    {
                        GrassAnim.SetTrigger("Cut");
                        myParticalSystem.Play();
                        myGrass.GetComponent<BoxCollider2D>().enabled = false; 
                        grassIsLong = false; 
                    }
                }
                else
                {
                    Debug.Log("Miss");
                }
                
            }
        }
    }
}
