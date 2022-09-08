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

public sealed class ReportMonitorMessage : ReusedAudioReport // TypeDefIndex: 10969
{
	// Fields
	private MonitorMessage _message; // 0x10

	// Nested types
	public class Spawner : ISpawner<ReportMonitorMessage, MonitorMessage> // TypeDefIndex: 10970
	{
		// Constructors
		public Spawner() {} // 0x000000018389A7B0-0x000000018389A810

		// Methods
		// [XID] // 0x00000001898924A0-0x00000001898924C0
		public ReportMonitorMessage Spawn(MonitorMessage param1) => default; // 0x000000018389A660-0x000000018389A7B0
	}

	public class Polisher : IPolisher<ReportMonitorMessage, MonitorMessage> // TypeDefIndex: 10971
	{
		// Constructors
		public Polisher() {} // 0x0000000183899CF0-0x0000000183899D50

		// Methods
		// [XID] // 0x0000000189961390-0x00000001899613B0
		public void Polish(ReportMonitorMessage reused, MonitorMessage param1) {} // 0x0000000183899C00-0x0000000183899CF0
	}

	// Constructors
	public ReportMonitorMessage() {} // Dummy constructor
	public ReportMonitorMessage(MonitorMessage message) {} // 0x000000018389B380-0x000000018389B400

	// Methods
	// [XID] // 0x00000001897663B0-0x00000001897663D0
	public override void BeforeRecycle() {} // 0x000000018389B210-0x000000018389B2D0
	// [XID] // 0x000000018994AC20-0x000000018994AC40
	public override void Digest(CommandThreadContext context) {} // 0x000000018389B120-0x000000018389B210
	// [XID] // 0x0000000189952550-0x0000000189952570
	public override void Recycle() {} // 0x000000018389B2D0-0x000000018389B380
}

