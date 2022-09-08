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

internal sealed class CmdSetArea2DAmbienceEnabled : ReusedAudioCmd // TypeDefIndex: 10780
{
	// Fields
	private bool _enabled; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdSetArea2DAmbienceEnabled, bool> // TypeDefIndex: 10781
	{
		// Constructors
		public Spawner() {} // 0x000000018289C340-0x000000018289C3A0

		// Methods
		// [XID] // 0x0000000189BC4FE0-0x0000000189BC5000
		public CmdSetArea2DAmbienceEnabled Spawn(bool enabled) => default; // 0x000000018289C270-0x000000018289C340
	}

	public class Polisher : IPolisher<CmdSetArea2DAmbienceEnabled, bool> // TypeDefIndex: 10782
	{
		// Constructors
		public Polisher() {} // 0x000000018289C210-0x000000018289C270

		// Methods
		// [XID] // 0x0000000189A9BE70-0x0000000189A9BE90
		public void Polish(CmdSetArea2DAmbienceEnabled reused, bool param1) {} // 0x000000018289C140-0x000000018289C210
	}

	// Constructors
	public CmdSetArea2DAmbienceEnabled() {} // Dummy constructor
	private CmdSetArea2DAmbienceEnabled(bool enabled) {} // 0x00000001828B1A10-0x00000001828B1A80

	// Methods
	// [XID] // 0x0000000189986CE0-0x0000000189986D00
	public override void BeforeRecycle() {} // 0x00000001828B18C0-0x00000001828B1960
	// [XID] // 0x0000000189BB5DB0-0x0000000189BB5DD0
	public override void Execute(WorkerThreadContext context) {} // 0x00000001828B17D0-0x00000001828B18C0
	// [XID] // 0x0000000189BBD3B0-0x0000000189BBD3D0
	public override void Recycle() {} // 0x00000001828B1960-0x00000001828B1A10
}

