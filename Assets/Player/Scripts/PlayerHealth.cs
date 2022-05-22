using ScriptableObjectArchitecture;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] FloatReference currentHealth = null;
    [SerializeField] FloatReference maxHealth = null;

    private void Awake()
    {
        currentHealth.Value = maxHealth.Value;
    }

    public void HealthChanged()
    {
        Debug.Log("PlayerHealth::HealthChanged: " + currentHealth.Value);
        if (currentHealth.Value <= 0)
            Destroy(gameObject);
    }
}
