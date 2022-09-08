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

public sealed class CmdSetGlobalRoom : ReusedAudioCmd // TypeDefIndex: 10881
{
	// Fields
	private uint _roomNameId; // 0x10
	private RoomParams _roomParams; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdSetGlobalRoom, uint, RoomParams> // TypeDefIndex: 10882
	{
		// Constructors
		public Spawner() {} // 0x0000000184BDCA00-0x0000000184BDCA60

		// Methods
		// [XID] // 0x0000000189AE7500-0x0000000189AE7520
		public CmdSetGlobalRoom Spawn(uint roomNameId, RoomParams roomParams) => default; // 0x0000000184BDC810-0x0000000184BDCA00
	}

	public class Polisher : IPolisher<CmdSetGlobalRoom, uint, RoomParams> // TypeDefIndex: 10883
	{
		// Constructors
		public Polisher() {} // 0x0000000184BDC140-0x0000000184BDC1A0

		// Methods
		// [XID] // 0x0000000189AEF2D0-0x0000000189AEF2F0
		public void Polish(CmdSetGlobalRoom reused, uint param1, RoomParams param2) {} // 0x0000000184BDBFE0-0x0000000184BDC140
	}

	// Constructors
	public CmdSetGlobalRoom() {} // Dummy constructor
	private CmdSetGlobalRoom(uint roomNameId, RoomParams roomParams) {} // 0x0000000184BF64C0-0x0000000184BF6570

	// Methods
	// [XID] // 0x0000000189B3AD30-0x0000000189B3AD50
	public override void BeforeRecycle() {} // 0x0000000184BF62E0-0x0000000184BF6410
	// [XID] // 0x0000000189B424D0-0x0000000189B424F0
	public override void Execute(WorkerThreadContext context) {} // 0x0000000184BF61B0-0x0000000184BF62E0
	// [XID] // 0x00000001898839B0-0x00000001898839D0
	public override void Recycle() {} // 0x0000000184BF6410-0x0000000184BF64C0
}

