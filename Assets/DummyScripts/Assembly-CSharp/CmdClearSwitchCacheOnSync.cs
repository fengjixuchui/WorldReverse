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

public sealed class CmdClearSwitchCacheOnSync : ReusedAudioCmd // TypeDefIndex: 10899
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdClearSwitchCacheOnSync, SyncId> // TypeDefIndex: 10900
	{
		// Constructors
		public Spawner() {} // 0x000000018296D610-0x000000018296D700

		// Methods
		// [XID] // 0x000000018964FAE0-0x000000018964FB00
		public CmdClearSwitchCacheOnSync Spawn(SyncId param1) => default; // 0x000000018296D4C0-0x000000018296D610
	}

	public class Polisher : IPolisher<CmdClearSwitchCacheOnSync, SyncId> // TypeDefIndex: 10901
	{
		// Constructors
		public Polisher() {} // 0x000000018296C670-0x000000018296C6D0

		// Methods
		// [XID] // 0x0000000189BCE370-0x0000000189BCE390
		public void Polish(CmdClearSwitchCacheOnSync reused, SyncId param1) {} // 0x000000018296C580-0x000000018296C670
	}

	// Constructors
	public CmdClearSwitchCacheOnSync() {} // Dummy constructor
	public CmdClearSwitchCacheOnSync(SyncId syncId) {} // 0x0000000182985240-0x00000001829852C0

	// Methods
	// [XID] // 0x000000018962A380-0x000000018962A3A0
	public override void BeforeRecycle() {} // 0x00000001829850B0-0x0000000182985190
	// [XID] // 0x0000000189BB73E0-0x0000000189BB7400
	public override void Execute(WorkerThreadContext context) {} // 0x0000000182984FC0-0x00000001829850B0
	// [XID] // 0x0000000189648480-0x00000001896484A0
	public override void Recycle() {} // 0x0000000182985190-0x0000000182985240
}

