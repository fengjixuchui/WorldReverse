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

public sealed class CmdRegisterSync : ReusedAudioCmd // TypeDefIndex: 10902
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdRegisterSync, SyncId> // TypeDefIndex: 10903
	{
		// Constructors
		public Spawner() {} // 0x0000000183751C70-0x0000000183751CD0

		// Methods
		// [XID] // 0x0000000189675750-0x0000000189675770
		public CmdRegisterSync Spawn(SyncId param1) => default; // 0x0000000183751B20-0x0000000183751C70
	}

	public class Polisher : IPolisher<CmdRegisterSync, SyncId> // TypeDefIndex: 10904
	{
		// Constructors
		public Polisher() {} // 0x0000000183751670-0x00000001837516D0

		// Methods
		// [XID] // 0x00000001895F8E80-0x00000001895F8EA0
		public void Polish(CmdRegisterSync reused, SyncId param1) {} // 0x0000000183751580-0x0000000183751670
	}

	// Constructors
	public CmdRegisterSync() {} // Dummy constructor
	private CmdRegisterSync(SyncId syncId) {} // 0x0000000183764F70-0x0000000183764FF0

	// Methods
	// [XID] // 0x0000000189BD5610-0x0000000189BD5630
	public override void BeforeRecycle() {} // 0x0000000183764DE0-0x0000000183764EC0
	// [XID] // 0x0000000189666120-0x0000000189666140
	public override void Execute(WorkerThreadContext context) {} // 0x0000000183764CF0-0x0000000183764DE0
	// [XID] // 0x00000001895E9C40-0x00000001895E9C60
	public override void Recycle() {} // 0x0000000183764EC0-0x0000000183764F70
}

