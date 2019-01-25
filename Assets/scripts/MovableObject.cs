using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BaseObject))]
[RequireComponent(typeof(GridObject))]
public class MovableObject : MonoBehaviour
{

    public GridObject gridObject;
    public BaseObject baseObject;

    protected void Awake()
    {
        baseObject = GetComponent<BaseObject>();
        gridObject = GetComponent<GridObject>();
        GameManager.Instance.movableObjects.Add(this);
    }
}
