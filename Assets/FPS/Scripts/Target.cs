
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
  public float health = 50f;
  
  public Slider healthBar;
  
  private void Update(){
  	
  	healthBar.value = health;
  }
  public void TakeDamage(float amount){
  		health -= amount;
   		if(health <= 0f){
 			
 			Die();  		
   		}
  }
  
  	void Die(){
  		Destroy(gameObject); 
  	}
}
