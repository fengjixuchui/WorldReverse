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

public sealed class CmdRegisterSpatialListener : ReusedAudioCmd // TypeDefIndex: 10872
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdRegisterSpatialListener, SyncId> // TypeDefIndex: 10873
	{
		// Constructors
		public Spawner() {} // 0x0000000181C39D90-0x0000000181C39DF0

		// Methods
		// [XID] // 0x0000000189A76370-0x0000000189A76390
		public CmdRegisterSpatialListener Spawn(SyncId param1) => default; // 0x0000000181C39C40-0x0000000181C39D90
	}

	public class Polisher : IPolisher<CmdRegisterSpatialListener, SyncId> // TypeDefIndex: 10874
	{
		// Constructors
		public Polisher() {} // 0x0000000181C3A330-0x0000000181C3A390

		// Methods
		// [XID] // 0x0000000189A7DCA0-0x0000000189A7DCC0
		public void Polish(CmdRegisterSpatialListener reused, SyncId param1) {} // 0x0000000181C3A240-0x0000000181C3A330
	}

	// Constructors
	public CmdRegisterSpatialListener() {} // Dummy constructor
	private CmdRegisterSpatialListener(SyncId syncId) {} // 0x0000000181C3BE60-0x0000000181C3BEE0

	// Methods
	// [XID] // 0x0000000189A5FAD0-0x0000000189A5FAF0
	public override void BeforeRecycle() {} // 0x0000000181C3BCD0-0x0000000181C3BDB0
	// [XID] // 0x0000000189A673F0-0x0000000189A67410
	public override void Execute(WorkerThreadContext context) {} // 0x0000000181C3BBE0-0x0000000181C3BCD0
	// [XID] // 0x0000000189A3B9A0-0x0000000189A3B9C0
	public override void Recycle() {} // 0x0000000181C3BDB0-0x0000000181C3BE60
}

