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
	public class MonoSimpleProgressBar : MonoBehaviour // TypeDefIndex: 30935
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _updateTime; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _fill; // 0x20
		private float _lastValue; // 0x28
		private float _newValue; // 0x2C
		private float _maxTime; // 0x30
		private float _curTime; // 0x34
	
		// Constructors
		public MonoSimpleProgressBar() {} // 0x0000000184FF4030-0x0000000184FF40B0
	
		// Methods
		// [XID] // 0x0000000189AA1E70-0x0000000189AA1E90
		public void SetProgressBar(float lastValue, float newValue, float updateTime = 0f /* Metadata: 0x00B11AD0 */) {} // 0x0000000184FF3DA0-0x0000000184FF3EC0
		// [XID] // 0x0000000189AA9350-0x0000000189AA9370
		private void Update() {} // 0x0000000184FF3EC0-0x0000000184FF4030
	}
}
