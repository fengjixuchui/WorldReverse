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

public sealed class CmdResetToUseDefaultListener : ReusedAudioCmd // TypeDefIndex: 10813
{
	// Fields
	private SyncId _emitterId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdResetToUseDefaultListener, SyncId> // TypeDefIndex: 10814
	{
		// Constructors
		public Spawner() {} // 0x0000000181432DC0-0x0000000181432E20

		// Methods
		// [XID] // 0x00000001897737C0-0x00000001897737E0
		public CmdResetToUseDefaultListener Spawn(SyncId param1) => default; // 0x0000000181432C70-0x0000000181432DC0
	}

	public class Polisher : IPolisher<CmdResetToUseDefaultListener, SyncId> // TypeDefIndex: 10815
	{
		// Constructors
		public Polisher() {} // 0x0000000181432F10-0x0000000181432F70

		// Methods
		// [XID] // 0x0000000189970400-0x0000000189970420
		public void Polish(CmdResetToUseDefaultListener reused, SyncId param1) {} // 0x0000000181432E20-0x0000000181432F10
	}

	// Constructors
	public CmdResetToUseDefaultListener() {} // Dummy constructor
	private CmdResetToUseDefaultListener(SyncId emitterId) {} // 0x0000000181415730-0x00000001814157B0

	// Methods
	// [XID] // 0x0000000189925C50-0x0000000189925C70
	public override void BeforeRecycle() {} // 0x00000001814155A0-0x0000000181415680
	// [XID] // 0x00000001897648C0-0x00000001897648E0
	public override void Execute(WorkerThreadContext context) {} // 0x00000001814154B0-0x00000001814155A0
	// [XID] // 0x0000000189959D50-0x0000000189959D70
	public override void Recycle() {} // 0x0000000181415680-0x0000000181415730
}

