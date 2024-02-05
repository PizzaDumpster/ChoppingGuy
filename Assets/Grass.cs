using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour, ICutable
{
    public GameObject grass;
    public Animator animator;
    public ParticleSystem myParticleSystem;
    public bool grassIsLong; 

    private void Start()
    {
        grassIsLong = true;
        animator = GetComponent<Animator>();
    }

    public void Cut()
    {
        CutGrass();
    }

    private void CutGrass()
    {
        animator.SetTrigger("Cut");
        myParticleSystem.Play();
        grass.GetComponent<BoxCollider2D>().enabled = false;
        grassIsLong = false;
    }
}
