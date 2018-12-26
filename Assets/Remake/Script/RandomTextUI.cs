using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTextUI : MonoBehaviour {

	public GameObject NumText1;
	
	
	public int AleNum;
	

	// Use this for initialization
	void Start () {
        
		}
	
	// Update is called once per frame
	public void randomGenerator()
	{
		AleNum = Random.Range(1,4);
		

		if (AleNum == 1)
		{
			
			NumText1.GetComponent<Text> ().text = "Chocolate";
		}

		if (AleNum == 2)
		{
			NumText1.GetComponent<Text> ().text = "Fresa";
		}

		if (AleNum == 3)
		{
			NumText1.GetComponent<Text> ().text = "Vainilla";
		}
	}



	
}
