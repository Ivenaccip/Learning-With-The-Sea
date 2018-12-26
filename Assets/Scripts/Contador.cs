using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

	public static int BotonesMal = 0;
	//Text BotonesText;

	public Button No;
	public Button Nop;

	


	// Use this for initialization
	void Start () {
	
	BotonesMal = 0;
	//BotonesText = GameObject.Find("BotonesMalText").GetComponent<Text>();
	Button No1 = No.GetComponent<Button>();
	No1.onClick.AddListener(NoCount1);
	Button No2 = Nop.GetComponent<Button>();
	No2.onClick.AddListener(NoCount1);
	}



	// Update is called once per frame
	public static void NoCount1()
	{	
		
		BotonesMal = BotonesMal +1;
		//BotonesText.text = BotonesMal.ToString();
		Debug.Log(BotonesMal);
		
		
		
	}

}
