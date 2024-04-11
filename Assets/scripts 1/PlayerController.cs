using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbd;
    public Text t;
    public float forceVal;

    public int count;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 modveDir = new Vector3(h, 0,v );
        rbd.AddForce(modveDir*forceVal); 
    }

    private void OnTriggerEnter(Collider other)
    {
            other.gameObject.SetActive(false);
            count += 5;
            print(count);
            t.text = "得分: " + count;
    } 
} 
 