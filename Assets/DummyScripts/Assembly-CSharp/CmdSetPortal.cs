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

public sealed class CmdSetPortal : ReusedAudioCmd // TypeDefIndex: 10884
{
	// Fields
	private uint _portalNameId; // 0x10
	private RoomPortalParams _portalParams; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdSetPortal, uint, RoomPortalParams> // TypeDefIndex: 10885
	{
		// Constructors
		public Spawner() {} // 0x0000000181F6B910-0x0000000181F6B970

		// Methods
		// [XID] // 0x0000000189B0CB80-0x0000000189B0CBA0
		public CmdSetPortal Spawn(uint portalNameId, RoomPortalParams portalParams) => default; // 0x0000000181F6B760-0x0000000181F6B910
	}

	public class Polisher : IPolisher<CmdSetPortal, uint, RoomPortalParams> // TypeDefIndex: 10886
	{
		// Constructors
		public Polisher() {} // 0x0000000181F4AF50-0x0000000181F4AFB0

		// Methods
		// [XID] // 0x0000000189B140A0-0x0000000189B140C0
		public void Polish(CmdSetPortal reused, uint param1, RoomPortalParams param2) {} // 0x0000000181F4AE20-0x0000000181F4AF50
	}

	// Constructors
	public CmdSetPortal() {} // Dummy constructor
	private CmdSetPortal(uint portalNameId, RoomPortalParams portalParams) {} // 0x0000000181F609B0-0x0000000181F60A50

	// Methods
	// [XID] // 0x0000000189AF65E0-0x0000000189AF6600
	public override void BeforeRecycle() {} // 0x0000000181F60810-0x0000000181F60900
	// [XID] // 0x0000000189AFDC90-0x0000000189AFDCB0
	public override void Execute(WorkerThreadContext context) {} // 0x0000000181F60700-0x0000000181F60810
	// [XID] // 0x0000000189B053B0-0x0000000189B053D0
	public override void Recycle() {} // 0x0000000181F60900-0x0000000181F609B0
}

