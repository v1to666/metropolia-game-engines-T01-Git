using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class MeshGenerator : MonoBehaviour
{
    [SerializeField] private Transform _prefab;
    [SerializeField] private InputAction spawnAction;

    private void Start()
    {
        spawnAction = InputSystem.actions.FindAction("Jump");
        StartCoroutine(Generate());
    }

    private void Update()
    {
        if (spawnAction.IsPressed())
        {
            Instantiate(_prefab);
        }
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
