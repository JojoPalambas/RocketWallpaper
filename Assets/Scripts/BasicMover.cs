using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public Vector3 translation;
    public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation * Time.deltaTime);
        transform.Rotate(rotation * Time.deltaTime);
    }
}
