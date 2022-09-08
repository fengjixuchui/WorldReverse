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

public sealed class CmdPauseOrResumeInGameBuses : ReusedAudioCmd // TypeDefIndex: 10805
{
	// Fields
	private bool _pause; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdPauseOrResumeInGameBuses, bool> // TypeDefIndex: 10806
	{
		// Constructors
		public Spawner() {} // 0x0000000182CD23A0-0x0000000182CD2400

		// Methods
		// [XID] // 0x00000001897FBFE0-0x00000001897FC000
		public CmdPauseOrResumeInGameBuses Spawn(bool param1) => default; // 0x0000000182CD22D0-0x0000000182CD23A0
	}

	public class Polisher : IPolisher<CmdPauseOrResumeInGameBuses, bool> // TypeDefIndex: 10807
	{
		// Constructors
		public Polisher() {} // 0x0000000182CD25B0-0x0000000182CD2610

		// Methods
		// [XID] // 0x0000000189712AF0-0x0000000189712B10
		public void Polish(CmdPauseOrResumeInGameBuses reused, bool param1) {} // 0x0000000182CD24E0-0x0000000182CD25B0
	}

	// Constructors
	public CmdPauseOrResumeInGameBuses() {} // Dummy constructor
	public CmdPauseOrResumeInGameBuses(bool pause) {} // 0x0000000182CCBDD0-0x0000000182CCBE40

	// Methods
	// [XID] // 0x00000001896F4DC0-0x00000001896F4DE0
	public override void BeforeRecycle() {} // 0x0000000182CCBC80-0x0000000182CCBD20
	// [XID] // 0x00000001896FC510-0x00000001896FC530
	public override void Execute(WorkerThreadContext context) {} // 0x0000000182CCBBA0-0x0000000182CCBC80
	// [XID] // 0x0000000189703B00-0x0000000189703B20
	public override void Recycle() {} // 0x0000000182CCBD20-0x0000000182CCBDD0
}

