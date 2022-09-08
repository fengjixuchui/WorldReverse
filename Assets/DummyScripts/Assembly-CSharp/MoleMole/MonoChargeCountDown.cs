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
	public class MonoChargeCountDown : MonoUIProxy // TypeDefIndex: 31188
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Slider _barSlider; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _barMask; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTime; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDesc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtInterrupt; // 0x60
		private ulong _endTime; // 0x68
		private float _duration; // 0x70
		private bool _increase; // 0x74
		private bool _isEnd; // 0x75
	
		// Properties
		public UnityEngine.UI.Text txtDesc { /* [XID] */ /* 0x0000000189A5FD40-0x0000000189A5FD60 */ get => default; } // 0x0000000184B9C9E0-0x0000000184B9CA80 
		public UnityEngine.UI.Text txtInterrupt { /* [XID] */ /* 0x0000000189A679E0-0x0000000189A67A00 */ get => default; } // 0x0000000184B9CA80-0x0000000184B9CB20 
	
		// Constructors
		public MonoChargeCountDown() {} // 0x0000000184B9C960-0x0000000184B9C9E0
	
		// Methods
		// [XID] // 0x0000000189A6EDF0-0x0000000189A6EE10
		public void SetEndTime(float duration, bool increase) {} // 0x0000000184B9C5F0-0x0000000184B9C730
		// [XID] // 0x0000000189A765F0-0x0000000189A76610
		public void Interrupt() {} // 0x0000000184B9C3A0-0x0000000184B9C520
		// [XID] // 0x0000000189A7DF60-0x0000000189A7DF80
		private void SetValue(float value) {} // 0x0000000184B9C2B0-0x0000000184B9C3A0
		// [XID] // 0x0000000189A858E0-0x0000000189A85900
		private void Update() {} // 0x0000000184B9C730-0x0000000184B9C960
		// [XID] // 0x0000000189A8D1C0-0x0000000189A8D1E0
		private void Close() {} // 0x0000000184B9C520-0x0000000184B9C5F0
	}
}
