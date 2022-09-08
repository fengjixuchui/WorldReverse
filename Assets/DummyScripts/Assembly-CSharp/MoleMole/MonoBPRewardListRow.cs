/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoBPRewardListRow : MonoBehaviour // TypeDefIndex: 30711
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemNameText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemNumText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _iconList; // 0x28
	
		// Properties
		public MonoSimpleReusableList iconList { /* [XID] */ /* 0x0000000189936110-0x0000000189936130 */ get => default; } // 0x00000001847F9BF0-0x00000001847F9C90 
	
		// Constructors
		public MonoBPRewardListRow() {} // 0x00000001847F9B80-0x00000001847F9BF0
	
		// Methods
		// [XID] // 0x000000018993DB50-0x000000018993DB70
		public void SetItemView(uint itemId, uint itemCount, bool showSpecialDesc = false /* Metadata: 0x00B114A6 */) {} // 0x00000001847F9790-0x00000001847F9B80
		// [XID] // 0x0000000189945320-0x0000000189945340
		public MonoItemSlot GetItemSlot() => default; // 0x00000001847F9630-0x00000001847F9790
	}
}
