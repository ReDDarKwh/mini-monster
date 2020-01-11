using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMask : MonoBehaviour {

    [Range(0.05f,0.2f)]
    public float flicTime;


    [Range(0.02f, 0.09f)]
    public float addSize;

    float timer = 0;
    private bool bigger = true;
    public Transform target;
    public void Update()
    {
        timer += Time.deltaTime;
        if (timer > flicTime)
        {
            if (bigger)
            {
            transform.localScale = new Vector3(transform.localScale.x + addSize, transform.localScale.y + addSize, transform.localScale.z);
            }
            else
            {
            transform.localScale = new Vector3(transform.localScale.x - addSize, transform.localScale.y - addSize, transform.localScale.z);
            }

            timer = 0;
            bigger = !bigger;

        }
        if ( target!=null)
        transform.position = Vector3.MoveTowards(transform.position, target.position, 20 * Time.deltaTime);
            
    }

}
