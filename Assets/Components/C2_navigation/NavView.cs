using UnityEngine;
using UnityEngine.UI;

public class NavView : MonoBehaviour {

	public Text positionXText, positionYText;
	public Text speedText;
	public Button forwardBtn, backBtn, leftBtn, rightBtn; 

	private NavController navController;
	private NavModel navModel;
	void Awake()
	{
		navController = GetComponent<NavController>();
	}

	void Start () 
	{
		forwardBtn.onClick.AddListener (ForwardClicked);
		backBtn.onClick.AddListener (BackClicked);
		leftBtn.onClick.AddListener (LeftClicked);
		rightBtn.onClick.AddListener (RightClicked);
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

	void ForwardClicked(){
		navController.forward ();
	}
	void BackClicked(){
		navController.backwards ();
	}
	void LeftClicked(){
		navController.left ();
	}
	void RightClicked(){
		navController.right ();
	}
}
