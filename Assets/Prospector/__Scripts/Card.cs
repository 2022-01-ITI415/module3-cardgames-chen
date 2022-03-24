using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour {

	public string    suit;
	public int       rank;
	public Color     color = Color.black;
	public string    colS = "Black";  // or "Red"
	
	public List<GameObject> decoGOs = new List<GameObject>();
	public List<GameObject> pipGOs = new List<GameObject>();
	
	public GameObject back;  // back of card;
	public CardDefinition def;  // from DeckXML.xml	
	public SpriteRenderer[]	spriteRenderers;

[System.Serializable]
public class Decorator{
	public string	type;			// For card pips, tyhpe = "pip"
	public Vector3	loc;			// location of sprite on the card
	public bool		flip = false;	//whether to flip vertically
	public float 	scale = 1.0f;
}

[System.Serializable]
public class CardDefinition{
	public string	face;	//sprite to use for face cart
	public int		rank;	// value from 1-13 (Ace-King)
	public List<Decorator>	
					pips = new List<Decorator>();  // Pips Used
}

	void Start() {
		SetSortOrder(0);
	}
	public void PopulatedSpriteRenderers(){
		if(spriteRenderers == null || spriteRenderers.Length == 0) {
			spriteRenderers = GetComponentsInChildren<spriteRenderers>();
		}
	}
	public void SetSortingLayerName(string tSLN) {
		PopulatedSpriteRenderers();
		foreach (SpriteRenderer tSR in spriteRenderers) {
			if (tSR.gameObject == this.gameObject) {
				tSR.sortingOrder = s0rd;
				continue;
			}
		switch (tSR.gameObject.name) {
			case "back": // if the name is "back"
			tSR.sortingOrder = SortedList+2;
			break;
			case "face":
			default: //or if it's anything else
			tSR.sortingOrder = sOrd+1;
			break;
		}
	  }
	}

	public bool faceUp {
		get {
			return (!back.activeSelf);
		}

		set {
			back.SetActive(!value);
		}
	} 
}
