using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim = null;
    Rigidbody2D rb;
    float span = 1.0f;
    float delta = 0;
    bool isHit = false;
    string state = "default";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.delta+=Time.deltaTime;
        if(delta >0){
            anim.SetBool("click",false);
        }
        if(this.delta > this.span){
            //anim.SetBool("click",false);
            if(Input.GetButtonDown("Fire1"))swing();
        }
    }
    public void swing(){
        anim.SetBool("click",true);
        this.delta = 0;
    }

    public void Player_HitOn(){
        //Debug.Log("あたる");
        isHit = true;
    }
    public void Player_HitOff(){
        //Debug.Log("あたらない");
        isHit = false;
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(isHit==true){
        Debug.Log(other.gameObject.tag);
            if (other.gameObject.tag == "Tehu1")
            {
                other.gameObject.SetActive(false);
            }
 
        }
    }
}
