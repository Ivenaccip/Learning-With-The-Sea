using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartOrOther : MonoBehaviour {

	public Button SOO;
	public GameObject ChangeStart;
	// Use this for initialization
	void Start () {
		Button B_SOO = SOO.GetComponent<Button> ();
		B_SOO.onClick.AddListener(TaskOnSOO);

	}

	public void TaskOnSOO()
	{
		ChangeStart.GetComponent<Text> ().text = "Other";
	}
}
