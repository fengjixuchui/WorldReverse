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

public sealed class ReportRemoveFromLossMonitoring : ReusedAudioReport // TypeDefIndex: 10993
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<ReportRemoveFromLossMonitoring, SyncId> // TypeDefIndex: 10994
	{
		// Constructors
		public Spawner() {} // 0x000000018416D980-0x000000018416D9E0

		// Methods
		// [XID] // 0x0000000189889A00-0x0000000189889A20
		public ReportRemoveFromLossMonitoring Spawn(SyncId param1) => default; // 0x000000018416D830-0x000000018416D980
	}

	public class Polisher : IPolisher<ReportRemoveFromLossMonitoring, SyncId> // TypeDefIndex: 10995
	{
		// Constructors
		public Polisher() {} // 0x000000018416D7D0-0x000000018416D830

		// Methods
		// [XID] // 0x0000000189A9BBC0-0x0000000189A9BBE0
		public void Polish(ReportRemoveFromLossMonitoring reused, SyncId param1) {} // 0x000000018416D6E0-0x000000018416D7D0
	}

	// Constructors
	public ReportRemoveFromLossMonitoring() {} // Dummy constructor
	private ReportRemoveFromLossMonitoring(SyncId syncId) {} // 0x0000000184175B00-0x0000000184175B80

	// Methods
	// [XID] // 0x0000000189A7DC80-0x0000000189A7DCA0
	public override void BeforeRecycle() {} // 0x0000000184175970-0x0000000184175A50
	// [XID] // 0x0000000189864CD0-0x0000000189864CF0
	public override void Digest(CommandThreadContext context) {} // 0x0000000184175880-0x0000000184175970
	// [XID] // 0x0000000189882360-0x0000000189882380
	public override void Recycle() {} // 0x0000000184175A50-0x0000000184175B00
}

