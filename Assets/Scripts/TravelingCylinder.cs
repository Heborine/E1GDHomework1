using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelingCylinder : MonoBehaviour
{
    // The light component moves with it

    Vector3 startPos = new Vector3(5, 2, -1);
    Vector3 midPos = new Vector3(0, 7, -2);
    Vector3 endPos = new Vector3(-5, 2, -1);

    Vector3 nextPos;
    Vector3 oppNextPos;

    int peaked = 0;

    public float speed = 1.0f;
    Transform child;


    // Start is called before the first frame update
    void Start()
    {
        nextPos = midPos;
        Debug.Log("Starting TravelingCylinder");
        child = transform.GetChild(0);
        Debug.Log("Starting StrangleCapsule");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        // The child has a strange flip of movement compared to the original by -1
        child.position = Vector3.MoveTowards(child.position, oppNextPos, speed * Time.deltaTime);

        if(transform.position == nextPos){
            if (nextPos == startPos || nextPos == endPos)
            {
                nextPos = midPos;
                oppNextPos = -midPos;
            }
            else if(nextPos == midPos)
            {
                if(peaked % 2 == 0)
                {
                    nextPos = endPos;
                    oppNextPos = -startPos;
                }
                else
                {
                    nextPos = startPos;
                    oppNextPos = -endPos;
                }
                peaked++;
                Debug.Log($"Reached the top {peaked} times!");
            }
            // else if(nextPos == endPos)
            // {
            //     nextPos = midPos;
            //     oppNextPos = -midPos;
            // }
        }
    }
}
