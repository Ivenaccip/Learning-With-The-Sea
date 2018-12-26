using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Yas : MonoBehaviour {

    public Button BS;

	public string Next;

    // Use this for initialization
    void Start () {
        Button BS_1 = BS.GetComponent<Button>();
        BS_1.onClick.AddListener(TaskOnBN1);
    }

    public void TaskOnBN1()
    {
       SceneManager.LoadScene(Next); 
    }
  
   
    }

