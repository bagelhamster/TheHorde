using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public static int currentHealth;
	public GameObject Dead, MainMenu2;
	public HeathBar healthBar;


	// Start is called before the first frame update
	void Start()
	{
		Dead.gameObject.SetActive(false);
		MainMenu2.gameObject.SetActive(false);
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		Time.timeScale = 1;
	}
	 
	// Update is called once per frame
	void Update()
	{

		if (currentHealth <= 0)
		{
			MainMenu2.gameObject.SetActive(true);
			Time.timeScale = 0;
			Dead.gameObject.SetActive(true);
			Cursor.visible = true;
		}
		/*fixes problem with health not updating from external scripts*/
		if (currentHealth >= 1)
			TakeDamage(-1);
		TakeDamage(1);
		/*Health cap*/
		if (currentHealth >= 100)
			currentHealth = 100;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Enemy")
		{
			TakeDamage(20);
			
		}
	}

		void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
