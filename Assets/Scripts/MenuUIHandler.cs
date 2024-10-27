
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;

    public void NewColorSelected(Color color)
    {
        MainManager.Instance.TeamColor = color;
    }
    
    private void Start()
    {
        ColorPicker.Init();
        ColorPicker.onColorChanged += NewColorSelected;
        ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        MainManager.Instance.SaveColor();
        EditorApplication.ExitPlaymode();
        Application.Quit();
    }

    public void SaveColorClicked()
    {
        MainManager.Instance.SaveColor();
    }

    public void LoadColorClicked()
    {
        MainManager.Instance.LoadColor();
        ColorPicker.SelectColor(MainManager.Instance.TeamColor);

    }
}
