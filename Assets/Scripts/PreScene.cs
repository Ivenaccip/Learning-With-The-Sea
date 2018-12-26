using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PreScene : MonoBehaviour {

    public Button Fa;
    public Button Di;

    public Animator Fac;
    public Animator Dif;

    public string sceneFac;
    public string sceneDif;

    // Use this for initialization
    void Start () {
        Button Bf_1 = Fa.GetComponent<Button>();
        Bf_1.onClick.AddListener(TaskOnFac);
        Button Bd_2 = Di.GetComponent<Button>();
        Bd_2.onClick.AddListener(TaskOnDif);
    }

    public void TaskOnDif()
    {
        Dif.SetTrigger("Dif");
        StartCoroutine(DifCo());
    }

    public void TaskOnFac()
    {
        Fac.SetTrigger("Fac");
        StartCoroutine(FacCo());
    }

    IEnumerator FacCo()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneFac);
    }

    IEnumerator DifCo()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneDif);
    }
}
