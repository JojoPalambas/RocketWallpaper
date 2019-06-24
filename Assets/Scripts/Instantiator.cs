using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InstantiationParameters
{
    public GameObject prefab;
    private GameObject parent;

    public float ySummonRadius;

    public float minInterval;
    public float maxInterval;
    
    private float coolDown;

    public void Start(GameObject parent)
    {
        this.parent = parent;
        coolDown = Random.Range(minInterval, maxInterval);
    }

    public void Frame()
    {
        coolDown -= Time.deltaTime;
        if (coolDown < 0)
        {
            coolDown = Random.Range(minInterval, maxInterval);
            GameObject.Instantiate(
                prefab,
                new Vector3(parent.transform.position.x, parent.transform.position.y + Random.Range(-ySummonRadius, ySummonRadius), parent.transform.position.z),
                new Quaternion());
        }
    }
}

public class Instantiator : MonoBehaviour
{
    public List<InstantiationParameters> instantiators;

    // Start is called before the first frame update
    void Start()
    {
        foreach (InstantiationParameters ip in instantiators)
        {
            ip.Start(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (InstantiationParameters ip in instantiators)
        {
            ip.Frame();
        }
    }
}
