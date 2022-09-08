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
	[Serializable]
	public struct CycleStatData // TypeDefIndex: 27843
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public double tickMilliseconds; // 0x00
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public double lateTickMilliseconds; // 0x08
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public double fixedTickMilliseconds; // 0x10
		public HandleEventStatData handleOnEvent; // 0x18
		public HandleEventStatData handleOnEventResolved; // 0x38
		public HandleEventStatData handleListenEvent; // 0x58
	
		// Properties
		public double totalMilliseconds { /* [XID] */ /* 0x00000001898C08B0-0x00000001898C08D0 */ get => default; } // 0x0000000184D7BE00-0x0000000184D7BED0 
		public double totalTickMilliseconds { /* [XID] */ /* 0x0000000189BB7B20-0x0000000189BB7B40 */ get => default; } // 0x0000000184D7BED0-0x0000000184D7BEE0 
	
		// Methods
		// [XID] // 0x0000000189BBF160-0x0000000189BBF180
		public void SubstractTickTime(ref CycleStatData inCycleStat) {} // 0x0000000184D7BB60-0x0000000184D7BC50
		// [XID] // 0x0000000189BC6E70-0x0000000189BC6E90
		public void ResetTickStatValue(bool bClearHistroyStat) {} // 0x0000000184D7BC50-0x0000000184D7BD20
		// [XID] // 0x0000000189B215E0-0x0000000189B21600
		public void AccumulateInclusiveStat(ref CycleStatData inCycleStat) {} // 0x0000000184D7BA80-0x0000000184D7BB60
		// [XID] // 0x0000000189BD5E00-0x0000000189BD5E20
		public void AccumulateExclusiveStat() {} // 0x0000000184D7BD20-0x0000000184D7BE00
	}
}
