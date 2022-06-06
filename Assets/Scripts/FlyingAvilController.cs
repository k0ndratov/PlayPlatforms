using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingAvilController : MonoBehaviour
{
    public GameObject[] wayPoints;
    int currentWayPoint = 0;
    public float movementSpeed;

    private void Update()
    {
        if (Vector2.Distance(wayPoints[currentWayPoint].transform.position, transform.position) <= .1f)
        {
            currentWayPoint++;
            if (currentWayPoint >= wayPoints.Length)
            {
                currentWayPoint = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Time.deltaTime * movementSpeed);
    }
}
