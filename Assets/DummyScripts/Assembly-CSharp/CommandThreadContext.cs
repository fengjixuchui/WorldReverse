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

public class CommandThreadContext // TypeDefIndex: 11010
{
	// Fields
	private readonly List<AudioCmd> _freshCmds; // 0x10
	private readonly List<AudioReport> _freshReports; // 0x18
	private readonly WwiseInterface _wwiseInterface; // 0x20

	// Properties
	public CommandThreadAmbienceFunctionalities ambience { /* [XID] */ /* 0x0000000189B92720-0x0000000189B92760 */ get; set; } // 0x00000001830251D0-0x0000000183025230 0x0000000183024DE0-0x0000000183024E40
	public CommandThreadControlFunctionalities control { /* [XID] */ /* 0x0000000189BA4340-0x0000000189BA4380 */ get; set; } // 0x00000001830244F0-0x0000000183024550 0x0000000183025230-0x0000000183025290
	public CommandThreadDevFunctionalities dev { /* [XID] */ /* 0x0000000189BB5D70-0x0000000189BB5DB0 */ get; set; } // 0x0000000183024550-0x00000001830245B0 0x0000000183024FC0-0x0000000183025020
	public CommandThreadEngineFunctionalities engine { get; set; } // 0x00000001830245B0-0x0000000183024610 0x0000000183024C70-0x0000000183024CD0
	public CommandThreadEventFunctionalities events { /* [XID] */ /* 0x0000000189BD6E00-0x0000000189BD6E40 */ get; set; } // 0x00000001830248B0-0x0000000183024910 0x00000001830247F0-0x0000000183024850
	public CommandThreadListenerFunctionalities listeners { /* [XID] */ /* 0x00000001895EE590-0x00000001895EE5D0 */ get; set; } // 0x0000000183024AF0-0x0000000183024B50 0x0000000183024EA0-0x0000000183024F00
	public CommandThreadMusicFunctionalities music { /* [XID] */ /* 0x00000001896001B0-0x00000001896001F0 */ get; set; } // 0x00000001830249D0-0x0000000183024A30 0x0000000183024E40-0x0000000183024EA0
	public CommandThreadQuestFunctionalities quest { get; set; } // 0x0000000183024BB0-0x0000000183024C10 0x0000000183024850-0x00000001830248B0
	public CommandThreadSoundBankFunctionalities soundBanks { /* [XID] */ /* 0x0000000189621030-0x0000000189621070 */ get; set; } // 0x0000000183024F60-0x0000000183024FC0 0x0000000183024F00-0x0000000183024F60
	public CommandThreadSyncFunctionalities syncs { /* [XID] */ /* 0x0000000189633090-0x00000001896330D0 */ get; set; } // 0x0000000183024B50-0x0000000183024BB0 0x0000000183024970-0x00000001830249D0
	public CommandThreadUiFunctionalities ui { get; set; } // 0x0000000183024910-0x0000000183024970 0x0000000183024A90-0x0000000183024AF0
	public CommandThreadVoiceFunctionalities voices { /* [XID] */ /* 0x0000000189654030-0x0000000189654070 */ get; set; } // 0x0000000183024A30-0x0000000183024A90 0x0000000183024780-0x00000001830247F0
	public CommandThreadSpatialFunctionalities spatial { /* [XID] */ /* 0x0000000189665E80-0x0000000189665EC0 */ get; set; } // 0x0000000183024C10-0x0000000183024C70 0x0000000183025160-0x00000001830251D0
	public List<AudioCmd> freshCmds { /* [XID] */ /* 0x00000001898D4040-0x00000001898D4060 */ get => default; } // 0x00000001830246E0-0x0000000183024780 
	public List<AudioReport> freshReports { /* [XID] */ /* 0x000000018967FD10-0x000000018967FD30 */ get => default; } // 0x00000001830250C0-0x0000000183025160 
	public WwiseInterface wwiseInterface { /* [XID] */ /* 0x0000000189687360-0x0000000189687380 */ get => default; } // 0x0000000183025020-0x00000001830250C0 

	// Constructors
	public CommandThreadContext() {} // Dummy constructor
	public CommandThreadContext(WwiseInterface wwiseInterface) {} // 0x0000000183025290-0x0000000183025350

	// Methods
	// [XID] // 0x000000018968F170-0x000000018968F190
	public void SubmitCmd(AudioCmd cmd) {} // 0x0000000183024610-0x00000001830246E0
	// [XID] // 0x00000001898F2760-0x00000001898F2780
	public void TryRecycleReport(AudioReport report) {} // 0x0000000183024CD0-0x0000000183024DE0
}

