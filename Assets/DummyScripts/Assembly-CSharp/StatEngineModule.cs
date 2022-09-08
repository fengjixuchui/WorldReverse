/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StatEngineModule : SingletonStat<StatEngineModule> // TypeDefIndex: 27876
{
	// Fields
	private int _moduleCount; // 0x38
	private string _sessionName; // 0x40
	private StatMMA[] _moduleStats; // 0x48

	// Constructors
	public StatEngineModule() {} // 0x0000000181A823E0-0x0000000181A82490

	// Methods
	// [XID] // 0x0000000189B84A40-0x0000000189B84A60
	private void OnAnalyzeFrame(ref StatFrameData inFrameData) {} // 0x0000000181A81FE0-0x0000000181A82110
	// [XID] // 0x0000000189B8B7B0-0x0000000189B8B7D0
	protected override void OnStart(string inSessionID) {} // 0x0000000181A81DE0-0x0000000181A81FE0
	// [XID] // 0x0000000189B92F20-0x0000000189B92F40
	protected override void OnStop() {} // 0x0000000181A821C0-0x0000000181A823E0
	// [XID] // 0x0000000189B9A520-0x0000000189B9A540
	protected override void OnTakeSnapshot(bool bDetailMode) {} // 0x0000000181A82110-0x0000000181A821C0
}

