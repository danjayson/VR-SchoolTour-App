﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textshow : MonoBehaviour {


	public void ShowHideText (UnityEngine.UI.Text text){
		text.gameObject.active = !text.gameObject.active;
	}
		
}
