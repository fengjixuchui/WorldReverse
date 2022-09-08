/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
public class ConfigAICommandSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17399
{
	// Fields
	private SimpleSafeInt32[] _acceptCommandIDs; // 0x10

	// Properties
	public SimpleSafeInt32[] acceptCommandIDs { /* [XID] */ /* 0x0000000189BDE200-0x0000000189BDE220 */ get => default; /* [XID] */ /* 0x00000001895EAD10-0x00000001895EAD30 */ private set {} } // 0x0000000185154910-0x00000001851549B0 0x0000000185154DC0-0x0000000185154E70

	// Constructors
	public ConfigAICommandSetting() {} // 0x0000000185155C80-0x0000000185155CE0

	// Methods
	// [XID] // 0x0000000189AB2550-0x0000000189AB2570
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851559C0-0x0000000185155AA0
	// [XID] // 0x00000001895F9B20-0x00000001895F9B40
	public void InitEmpty() {} // 0x0000000185155400-0x00000001851554D0
	[BlackList] // 0x0000000189601260-0x00000001896012A0
	// [XID] // 0x0000000189601260-0x00000001896012A0
	public bool FromJson(JSONNode node) => default; // 0x0000000185155080-0x0000000185155400
	// [XID] // 0x000000018960BB80-0x000000018960BBA0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185154730-0x0000000185154910
	// [XID] // 0x0000000189613140-0x0000000189613160
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D41 */, bool useObjectPool = false /* Metadata: 0x00AF6D45 */) => default; // 0x00000001851554D0-0x00000001851557D0
	// [XID] // 0x000000018961A9A0-0x000000018961A9C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D46 */, bool useObjectPool = false /* Metadata: 0x00AF6D4A */) => default; // 0x0000000185154E70-0x0000000185155080
	[BlackList] // 0x0000000189621FC0-0x0000000189622000
	// [XID] // 0x0000000189621FC0-0x0000000189622000
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001851549B0-0x0000000185154C80
	// [XID] // 0x000000018962C5F0-0x000000018962C610
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851557D0-0x00000001851559C0
	[BlackList] // 0x0000000189634210-0x0000000189634250
	// [XID] // 0x0000000189634210-0x0000000189634250
	public virtual void AutoAllocTypeFields() {} // 0x0000000185154C80-0x0000000185154D20
	[BlackList] // 0x000000018963E920-0x000000018963E960
	// [XID] // 0x000000018963E920-0x000000018963E960
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185154D20-0x0000000185154DC0
	[BlackList] // 0x0000000189649200-0x0000000189649240
	// [XID] // 0x0000000189649200-0x0000000189649240
	public virtual void ReturnToObjectPool() {} // 0x0000000185155BE0-0x0000000185155C80
	[BlackList] // 0x0000000189653840-0x0000000189653880
	// [XID] // 0x0000000189653840-0x0000000189653880
	public virtual void OnPoolAllocated() {} // 0x0000000185155B40-0x0000000185155BE0
	[BlackList] // 0x000000018965DE50-0x000000018965DE90
	// [XID] // 0x000000018965DE50-0x000000018965DE90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185155AA0-0x0000000185155B40
}

