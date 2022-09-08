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

public sealed class WorkerThreadVoiceFunctionalities : WorkerThreadFunctionalities<SharedVoiceFunctionalities> // TypeDefIndex: 11466
{
	// Fields
	private readonly HashSet<uint> _playingVoiceIds; // 0x20

	// Constructors
	public WorkerThreadVoiceFunctionalities() {} // Dummy constructor
	public WorkerThreadVoiceFunctionalities(WorkerThreadContext context, SharedVoiceFunctionalities shared) {} // 0x0000000182DBB2C0-0x0000000182DBB380

	// Methods
	// [XID] // 0x00000001897574C0-0x00000001897574E0
	public override void Init() {} // 0x0000000182DBAEB0-0x0000000182DBAF50
	// [XID] // 0x000000018975ECB0-0x000000018975ECD0
	public override void Tick(TimeSpan deltaTime) {} // 0x0000000182DBAF50-0x0000000182DBAFF0
	// [XID] // 0x0000000189766130-0x0000000189766150
	public override void Destroy() {} // 0x0000000182DBAE10-0x0000000182DBAEB0
	// [XID] // 0x000000018976D9C0-0x000000018976D9E0
	public void AddToPlayingVoiceIds(uint playingId) {} // 0x0000000182DBAD40-0x0000000182DBAE10
	// [XID] // 0x0000000189774DC0-0x0000000189774DE0
	public void RemoveFromPlayingVoiceIds(uint playingId) {} // 0x0000000182DBAFF0-0x0000000182DBB0C0
	// [XID] // 0x000000018977C660-0x000000018977C680
	public void StopAllPlayingVoiceIds() {} // 0x0000000182DBB0C0-0x0000000182DBB2C0
}

