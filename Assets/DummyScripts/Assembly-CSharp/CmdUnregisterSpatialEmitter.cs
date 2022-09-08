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

public sealed class CmdUnregisterSpatialEmitter : ReusedAudioCmd // TypeDefIndex: 10893
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdUnregisterSpatialEmitter, SyncId> // TypeDefIndex: 10894
	{
		// Constructors
		public Spawner() {} // 0x0000000182D7AF80-0x0000000182D7AFE0

		// Methods
		// [XID] // 0x0000000189B7C430-0x0000000189B7C450
		public CmdUnregisterSpatialEmitter Spawn(SyncId param1) => default; // 0x0000000182D7AE30-0x0000000182D7AF80
	}

	public class Polisher : IPolisher<CmdUnregisterSpatialEmitter, SyncId> // TypeDefIndex: 10895
	{
		// Constructors
		public Polisher() {} // 0x0000000182D7B0D0-0x0000000182D7B130

		// Methods
		// [XID] // 0x0000000189B83FC0-0x0000000189B83FE0
		public void Polish(CmdUnregisterSpatialEmitter reused, SyncId param1) {} // 0x0000000182D7AFE0-0x0000000182D7B0D0
	}

	// Constructors
	public CmdUnregisterSpatialEmitter() {} // Dummy constructor
	private CmdUnregisterSpatialEmitter(SyncId syncId) {} // 0x0000000182D6A9C0-0x0000000182D6AA40

	// Methods
	// [XID] // 0x0000000189B66340-0x0000000189B66360
	public override void BeforeRecycle() {} // 0x0000000182D6A830-0x0000000182D6A910
	// [XID] // 0x0000000189B6D8B0-0x0000000189B6D8D0
	public override void Execute(WorkerThreadContext context) {} // 0x0000000182D6A740-0x0000000182D6A830
	// [XID] // 0x0000000189B74E90-0x0000000189B74EB0
	public override void Recycle() {} // 0x0000000182D6A910-0x0000000182D6A9C0
}

