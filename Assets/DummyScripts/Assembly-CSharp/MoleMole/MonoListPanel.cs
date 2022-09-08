/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoListPanel : MonoBehaviour // TypeDefIndex: 31251
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _listPanelContent; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemPrefab; // 0x20
		private List<GameObject> _listItems; // 0x28
		private int _allInstanceCount; // 0x30
		private Queue<GameObject> _itemUnused; // 0x38
	
		// Properties
		public Action onAllItemsRemoved { get; set; } // 0x000000018427DB00-0x000000018427DB60 0x000000018427DB60-0x000000018427DBC0
	
		// Constructors
		public MonoListPanel() {} // 0x000000018427DA30-0x000000018427DB00
	
		// Methods
		// [XID] // 0x00000001898B97B0-0x00000001898B97D0
		public virtual void SetupView(Action<Transform, int> onChange, int itemCount) {} // 0x000000018427D690-0x000000018427DA30
		// [XID] // 0x00000001898C0B90-0x00000001898C0BB0
		public void ClearAll() {} // 0x000000018427D3E0-0x000000018427D590
		// [XID] // 0x00000001898C8430-0x00000001898C8450
		private void Reuse(GameObject obj) {} // 0x000000018427D590-0x000000018427D690
	}
}
