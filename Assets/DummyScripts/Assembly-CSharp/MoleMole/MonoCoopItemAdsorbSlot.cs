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
	public class MonoCoopItemAdsorbSlot : MonoSpriteProxy, AdsorbEffectItemInterface // TypeDefIndex: 30740
	{
		// Fields
		private int _curState; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _startDuringTime; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconImage; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _startEffect; // 0x38
	
		// Properties
		public int CurrentState { /* [XID] */ /* 0x0000000189724A70-0x0000000189724A90 */ get => default; } // 0x0000000183F33320-0x0000000183F333C0 
		public float StartDuringTime { /* [XID] */ /* 0x000000018972C2C0-0x000000018972C2E0 */ get => default; } // 0x0000000183F33470-0x0000000183F33520 
		public float EndDuringTime { /* [XID] */ /* 0x0000000189733980-0x00000001897339A0 */ get => default; } // 0x0000000183F333C0-0x0000000183F33470 
	
		// Constructors
		public MonoCoopItemAdsorbSlot() {} // 0x0000000183F332A0-0x0000000183F33320
	
		// Methods
		// [XID] // 0x000000018973B0E0-0x000000018973B100
		public void SetEffectItemState(int index, object objData, int state) {} // 0x0000000183F32D90-0x0000000183F331A0
		// [XID] // 0x0000000189742A50-0x0000000189742A70
		public void LoadItemIconImage(uint itemId) {} // 0x0000000183F32C70-0x0000000183F32D90
		// [XID] // 0x000000018974A740-0x000000018974A760
		public void SetItemIconImage(Sprite sprite) {} // 0x0000000183F331A0-0x0000000183F332A0
	}
}
