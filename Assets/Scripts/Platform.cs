using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float speed=-1;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        //transform.Transform(-1, 0, 0);
        //transform.position = transform.position + new Vector3(-1, 0, 0);
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        if (transform.position.x < -10) {
            Destroy(gameObject);
        }

    }
}
