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

public sealed class CmdUnregisterSpatialListener : ReusedAudioCmd // TypeDefIndex: 10896
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdUnregisterSpatialListener, SyncId> // TypeDefIndex: 10897
	{
		// Constructors
		public Spawner() {} // 0x0000000182331E10-0x0000000182331E70

		// Methods
		// [XID] // 0x000000018961B500-0x000000018961B520
		public CmdUnregisterSpatialListener Spawn(SyncId param1) => default; // 0x0000000182331CC0-0x0000000182331E10
	}

	public class Polisher : IPolisher<CmdUnregisterSpatialListener, SyncId> // TypeDefIndex: 10898
	{
		// Constructors
		public Polisher() {} // 0x0000000182311E30-0x0000000182311E90

		// Methods
		// [XID] // 0x0000000189622B20-0x0000000189622B40
		public void Polish(CmdUnregisterSpatialListener reused, SyncId param1) {} // 0x0000000182311D40-0x0000000182311E30
	}

	// Constructors
	public CmdUnregisterSpatialListener() {} // Dummy constructor
	private CmdUnregisterSpatialListener(SyncId syncId) {} // 0x0000000182312110-0x0000000182312190

	// Methods
	// [XID] // 0x0000000189B8AFC0-0x0000000189B8AFE0
	public override void BeforeRecycle() {} // 0x0000000182311F80-0x0000000182312060
	// [XID] // 0x0000000189B92760-0x0000000189B92780
	public override void Execute(WorkerThreadContext context) {} // 0x0000000182311E90-0x0000000182311F80
	// [XID] // 0x0000000189613CA0-0x0000000189613CC0
	public override void Recycle() {} // 0x0000000182312060-0x0000000182312110
}

