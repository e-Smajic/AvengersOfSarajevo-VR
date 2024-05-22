using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    private const string OFFICE_SCENE = "OfficeScene";
    public Button switchButton;

    void Start()
    {
        if (switchButton != null)
        {
            switchButton.onClick.AddListener(SwitchScene);
        }
        else
        {
            Debug.LogError("Switch Button is not assigned in the inspector");
        }
    }

    void SwitchScene()
    {
        SceneManager.LoadScene(OFFICE_SCENE);
    }

}
