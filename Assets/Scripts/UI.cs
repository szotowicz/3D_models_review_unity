using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject Model1;
    public GameObject Model2;
    public GameObject Model3;
    public Animator AnimatorModel1;
    public Animator AnimatorModel2;
    public Animator AnimatorModel3;
    public Slider AnimationSpeedSlider;

    private GameObject SelectedObject;

    public void SelectModel1()
    {
        if (Model1 != null)
        {
            HideCurrentModel();
            ShowModel(Model1);
        }
    }

    public void SelectModel2()
    {
        if (Model2 != null)
        {
            HideCurrentModel();
            ShowModel(Model2);
        }
    }

    public void SelectModel3()
    {
        if (Model3 != null)
        {
            HideCurrentModel();
            ShowModel(Model3);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void RunAnimation0()
    {
        RunAnimation(0);
    }

    public void RunAnimation1()
    {
        RunAnimation(1);
    }

    public void RunAnimation2()
    {
        RunAnimation(2);
    }

    private void HideCurrentModel()
    {
        if (SelectedObject != null)
        {
            SelectedObject.SetActive(false);
        }
    }

    private void ShowModel(GameObject modelToShow)
    {
        if (modelToShow != null)
        {
            SelectedObject = modelToShow;
            SelectedObject.SetActive(true);
        }
    }

    public void RunAnimation(int animation)
    {
        if (SelectedObject != null)
        {
            if (SelectedObject == Model1 && AnimatorModel1.isActiveAndEnabled)
            {
                AnimatorModel1.SetInteger("value", animation);
                AnimatorModel1.speed = AnimationSpeedSlider.value;
            }
            else if (SelectedObject == Model2 && AnimatorModel2.isActiveAndEnabled)
            {
                AnimatorModel2.SetInteger("value", animation);
                AnimatorModel2.speed = AnimationSpeedSlider.value;
            }
            else if (SelectedObject == Model3 && AnimatorModel3.isActiveAndEnabled)
            {
                AnimatorModel3.SetInteger("value", animation);
                AnimatorModel3.speed = AnimationSpeedSlider.value;
            }
        }
    }
}