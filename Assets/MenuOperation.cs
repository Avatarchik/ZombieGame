using UnityEngine;
using System.Collections;

public class MenuOperation : MonoBehaviour 
{
	public Camera mainCamera;
	public GameObject gate;
	public bool isQuitButton;
	public AudioClip gateAudio;
		
	// Use this for initialization
	void Start () 
	{
			
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	
	}
	
	void StartCameraAnimation()
	{
		
	}
	
	void StartGateAnimation()
	{
		
	}
	
	void OnMouseUp()
    {
   
		//are we dealing with a quit button
	    if( isQuitButton )
	    {
	          //quit the game
	          Application.Quit();
	    }
	    else
	    {
	     	 mainCamera.animation.Play();
			gate.animation.Play();
			//AudioSource.PlayClipAtPoint(gateAudio,Camera.main.transform.position);
			AudioSource.PlayClipAtPoint(gateAudio,mainCamera.transform.position);
		}
	}
	
	void OnCameraAnimationComplete()
	{
		Application.LoadLevel(1);	
	}
	
	void OnMouseEnter()
	{
		//changen the color of the text
		renderer.material.color = Color.green;
	}
	
	void OnMouseExit()
	{
		//change the color of the text
		renderer.material.color =Color.white;
	}
}
