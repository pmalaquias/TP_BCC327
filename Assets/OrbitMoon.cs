using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMoon : MonoBehaviour
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
        var sun = GameObject.Find("Earth");
        this.transform.RotateAround(sun.transform.position, Vector3.forward, speed * Time.deltaTime);
        this.transform.RotateAround(this.transform.position, Vector3.up, 200f * Time.deltaTime);

    }
}
