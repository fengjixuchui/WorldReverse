/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TickModuleStatConcluder // TypeDefIndex: 27867
{
	// Fields
	private CycleStat _statProfilerStat; // 0x10
	private Dictionary<string, CycleStatTickModuleNode> _tmStat; // 0x18

	// Properties
	public double statProfilerFinishTime { /* [XID] */ /* 0x0000000189848B60-0x0000000189848B80 */ set {} } // 0x00000001845A7610-0x00000001845A76E0

	// Constructors
	public TickModuleStatConcluder() {} // 0x00000001845A7900-0x00000001845A79A0

	// Methods
	// [XID] // 0x0000000189A6D850-0x0000000189A6D870
	public static void Swap(ref TickModuleStatConcluder tmsc1, ref TickModuleStatConcluder tmsc2) {} // 0x00000001845A6440-0x00000001845A6500
	// [XID] // 0x0000000189A7CBA0-0x0000000189A7CBC0
	public void OnFrameFinish(Dictionary<string, CycleStatTickModuleNode> inThisframeTMStat, CycleStat inStatprofilerStat) {} // 0x00000001845A6500-0x00000001845A6770
	// [XID] // 0x0000000189A844E0-0x0000000189A84500
	private CycleStatTickModuleNode CreateNameTickModuleMap(CycleStat inStat, bool bAddtoStatPool = true /* Metadata: 0x00B0D0B6 */) => default; // 0x00000001845A74D0-0x00000001845A7610
	// [XID] // 0x0000000189A8BE10-0x0000000189A8BE30
	public void OnConcludeFrameStat(ref StatFrameData unitStat, Dictionary<string, StatMMA> globalModuleMMAMap, List<CycleStatTickModuleNode> cstmnTree) {} // 0x00000001845A6770-0x00000001845A74D0
	// [XID] // 0x0000000189874D30-0x0000000189874D50
	public void Flush() {} // 0x00000001845A76E0-0x00000001845A7900
}

