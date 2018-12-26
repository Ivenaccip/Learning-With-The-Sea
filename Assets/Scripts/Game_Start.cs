using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Start : MonoBehaviour {

    public Button No1;
//    public Button No2;
 //   public Button Si;

   

//    public SceneChanger sceneChanger;

    // Use this for initialization
    void Start () {
        Button BN_1 = No1.GetComponent<Button>();
        BN_1.onClick.AddListener(TaskOnBN1);
//        Button BN_2 = No1.GetComponent<Button>();
//        BN_2.onClick.AddListener(TaskOnBN2);
//        Button BS = No1.GetComponent<Button>();
//        BS.onClick.AddListener(TaskOnBS);

      
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TaskOnBN1()
    {
        gameObject.SetActive(false);
        
        
    }
  
   
    }

    
