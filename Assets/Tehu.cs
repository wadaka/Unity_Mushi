using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tehu : MonoBehaviour
{
    Rigidbody2D rb;
    float time=0f;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * -80f);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(transform.right * 6f);
    }


}
