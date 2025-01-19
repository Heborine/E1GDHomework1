using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCube : MonoBehaviour
{

    public float minRotSp = 2f;
    public float maxRotSp = 15f;

    private Vector3 rotSp;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting LightCube");
        rotSp = new Vector3(Random.Range(minRotSp, maxRotSp),Random.Range(minRotSp, maxRotSp),Random.Range(minRotSp, maxRotSp));
    }

    // Update is called once per frame
    void Update()
    {
        // rotate
        transform.Rotate(rotSp * Time.deltaTime);
    }
}
