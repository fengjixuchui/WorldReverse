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
	public class MonoAsterChapterButton : MonoBehaviour // TypeDefIndex: 31098
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _buttonName; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockTips; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _unlockGrp; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _highLightGrp; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _pressedGrp; // 0x50
		private bool _hightlighted; // 0x58
	
		// Properties
		public UnityEngine.UI.Text buttonName { /* [XID] */ /* 0x00000001895F2E80-0x00000001895F2EA0 */ get => default; } // 0x0000000184C96CE0-0x0000000184C96D80 
		public UnityEngine.UI.Text unlockTips { /* [XID] */ /* 0x00000001895FA6E0-0x00000001895FA700 */ get => default; } // 0x0000000184C96F60-0x0000000184C97000 
		public GameObject unlockGrp { /* [XID] */ /* 0x00000001896020A0-0x00000001896020C0 */ get => default; } // 0x0000000184C96EC0-0x0000000184C96F60 
		public Image icon { /* [XID] */ /* 0x0000000189609880-0x00000001896098A0 */ get => default; } // 0x0000000184C96E20-0x0000000184C96EC0 
		public Button actionButton { /* [XID] */ /* 0x00000001896110A0-0x00000001896110C0 */ get => default; } // 0x0000000184C96C40-0x0000000184C96CE0 
		public bool highlight { /* [XID] */ /* 0x0000000189627490-0x00000001896274B0 */ get => default; /* [XID] */ /* 0x000000018962EF90-0x000000018962EFB0 */ set {} } // 0x0000000184C96D80-0x0000000184C96E20 0x0000000184C97000-0x0000000184C97220
	
		// Constructors
		public MonoAsterChapterButton() {} // 0x0000000184C96BD0-0x0000000184C96C40
	
		// Methods
		// [XID] // 0x0000000189618A70-0x0000000189618A90
		public void SetTimeTips(uint openTime) {} // 0x0000000184C96A30-0x0000000184C96BD0
		// [XID] // 0x0000000189620000-0x0000000189620020
		public void SetOffset(float x, float y) {} // 0x0000000184C96880-0x0000000184C96A30
	}
}
