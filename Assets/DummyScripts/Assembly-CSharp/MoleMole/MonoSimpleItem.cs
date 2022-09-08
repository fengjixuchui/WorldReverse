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
	public class MonoSimpleItem : MonoSpriteProxy // TypeDefIndex: 30429
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _itemIcon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemName; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RewardItemQuality _rewardQuality; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _activeFalseTime; // 0x3C
		private Coroutine _coroutine; // 0x40
	
		// Properties
		public RewardItemQuality rewardQuality { /* [XID] */ /* 0x00000001896EDA00-0x00000001896EDA20 */ get => default; } // 0x0000000184FF3D00-0x0000000184FF3DA0 
	
		// Constructors
		public MonoSimpleItem() {} // 0x0000000184FF3C30-0x0000000184FF3D00
	
		// Methods
		// [XID] // 0x00000001896F51D0-0x00000001896F51F0
		public void UpdateSimpleItemByConfig(SimpleItemStruct item) {} // 0x0000000184FF3A70-0x0000000184FF3C30
		// [XID] // 0x00000001896FCA30-0x00000001896FCA50
		public void FadeIn() {} // 0x0000000184FF34A0-0x0000000184FF3660
		// [XID] // 0x0000000189703EF0-0x0000000189703F10
		public void FadeOut() {} // 0x0000000184FF3660-0x0000000184FF3880
		// [XID] // 0x000000018970B7D0-0x000000018970B7F0
		public void SetActiveFalse() {} // 0x0000000184FF3980-0x0000000184FF3A70
		// [XID] // 0x0000000189713050-0x0000000189713070
		protected override void OnDestroy() {} // 0x0000000184FF3880-0x0000000184FF3980
	}
}
