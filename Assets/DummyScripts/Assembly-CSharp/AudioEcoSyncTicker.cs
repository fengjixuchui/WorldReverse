/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioEcoSyncTicker : AudioStuffTicker<ReusedAudioSync> // TypeDefIndex: 11476
{
	// Fields
	private readonly CommandThreadContext _context; // 0x18

	// Constructors
	public AudioEcoSyncTicker() {} // Dummy constructor
	public AudioEcoSyncTicker(CommandThreadContext context) {} // 0x000000018322F910-0x000000018322F990

	// Methods
	// [XID] // 0x0000000189B4CC90-0x0000000189B4CCB0
	protected override void Added(ReusedAudioSync t) {} // 0x000000018322F390-0x000000018322F450
	// [XID] // 0x0000000189B633F0-0x0000000189B63410
	protected override void Tick(float deltaTime, ReusedAudioSync t) {} // 0x000000018322F450-0x000000018322F520
	// [XID] // 0x0000000189B79920-0x0000000189B79940
	protected override bool IsFinished(ReusedAudioSync t) => default; // 0x000000018322F5D0-0x000000018322F690
	// [XID] // 0x000000018992B8C0-0x000000018992B8E0
	protected override void Terminate(ReusedAudioSync t, bool natural) {} // 0x000000018322F730-0x000000018322F910
	// [XID] // 0x0000000189933060-0x0000000189933080
	protected override void Removed(ReusedAudioSync t) {} // 0x000000018322F520-0x000000018322F5D0
	// [XID] // 0x000000018993A900-0x000000018993A920
	protected override void Destroyed() {} // 0x000000018322F690-0x000000018322F730
}

