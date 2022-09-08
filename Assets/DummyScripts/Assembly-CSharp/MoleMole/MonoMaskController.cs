/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	public class MonoMaskController : MonoBehaviour // TypeDefIndex: 30826
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform maskRect; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask fillRect; // 0x20
		private UnityAction _OnCountDownFinish; // 0x28
		private Coroutine _currRoutine; // 0x30
		private float _currTime; // 0x38
	
		// Constructors
		public MonoMaskController() {} // 0x00000001849367F0-0x0000000184936870
	
		// Methods
		// [XID] // 0x00000001897DF200-0x00000001897DF220
		public void SetValue(float value) {} // 0x0000000184936610-0x0000000184936730
		// [XID] // 0x00000001897E6AA0-0x00000001897E6AC0
		public void StartCountDown(UnityAction callback) {} // 0x0000000184936730-0x00000001849367F0
		[DebuggerHidden] // 0x00000001897EE610-0x00000001897EE650
		// [XID] // 0x00000001897EE610-0x00000001897EE650
		private IEnumerator CountDown() => default; // 0x0000000184936430-0x0000000184936540
		// [XID] // 0x00000001897F8F40-0x00000001897F8F60
		public void ResetCoroutine() {} // 0x0000000184936540-0x0000000184936610
	}
}
