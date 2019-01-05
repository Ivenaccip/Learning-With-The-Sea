using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTextUI : MonoBehaviour {

	public GameObject NumText1;
	public GameObject NumText2;
	
	
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
			NumText2.GetComponent<Text> ().text = "Cereza";
		}

		if (AleNum == 2)
		{
			NumText1.GetComponent<Text> ().text = "Fresa";
			NumText2.GetComponent<Text> ().text = "Frambuesa";
		}

		if (AleNum == 3)
		{
			NumText1.GetComponent<Text> ().text = "Vainilla";
			NumText2.GetComponent<Text> ().text = "Verde";
		}
	}



	
}
