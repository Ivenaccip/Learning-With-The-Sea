using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Casita : MonoBehaviour {
	 

	public Button X; 
	public string Escena;
	
	// Use this for initialization
	void Start () {
		Button Back = X.GetComponent<Button>();
		Back.onClick.AddListener(TaskOnX);
	}
	
	// Update is called once per frame
	public void TaskOnX()
	{
		SceneManager.LoadScene(Escena);
	}

}
