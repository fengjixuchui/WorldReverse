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

public sealed class CmdAddPlayingVoice : ReusedAudioCmd // TypeDefIndex: 10929
{
	// Fields
	private uint _playingId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdAddPlayingVoice, uint> // TypeDefIndex: 10930
	{
		// Constructors
		public Spawner() {} // 0x0000000183AF27F0-0x0000000183AF2850

		// Methods
		// [XID] // 0x0000000189741060-0x0000000189741080
		public CmdAddPlayingVoice Spawn(uint param1) => default; // 0x0000000183AF2720-0x0000000183AF27F0
	}

	public class Polisher : IPolisher<CmdAddPlayingVoice, uint> // TypeDefIndex: 10931
	{
		// Constructors
		public Polisher() {} // 0x0000000183AF2920-0x0000000183AF2980

		// Methods
		// [XID] // 0x00000001897488B0-0x00000001897488D0
		public void Polish(CmdAddPlayingVoice reused, uint param1) {} // 0x0000000183AF2850-0x0000000183AF2920
	}

	// Constructors
	public CmdAddPlayingVoice() {} // Dummy constructor
	private CmdAddPlayingVoice(uint playingId) {} // 0x0000000183B01CD0-0x0000000183B01D40

	// Methods
	// [XID] // 0x000000018972A590-0x000000018972A5B0
	public override void BeforeRecycle() {} // 0x0000000183B01B80-0x0000000183B01C20
	// [XID] // 0x0000000189731E00-0x0000000189731E20
	public override void Execute(WorkerThreadContext context) {} // 0x0000000183B01AA0-0x0000000183B01B80
	// [XID] // 0x0000000189739340-0x0000000189739360
	public override void Recycle() {} // 0x0000000183B01C20-0x0000000183B01CD0
}

