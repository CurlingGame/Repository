using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour


{

    public void OnClickGameStart()
    {
        Debug.Log("���� ����");
        SceneManager.LoadScene("Main Scene");

    }
    public void OnClickGameRule()
    {
        Debug.Log("���� ���");
    }
    public void OnClickGameSetting()
    {
        Debug.Log("ȯ�� ����");
    }
    public void OnClickGameQuit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }







}
