using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavView : MonoBehaviour {

	public Text positionXText, positionYText;
	public Text speedText;

	private NavController navController;
	private NavModel navModel;
	void Awake()
	{
		navController = GetComponent<NavController>();
	}

	void Start () 
	{
		navModel = navController.GetNavModel();
		UpdateViews();
	}

	void Update () 
	{
		UpdateViews();
	}

	private void UpdateViews()
	{
		positionXText.text = navModel.GetPositionX()+",";
		positionYText.text = navModel.GetPositionY () + "";
		speedText.text = navModel.GetVelocity ()+"";

	}
}
