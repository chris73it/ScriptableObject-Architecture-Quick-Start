using ScriptableObjectArchitecture;
using UnityEngine;

public class PlayerHealth1 : MonoBehaviour
{
    [SerializeField] FloatReference currentHealth = null;

    private void Awake()
    {
        Debug.Log("PlayerHealth1::Awake");
        currentHealth.Value = 10;
    }
}
