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

public sealed class CmdRegisterSpatialEmitter : ReusedAudioCmd // TypeDefIndex: 10869
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdRegisterSpatialEmitter, SyncId> // TypeDefIndex: 10870
	{
		// Constructors
		public Spawner() {} // 0x00000001834410F0-0x0000000183441150

		// Methods
		// [XID] // 0x0000000189A255D0-0x0000000189A255F0
		public CmdRegisterSpatialEmitter Spawn(SyncId param1) => default; // 0x0000000183440FA0-0x00000001834410F0
	}

	public class Polisher : IPolisher<CmdRegisterSpatialEmitter, SyncId> // TypeDefIndex: 10871
	{
		// Constructors
		public Polisher() {} // 0x0000000183441240-0x00000001834412A0

		// Methods
		// [XID] // 0x0000000189A57E40-0x0000000189A57E60
		public void Polish(CmdRegisterSpatialEmitter reused, SyncId param1) {} // 0x0000000183441150-0x0000000183441240
	}

	// Constructors
	public CmdRegisterSpatialEmitter() {} // Dummy constructor
	private CmdRegisterSpatialEmitter(SyncId syncId) {} // 0x00000001834330A0-0x0000000183433120

	// Methods
	// [XID] // 0x0000000189A3A1D0-0x0000000189A3A1F0
	public override void BeforeRecycle() {} // 0x0000000183432F10-0x0000000183432FF0
	// [XID] // 0x0000000189A41A70-0x0000000189A41A90
	public override void Execute(WorkerThreadContext context) {} // 0x0000000183432E20-0x0000000183432F10
	// [XID] // 0x0000000189A49090-0x0000000189A490B0
	public override void Recycle() {} // 0x0000000183432FF0-0x00000001834330A0
}

