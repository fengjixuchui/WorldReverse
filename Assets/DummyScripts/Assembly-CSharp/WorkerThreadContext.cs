/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class WorkerThreadContext // TypeDefIndex: 11544
{
	// Fields
	private readonly List<AudioCmd> _freshCmds; // 0x10
	private readonly List<AudioReport> _freshReports; // 0x18
	private readonly WwiseInterface _wwiseInterface; // 0x20

	// Properties
	public int frameCount { /* [XID] */ /* 0x000000018985E6C0-0x000000018985E700 */ get; /* [XID] */ /* 0x0000000189869230-0x0000000189869270 */ private set; } // 0x00000001831F3C20-0x00000001831F3C80 0x00000001831F3C80-0x00000001831F3CE0
	public WorkerThreadAmbienceFunctionalities ambience { /* [XID] */ /* 0x0000000189873530-0x0000000189873560 */ get; set; } // 0x00000001831F47F0-0x00000001831F4850 0x00000001831F42E0-0x00000001831F4340
	public WorkerThreadControlFunctionalities control { /* [XID] */ /* 0x00000001898851A0-0x00000001898851E0 */ get; set; } // 0x00000001831F39F0-0x00000001831F3A50 0x00000001831F4850-0x00000001831F48B0
	public WorkerThreadDevFunctionalities dev { get; set; } // 0x00000001831F3A50-0x00000001831F3AB0 0x00000001831F44C0-0x00000001831F4520
	public WorkerThreadEngineFunctionalities engine { /* [XID] */ /* 0x00000001898A5970-0x00000001898A59B0 */ get; set; } // 0x00000001831F3AB0-0x00000001831F3B10 0x00000001831F4280-0x00000001831F42E0
	public WorkerThreadEventFunctionalities events { /* [XID] */ /* 0x00000001898B7510-0x00000001898B7550 */ get; set; } // 0x00000001831F3F80-0x00000001831F3FE0 0x00000001831F3EC0-0x00000001831F3F20
	public WorkerThreadListenerFunctionalities listeners { /* [XID] */ /* 0x00000001898C97A0-0x00000001898C97D0 */ get; set; } // 0x00000001831F4100-0x00000001831F4160 0x00000001831F43A0-0x00000001831F4400
	public WorkerThreadMusicFunctionalities music { /* [XID] */ /* 0x00000001898DB520-0x00000001898DB560 */ get; set; } // 0x00000001831F4040-0x00000001831F40A0 0x00000001831F4340-0x00000001831F43A0
	public WorkerThreadQuestFunctionalities quest { /* [XID] */ /* 0x00000001898EDCB0-0x00000001898EDCF0 */ get; set; } // 0x00000001831F41C0-0x00000001831F4220 0x00000001831F3F20-0x00000001831F3F80
	public WorkerThreadSoundBankFunctionalities soundBanks { /* [XID] */ /* 0x00000001898FFFE0-0x0000000189900010 */ get; set; } // 0x00000001831F4460-0x00000001831F44C0 0x00000001831F4400-0x00000001831F4460
	public WorkerThreadSyncFunctionalities syncs { /* [XID] */ /* 0x0000000189911F10-0x0000000189911F50 */ get; set; } // 0x00000001831F4160-0x00000001831F41C0 0x00000001831F3FE0-0x00000001831F4040
	public WorkerThreadVoiceFunctionalities voices { /* [XID] */ /* 0x0000000189924430-0x0000000189924470 */ get; set; } // 0x00000001831F40A0-0x00000001831F4100 0x00000001831F3D80-0x00000001831F3DF0
	public WorkerThreadSpatialFunctionalities spatial { /* [XID] */ /* 0x0000000189935B80-0x0000000189935BC0 */ get; set; } // 0x00000001831F4220-0x00000001831F4280 0x00000001831F4780-0x00000001831F47F0
	public List<AudioCmd> freshCmds { /* [XID] */ /* 0x0000000189947BD0-0x0000000189947BF0 */ get => default; } // 0x00000001831F3CE0-0x00000001831F3D80 
	public List<AudioReport> freshReports { /* [XID] */ /* 0x000000018994F2B0-0x000000018994F2D0 */ get => default; } // 0x00000001831F45C0-0x00000001831F4660 
	public WwiseInterface wwiseInterface { /* [XID] */ /* 0x0000000189956840-0x0000000189956860 */ get => default; } // 0x00000001831F4520-0x00000001831F45C0 

	// Constructors
	public WorkerThreadContext() {} // Dummy constructor
	public WorkerThreadContext(WwiseInterface wwiseInterface) {} // 0x00000001831F48B0-0x00000001831F49B0

	// Methods
	// [XID] // 0x000000018995E330-0x000000018995E350
	public void SubmitReport(AudioReport report) {} // 0x00000001831F3DF0-0x00000001831F3EC0
	// [XID] // 0x000000018980D710-0x000000018980D730
	public void TryRecycleCmd(AudioCmd cmd) {} // 0x00000001831F3B10-0x00000001831F3C20
	// [XID] // 0x000000018996D250-0x000000018996D270
	public void TickFrameCount() {} // 0x00000001831F4660-0x00000001831F4780
}

