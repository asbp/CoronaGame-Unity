using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusGenerator : MonoBehaviour
{
    public GameObject virus;
    public float minTime, maxTime;
    public float minPos, maxPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(VirusSpawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator VirusSpawn()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(minPos, maxPos), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        StartCoroutine(VirusSpawn());
    }
}
