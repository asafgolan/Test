using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class PlayerNetworkSetup : NetworkBehaviour {

	[SerializeField] Camera FPScam;
	[SerializeField] AudioListener audioListener;

	// Use this for initialization
	void Start ()
	{
		if(isLocalPlayer)
		{
			GameObject.Find ("Main Camera").SetActive(false);
			GetComponent<CharacterController>().enabled = true ;
			GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
			FPScam.enabled = true ;
			audioListener.enabled = true ;


		}	
	}
	

}
