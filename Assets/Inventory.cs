using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour, IHasChanged{
	[SerializeField] Transform slots;

	// Use this for initialization
	void Start () {
		HasChanged();
	}

	#region IHasChanged implementation
	public void HasChanged ()
	{
		System.Text.StringBuilder builder = new System.Text.StringBuilder ();
		builder.Append (" - ");
		foreach (Transform slotTransform in slots) {
			GameObject item = slotTransform.GetComponent<Slots> ().item;
			if (item) {
				builder.Append (item.name);
				builder.Append (" - ");
				
			}
		}
	}
	#endregion
}
namespace UnityEngine.EventSystems{
	public interface IHasChanged : IEventSystemHandler{
		void HasChanged();
	}
}