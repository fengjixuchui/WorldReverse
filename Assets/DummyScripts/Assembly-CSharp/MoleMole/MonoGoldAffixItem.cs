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
	// [RequireComponent] // 0x000000018968C430-0x000000018968C480
	internal class MonoGoldAffixItem : MonoBehaviour // TypeDefIndex: 30793
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _affixName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _affixDesc; // 0x28
		private int _index; // 0x30
		private Action<int> _onClicked; // 0x38
	
		// Properties
		public UnityEngine.UI.Text affixName { /* [XID] */ /* 0x00000001896B0E10-0x00000001896B0E30 */ get => default; } // 0x0000000184073B00-0x0000000184073BA0 
		public UnityEngine.UI.Text affixDesc { /* [XID] */ /* 0x00000001896B8A30-0x00000001896B8A50 */ get => default; } // 0x0000000184073A60-0x0000000184073B00 
		public int index { /* [XID] */ /* 0x00000001896BFCB0-0x00000001896BFCD0 */ set {} } // 0x0000000184073BA0-0x0000000184073C50
		public Action<int> onClicked { /* [XID] */ /* 0x00000001896C7590-0x00000001896C75B0 */ set {} } // 0x0000000184073C50-0x0000000184073D00
	
		// Constructors
		public MonoGoldAffixItem() {} // 0x00000001840739F0-0x0000000184073A60
	
		// Methods
		// [XID] // 0x00000001896CECF0-0x00000001896CED10
		public void OnClick() {} // 0x00000001840737A0-0x0000000184073850
		// [XID] // 0x00000001896D60F0-0x00000001896D6110
		public void SetSelect(bool value) {} // 0x0000000184073850-0x00000001840739F0
	}
}
