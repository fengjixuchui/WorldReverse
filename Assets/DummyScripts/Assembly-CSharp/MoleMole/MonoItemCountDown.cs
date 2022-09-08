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
	public class MonoItemCountDown : MonoBehaviour // TypeDefIndex: 30415
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _fillImg; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeText; // 0x20
		private uint _remainingSec; // 0x28
		private uint _totalSec; // 0x2C
		private float _currTime; // 0x30
		private uint _targetTime; // 0x34
	
		// Constructors
		public MonoItemCountDown() {} // 0x0000000184325620-0x00000001843256A0
	
		// Methods
		// [XID] // 0x0000000189A78090-0x0000000189A780B0
		private void Update() {} // 0x0000000184325580-0x0000000184325620
		// [XID] // 0x0000000189A7F680-0x0000000189A7F6A0
		private void UpdateRemainingTime() {} // 0x0000000184325150-0x0000000184325480
		// [XID] // 0x0000000189A87380-0x0000000189A873A0
		public void SetRemainingTime(uint targetTime, uint totalSec) {} // 0x0000000184325480-0x0000000184325580
	}
}
