using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/*
 * Created by : Ayran Olckers
 * 01/2020
 */
public class Equipment : Item {
	public int tier;

	public Equipment (int tier, GameObject inventorySlotObject) : base (inventorySlotObject) {
		this.tier = tier;
		type = "Equipment";

	}

}
