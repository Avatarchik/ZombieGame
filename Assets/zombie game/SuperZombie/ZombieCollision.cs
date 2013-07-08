using UnityEngine;
using System.Collections;

public class ZombieCollision : MonoBehaviour {
	
	private string DamageMethodName = "Damage";	// user defined name of damage method on target
	public float Damage = 1.0f;				// the damage transmitted to target by the bullet
	public GameObject Player;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    // Destroy everything that enters the trigger
    void OnTriggerEnter (Collider collider) 
	{
		// Debug.Log("Zombie Trigger  GameObject:" + collider.gameObject.name );
	
		if(collider.gameObject.name == "AdvancedDemoPlayer")
		{
		
        	// do damage on the target
			Player.SendMessageUpwards(DamageMethodName, Damage, SendMessageOptions.DontRequireReceiver);
		
		}		
    }

    void OnTriggerStay (Collider collider) 
	{
		// ßDebug.Log("Zombie Trigger stay  GameObject:" + collider.gameObject.name );
	
    }
	
	
}
