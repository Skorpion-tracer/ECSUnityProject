using ECSCore;
using ECSCore.BaseObjects;
using ECSCore.Interfaces;
//using Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECSWorld : MonoBehaviour
{
    /// <summary>
    /// ECS ����
    /// </summary>
    public static IECS iECS;
    public IECSDebug eCSDebug;

    // Start is called before the first frame update
    void Start()
    {
        //ECS.Initialization(GetAssembly.Get(), 11000); //������������� ECS
        iECS = ECS.InstanceIECS; //������� ������
        eCSDebug = ECS.InstanceDebug; //������� ������
    }

    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(eCSDebug.GetInfo(true));
    }
}