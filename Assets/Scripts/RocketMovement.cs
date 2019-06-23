using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public bool isPlayer;

    public float curveAmplitude;
    public float curveFrequency;

    public float xSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer)
        {
            transform.position = new Vector3(transform.position.x + xSpeed * Time.deltaTime, Mathf.Sin(Time.time * curveFrequency) * curveAmplitude, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + xSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
