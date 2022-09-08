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

public sealed class CmdHandleMusicUInt32Stimulus : CmdHandleMusicParameterizedStimulus // TypeDefIndex: 10832
{
	// Fields
	private uint _parameter; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdHandleMusicUInt32Stimulus, MusicStimulus, uint> // TypeDefIndex: 10833
	{
		// Constructors
		public Spawner() {} // 0x00000001845C6870-0x00000001845C68D0

		// Methods
		// [XID] // 0x000000018986AAF0-0x000000018986AB10
		public CmdHandleMusicUInt32Stimulus Spawn(MusicStimulus param1, uint param2) => default; // 0x00000001845C6790-0x00000001845C6870
	}

	public class Polisher : IPolisher<CmdHandleMusicUInt32Stimulus, MusicStimulus, uint> // TypeDefIndex: 10834
	{
		// Constructors
		public Polisher() {} // 0x00000001845A5AB0-0x00000001845A5B10

		// Methods
		// [XID] // 0x0000000189871E90-0x0000000189871EB0
		public void Polish(CmdHandleMusicUInt32Stimulus reused, MusicStimulus param1, uint param2) {} // 0x00000001845A59C0-0x00000001845A5AB0
	}

	// Constructors
	public CmdHandleMusicUInt32Stimulus() {} // Dummy constructor
	private CmdHandleMusicUInt32Stimulus(MusicStimulus stimulus, uint parameter) {} // 0x00000001845A5DC0-0x00000001845A5E40

	// Methods
	// [XID] // 0x0000000189854550-0x0000000189854570
	public override void BeforeRecycle() {} // 0x00000001845A5C00-0x00000001845A5CB0
	// [XID] // 0x000000018985BF40-0x000000018985BF60
	public override void Execute(WorkerThreadContext context) {} // 0x00000001845A5B10-0x00000001845A5C00
	// [XID] // 0x0000000189B3AD50-0x0000000189B3AD70
	public override void Recycle() {} // 0x00000001845A5CB0-0x00000001845A5D60
}

