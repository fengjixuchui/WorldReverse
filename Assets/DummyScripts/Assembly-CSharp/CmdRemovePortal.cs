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

public sealed class CmdRemovePortal : ReusedAudioCmd // TypeDefIndex: 10875
{
	// Fields
	private uint _portalNameId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdRemovePortal, uint> // TypeDefIndex: 10876
	{
		// Constructors
		public Spawner() {} // 0x0000000182674C20-0x0000000182674C80

		// Methods
		// [XID] // 0x0000000189A9BBE0-0x0000000189A9BC00
		public CmdRemovePortal Spawn(uint param1) => default; // 0x0000000182674B50-0x0000000182674C20
	}

	public class Polisher : IPolisher<CmdRemovePortal, uint> // TypeDefIndex: 10877
	{
		// Constructors
		public Polisher() {} // 0x00000001826547F0-0x0000000182654850

		// Methods
		// [XID] // 0x0000000189AA3140-0x0000000189AA3160
		public void Polish(CmdRemovePortal reused, uint param1) {} // 0x0000000182654720-0x00000001826547F0
	}

	// Constructors
	public CmdRemovePortal() {} // Dummy constructor
	private CmdRemovePortal(uint portalNameId) {} // 0x000000018266F780-0x000000018266F7F0

	// Methods
	// [XID] // 0x0000000189649C20-0x0000000189649C40
	public override void BeforeRecycle() {} // 0x000000018266F630-0x000000018266F6D0
	// [XID] // 0x0000000189741290-0x00000001897412B0
	public override void Execute(WorkerThreadContext context) {} // 0x000000018266F550-0x000000018266F630
	// [XID] // 0x0000000189A94230-0x0000000189A94250
	public override void Recycle() {} // 0x000000018266F6D0-0x000000018266F780
}

