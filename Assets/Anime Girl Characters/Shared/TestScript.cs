using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	public Animator[] anim;
	public Material[] outfitMaterials;
	public Texture2D[] outfitLists;

	public SkinnedMeshRenderer[] hairRenderer;
	public Material[] hairMaterials;

	public Material mouthMaterial;
	public Texture2D[] mouthTextures;

	public Material eyeMaterial;
	public Texture2D[] eyeTextures;

	public GameObject[] cubes;

	// bools
	private bool animSwitched = false;
	private bool showCube = true;
	//private int outfitIndex = 0;

	void Update(){
		if(Input.GetKeyDown(KeyCode.Space)){
			animSwitched = !animSwitched;
			TogglePreviewAnimation(animSwitched);
		}

		if(Input.GetKeyDown(KeyCode.Tab)){
			showCube = !showCube;
			ToggleCube(showCube);
		}

		if(Input.GetKeyDown(KeyCode.Q)) SwitchOutfits(0);
		if(Input.GetKeyDown(KeyCode.W)) SwitchOutfits(1);
		if(Input.GetKeyDown(KeyCode.E)) SwitchOutfits(2);

		if(Input.GetKeyDown(KeyCode.Alpha1)) SwitchHair(0);
		if(Input.GetKeyDown(KeyCode.Alpha2)) SwitchHair(1);
		if(Input.GetKeyDown(KeyCode.Alpha3)) SwitchHair(2);
		if(Input.GetKeyDown(KeyCode.Alpha4)) SwitchHair(3);
		if(Input.GetKeyDown(KeyCode.Alpha5)) SwitchHair(4);
		if(Input.GetKeyDown(KeyCode.Alpha6)) SwitchHair(5);
		if(Input.GetKeyDown(KeyCode.Alpha7)) SwitchHair(6);
		if(Input.GetKeyDown(KeyCode.Alpha8)) SwitchHair(7);
		if(Input.GetKeyDown(KeyCode.Alpha9)) SwitchHair(8);
		if(Input.GetKeyDown(KeyCode.Alpha0)) SwitchHair(9);

		if(Input.GetKeyDown(KeyCode.A)) SwitchMouth(0);
		if(Input.GetKeyDown(KeyCode.S)) SwitchMouth(1);
		if(Input.GetKeyDown(KeyCode.D)) SwitchMouth(2);

		if(Input.GetKeyDown(KeyCode.Z)) SwitchEyes(0);
		if(Input.GetKeyDown(KeyCode.X)) SwitchEyes(1);
		if(Input.GetKeyDown(KeyCode.C)) SwitchEyes(2);
	}

	void TogglePreviewAnimation(bool b){
		for(int i = 0; i < anim.Length; i++){
			anim[i].SetBool("Run", b);
		}
	}

	void ToggleCube(bool b){
		for(int i = 0; i < cubes.Length; i++){
			cubes[i].SetActive(b);
		}
	}

	void SwitchEyes(int toIndex){
		eyeMaterial.mainTexture = eyeTextures[toIndex];
	}

	void SwitchMouth(int toIndex){
		mouthMaterial.mainTexture = mouthTextures[toIndex];
	}

	void SwitchHair(int toIndex){
		for (int i = 0; i < hairRenderer.Length; i++){
			hairRenderer[i].material = hairMaterials[toIndex];
		}
	}

	void SwitchOutfits(int toIndex){
		for(int i = 0; i < outfitMaterials.Length; i++){
			outfitMaterials[i].mainTexture = outfitLists[toIndex];
		}
	}

	void OnApplicationQuit(){
		SwitchOutfits(0);
		SwitchHair(0);
		SwitchEyes(0);
		SwitchMouth(0);
	}
}
