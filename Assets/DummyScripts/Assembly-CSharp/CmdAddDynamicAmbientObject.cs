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

public sealed class CmdAddDynamicAmbientObject : ReusedAudioCmd // TypeDefIndex: 10771
{
	// Fields
	private int _id; // 0x10
	private Vector3 _position; // 0x14
	private Quaternion _rotation; // 0x20
	private Vector3 _scale; // 0x30
	private ulong _prefabHash; // 0x40

	// Nested types
	public class Spawner : ISpawner<CmdAddDynamicAmbientObject, int, Vector3, Quaternion, Vector3, ulong> // TypeDefIndex: 10772
	{
		// Constructors
		public Spawner() {} // 0x0000000181678F60-0x0000000181678FC0

		// Methods
		// [XID] // 0x0000000189934790-0x00000001899347B0
		public CmdAddDynamicAmbientObject Spawn(int param1, Vector3 param2, Quaternion param3, Vector3 param4, ulong param5) => default; // 0x0000000181678D60-0x0000000181678F60
	}

	public class Polisher : IPolisher<CmdAddDynamicAmbientObject, int, Vector3, Quaternion, Vector3, ulong> // TypeDefIndex: 10773
	{
		// Constructors
		public Polisher() {} // 0x0000000181678480-0x00000001816784E0

		// Methods
		// [XID] // 0x000000018993C2B0-0x000000018993C2D0
		public void Polish(CmdAddDynamicAmbientObject reused, int param1, Vector3 param2, Quaternion param3, Vector3 param4, ulong param5) {} // 0x00000001816782E0-0x0000000181678480
	}

	// Constructors
	public CmdAddDynamicAmbientObject() {} // Dummy constructor
	public CmdAddDynamicAmbientObject(int id, Vector3 position, Quaternion rotation, Vector3 scale, ulong prefabHash) {} // 0x0000000181682740-0x00000001816827F0

	// Methods
	// [XID] // 0x00000001899F7A10-0x00000001899F7A30
	public override void BeforeRecycle() {} // 0x0000000181682550-0x0000000181682690
	// [XID] // 0x0000000189B46B80-0x0000000189B46BA0
	public override void Execute(WorkerThreadContext context) {} // 0x0000000181682410-0x0000000181682550
	// [XID] // 0x00000001896AE2D0-0x00000001896AE2F0
	public override void Recycle() {} // 0x0000000181682690-0x0000000181682740
}

