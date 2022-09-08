/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigHitScene : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17529
{
	// Fields
	private string _defaultEffect; // 0x10
	private Dictionary<string, string> _surfaceEffect; // 0x18

	// Properties
	public string defaultEffect { /* [XID] */ /* 0x00000001898EF7E0-0x00000001898EF800 */ get => default; /* [XID] */ /* 0x0000000189B14F90-0x0000000189B14FB0 */ private set {} } // 0x00000001837E1E70-0x00000001837E1F10 0x00000001837E1F10-0x00000001837E1FC0
	public Dictionary<string, string> surfaceEffect { /* [XID] */ /* 0x0000000189B1C970-0x0000000189B1C990 */ get => default; /* [XID] */ /* 0x0000000189B23EC0-0x0000000189B23EE0 */ private set {} } // 0x00000001837E1300-0x00000001837E13A0 0x00000001837E1DC0-0x00000001837E1E70

	// Constructors
	public ConfigHitScene() {} // 0x00000001837E2520-0x00000001837E2580

	// Methods
	// [XID] // 0x0000000189B2B1E0-0x0000000189B2B200
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837E2230-0x00000001837E2340
	// [XID] // 0x0000000189B32800-0x0000000189B32820
	public void InitEmpty() {} // 0x00000001837E19E0-0x00000001837E1AC0
	[BlackList] // 0x0000000189B3A0F0-0x0000000189B3A130
	// [XID] // 0x0000000189B3A0F0-0x0000000189B3A130
	public bool FromJson(JSONNode node) => default; // 0x00000001837E1660-0x00000001837E19E0
	// [XID] // 0x0000000189B44A70-0x0000000189B44A90
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001837E0C20-0x00000001837E0EF0
	// [XID] // 0x0000000189B4C2E0-0x0000000189B4C300
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF71DF */, bool useObjectPool = false /* Metadata: 0x00AF71E3 */) => default; // 0x00000001837E1AC0-0x00000001837E1DC0
	// [XID] // 0x0000000189B538E0-0x0000000189B53900
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF71E4 */, bool useObjectPool = false /* Metadata: 0x00AF71E8 */) => default; // 0x00000001837E13A0-0x00000001837E1660
	[BlackList] // 0x0000000189B5B170-0x0000000189B5B1B0
	// [XID] // 0x0000000189B5B170-0x0000000189B5B1B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001837E0EF0-0x00000001837E11C0
	// [XID] // 0x0000000189B65940-0x0000000189B65960
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837E1FC0-0x00000001837E2230
	[BlackList] // 0x0000000189B6CEA0-0x0000000189B6CEE0
	// [XID] // 0x0000000189B6CEA0-0x0000000189B6CEE0
	public virtual void AutoAllocTypeFields() {} // 0x00000001837E11C0-0x00000001837E1260
	[BlackList] // 0x0000000189B77370-0x0000000189B773B0
	// [XID] // 0x0000000189B77370-0x0000000189B773B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837E1260-0x00000001837E1300
	[BlackList] // 0x0000000189B81C10-0x0000000189B81C50
	// [XID] // 0x0000000189B81C10-0x0000000189B81C50
	public virtual void ReturnToObjectPool() {} // 0x00000001837E2480-0x00000001837E2520
	[BlackList] // 0x0000000189B8BEA0-0x0000000189B8BEE0
	// [XID] // 0x0000000189B8BEA0-0x0000000189B8BEE0
	public virtual void OnPoolAllocated() {} // 0x00000001837E23E0-0x00000001837E2480
	[BlackList] // 0x0000000189B963A0-0x0000000189B963E0
	// [XID] // 0x0000000189B963A0-0x0000000189B963E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837E2340-0x00000001837E23E0
}

