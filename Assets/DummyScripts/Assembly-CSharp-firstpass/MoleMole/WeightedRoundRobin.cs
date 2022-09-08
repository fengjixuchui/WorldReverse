/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class WeightedRoundRobin // TypeDefIndex: 10618
	{
		// Fields
		private List<IWRRHandle> _wRRHandles; // 0x10
		private int _totalWeight; // 0x18
		private int _currentWeight; // 0x1C
		private int _lastIndex; // 0x20
		private IWRRHandle _lastSelectedHandle; // 0x28
	
		// Constructors
		public WeightedRoundRobin() {} // 0x000000018609C4A0-0x000000018609C540
	
		// Methods
		// [XID] // 0x0000000189B06A70-0x0000000189B06A90
		private void Reset() {} // 0x000000018609C290-0x000000018609C4A0
		// [XID] // 0x0000000189B32DF0-0x0000000189B32E10
		public void OnNext() {} // 0x000000018609BE70-0x000000018609C060
		// [XID] // 0x0000000189944CF0-0x0000000189944D10
		public WRRHandle AddHandle(int weight) => default; // 0x000000018609BCB0-0x000000018609BDB0
		// [XID] // 0x0000000189600660-0x0000000189600680
		public void RemoveHandle(WRRHandle inHandle) {} // 0x000000018609C060-0x000000018609C290
		// [XID] // 0x00000001899539D0-0x00000001899539F0
		public void Clear() {} // 0x000000018609BDB0-0x000000018609BE70
	}
}
