using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour {

 	float timeBeforeChange;
    public float speed = 3;
    public float delay = .75f;

	 public Rigidbody2D P1;

	  public Animator Pez1;
	// Use this for initialization
	void Start () {
		P1 = GetComponent<Rigidbody2D>();
		Pez1 = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		P1.velocity = Vector2.right * speed;

		 if (speed > 0)
            {
               Pez1.SetBool("Vuelta", false);
              
            }
        else if (speed < 0)
           {
               Pez1.SetBool("Vuelta", true);
              
           }
        if (timeBeforeChange < Time.time)
        {
            speed *= -1;
            timeBeforeChange = Time.time + delay;
        }
	}
}
