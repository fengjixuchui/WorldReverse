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

public sealed class CmdHandleMusicStimulus : ReusedAudioCmd // TypeDefIndex: 10828
{
	// Fields
	private MusicStimulus _stimulus; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdHandleMusicStimulus, MusicStimulus> // TypeDefIndex: 10829
	{
		// Constructors
		public Spawner() {} // 0x00000001837F6350-0x00000001837F63B0

		// Methods
		// [XID] // 0x000000018982FAD0-0x000000018982FAF0
		public CmdHandleMusicStimulus Spawn(MusicStimulus param1) => default; // 0x00000001837F6280-0x00000001837F6350
	}

	public class Polisher : IPolisher<CmdHandleMusicStimulus, MusicStimulus> // TypeDefIndex: 10830
	{
		// Constructors
		public Polisher() {} // 0x00000001837F6930-0x00000001837F6990

		// Methods
		// [XID] // 0x0000000189837330-0x0000000189837350
		public void Polish(CmdHandleMusicStimulus reused, MusicStimulus param1) {} // 0x00000001837F6860-0x00000001837F6930
	}

	// Constructors
	public CmdHandleMusicStimulus() {} // Dummy constructor
	private CmdHandleMusicStimulus(MusicStimulus stimulus) {} // 0x00000001837E6310-0x00000001837E6380

	// Methods
	// [XID] // 0x0000000189819A70-0x0000000189819A90
	public override void BeforeRecycle() {} // 0x00000001837E61C0-0x00000001837E6260
	// [XID] // 0x0000000189821260-0x0000000189821280
	public override void Execute(WorkerThreadContext context) {} // 0x00000001837E60E0-0x00000001837E61C0
	// [XID] // 0x0000000189828780-0x00000001898287A0
	public override void Recycle() {} // 0x00000001837E6260-0x00000001837E6310
}

