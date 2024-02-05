using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircle : MonoBehaviour
{

    [SerializeField] GameObject myCircle;
    [SerializeField] Transform mySpawnPoint;
    [SerializeField] float myCircleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject myClone = Instantiate(myCircle, mySpawnPoint.position, Quaternion.identity) as GameObject;
            myClone.GetComponent<Rigidbody2D>().AddForce(new Vector2(myCircleSpeed,0));
        }
    }
}
