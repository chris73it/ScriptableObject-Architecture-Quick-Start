using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    [SerializeField] Image fillImage = null;
    [SerializeField] FloatReference currentHealth = null;
    [SerializeField] FloatReference maxHealth = null;

    //private void Update()
    //{
    //    fillImage.fillAmount = currentHealth.Value / maxHealth.Value;
    //}

    public void UpdateHealthBar()
    {
        Debug.Log("HealthBarManager::UpdateHealthBar " + currentHealth.Value);
        fillImage.fillAmount = currentHealth.Value / maxHealth.Value;
    }
}
