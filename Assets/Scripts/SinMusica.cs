using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMusica : MonoBehaviour {

	public static SinMusica Canciones;


	void Awake(){
		if (Canciones == null)
		{
			Destroy(gameObject);
			
		}
		else if (Canciones != null)
		{
			Canciones = this;
			DontDestroyOnLoad(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
				
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	

	}
