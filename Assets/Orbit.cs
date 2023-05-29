using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var sun = GameObject.Find("sun");
        this.transform.RotateAround(sun.transform.position, Vector3.forward, 100f * Time.deltaTime);
        this.transform.RotateAround(this.transform.position, Vector3.up, 200f * Time.deltaTime);

    }
}
