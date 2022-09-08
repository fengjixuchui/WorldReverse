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

public sealed class ReportEventStartPlaying : ReusedAudioReport // TypeDefIndex: 10981
{
	// Fields
	private EventIdPair _idPair; // 0x10

	// Nested types
	public class Spawner : ISpawner<ReportEventStartPlaying, EventIdPair> // TypeDefIndex: 10982
	{
		// Constructors
		public Spawner() {} // 0x0000000182BE9840-0x0000000182BE98A0

		// Methods
		// [XID] // 0x00000001899F0220-0x00000001899F0240
		public ReportEventStartPlaying Spawn(EventIdPair param1) => default; // 0x0000000182BE9770-0x0000000182BE9840
	}

	public class Polisher : IPolisher<ReportEventStartPlaying, EventIdPair> // TypeDefIndex: 10983
	{
		// Constructors
		public Polisher() {} // 0x0000000182BE9A70-0x0000000182BE9AD0

		// Methods
		// [XID] // 0x00000001899F7810-0x00000001899F7830
		public void Polish(ReportEventStartPlaying reused, EventIdPair param1) {} // 0x0000000182BE99A0-0x0000000182BE9A70
	}

	// Constructors
	public ReportEventStartPlaying() {} // Dummy constructor
	private ReportEventStartPlaying(EventIdPair idPair) {} // 0x0000000182BEDB70-0x0000000182BEDBE0

	// Methods
	// [XID] // 0x00000001899D99A0-0x00000001899D99C0
	public override void BeforeRecycle() {} // 0x0000000182BEDA00-0x0000000182BEDAC0
	// [XID] // 0x00000001899E0EF0-0x00000001899E0F10
	public override void Digest(CommandThreadContext context) {} // 0x0000000182BED920-0x0000000182BEDA00
	// [XID] // 0x00000001899E8AC0-0x00000001899E8AE0
	public override void Recycle() {} // 0x0000000182BEDAC0-0x0000000182BEDB70
}

