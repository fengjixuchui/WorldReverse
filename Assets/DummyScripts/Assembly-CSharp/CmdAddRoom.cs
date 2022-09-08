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

public sealed class CmdAddRoom : ReusedAudioCmd // TypeDefIndex: 10857
{
	// Fields
	private uint _roomNameId; // 0x10
	private RoomParams _roomParams; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdAddRoom, uint, RoomParams> // TypeDefIndex: 10858
	{
		// Constructors
		public Spawner() {} // 0x000000018439E370-0x000000018439E3D0

		// Methods
		// [XID] // 0x0000000189A22B60-0x0000000189A22B80
		public CmdAddRoom Spawn(uint roomNameId, RoomParams roomParams) => default; // 0x000000018439E180-0x000000018439E370
	}

	public class Polisher : IPolisher<CmdAddRoom, uint, RoomParams> // TypeDefIndex: 10859
	{
		// Constructors
		public Polisher() {} // 0x00000001843BE2C0-0x00000001843BE320

		// Methods
		// [XID] // 0x00000001899C3750-0x00000001899C3770
		public void Polish(CmdAddRoom reused, uint param1, RoomParams param2) {} // 0x00000001843BE160-0x00000001843BE2C0
	}

	// Constructors
	public CmdAddRoom() {} // Dummy constructor
	private CmdAddRoom(uint roomNameId, RoomParams roomParams) {} // 0x00000001843B2500-0x00000001843B25B0

	// Methods
	// [XID] // 0x000000018965BCB0-0x000000018965BCD0
	public override void BeforeRecycle() {} // 0x00000001843B2320-0x00000001843B2450
	// [XID] // 0x00000001899ACE30-0x00000001899ACE50
	public override void Execute(WorkerThreadContext context) {} // 0x00000001843B21F0-0x00000001843B2320
	// [XID] // 0x00000001899B4690-0x00000001899B46B0
	public override void Recycle() {} // 0x00000001843B2450-0x00000001843B2500
}

