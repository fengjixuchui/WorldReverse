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

public sealed class CmdSetSwitch : ReusedAudioCmd // TypeDefIndex: 10920
{
	// Fields
	private uint _nameId; // 0x10
	private uint _valueId; // 0x14
	private SyncId _syncId; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdSetSwitch, uint, uint, SyncId> // TypeDefIndex: 10921
	{
		// Constructors
		public Spawner() {} // 0x00000001835E1900-0x00000001835E1960

		// Methods
		// [XID] // 0x0000000189852ED0-0x0000000189852EF0
		public CmdSetSwitch Spawn(uint param1, uint param2, SyncId param3) => default; // 0x00000001835E1780-0x00000001835E1900
	}

	public class Polisher : IPolisher<CmdSetSwitch, uint, uint, SyncId> // TypeDefIndex: 10922
	{
		// Constructors
		public Polisher() {} // 0x00000001835C0350-0x00000001835C03B0

		// Methods
		// [XID] // 0x00000001896D8B00-0x00000001896D8B20
		public void Polish(CmdSetSwitch reused, uint param1, uint param2, SyncId param3) {} // 0x00000001835C0230-0x00000001835C0350
	}

	// Constructors
	public CmdSetSwitch() {} // Dummy constructor
	private CmdSetSwitch(uint nameId, uint valueId, SyncId syncId) {} // 0x00000001835D6110-0x00000001835D61A0

	// Methods
	// [XID] // 0x00000001896BB440-0x00000001896BB460
	public override void BeforeRecycle() {} // 0x00000001835D5F80-0x00000001835D6060
	// [XID] // 0x00000001896C26C0-0x00000001896C26E0
	public override void Execute(WorkerThreadContext context) {} // 0x00000001835D5E80-0x00000001835D5F80
	// [XID] // 0x00000001896C9C50-0x00000001896C9C70
	public override void Recycle() {} // 0x00000001835D6060-0x00000001835D6110
}

