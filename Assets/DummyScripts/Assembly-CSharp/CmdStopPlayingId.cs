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

public sealed class CmdStopPlayingId : ReusedAudioCmd // TypeDefIndex: 10788
{
	// Fields
	private uint _playingId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdStopPlayingId, uint> // TypeDefIndex: 10789
	{
		// Constructors
		public Spawner() {} // 0x000000018113F220-0x000000018113F4B0

		// Methods
		// [XID] // 0x00000001898B2F20-0x00000001898B2F40
		public CmdStopPlayingId Spawn(uint param1) => default; // 0x000000018113F150-0x000000018113F220
	}

	public class Polisher : IPolisher<CmdStopPlayingId, uint> // TypeDefIndex: 10790
	{
		// Constructors
		public Polisher() {} // 0x0000000181110F90-0x00000001811110D0

		// Methods
		// [XID] // 0x0000000189B61AE0-0x0000000189B61B00
		public void Polish(CmdStopPlayingId reused, uint param1) {} // 0x0000000181110EC0-0x0000000181110F90
	}

	// Constructors
	public CmdStopPlayingId() {} // Dummy constructor
	private CmdStopPlayingId(uint playingId) {} // 0x000000018111D680-0x000000018111D6F0

	// Methods
	// [XID] // 0x000000018961CBE0-0x000000018961CC00
	public override void BeforeRecycle() {} // 0x000000018111D530-0x000000018111D5D0
	// [XID] // 0x0000000189624060-0x0000000189624080
	public override void Execute(WorkerThreadContext context) {} // 0x000000018111D450-0x000000018111D530
	// [XID] // 0x0000000189B5A5E0-0x0000000189B5A600
	public override void Recycle() {} // 0x000000018111D5D0-0x000000018111D680
}

