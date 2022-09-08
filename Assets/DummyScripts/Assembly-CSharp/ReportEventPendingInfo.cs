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

public sealed class ReportEventPendingInfo : ReusedAudioReport // TypeDefIndex: 10978
{
	// Fields
	private int frameNumber; // 0x10
	private int successCount; // 0x14
	private int failCount; // 0x18
	private int waitCount; // 0x1C

	// Nested types
	public class Spawner : ISpawner<ReportEventPendingInfo, int, int, int, int> // TypeDefIndex: 10979
	{
		// Constructors
		public Spawner() {} // 0x0000000182F47900-0x0000000182F47960

		// Methods
		// [XID] // 0x00000001899CABC0-0x00000001899CABE0
		public ReportEventPendingInfo Spawn(int param1, int param2, int param3, int param4) => default; // 0x0000000182F477F0-0x0000000182F47900
	}

	public class Polisher : IPolisher<ReportEventPendingInfo, int, int, int, int> // TypeDefIndex: 10980
	{
		// Constructors
		public Polisher() {} // 0x0000000182F47040-0x0000000182F470A0

		// Methods
		// [XID] // 0x00000001899D2290-0x00000001899D22B0
		public void Polish(ReportEventPendingInfo reused, int param1, int param2, int param3, int param4) {} // 0x0000000182F46F30-0x0000000182F47040
	}

	// Constructors
	public ReportEventPendingInfo() {} // Dummy constructor
	private ReportEventPendingInfo(int frame, int success, int fail, int wait) {} // 0x0000000182F42FC0-0x0000000182F43060

	// Methods
	// [XID] // 0x00000001899B4670-0x00000001899B4690
	public override void BeforeRecycle() {} // 0x0000000182F42E70-0x0000000182F42F10
	// [XID] // 0x00000001899BBB60-0x00000001899BBB80
	public override void Digest(CommandThreadContext context) {} // 0x0000000182F42D80-0x0000000182F42E70
	// [XID] // 0x00000001899C3730-0x00000001899C3750
	public override void Recycle() {} // 0x0000000182F42F10-0x0000000182F42FC0
}

