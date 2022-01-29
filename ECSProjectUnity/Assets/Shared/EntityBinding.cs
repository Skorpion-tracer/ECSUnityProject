using ECSCore.BaseObjects;
//using Game.Components;
//using Game.Entitys;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBinding : MonoBehaviour
{
    Entity entity;
    //Pozition pozition;

    // Start is called before the first frame update
    void Start()
    {
        //entity = ECSWorld.iECS.AddEntity(new Ship());
        //entity.Add(new ShipAi());
        //entity.Add(new Pozition() { X = this.gameObject.transform.position.x, Y = this.gameObject.transform.position.y, Z = this.gameObject.transform.position.z });
        //entity.Add(new Direction() { XNorm = 1, YNorm = 0, ZNorm = 0 });
        //entity.Add(new PozitionSV() { X = 10000, Y = 10000, Z = 10000 });
        //entity.Add(new Enargy() { EnargyFact = 1000, EnargyMax = 10000 });
        //entity.Add(new Health() { HealthFact = 500, HealthMax = 1000 });
        //entity.Add(new Speed() { dX = 0.1f, dY = 0.1f, dZ = 0.1f });

        //entity.Get(out pozition);
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.position = new Vector3(pozition.X, pozition.Y, pozition.Z);
    }
}
