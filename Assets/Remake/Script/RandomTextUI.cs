using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomTextUI : MonoBehaviour {

	public GameObject NumText1;
	public GameObject NumText2;
	public GameObject NumText3;
	public GameObject DSOOobject;

	public GameObject Operations;

	public Button No1;

	public Button No2;

	public Button No3;
	public GameObject NoBut1;
	public GameObject NoBut2;

	public GameObject NoBut3;
	public string Next;



	//When the others buttons will be touched, the start n' other will deactivate

	public bool DSOO;

	public bool change;
	
	public int AleNum;
	
	public void randomGenerator()
	{
		AleNum = Random.Range(1,11);
		

		if (AleNum == 1)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "1";
			NumText2.GetComponent<Text> ().text = "2";
			NumText3.GetComponent<Text> ().text = "3";
			Operations.GetComponent<Text> ().text = "1 + 1";	
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(NoB1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(Si_B1);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(NoB3);
			

		}

		if (AleNum == 2)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "3";
			NumText2.GetComponent<Text> ().text = "4";
			NumText3.GetComponent<Text> ().text = "5";
			Operations.GetComponent<Text> ().text = "2 + 3";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(NoB1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(NoB2);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(Si_B1);
		}

		if (AleNum == 3)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "5";
			NumText2.GetComponent<Text> ().text = "6";
			NumText3.GetComponent<Text> ().text = "7";
			Operations.GetComponent<Text> ().text = "3 + 2";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(Si_B1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(NoB2);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(NoB3);
		}

		if (AleNum == 4)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "7";
			NumText2.GetComponent<Text> ().text = "8";
			NumText3.GetComponent<Text> ().text = "9";
			Operations.GetComponent<Text> ().text = "4 + 4";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(NoB1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(Si_B1);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(NoB3);
		}

		if (AleNum == 5)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "9";
			NumText2.GetComponent<Text> ().text = "1";
			NumText3.GetComponent<Text> ().text = "3";
			Operations.GetComponent<Text> ().text = "1 + 2";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(NoB1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(NoB2);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(Si_B1);
		}

		if (AleNum == 6)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "3";
			NumText2.GetComponent<Text> ().text = "5";
			NumText3.GetComponent<Text> ().text = "7";
			Operations.GetComponent<Text> ().text = "1 + 1 + 1";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(Si_B1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(NoB2);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(NoB3);
		}

		if (AleNum == 7)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "7";
			NumText2.GetComponent<Text> ().text = "9";
			NumText3.GetComponent<Text> ().text = "3";
			Operations.GetComponent<Text> ().text = "7 + 1 + 1";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(NoB1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(Si_B1);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(NoB3);
		}

		if (AleNum == 8)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "3";
			NumText2.GetComponent<Text> ().text = "6";
			NumText3.GetComponent<Text> ().text = "9";
			Operations.GetComponent<Text> ().text = "3 + 3 + 3";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(NoB1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(NoB2);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(Si_B1);
		}

		if (AleNum == 9)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "9";
			NumText2.GetComponent<Text> ().text = "4";
			NumText3.GetComponent<Text> ().text = "8";
			Operations.GetComponent<Text> ().text = "9 + 0";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(Si_B1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(NoB2);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(NoB3);
		}

		if (AleNum == 10)
		{
			DSOO = false;
			NumText1.GetComponent<Text> ().text = "1";
			NumText2.GetComponent<Text> ().text = "5";
			NumText3.GetComponent<Text> ().text = "6";
			Operations.GetComponent<Text> ().text = "1 + 0";
			Button BN_1 = No1.GetComponent<Button>();
			BN_1.onClick.AddListener(Si_B1);
			Button BN_2 = No2.GetComponent<Button>();
			BN_2.onClick.AddListener(NoB2);
			Button BN_3 = No3.GetComponent<Button>();
			BN_3.onClick.AddListener(NoB3);
		}

	}

	public void NoB1()
	{
			DSOO = true;
			if(DSOO == true)
			{
				NoBut1.SetActive (false);
				DSOOobject.SetActive (false);
				change = true;
			}

		
	}

	public void NoB2()
	{
			DSOO = true;
			if(DSOO == true)
			{
				NoBut2.SetActive (false);
				DSOOobject.SetActive (false);
			}
			
	}

	public void NoB3()
	{
			DSOO = true;
			if(DSOO == true)
			{
				NoBut3.SetActive (false);
				DSOOobject.SetActive (false);
			}
			
	}
	

	

	public void Si_B1()
	{
		SceneManager.LoadScene(Next);
	}

}
