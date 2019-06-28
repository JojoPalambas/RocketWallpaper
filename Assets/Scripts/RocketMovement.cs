using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public GameObject followingCamera;
    public GameObject background;

    public bool isPlayer;

    public float curveAmplitude;
    public float curveFrequency;

    public float xSpeed;

    public Animator headAnimator;
    public float minHeadAnimationInterval;
    public float maxHeadAnimationInterval;
    private float headAnimationCooldown;

    // Start is called before the first frame update
    void Start()
    {
        headAnimator.SetBool("open", false);
        headAnimationCooldown = Random.Range(minHeadAnimationInterval, maxHeadAnimationInterval);
    }

    // Update is called once per frame
    void Update()
    {
        headAnimationCooldown -= Time.deltaTime;
        if (headAnimationCooldown < 0)
        {
            headAnimator.SetBool("open", !headAnimator.GetBool("open"));
            headAnimationCooldown = Random.Range(minHeadAnimationInterval, maxHeadAnimationInterval);
        }

        if (isPlayer)
        {
            transform.position = new Vector3(transform.position.x + xSpeed * Time.deltaTime, Mathf.Sin(Time.time * curveFrequency) * curveAmplitude, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + xSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if (background != null)
            background.transform.position = new Vector3(transform.position.x, background.transform.position.y, background.transform.position.z);
        if (followingCamera != null)
            followingCamera.transform.position = new Vector3(transform.position.x, followingCamera.transform.position.y, followingCamera.transform.position.z);
    }
}
