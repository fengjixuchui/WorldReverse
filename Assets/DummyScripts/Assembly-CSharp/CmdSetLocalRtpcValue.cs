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

public sealed class CmdSetLocalRtpcValue : ReusedAudioCmd // TypeDefIndex: 10908
{
	// Fields
	private uint _nameId; // 0x10
	private float _value; // 0x14
	private SyncId _syncId; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdSetLocalRtpcValue, uint, float, SyncId> // TypeDefIndex: 10909
	{
		// Constructors
		public Spawner() {} // 0x00000001849CA400-0x00000001849CA480

		// Methods
		// [XID] // 0x000000018963C280-0x000000018963C2A0
		public CmdSetLocalRtpcValue Spawn(uint param1, float param2, SyncId param3) => default; // 0x00000001849CA280-0x00000001849CA400
	}

	public class Polisher : IPolisher<CmdSetLocalRtpcValue, uint, float, SyncId> // TypeDefIndex: 10910
	{
		// Constructors
		public Polisher() {} // 0x00000001849A91F0-0x00000001849A9380

		// Methods
		// [XID] // 0x0000000189643960-0x0000000189643980
		public void Polish(CmdSetLocalRtpcValue reused, uint param1, float param2, SyncId param3) {} // 0x00000001849A90C0-0x00000001849A91F0
	}

	// Constructors
	public CmdSetLocalRtpcValue() {} // Dummy constructor
	private CmdSetLocalRtpcValue(uint nameId, float value, SyncId syncId) {} // 0x00000001849A9DF0-0x00000001849A9E90

	// Methods
	// [XID] // 0x00000001896257D0-0x00000001896257F0
	public override void BeforeRecycle() {} // 0x00000001849A9C60-0x00000001849A9D40
	// [XID] // 0x0000000189750060-0x0000000189750080
	public override void Execute(WorkerThreadContext context) {} // 0x00000001849A9B60-0x00000001849A9C60
	// [XID] // 0x00000001896F1A10-0x00000001896F1A30
	public override void Recycle() {} // 0x00000001849A9D40-0x00000001849A9DF0
}

