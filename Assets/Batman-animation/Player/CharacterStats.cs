using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int maxBullet = 20;
    public int currentHeath;
    public int currentBullet;
    public HealthBar healthBar;
    public BulletBar bulletBar;
    public GameObject Batman;
   

    private void Start()
    {
        currentHeath = maxHealth;
        currentBullet = maxBullet;
        healthBar.SetMaxHealth(maxHealth);
        bulletBar.SetMaxBullet(maxBullet);
    }

    public void TakeDamage(int damage)
    {
        currentHeath -= damage;
        healthBar.SetHealth(currentHeath);
        if(currentHeath <=0 )
        {
            Die();
        }
    }
    public virtual void Die()
    {
        Destroy(GameObject.Find("Batman"));
        SceneManager.LoadScene(1);

    }
    public void TakePotion()
    {
        heal();
    }
    public void heal()
    {
        currentHeath += 10;
        currentHeath = Mathf.Min(currentHeath, maxHealth);
        if (healthBar)
        {
            healthBar.SetHealth(currentHeath);
        }
    }
    public void takeBullet()
    {
        currentBullet += 1;
        bulletBar.Setbullet(currentBullet);
    }


}
