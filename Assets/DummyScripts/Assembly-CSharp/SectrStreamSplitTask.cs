/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SectrStreamSplitTask : ThreadTask<SectrStreamSplitData> // TypeDefIndex: 26638
{
	// Fields
	private const string _taskName = "SectrStreamSplit"; // Metadata: 0x00B0C791
	private bool _bShouldTick; // 0x48
	private SECTR_ThreadContext _context; // 0x50

	// Properties
	public override string taskName { /* [XID] */ /* 0x00000001898D78D0-0x00000001898D78F0 */ get => default; } // 0x00000001839ACD60-0x00000001839ACE10 
	public override bool isValid { /* [XID] */ /* 0x00000001898DF580-0x00000001898DF5A0 */ get => default; } // 0x00000001839ACCC0-0x00000001839ACD60 

	// Constructors
	public SectrStreamSplitTask() {} // 0x00000001839ACC40-0x00000001839ACCC0

	// Methods
	// [XID] // 0x00000001898E7000-0x00000001898E7020
	public void Init(SECTR_ThreadContext t) {} // 0x00000001839AC9A0-0x00000001839ACA70
	// [XID] // 0x00000001898EE770-0x00000001898EE790
	public override void Collect() {} // 0x00000001839AC510-0x00000001839AC740
	// [XID] // 0x00000001898F5F20-0x00000001898F5F40
	public override void Execute() {} // 0x00000001839AC8C0-0x00000001839AC9A0
	// [XID] // 0x00000001898FD7C0-0x00000001898FD7E0
	public override void Flush() {} // 0x00000001839ACA70-0x00000001839ACB10
	// [XID] // 0x0000000189905020-0x0000000189905040
	public override void Destroy() {} // 0x00000001839AC740-0x00000001839AC7F0
}

