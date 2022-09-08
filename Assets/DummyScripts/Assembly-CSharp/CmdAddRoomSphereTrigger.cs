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

public sealed class CmdAddRoomSphereTrigger : ReusedAudioCmd // TypeDefIndex: 10863
{
	// Fields
	private uint _roomNameId; // 0x10
	private Vector3 _position; // 0x14
	private float _radius; // 0x20

	// Nested types
	public class Spawner : ISpawner<CmdAddRoomSphereTrigger, uint, Vector3, float> // TypeDefIndex: 10864
	{
		// Constructors
		public Spawner() {} // 0x000000018169D9C0-0x000000018169DA20

		// Methods
		// [XID] // 0x0000000189A067C0-0x0000000189A067E0
		public CmdAddRoomSphereTrigger Spawn(uint param1, Vector3 param2, float param3) => default; // 0x000000018169D850-0x000000018169D9C0
	}

	public class Polisher : IPolisher<CmdAddRoomSphereTrigger, uint, Vector3, float> // TypeDefIndex: 10865
	{
		// Constructors
		public Polisher() {} // 0x000000018169D7D0-0x000000018169D850

		// Methods
		// [XID] // 0x0000000189A0DCE0-0x0000000189A0DD00
		public void Polish(CmdAddRoomSphereTrigger reused, uint param1, Vector3 param2, float param3) {} // 0x000000018169D6B0-0x000000018169D7D0
	}

	// Constructors
	public CmdAddRoomSphereTrigger() {} // Dummy constructor
	private CmdAddRoomSphereTrigger(uint roomNameId, Vector3 position, float radius) {} // 0x00000001816ACD10-0x00000001816ACDB0

	// Methods
	// [XID] // 0x0000000189A7B090-0x0000000189A7B0B0
	public override void BeforeRecycle() {} // 0x00000001816ACB50-0x00000001816ACC60
	// [XID] // 0x00000001899F7830-0x00000001899F7850
	public override void Execute(WorkerThreadContext context) {} // 0x00000001816ACA50-0x00000001816ACB50
	// [XID] // 0x00000001899FEEC0-0x00000001899FEEE0
	public override void Recycle() {} // 0x00000001816ACC60-0x00000001816ACD10
}

