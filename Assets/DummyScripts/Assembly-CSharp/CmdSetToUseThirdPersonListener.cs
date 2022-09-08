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

public sealed class CmdSetToUseThirdPersonListener : ReusedAudioCmd // TypeDefIndex: 10822
{
	// Fields
	private SyncId _emitterId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdSetToUseThirdPersonListener, SyncId> // TypeDefIndex: 10823
	{
		// Constructors
		public Spawner() {} // 0x000000018412B990-0x000000018412B9F0

		// Methods
		// [XID] // 0x0000000189A00620-0x0000000189A00640
		public CmdSetToUseThirdPersonListener Spawn(SyncId param1) => default; // 0x000000018412B840-0x000000018412B990
	}

	public class Polisher : IPolisher<CmdSetToUseThirdPersonListener, SyncId> // TypeDefIndex: 10824
	{
		// Constructors
		public Polisher() {} // 0x000000018412B7E0-0x000000018412B840

		// Methods
		// [XID] // 0x0000000189A07E90-0x0000000189A07EB0
		public void Polish(CmdSetToUseThirdPersonListener reused, SyncId param1) {} // 0x000000018412B6F0-0x000000018412B7E0
	}

	// Constructors
	public CmdSetToUseThirdPersonListener() {} // Dummy constructor
	private CmdSetToUseThirdPersonListener(SyncId emitterId) {} // 0x000000018412E9A0-0x000000018412EA20

	// Methods
	// [XID] // 0x000000018994AD90-0x000000018994ADB0
	public override void BeforeRecycle() {} // 0x000000018412E810-0x000000018412E8F0
	// [XID] // 0x00000001897D5D90-0x00000001897D5DB0
	public override void Execute(WorkerThreadContext context) {} // 0x000000018412E720-0x000000018412E810
	// [XID] // 0x0000000189A06950-0x0000000189A06970
	public override void Recycle() {} // 0x000000018412E8F0-0x000000018412E9A0
}

