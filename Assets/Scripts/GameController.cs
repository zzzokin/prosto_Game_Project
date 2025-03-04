using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController GetInstance() => instance;

    // ������ �� �������� ����������
    private DemonDataBase demonDataBase;
    [SerializeField] private GameObject firstWindow;
    [SerializeField] private MainUIController mainUIController;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        firstWindow.SetActive(true);
        demonDataBase = this.GetComponent<DemonDataBase>();
    }

    public void SwitchWindow(GameObject toOpen, GameObject toClose)
    {
        toOpen.SetActive(true);
        toClose.SetActive(false);
    }

    public DemonDataBase GetDemonDataBase() => demonDataBase;
    public MainUIController GetMainUIController() => mainUIController;
}
