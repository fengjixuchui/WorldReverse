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

public sealed class ReportTotalSyncsCount : ReusedAudioReport // TypeDefIndex: 10996
{
	// Fields
	private int _count; // 0x10

	// Nested types
	public class Spawner : ISpawner<ReportTotalSyncsCount, int> // TypeDefIndex: 10997
	{
		// Constructors
		public Spawner() {} // 0x0000000181FCE6F0-0x0000000181FCE750

		// Methods
		// [XID] // 0x00000001898B6010-0x00000001898B6030
		public ReportTotalSyncsCount Spawn(int param1) => default; // 0x0000000181FCE620-0x0000000181FCE6F0
	}

	public class Polisher : IPolisher<ReportTotalSyncsCount, int> // TypeDefIndex: 10998
	{
		// Constructors
		public Polisher() {} // 0x0000000181FD08F0-0x0000000181FD0950

		// Methods
		// [XID] // 0x0000000189AC1490-0x0000000189AC14B0
		public void Polish(ReportTotalSyncsCount reused, int param1) {} // 0x0000000181FD0820-0x0000000181FD08F0
	}

	// Constructors
	public ReportTotalSyncsCount() {} // Dummy constructor
	private ReportTotalSyncsCount(int count) {} // 0x0000000181FB02E0-0x0000000181FB0350

	// Methods
	// [XID] // 0x0000000189898490-0x00000001898984B0
	public override void BeforeRecycle() {} // 0x0000000181FB0190-0x0000000181FB0230
	// [XID] // 0x0000000189AAA610-0x0000000189AAA630
	public override void Digest(CommandThreadContext context) {} // 0x0000000181FB00B0-0x0000000181FB0190
	// [XID] // 0x0000000189AB2490-0x0000000189AB24B0
	public override void Recycle() {} // 0x0000000181FB0230-0x0000000181FB02E0
}

