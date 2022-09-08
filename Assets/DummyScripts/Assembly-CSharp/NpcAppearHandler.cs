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

public sealed class NpcAppearHandler : SliceFrameJobHandler // TypeDefIndex: 21257
{
	// Fields
	private uint _configId; // 0x18
	private uint _roomId; // 0x1C
	private uint _mainQuestId; // 0x20
	private Vector3 _pos; // 0x24
	private Vector3 _rot; // 0x30
	private uint _runtimeId; // 0x3C

	// Properties
	public uint runtimeID { /* [XID] */ /* 0x0000000189A1A090-0x0000000189A1A0B0 */ get => default; } // 0x00000001814725C0-0x0000000181472660 

	// Constructors
	public NpcAppearHandler() {} // 0x0000000181472A50-0x0000000181472AB0

	// Methods
	// [XID] // 0x0000000189A215D0-0x0000000189A215F0
	public static NpcAppearHandler Alloc(uint configId, uint roomId, uint mainQuestId, Vector3 pos, Vector3 rot, uint runtimeID = 0 /* Metadata: 0x00AFF175 */) => default; // 0x00000001814728C0-0x0000000181472A50
	// [XID] // 0x0000000189A28B90-0x0000000189A28BB0
	public override void Handle(int i) {} // 0x0000000181472700-0x0000000181472860
	// [XID] // 0x0000000189A30290-0x0000000189A302B0
	public override void Dispose() {} // 0x0000000181472660-0x0000000181472700
}

