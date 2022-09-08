/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class MainThreadRunnerPool : IRunnerPool // TypeDefIndex: 9029
	{
		// Fields
		private MainThreadRunner _runner; // 0x10
	
		// Constructors
		public MainThreadRunnerPool() {} // 0x0000000187630DC0-0x0000000187630E30
	
		// Methods
		// [XID] // 0x000000018982E4B0-0x000000018982E4D0
		public void Init(int threadNum) {} // 0x0000000187630B50-0x0000000187630C00
		// [XID] // 0x0000000189709960-0x0000000189709980
		public IRunner GetRunner(int handler) => default; // 0x0000000187630AA0-0x0000000187630B50
		// [XID] // 0x00000001897113D0-0x00000001897113F0
		public IRunner GetFreeRunner() => default; // 0x0000000187630960-0x0000000187630A00
		// [XID] // 0x0000000189844B50-0x0000000189844B70
		public IRunner GetMainThreadRunner() => default; // 0x0000000187630A00-0x0000000187630AA0
		// [XID] // 0x0000000189A23C90-0x0000000189A23CB0
		public void StartNodeOnFreeRunner(INode node) {} // 0x0000000187630C00-0x0000000187630CE0
		// [XID] // 0x0000000189617B70-0x0000000189617B90
		public void StartNodeOnMainThreadRunner(INode node) {} // 0x0000000187630CE0-0x0000000187630DC0
		// [XID] // 0x000000018985A9D0-0x000000018985A9F0
		public void Destroy() {} // 0x00000001876308B0-0x0000000187630960
	}
}
