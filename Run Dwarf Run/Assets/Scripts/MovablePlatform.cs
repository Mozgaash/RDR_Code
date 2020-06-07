using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MovablePlatform : MonoBehaviour
{

    public Transform target;
    public float speed;

    private Vector3 startPos, endPos;

    void Start()
    {
        if (target != null)
        {
            target.parent = null;
            startPos = transform.position;
            endPos = target.position;
        }
    }


    private void FixedUpdate()
    {
        if(target != null)
        {
            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);
        }

        if(transform.position == target.position)
        {
            target.position = (target.position == startPos) ? endPos : startPos;
        }
    }
}
