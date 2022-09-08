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
	internal class MonoTalkCountDownProgress : MonoBehaviour // TypeDefIndex: 31270
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _progress; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _warningValue; // 0x28
		private bool _inWarning; // 0x2C
		private float _cooldownTime; // 0x30
		private float _curTime; // 0x34
		private bool _start; // 0x38
	
		// Constructors
		public MonoTalkCountDownProgress() {} // 0x0000000185011150-0x00000001850111D0
	
		// Methods
		// [XID] // 0x00000001898CFE80-0x00000001898CFEA0
		private void Update() {} // 0x0000000185010FA0-0x0000000185011150
		// [XID] // 0x00000001898D7430-0x00000001898D7450
		public void StartCoolDown(float cooldownTime) {} // 0x0000000185010EC0-0x0000000185010FA0
		// [XID] // 0x00000001898DF1A0-0x00000001898DF1C0
		public void SetProgress(float value) {} // 0x0000000185010CF0-0x0000000185010DB0
		// [XID] // 0x00000001898E6BC0-0x00000001898E6BE0
		public void SetWarningState(bool active) {} // 0x0000000185010DB0-0x0000000185010EC0
		// [XID] // 0x00000001898EE2D0-0x00000001898EE2F0
		private void OnEnable() {} // 0x0000000185010BF0-0x0000000185010CF0
	}
}
