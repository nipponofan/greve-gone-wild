using UnityEngine;
using System.Collections;


public class canCollisionWithPlayer : MonoBehaviour
{
    Animator anim;
	


    void Start()
    {
        anim = GetComponent<Animator>();
        Debug.Log(anim);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player") {
            anim.Play("canCrush");
                
    }
	if (other.tag == "can") {
	Debug.Log("power-up");
}
}
}
