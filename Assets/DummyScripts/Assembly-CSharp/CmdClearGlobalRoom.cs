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

public sealed class CmdClearGlobalRoom : ReusedAudioCmd // TypeDefIndex: 10866
{
	// Nested types
	public class Spawner : ISpawner<CmdClearGlobalRoom> // TypeDefIndex: 10867
	{
		// Constructors
		public Spawner() {} // 0x0000000182DBD6D0-0x0000000182DBD730

		// Methods
		// [XID] // 0x0000000189A2B200-0x0000000189A2B220
		public CmdClearGlobalRoom Spawn() => default; // 0x0000000182DBD5D0-0x0000000182DBD6D0
	}

	public class Polisher : IPolisher<CmdClearGlobalRoom> // TypeDefIndex: 10868
	{
		// Constructors
		public Polisher() {} // 0x0000000182DBD840-0x0000000182DBDB00

		// Methods
		// [XID] // 0x0000000189A32810-0x0000000189A32830
		public void Polish(CmdClearGlobalRoom reused) {} // 0x0000000182DBD790-0x0000000182DBD840
	}

	// Constructors
	private CmdClearGlobalRoom() {} // 0x0000000182DAC8A0-0x0000000182DAC900

	// Methods
	// [XID] // 0x0000000189A15340-0x0000000189A15360
	public override void BeforeRecycle() {} // 0x0000000182DAC760-0x0000000182DAC800
	// [XID] // 0x0000000189A1C5B0-0x0000000189A1C5D0
	public override void Execute(WorkerThreadContext context) {} // 0x0000000182DAC690-0x0000000182DAC760
	// [XID] // 0x0000000189A23E90-0x0000000189A23EB0
	public override void Recycle() {} // 0x0000000182DAC800-0x0000000182DAC8A0
}

