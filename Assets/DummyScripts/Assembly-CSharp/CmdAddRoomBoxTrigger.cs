/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CmdAddRoomBoxTrigger : ReusedAudioCmd // TypeDefIndex: 10860
{
	// Fields
	private uint _roomNameId; // 0x10
	private Vector3 _position; // 0x14
	private Quaternion _rotation; // 0x20
	private Vector3 _size; // 0x30

	// Nested types
	public class Spawner : ISpawner<CmdAddRoomBoxTrigger, uint, Vector3, Quaternion, Vector3> // TypeDefIndex: 10861
	{
		// Constructors
		public Spawner() {} // 0x0000000182126680-0x00000001821266E0

		// Methods
		// [XID] // 0x00000001899E0F10-0x00000001899E0F30
		public CmdAddRoomBoxTrigger Spawn(uint param1, Vector3 param2, Quaternion param3, Vector3 param4) => default; // 0x00000001821264A0-0x0000000182126680
	}

	public class Polisher : IPolisher<CmdAddRoomBoxTrigger, uint, Vector3, Quaternion, Vector3> // TypeDefIndex: 10862
	{
		// Constructors
		public Polisher() {} // 0x00000001821249A0-0x0000000182124A00

		// Methods
		// [XID] // 0x0000000189A73480-0x0000000189A734A0
		public void Polish(CmdAddRoomBoxTrigger reused, uint param1, Vector3 param2, Quaternion param3, Vector3 param4) {} // 0x0000000182124820-0x00000001821249A0
	}

	// Constructors
	public CmdAddRoomBoxTrigger() {} // Dummy constructor
	private CmdAddRoomBoxTrigger(uint roomNameId, Vector3 position, Quaternion rotation, Vector3 size) {} // 0x000000018211AD90-0x000000018211AE40

	// Methods
	// [XID] // 0x00000001899CABE0-0x00000001899CAC00
	public override void BeforeRecycle() {} // 0x000000018211AB80-0x000000018211ACE0
	// [XID] // 0x00000001899D22B0-0x00000001899D22D0
	public override void Execute(WorkerThreadContext context) {} // 0x000000018211AA50-0x000000018211AB80
	// [XID] // 0x00000001899D99C0-0x00000001899D99E0
	public override void Recycle() {} // 0x000000018211ACE0-0x000000018211AD90
}

