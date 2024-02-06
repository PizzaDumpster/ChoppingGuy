using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutCircle : MonoBehaviour, ICutable
{
    public void Cut()
    {
        Destroy(gameObject);
    }
}
