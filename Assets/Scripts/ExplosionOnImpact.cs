using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionOnImpact : MonoBehaviour
{
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        Instantiate(explosionPrefab, collision.transform.position, collision.transform.rotation);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger enter");
        Instantiate(explosionPrefab, collision.transform.position, collision.transform.rotation);
        Destroy(gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Trigger stay");
        Instantiate(explosionPrefab, collision.transform.position, collision.transform.rotation);
        Destroy(gameObject);
    }
}
