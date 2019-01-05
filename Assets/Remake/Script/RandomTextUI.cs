using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTextUI : MonoBehaviour {

	public GameObject NumText1;
	public GameObject NumText2;
	public GameObject NumText3;
	public GameObject DSOOobject;

	public Button No1;

	public Button No2;
	public GameObject NoBut1;
	public GameObject NoBut2;

	//When the others buttons will be touched, the start n' other will deactivate

	public bool DSOO;
	
	public int AleNum;
	
	public void randomGenerator()
	{
		AleNum = Random.Range(1,4);
		

		if (AleNum == 1)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "Chocolate";
			NumText2.GetComponent<Text> ().text = "Cereza";
			NumText3.GetComponent<Text> ().text = "Cono";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(NoB1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(ONoB1);
			

		}

		if (AleNum == 2)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "Fresa";
			NumText2.GetComponent<Text> ().text = "Frambuesa";
			NumText3.GetComponent<Text> ().text = "Barquillo";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(NoB2);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(ONoB2);
		}

		if (AleNum == 3)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "Vainilla";
			NumText2.GetComponent<Text> ().text = "Verde";
			NumText3.GetComponent<Text> ().text = "Vaso";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(NoB3);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(ONoB2);
		}

	}

	public void NoB1()
	{
			DSOO = true;
			if(DSOO == true)
			{
				NoBut1.SetActive (false);
				DSOOobject.SetActive (false);
			}
			
	}
	public void NoB2()
	{
			DSOO = true;
			if(DSOO == true)
			{
			NoBut1.SetActive (false);
			DSOOobject.SetActive (false);
			}
	}
	public void NoB3()
	{
			DSOO = true;
			if(DSOO == true)
			{
			NoBut1.SetActive (false);
			DSOOobject.SetActive (false);
			}
	}

	public void ONoB1()
	{
			DSOO = true;
			if(DSOO == true)
			{
			NoBut2.SetActive (false);
			DSOOobject.SetActive (false);
			}
	}

	public void ONoB2()
	{
			DSOO = true;
			if(DSOO == true)
			{
			NoBut2.SetActive (false);
			DSOOobject.SetActive (false);
			}
	}

	public void ONoB3()
	{
			DSOO = true;
			if(DSOO == true)
			{
			NoBut2.SetActive (false);
			DSOOobject.SetActive (false);
			}
	}
}
