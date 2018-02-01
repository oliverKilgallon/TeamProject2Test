using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

    public float MaxHealth { get; set; }
    public float CurrentHealth { get; set; }
    
	void Start ()
    {
        MaxHealth = 100f;
        CurrentHealth = MaxHealth;	
	}

    public void DealDamage(float amount)
    {
        if (CurrentHealth - amount > 0)
            CurrentHealth -= amount;
        else
            CurrentHealth = 0;
        gameObject.GetComponentInChildren<Slider>().value = CurrentHealth / MaxHealth;
    }
}
