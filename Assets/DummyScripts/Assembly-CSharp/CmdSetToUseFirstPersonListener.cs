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

public sealed class CmdSetToUseFirstPersonListener : ReusedAudioCmd // TypeDefIndex: 10816
{
	// Fields
	private SyncId _emitterId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdSetToUseFirstPersonListener, SyncId> // TypeDefIndex: 10817
	{
		// Constructors
		public Spawner() {} // 0x0000000183CD3EB0-0x0000000183CD3F10

		// Methods
		// [XID] // 0x0000000189798C70-0x0000000189798C90
		public CmdSetToUseFirstPersonListener Spawn(SyncId param1) => default; // 0x0000000183CD3D60-0x0000000183CD3EB0
	}

	public class Polisher : IPolisher<CmdSetToUseFirstPersonListener, SyncId> // TypeDefIndex: 10818
	{
		// Constructors
		public Polisher() {} // 0x0000000183CD3D00-0x0000000183CD3D60

		// Methods
		// [XID] // 0x00000001897A0B50-0x00000001897A0B70
		public void Polish(CmdSetToUseFirstPersonListener reused, SyncId param1) {} // 0x0000000183CD3C10-0x0000000183CD3D00
	}

	// Constructors
	public CmdSetToUseFirstPersonListener() {} // Dummy constructor
	private CmdSetToUseFirstPersonListener(SyncId emitterId) {} // 0x0000000183CB2FF0-0x0000000183CB3070

	// Methods
	// [XID] // 0x0000000189782B80-0x0000000189782BA0
	public override void BeforeRecycle() {} // 0x0000000183CB2E60-0x0000000183CB2F40
	// [XID] // 0x0000000189789DF0-0x0000000189789E10
	public override void Execute(WorkerThreadContext context) {} // 0x0000000183CB2D70-0x0000000183CB2E60
	// [XID] // 0x00000001897915F0-0x0000000189791610
	public override void Recycle() {} // 0x0000000183CB2F40-0x0000000183CB2FF0
}

