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

public sealed class CmdPauseOrResume : ReusedAudioCmd // TypeDefIndex: 10802
{
	// Fields
	private bool _pause; // 0x10
	private SyncId _syncId; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdPauseOrResume, bool, SyncId> // TypeDefIndex: 10803
	{
		// Constructors
		public Spawner() {} // 0x00000001850BD6C0-0x00000001850BD720

		// Methods
		// [XID] // 0x00000001896E5E00-0x00000001896E5E20
		public CmdPauseOrResume Spawn(bool param1, SyncId param2) => default; // 0x00000001850BD550-0x00000001850BD6C0
	}

	public class Polisher : IPolisher<CmdPauseOrResume, bool, SyncId> // TypeDefIndex: 10804
	{
		// Constructors
		public Polisher() {} // 0x00000001850BD830-0x00000001850BD890

		// Methods
		// [XID] // 0x0000000189821460-0x0000000189821480
		public void Polish(CmdPauseOrResume reused, bool param1, SyncId param2) {} // 0x00000001850BD720-0x00000001850BD830
	}

	// Constructors
	public CmdPauseOrResume() {} // Dummy constructor
	public CmdPauseOrResume(bool pause, SyncId syncId) {} // 0x00000001850B36C0-0x00000001850B3750

	// Methods
	// [XID] // 0x00000001897261A0-0x00000001897261C0
	public override void BeforeRecycle() {} // 0x00000001850B3530-0x00000001850B3610
	// [XID] // 0x00000001896D73A0-0x00000001896D73C0
	public override void Execute(WorkerThreadContext context) {} // 0x00000001850B3440-0x00000001850B3530
	// [XID] // 0x0000000189803310-0x0000000189803330
	public override void Recycle() {} // 0x00000001850B3610-0x00000001850B36C0
}

