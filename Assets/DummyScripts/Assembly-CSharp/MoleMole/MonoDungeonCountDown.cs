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
	public class MonoDungeonCountDown : MonoBehaviour // TypeDefIndex: 31202
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private SimpleText _countDownLabel; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _addTimeLabel; // 0x28
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private int _flashThreshold; // 0x30
		private CountDownShowType _showType; // 0x34
		private bool _sendFinishNtf; // 0x40
		private bool _useLevelTime; // 0x41
		private ulong _deadline; // 0x48
		private ulong _prevTickTime; // 0x50
		private bool _valid; // 0x60
	
		// Properties
		public ulong beginTimeStamp { /* [XID] */ /* 0x00000001896633C0-0x0000000189663400 */ get; /* [XID] */ /* 0x000000018966DA80-0x000000018966DAC0 */ set; } // 0x0000000183F47490-0x0000000183F474F0 0x0000000183F47800-0x0000000183F47860
		public ulong deadline { /* [XID] */ /* 0x00000001896789E0-0x0000000189678A00 */ get => default; /* [XID] */ /* 0x000000018967FFE0-0x0000000189680000 */ set {} } // 0x0000000183F474F0-0x0000000183F47590 0x0000000183F47920-0x0000000183F47AB0
		public string countDown { /* [XID] */ /* 0x0000000189687C30-0x0000000189687C50 */ set {} } // 0x0000000183F47860-0x0000000183F47920
		public string addTime { /* [XID] */ /* 0x000000018968F630-0x000000018968F650 */ set {} } // 0x0000000183F47730-0x0000000183F47800
		public int flashThreshold { /* [XID] */ /* 0x00000001896A5650-0x00000001896A5670 */ get => default; } // 0x0000000183F47590-0x0000000183F47630 
		public ulong spanSeconds { /* [XID] */ /* 0x00000001896ACE90-0x00000001896ACED0 */ get; /* [XID] */ /* 0x00000001896B71F0-0x00000001896B7230 */ private set; } // 0x0000000183F47630-0x0000000183F47690 0x0000000183F46BB0-0x0000000183F46C10
		public bool valid { /* [XID] */ /* 0x00000001896C88B0-0x00000001896C88D0 */ get => default; /* [XID] */ /* 0x00000001896D02A0-0x00000001896D02C0 */ set {} } // 0x0000000183F47690-0x0000000183F47730 0x0000000183F47AB0-0x0000000183F47BB0
	
		// Nested types
		public enum CountDownShowType // TypeDefIndex: 31203
		{
			Decrease = 0,
			Increase = 1
		}
	
		// Constructors
		public MonoDungeonCountDown() {} // 0x0000000183F47400-0x0000000183F47490
	
		// Methods
		// [XID] // 0x0000000189697090-0x00000001896970B0
		public void AnimAdd() {} // 0x0000000183F46AD0-0x0000000183F46BB0
		// [XID] // 0x000000018969E570-0x000000018969E590
		public void SetFlash(bool value) {} // 0x0000000183F470A0-0x0000000183F471A0
		// [XID] // 0x00000001896C1210-0x00000001896C1230
		public void Tick(bool force = false /* Metadata: 0x00B11FFF */) {} // 0x0000000183F471A0-0x0000000183F47400
		// [XID] // 0x00000001896D7800-0x00000001896D7820
		public void Reset() {} // 0x0000000183F46CC0-0x0000000183F46DC0
		// [XID] // 0x00000001896DEFE0-0x00000001896DF000
		public void Recover() {} // 0x0000000183F46C10-0x0000000183F46CC0
		// [XID] // 0x00000001896E6450-0x00000001896E6470
		public void SetCountdownText(ulong spanSeconds) {} // 0x0000000183F46DC0-0x0000000183F46FC0
		// [XID] // 0x00000001896ED960-0x00000001896ED980
		public void SetCountdownType(bool isIncrease, bool useLevelTime = true /* Metadata: 0x00B12000 */) {} // 0x0000000183F46FC0-0x0000000183F470A0
	}
}
