using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform referencePoint;
    private GameObject lastCreatedPlatfrom;
    // Start is called before the first frame update
    void Start()
    {
        lastCreatedPlatfrom = Instantiate(platformPrefab, referencePoint.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        if (lastCreatedPlatfrom.transform.position.x < 0) {
            lastCreatedPlatfrom = Instantiate(platformPrefab, referencePoint.position, Quaternion.identity);
        }
    }
}