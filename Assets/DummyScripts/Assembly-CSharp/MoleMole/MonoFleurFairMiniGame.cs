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
	public class MonoFleurFairMiniGame : MonoBehaviour // TypeDefIndex: 30372
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockedTrans; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _unlockedTrans; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockedTimeTrans; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _missionScroller; // 0x38
	
		// Properties
		public UnityEngine.UI.Text unlockText { /* [XID] */ /* 0x0000000189A1FBE0-0x0000000189A1FC00 */ get => default; } // 0x000000018563A310-0x000000018563A460 
		public MonoGridScroller missionScroller { /* [XID] */ /* 0x0000000189A26F30-0x0000000189A26F50 */ get => default; } // 0x000000018563A270-0x000000018563A310 
	
		// Constructors
		public MonoFleurFairMiniGame() {} // 0x000000018563A1F0-0x000000018563A270
	
		// Methods
		// [XID] // 0x0000000189A2E750-0x0000000189A2E770
		public void SetLocked(bool locked) {} // 0x0000000185639FD0-0x000000018563A0D0
		// [XID] // 0x0000000189A360A0-0x0000000189A360C0
		public void SetTimeLocked(bool bLocked) {} // 0x000000018563A0D0-0x000000018563A1F0
	}
}
