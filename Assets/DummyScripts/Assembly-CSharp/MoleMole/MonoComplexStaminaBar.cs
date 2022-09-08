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
	public class MonoComplexStaminaBar : MonoStaminaInfo // TypeDefIndex: 31193
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float[] _maxBarFillArray; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _calibrationArray; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _minCalibration; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _maxCalibration; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _barContent; // 0x70
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private float _warningValue; // 0x78
		private float _length; // 0x7C
		private bool _inWarning; // 0x80
	
		// Properties
		public override float maxStamina { /* [XID] */ /* 0x00000001896B7230-0x00000001896B7250 */ set {} } // 0x0000000184BB2840-0x0000000184BB2D00
		public override float temporaryStamina { /* [XID] */ /* 0x00000001896BE380-0x00000001896BE3A0 */ set {} } // 0x0000000184BB2D00-0x0000000184BB2E90
		public override float currStamina { /* [XID] */ /* 0x00000001896C5BF0-0x00000001896C5C10 */ set {} } // 0x0000000184BB26C0-0x0000000184BB2840
	
		// Constructors
		public MonoComplexStaminaBar() {} // 0x0000000184BB25F0-0x0000000184BB26C0
	
		// Methods
		// [XID] // 0x00000001896CD360-0x00000001896CD380
		private void SetWarningState(bool active) {} // 0x0000000184BB2170-0x0000000184BB2280
		// [XID] // 0x00000001896D4790-0x00000001896D47B0
		private void OnEnable() {} // 0x0000000184BB2400-0x0000000184BB2500
		// [XID] // 0x00000001896DBE30-0x00000001896DBE50
		public void SetFullState() {} // 0x0000000184BB2500-0x0000000184BB25F0
	}
}
