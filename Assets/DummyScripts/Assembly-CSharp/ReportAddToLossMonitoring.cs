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

public sealed class ReportAddToLossMonitoring : ReusedAudioReport // TypeDefIndex: 10990
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<ReportAddToLossMonitoring, SyncId> // TypeDefIndex: 10991
	{
		// Constructors
		public Spawner() {} // 0x00000001820370C0-0x0000000182037120

		// Methods
		// [XID] // 0x0000000189A6EA60-0x0000000189A6EA80
		public ReportAddToLossMonitoring Spawn(SyncId param1) => default; // 0x0000000182036F70-0x00000001820370C0
	}

	public class Polisher : IPolisher<ReportAddToLossMonitoring, SyncId> // TypeDefIndex: 10992
	{
		// Constructors
		public Polisher() {} // 0x0000000182037640-0x0000000182037730

		// Methods
		// [XID] // 0x000000018984EF90-0x000000018984EFB0
		public void Polish(ReportAddToLossMonitoring reused, SyncId param1) {} // 0x0000000182037550-0x0000000182037640
	}

	// Constructors
	public ReportAddToLossMonitoring() {} // Dummy constructor
	private ReportAddToLossMonitoring(SyncId syncId) {} // 0x0000000182033550-0x00000001820335D0

	// Methods
	// [XID] // 0x00000001897E0840-0x00000001897E0860
	public override void BeforeRecycle() {} // 0x00000001820333C0-0x00000001820334A0
	// [XID] // 0x00000001897E7ED0-0x00000001897E7EF0
	public override void Digest(CommandThreadContext context) {} // 0x00000001820332D0-0x00000001820333C0
	// [XID] // 0x0000000189840100-0x0000000189840120
	public override void Recycle() {} // 0x00000001820334A0-0x0000000182033550
}

