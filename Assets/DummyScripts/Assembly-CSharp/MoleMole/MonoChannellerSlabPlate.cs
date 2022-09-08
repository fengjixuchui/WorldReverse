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
	public class MonoChannellerSlabPlate : MonoBehaviour // TypeDefIndex: 30047
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer[] _slotList; // 0x28
	
		// Properties
		public Button actionBtn { /* [XID] */ /* 0x0000000189953F80-0x0000000189953FA0 */ get => default; } // 0x000000018480B460-0x000000018480B500 
	
		// Constructors
		public MonoChannellerSlabPlate() {} // 0x000000018480B3F0-0x000000018480B460
	
		// Methods
		// [XID] // 0x000000018995B7E0-0x000000018995B800
		public int GetSlotCount() => default; // 0x000000018480AF40-0x000000018480AFF0
		// [XID] // 0x0000000189963400-0x0000000189963420
		public MonoChannellerSlabBuffSlot GetSlot(int index) => default; // 0x000000018480AFF0-0x000000018480B100
		// [XID] // 0x000000018996A740-0x000000018996A760
		public void DoSelect(uint buffID) {} // 0x000000018480AD80-0x000000018480AF40
		// [XID] // 0x00000001899724A0-0x00000001899724C0
		public void UnSelect() {} // 0x000000018480B240-0x000000018480B3F0
		// [XID] // 0x0000000189979C80-0x0000000189979CA0
		public void TriggerAnimation(string trigger) {} // 0x000000018480B100-0x000000018480B240
	}
}
