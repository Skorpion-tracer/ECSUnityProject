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
    /// ECS ядро
    /// </summary>
    public static IECS iECS;
    public IECSDebug eCSDebug;

    // Start is called before the first frame update
    void Start()
    {
        //ECS.Initialization(GetAssembly.Get(), 11000); //Инициализация ECS
        iECS = ECS.InstanceIECS; //Получим ссылку
        eCSDebug = ECS.InstanceDebug; //Получим ссылку
    }

    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(eCSDebug.GetInfo(true));
    }
}