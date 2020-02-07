using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerEnemyCollision : MonoBehaviour
{
	 public Animator anim;
	 public GameObject player;
	[SerializeField] private Transform Player;
	[SerializeField] private Transform respawnPoint;


    // Start is called before the first frame update
    void Start()
    {
          anim = GetComponent<Animator>();
         
    }


    // Update is called once per frame
  void OnTriggerEnter2D(Collider2D other)
    {
       	if(other.tag == "enemy") {
       		anim.Play("playerDeath");
		anim.SetBool("isdead", true);
	//if (other.gameObject.tag == "player") {
        //Destroy(other.gameObject);
       
	if(anim.GetBool("isdead")== true){
		
		//Application.LoadLevel("level2");
Player.transform.position = respawnPoint.transform.position;
	}

	}}
}



