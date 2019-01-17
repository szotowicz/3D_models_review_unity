using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject Model1;
    public GameObject Model2;
    public GameObject Model3;

    public void SelectModel1()
    {
        Debug.Log("SelectModel1");
    }

    public void SelectModel2()
    {
        Debug.Log("SelectModel2");
    }

    public void SelectModel3()
    {
        Debug.Log("SelectModel3");
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}