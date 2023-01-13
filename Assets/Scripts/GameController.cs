using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController GetInstance() => instance;

    [SerializeField] private GameObject firstWindow;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Instantiate(firstWindow, firstWindow.transform.position, firstWindow.transform.rotation);
    }

    public void SwitchWindow(GameObject currentWindow, GameObject newWindow)
    {
        Destroy(currentWindow);
        Instantiate(newWindow, newWindow.transform.position, newWindow.transform.rotation);
    }
}
