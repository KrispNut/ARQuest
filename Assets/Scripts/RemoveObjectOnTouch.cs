using UnityEngine;
using System.Collections.Generic;

public class PrefabTouchHandler : MonoBehaviour
{
    public static List<GameObject> Stored_Prefabs = new List<GameObject>();
    public static PrefabTouchHandler instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Store();
    }

    public void Store()
    {
        Stored_Prefabs.Add(gameObject);
        gameObject.SetActive(false);
    }
}
