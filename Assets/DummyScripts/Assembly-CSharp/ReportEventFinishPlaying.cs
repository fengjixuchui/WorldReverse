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

public sealed class ReportEventFinishPlaying : ReusedAudioReport // TypeDefIndex: 10975
{
	// Fields
	private uint _playingId; // 0x10

	// Nested types
	public class Spawner : ISpawner<ReportEventFinishPlaying, uint> // TypeDefIndex: 10976
	{
		// Constructors
		public Spawner() {} // 0x000000018226D3D0-0x000000018226D430

		// Methods
		// [XID] // 0x0000000189AF5060-0x0000000189AF5080
		public ReportEventFinishPlaying Spawn(uint param1) => default; // 0x000000018226D300-0x000000018226D3D0
	}

	public class Polisher : IPolisher<ReportEventFinishPlaying, uint> // TypeDefIndex: 10977
	{
		// Constructors
		public Polisher() {} // 0x000000018226D630-0x000000018226D690

		// Methods
		// [XID] // 0x00000001899ACE10-0x00000001899ACE30
		public void Polish(ReportEventFinishPlaying reused, uint param1) {} // 0x000000018226D560-0x000000018226D630
	}

	// Constructors
	public ReportEventFinishPlaying() {} // Dummy constructor
	private ReportEventFinishPlaying(uint playingId) {} // 0x000000018228A400-0x000000018228A470

	// Methods
	// [XID] // 0x0000000189A599B0-0x0000000189A599D0
	public override void BeforeRecycle() {} // 0x000000018228A2B0-0x000000018228A350
	// [XID] // 0x00000001899960E0-0x0000000189996100
	public override void Digest(CommandThreadContext context) {} // 0x000000018228A1D0-0x000000018228A2B0
	// [XID] // 0x000000018999DAA0-0x000000018999DAC0
	public override void Recycle() {} // 0x000000018228A350-0x000000018228A400
}

