/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoWheelView : MonoBehaviour // TypeDefIndex: 31093
	{
		// Fields
		public Transform itemPrefab; // 0x18
		public float viewRadius; // 0x20
		private Transform _content; // 0x28
		private int _itemtCount; // 0x30
		private OnSelect _onSelect; // 0x38
	
		// Nested types
		public delegate void OnChange(Transform trans, int index); // TypeDefIndex: 31094; 0x00000001824BCBB0-0x00000001824BCE60
	
		public delegate void OnSelect(int index); // TypeDefIndex: 31095; 0x000000018249DB40-0x000000018249DCD0
	
		// Constructors
		public MonoWheelView() {} // 0x00000001824AA970-0x00000001824AA9E0
	
		// Methods
		// [XID] // 0x0000000189A9AB80-0x0000000189A9ABA0
		public virtual void SetupView(OnChange onChange, OnSelect onSelect, int itemCount) {} // 0x00000001824AA5D0-0x00000001824AA970
		// [XID] // 0x0000000189AA1E50-0x0000000189AA1E70
		public int SelectItem(float angle) => default; // 0x00000001824AA4B0-0x00000001824AA5D0
	}
}
