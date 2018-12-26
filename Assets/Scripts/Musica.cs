using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour {

	public static Musica Canciones;
	 

	void Awake(){
		if (Canciones == null)
		{
			Canciones = this;
			DontDestroyOnLoad(gameObject);
		}
		else if (Canciones != null)
		{
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
