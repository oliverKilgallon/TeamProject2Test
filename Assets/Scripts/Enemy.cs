using UnityEngine;

public class Enemy : MonoBehaviour {

    private void Start()
    {
        FloatingTextController.Initialize();
    }
    public virtual void TakeDamage(int amount)
    {
        if(gameObject.GetComponent<EnemyHealth>() != null)
            gameObject.GetComponent<EnemyHealth>().DealDamage(amount);
        FloatingTextController.CreateFloatingText(amount.ToString(), transform);
    }
}
