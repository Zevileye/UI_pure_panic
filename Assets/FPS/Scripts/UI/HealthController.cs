using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.FPS.UI
{ 
public class HealthController : MonoBehaviour
{
    public float maxHealth = 100;
    public float Health;
    public float Damage;
    public float Heal;
    void Start()
    {
       
    }
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            Health += Heal;
        }
        if (Input.GetKeyDown("m"))
        {
            Health -= Damage;
        }
        Health = Mathf.Clamp(Health, 0, maxHealth);
    }
    public float UpdateHealthBar()
    {
        return (float)Health / (float)maxHealth;
    }
}
}

