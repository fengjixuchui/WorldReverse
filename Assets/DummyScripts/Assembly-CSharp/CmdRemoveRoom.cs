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

public sealed class CmdRemoveRoom : ReusedAudioCmd // TypeDefIndex: 10878
{
	// Fields
	private uint _roomNameId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdRemoveRoom, uint> // TypeDefIndex: 10879
	{
		// Constructors
		public Spawner() {} // 0x0000000180DD0220-0x0000000180DD0280

		// Methods
		// [XID] // 0x0000000189AC14B0-0x0000000189AC14D0
		public CmdRemoveRoom Spawn(uint param1) => default; // 0x0000000180DD0150-0x0000000180DD0220
	}

	public class Polisher : IPolisher<CmdRemoveRoom, uint> // TypeDefIndex: 10880
	{
		// Constructors
		public Polisher() {} // 0x0000000180DD00F0-0x0000000180DD0150

		// Methods
		// [XID] // 0x0000000189775190-0x00000001897751B0
		public void Polish(CmdRemoveRoom reused, uint param1) {} // 0x0000000180DD0020-0x0000000180DD00F0
	}

	// Constructors
	public CmdRemoveRoom() {} // Dummy constructor
	private CmdRemoveRoom(uint roomNameId) {} // 0x0000000180DD08A0-0x0000000180DD0910

	// Methods
	// [XID] // 0x0000000189AAA630-0x0000000189AAA650
	public override void BeforeRecycle() {} // 0x0000000180DD0720-0x0000000180DD07F0
	// [XID] // 0x0000000189AB24B0-0x0000000189AB24D0
	public override void Execute(WorkerThreadContext context) {} // 0x0000000180DD0640-0x0000000180DD0720
	// [XID] // 0x0000000189AB9920-0x0000000189AB9940
	public override void Recycle() {} // 0x0000000180DD07F0-0x0000000180DD08A0
}

