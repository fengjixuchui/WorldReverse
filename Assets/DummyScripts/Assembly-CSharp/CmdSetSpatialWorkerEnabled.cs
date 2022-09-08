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

internal sealed class CmdSetSpatialWorkerEnabled : ReusedAudioCmd // TypeDefIndex: 10887
{
	// Fields
	private bool _enabled; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdSetSpatialWorkerEnabled, bool> // TypeDefIndex: 10888
	{
		// Constructors
		public Spawner() {} // 0x000000018226D500-0x000000018226D560

		// Methods
		// [XID] // 0x0000000189B31AA0-0x0000000189B31AC0
		public CmdSetSpatialWorkerEnabled Spawn(bool enabled) => default; // 0x000000018226D430-0x000000018226D500
	}

	public class Polisher : IPolisher<CmdSetSpatialWorkerEnabled, bool> // TypeDefIndex: 10889
	{
		// Constructors
		public Polisher() {} // 0x000000018226D2A0-0x000000018226D300

		// Methods
		// [XID] // 0x0000000189B38F10-0x0000000189B38F30
		public void Polish(CmdSetSpatialWorkerEnabled reused, bool param1) {} // 0x000000018226D1D0-0x000000018226D2A0
	}

	// Constructors
	public CmdSetSpatialWorkerEnabled() {} // Dummy constructor
	private CmdSetSpatialWorkerEnabled(bool enabled) {} // 0x000000018227AD00-0x000000018227AD70

	// Methods
	// [XID] // 0x0000000189B1B8F0-0x0000000189B1B910
	public override void BeforeRecycle() {} // 0x000000018227ABB0-0x000000018227AC50
	// [XID] // 0x0000000189B22E90-0x0000000189B22EB0
	public override void Execute(WorkerThreadContext context) {} // 0x000000018227AAD0-0x000000018227ABB0
	// [XID] // 0x0000000189B2A4E0-0x0000000189B2A500
	public override void Recycle() {} // 0x000000018227AC50-0x000000018227AD00
}

