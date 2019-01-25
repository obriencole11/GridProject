using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MovableObject
{
    void Awake()
    {
        base.Awake();
        GameManager.Instance.playerObjects.Add(this);
    }
}
