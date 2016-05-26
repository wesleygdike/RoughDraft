using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Attributes : MonoBehaviour {

    public int MaxHealth, CurrentHealth, MaxEnergy, CurrentEnergy, HealthRegn, EnergyRegn;
    public Slider HealthSlider, EnergySlider;
    public float RegnTimer = 3f;

    //public int EnergyRegn, HealthRegn;

	// Use this for initialization
	void Start () {
        HealthSlider.value = CurrentHealth;
        EnergySlider.value = CurrentEnergy;

        InvokeRepeating("Regn", RegnTimer, RegnTimer);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
        HealthSlider.value = CurrentHealth;

        if (CurrentHealth >= 0)
        {
            Debug.Log("Player Dead");
        }
    }

    public void UseEnergy(int Expend)
    {
        CurrentEnergy -= Expend;
        EnergySlider.value = CurrentEnergy;
    }

    private void Regn()
    {
        if (CurrentHealth + HealthRegn < MaxHealth)
        {
            CurrentHealth += HealthRegn;
            HealthSlider.value = CurrentHealth;
        }

        if (CurrentEnergy + EnergyRegn < MaxEnergy)
        {
            CurrentEnergy += EnergyRegn;
            EnergySlider.value = CurrentEnergy;
        }
    }
}
