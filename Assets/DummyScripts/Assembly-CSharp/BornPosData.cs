/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BornPosData // TypeDefIndex: 21253
{
	// Fields
	public Vector3 position; // 0x10
	public Vector3 rotation; // 0x1C
	public uint roomId; // 0x28
	public uint sceneId; // 0x2C
	public bool isRoomType; // 0x30
	public NpcBornInfo npcInfo; // 0x38
	public RecycledLinkedList<BornPosData> listNode; // 0x40
	public uint groupId; // 0x48
	public uint suiteId; // 0x4C
	public uint[] suiteIdList; // 0x50
	public bool isSuiteEnable; // 0x58
	public uint dynUniqId; // 0x5C

	// Properties
	public bool isEnable { /* [XID] */ /* 0x00000001899D7280-0x00000001899D72A0 */ get => default; } // 0x0000000182FB4830-0x0000000182FB48E0 

	// Constructors
	public BornPosData() {} // 0x0000000182FB48E0-0x0000000182FB4950

	// Methods
	// [XID] // 0x00000001899DE6D0-0x00000001899DE6F0
	public bool CheckSuiteEnable(uint curIndex) => default; // 0x0000000182FB46B0-0x0000000182FB4790
	// [XID] // 0x00000001899E63F0-0x00000001899E6410
	public void Reset() {} // 0x0000000182FB4790-0x0000000182FB4830
}

