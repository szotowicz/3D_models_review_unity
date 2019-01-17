using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject Model1;
    public GameObject Model2;
    public GameObject Model3;

    private GameObject SelectedObject;

    public void SelectModel1()
    {
        if (Model1 != null)
        {
            HideModel();
            ShowModel(Model1);
        }
    }

    public void SelectModel2()
    {
        if (Model2 != null)
        {
            HideModel();
            ShowModel(Model2);
        }
    }

    public void SelectModel3()
    {
        if (Model3 != null)
        {
            HideModel();
            ShowModel(Model3);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void RunAnimation1()
    {
        if (SelectedObject != null)
        {
            Debug.Log("Animation1");
        }
    }

    private void HideModel()
    {
        if (SelectedObject != null)
        {
            Destroy(SelectedObject);
        }
    }

    private void ShowModel(GameObject modelToShow)
    {
        if (modelToShow != null)
        {
            SelectedObject = Instantiate(modelToShow, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }
}