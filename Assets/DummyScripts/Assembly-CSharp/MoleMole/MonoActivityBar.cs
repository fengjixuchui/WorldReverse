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
	public class MonoActivityBar : MonoUIProxy // TypeDefIndex: 31150
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _txtTime; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCountdown; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtReady; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _readyRoot; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _IconRoot; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _prepareRoot; // 0x68
		private uint _endTimeStamp; // 0x70
		private float _countDownTime; // 0x74
		private int _countDownSecond; // 0x78
		private uint _prevTickTime; // 0x7C
		private bool _finish; // 0x80
		private bool _useLevelTime; // 0x81
		private float _defaultCountdown; // 0x84
	
		// Properties
		public string readyString { /* [XID] */ /* 0x0000000189889C90-0x0000000189889CB0 */ set {} } // 0x0000000184C78B10-0x0000000184C78BE0
		public bool showWait { /* [XID] */ /* 0x00000001898911E0-0x0000000189891200 */ set {} } // 0x0000000184C78D40-0x0000000184C78EA0
		public bool showPrepare { /* [XID] */ /* 0x00000001898987F0-0x0000000189898810 */ set {} } // 0x0000000184C78BE0-0x0000000184C78D40
		public bool prepareTimeFinish { /* [XID] */ /* 0x000000018989F9F0-0x000000018989FA10 */ get => default; } // 0x0000000184C78A60-0x0000000184C78B10 
		public bool cdTimeFinish { /* [XID] */ /* 0x00000001898A7400-0x00000001898A7420 */ get => default; } // 0x0000000184C789B0-0x0000000184C78A60 
	
		// Constructors
		public MonoActivityBar() {} // 0x0000000184C78920-0x0000000184C789B0
	
		// Methods
		// [XID] // 0x00000001898AEDC0-0x00000001898AEDE0
		public void Recover() {} // 0x0000000184C78240-0x0000000184C78320
		// [XID] // 0x00000001898B61D0-0x00000001898B61F0
		public void SetTime(uint endTimeStamp, bool useLevelTime = false /* Metadata: 0x00B11FD6 */, float defaultCountdown = -1f /* Metadata: 0x00B11FD7 */) {} // 0x0000000184C784D0-0x0000000184C785C0
		// [XID] // 0x00000001898BDA60-0x00000001898BDA80
		public void SetCountdown(float seconds) {} // 0x0000000184C78320-0x0000000184C783E0
		// [XID] // 0x00000001898C5360-0x00000001898C5380
		public void TickTime() {} // 0x0000000184C78740-0x0000000184C78920
		// [XID] // 0x00000001898CC830-0x00000001898CC850
		public void TickCountdown() {} // 0x0000000184C785C0-0x0000000184C78740
		// [XID] // 0x00000001898D42B0-0x00000001898D42D0
		public void SetTimeText(uint spanSeconds) {} // 0x0000000184C783E0-0x0000000184C784D0
	}
}
