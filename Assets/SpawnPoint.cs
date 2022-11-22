using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject obsPre; 
    [SerializeField] float minTime;
    [SerializeField] float maxTime;


    private void Start()
    {
        StartCoroutine(delaySpawn()); 
    }
    IEnumerator delaySpawn()
    {
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        Instantiate(obsPre, transform.position, Quaternion.identity);
        StartCoroutine(delaySpawn()); 
    }
}
