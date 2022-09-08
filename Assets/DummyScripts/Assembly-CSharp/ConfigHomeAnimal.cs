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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigHomeAnimal : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18943
{
	// Fields
	private SimpleSafeUInt32 furnitureIdRawNum; // 0x10
	private MoleMole.Config.Vector _spawnPos; // 0x14
	private MoleMole.Config.Vector _spawnRot; // 0x20

	// Properties
	public uint furnitureId { /* [XID] */ /* 0x0000000189A69B10-0x0000000189A69B30 */ get => default; /* [XID] */ /* 0x0000000189A70E00-0x0000000189A70E20 */ private set {} } // 0x00000001841D8FD0-0x00000001841D90A0 0x00000001841D86B0-0x00000001841D8790
	public MoleMole.Config.Vector spawnPos { /* [XID] */ /* 0x0000000189A788C0-0x0000000189A788E0 */ get => default; /* [XID] */ /* 0x0000000189A7FD20-0x0000000189A7FD40 */ private set {} } // 0x00000001841D90A0-0x00000001841D9180 0x00000001841D9D20-0x00000001841D9DF0
	public MoleMole.Config.Vector spawnRot { /* [XID] */ /* 0x0000000189A87AC0-0x0000000189A87AE0 */ get => default; /* [XID] */ /* 0x0000000189A8F270-0x0000000189A8F290 */ private set {} } // 0x00000001841D9DF0-0x00000001841D9ED0 0x00000001841D9C50-0x00000001841D9D20

	// Constructors
	public ConfigHomeAnimal() {} // 0x00000001841DA5B0-0x00000001841DA610

	// Methods
	// [XID] // 0x0000000189A96780-0x0000000189A967A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841DA260-0x00000001841DA3D0
	// [XID] // 0x0000000189A9DCD0-0x0000000189A9DCF0
	public void InitEmpty() {} // 0x00000001841D9840-0x00000001841D9950
	[BlackList] // 0x0000000189AA5740-0x0000000189AA5780
	// [XID] // 0x0000000189AA5740-0x0000000189AA5780
	public bool FromJson(JSONNode node) => default; // 0x00000001841D94C0-0x00000001841D9840
	// [XID] // 0x0000000189AAFF30-0x0000000189AAFF50
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001841D8790-0x00000001841D8B70
	// [XID] // 0x0000000189AB7650-0x0000000189AB7670
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB477 */, bool useObjectPool = false /* Metadata: 0x00AFB47B */) => default; // 0x00000001841D9950-0x00000001841D9C50
	// [XID] // 0x0000000189ABF0B0-0x0000000189ABF0D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB47C */, bool useObjectPool = false /* Metadata: 0x00AFB480 */) => default; // 0x00000001841D9180-0x00000001841D94C0
	[BlackList] // 0x0000000189AC6B40-0x0000000189AC6B80
	// [XID] // 0x0000000189AC6B40-0x0000000189AC6B80
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001841D8B70-0x00000001841D8E40
	// [XID] // 0x0000000189AD12D0-0x0000000189AD12F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841D9ED0-0x00000001841DA260
	[BlackList] // 0x0000000189AD90B0-0x0000000189AD90F0
	// [XID] // 0x0000000189AD90B0-0x0000000189AD90F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001841D8E40-0x00000001841D8EE0
	[BlackList] // 0x0000000189AE3950-0x0000000189AE3990
	// [XID] // 0x0000000189AE3950-0x0000000189AE3990
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841D8EE0-0x00000001841D8FD0
	[BlackList] // 0x0000000189AEE460-0x0000000189AEE4A0
	// [XID] // 0x0000000189AEE460-0x0000000189AEE4A0
	public virtual void ReturnToObjectPool() {} // 0x00000001841DA510-0x00000001841DA5B0
	[BlackList] // 0x0000000189AF8BE0-0x0000000189AF8C20
	// [XID] // 0x0000000189AF8BE0-0x0000000189AF8C20
	public virtual void OnPoolAllocated() {} // 0x00000001841DA470-0x00000001841DA510
	[BlackList] // 0x0000000189B031B0-0x0000000189B031F0
	// [XID] // 0x0000000189B031B0-0x0000000189B031F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001841DA3D0-0x00000001841DA470
}

