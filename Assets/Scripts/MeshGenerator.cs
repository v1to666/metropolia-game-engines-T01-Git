using System.Collections;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{
    [SerializeField] private Transform _prefab;

    private void Start()
    {
        StartCoroutine(Generate());
    }

    private IEnumerator Generate()
    {
        while (true)
        {
            Instantiate(_prefab);

            yield return new WaitForSeconds(1f);
        }
    }
}
