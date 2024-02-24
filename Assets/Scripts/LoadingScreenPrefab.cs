using UnityEngine;

public class DisplayPrefabOnScreen : MonoBehaviour
{
    [SerializeField]
    public GameObject prefab;

    private void Start()
    {
        Instantiate(prefab);
    }
}
