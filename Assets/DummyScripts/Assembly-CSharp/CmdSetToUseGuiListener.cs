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

public sealed class CmdSetToUseGuiListener : ReusedAudioCmd // TypeDefIndex: 10819
{
	// Fields
	private SyncId _emitterId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdSetToUseGuiListener, SyncId> // TypeDefIndex: 10820
	{
		// Constructors
		public Spawner() {} // 0x000000018249CE30-0x000000018249CE90

		// Methods
		// [XID] // 0x00000001897BF960-0x00000001897BF980
		public CmdSetToUseGuiListener Spawn(SyncId param1) => default; // 0x000000018249CCE0-0x000000018249CE30
	}

	public class Polisher : IPolisher<CmdSetToUseGuiListener, SyncId> // TypeDefIndex: 10821
	{
		// Constructors
		public Polisher() {} // 0x000000018249CF80-0x000000018249CFE0

		// Methods
		// [XID] // 0x00000001897C7130-0x00000001897C7150
		public void Polish(CmdSetToUseGuiListener reused, SyncId param1) {} // 0x000000018249CE90-0x000000018249CF80
	}

	// Constructors
	public CmdSetToUseGuiListener() {} // Dummy constructor
	private CmdSetToUseGuiListener(SyncId emitterId) {} // 0x000000018248BB20-0x000000018248BBA0

	// Methods
	// [XID] // 0x00000001897A81D0-0x00000001897A81F0
	public override void BeforeRecycle() {} // 0x000000018248B990-0x000000018248BA70
	// [XID] // 0x00000001897AFC90-0x00000001897AFCB0
	public override void Execute(WorkerThreadContext context) {} // 0x000000018248B8A0-0x000000018248B990
	// [XID] // 0x0000000189934770-0x0000000189934790
	public override void Recycle() {} // 0x000000018248BA70-0x000000018248BB20
}

