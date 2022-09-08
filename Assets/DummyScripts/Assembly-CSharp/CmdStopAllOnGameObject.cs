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

public sealed class CmdStopAllOnGameObject : ReusedAudioCmd // TypeDefIndex: 10785
{
	// Fields
	private SyncId _syncId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdStopAllOnGameObject, SyncId> // TypeDefIndex: 10786
	{
		// Constructors
		public Spawner() {} // 0x000000018393F720-0x000000018393F780

		// Methods
		// [XID] // 0x000000018960DC50-0x000000018960DC70
		public CmdStopAllOnGameObject Spawn(SyncId param1) => default; // 0x000000018393F5D0-0x000000018393F720
	}

	public class Polisher : IPolisher<CmdStopAllOnGameObject, SyncId> // TypeDefIndex: 10787
	{
		// Constructors
		public Polisher() {} // 0x000000018393F570-0x000000018393F5D0

		// Methods
		// [XID] // 0x00000001896153D0-0x00000001896153F0
		public void Polish(CmdStopAllOnGameObject reused, SyncId param1) {} // 0x000000018393F480-0x000000018393F570
	}

	// Constructors
	public CmdStopAllOnGameObject() {} // Dummy constructor
	private CmdStopAllOnGameObject(SyncId syncId) {} // 0x0000000183940A10-0x0000000183940A90

	// Methods
	// [XID] // 0x00000001895F7670-0x00000001895F7690
	public override void BeforeRecycle() {} // 0x0000000183940880-0x0000000183940960
	// [XID] // 0x0000000189AD8480-0x0000000189AD84A0
	public override void Execute(WorkerThreadContext context) {} // 0x0000000183940790-0x0000000183940880
	// [XID] // 0x0000000189B34960-0x0000000189B34980
	public override void Recycle() {} // 0x0000000183940960-0x0000000183940A10
}

