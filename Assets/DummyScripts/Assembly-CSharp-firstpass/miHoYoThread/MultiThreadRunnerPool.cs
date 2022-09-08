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

namespace miHoYoThread
{
	public class MultiThreadRunnerPool : IRunnerPool // TypeDefIndex: 9034
	{
		// Fields
		private List<MultiThreadRunner> _runnerPool; // 0x10
		private MainThreadRunner _mainThreadRunner; // 0x18
		private long _freeRunnerIndex; // 0x20
		private int _normalThreadNum; // 0x28
		private int _statThreadIndex; // 0x2C
	
		// Constructors
		public MultiThreadRunnerPool() {} // 0x0000000187632180-0x0000000187632200
	
		// Methods
		// [XID] // 0x0000000189659430-0x0000000189659450
		public void Init(int threadNum) {} // 0x0000000187631E50-0x0000000187631F90
		// [XID] // 0x000000018992FF90-0x000000018992FFB0
		public IRunner GetRunner(int handler) => default; // 0x0000000187631CA0-0x0000000187631DA0
		// [XID] // 0x00000001899374F0-0x0000000189937510
		public IRunner GetFreeRunner() => default; // 0x0000000187631B20-0x0000000187631C00
		// [XID] // 0x000000018993EFC0-0x000000018993EFE0
		public IRunner GetMainThreadRunner() => default; // 0x0000000187631C00-0x0000000187631CA0
		// [XID] // 0x00000001899465C0-0x00000001899465E0
		public IRunner GetStatRunner() => default; // 0x0000000187631DA0-0x0000000187631E50
		// [XID] // 0x000000018994DCE0-0x000000018994DD00
		public void StartNodeOnFreeRunner(INode node) {} // 0x0000000187631F90-0x00000001876320A0
		// [XID] // 0x0000000189955400-0x0000000189955420
		public void StartNodeOnMainThreadRunner(INode node) {} // 0x00000001876320A0-0x0000000187632180
		// [XID] // 0x000000018995CBE0-0x000000018995CC00
		public void Destroy() {} // 0x00000001876319D0-0x0000000187631B20
	}
}
