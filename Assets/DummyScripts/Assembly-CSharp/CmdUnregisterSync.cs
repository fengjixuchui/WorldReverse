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

public sealed class CmdUnregisterSync : ReusedAudioCmd // TypeDefIndex: 10923
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdUnregisterSync, SyncId> // TypeDefIndex: 10924
	{
		// Constructors
		public Spawner() {} // 0x000000018128C220-0x000000018128C280

		// Methods
		// [XID] // 0x00000001896F66E0-0x00000001896F6700
		public CmdUnregisterSync Spawn(SyncId param1) => default; // 0x000000018128C0D0-0x000000018128C220
	}

	public class Polisher : IPolisher<CmdUnregisterSync, SyncId> // TypeDefIndex: 10925
	{
		// Constructors
		public Polisher() {} // 0x000000018128C370-0x000000018128C3D0

		// Methods
		// [XID] // 0x00000001896FDDF0-0x00000001896FDE10
		public void Polish(CmdUnregisterSync reused, SyncId param1) {} // 0x000000018128C280-0x000000018128C370
	}

	// Constructors
	public CmdUnregisterSync() {} // Dummy constructor
	private CmdUnregisterSync(SyncId syncId) {} // 0x0000000181273C30-0x0000000181273CB0

	// Methods
	// [XID] // 0x00000001896E0370-0x00000001896E0390
	public override void BeforeRecycle() {} // 0x0000000181273AA0-0x0000000181273B80
	// [XID] // 0x00000001896E7640-0x00000001896E7660
	public override void Execute(WorkerThreadContext context) {} // 0x00000001812739B0-0x0000000181273AA0
	// [XID] // 0x0000000189870630-0x0000000189870650
	public override void Recycle() {} // 0x0000000181273B80-0x0000000181273C30
}

