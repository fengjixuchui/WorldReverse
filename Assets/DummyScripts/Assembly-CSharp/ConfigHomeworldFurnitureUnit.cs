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
public class ConfigHomeworldFurnitureUnit : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18344
{
	// Fields
	private SimpleSafeUInt32 furnitureIDRawNum; // 0x10
	private MoleMole.Config.Vector _position; // 0x14
	private MoleMole.Config.Vector _rotation; // 0x20
	private SimpleSafeInt32 parentIndexRawNum; // 0x2C

	// Properties
	public uint furnitureID { /* [XID] */ /* 0x00000001897121F0-0x0000000189712210 */ get => default; /* [XID] */ /* 0x0000000189719870-0x0000000189719890 */ private set {} } // 0x00000001849D8B50-0x00000001849D8C20 0x00000001849D82E0-0x00000001849D83C0
	public MoleMole.Config.Vector position { /* [XID] */ /* 0x0000000189720E10-0x0000000189720E30 */ get => default; /* [XID] */ /* 0x0000000189728490-0x00000001897284B0 */ private set {} } // 0x00000001849D9BC0-0x00000001849D9CA0 0x00000001849D97F0-0x00000001849D98C0
	public MoleMole.Config.Vector rotation { /* [XID] */ /* 0x000000018972FC10-0x000000018972FC30 */ get => default; /* [XID] */ /* 0x0000000189737620-0x0000000189737640 */ private set {} } // 0x00000001849D9CA0-0x00000001849D9D80 0x00000001849D9510-0x00000001849D95E0
	public int parentIndex { /* [XID] */ /* 0x000000018973F0A0-0x000000018973F0C0 */ get => default; /* [XID] */ /* 0x0000000189746340-0x0000000189746360 */ private set {} } // 0x00000001849D95E0-0x00000001849D96B0 0x00000001849DA1C0-0x00000001849DA2A0

	// Constructors
	public ConfigHomeworldFurnitureUnit() {} // 0x00000001849DA610-0x00000001849DA6A0

	// Methods
	// [XID] // 0x000000018974DE30-0x000000018974DE50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849DA2A0-0x00000001849DA430
	// [XID] // 0x0000000189755550-0x0000000189755570
	public void InitEmpty() {} // 0x00000001849D96B0-0x00000001849D97F0
	[BlackList] // 0x000000018975C6B0-0x000000018975C6F0
	// [XID] // 0x000000018975C6B0-0x000000018975C6F0
	public bool FromJson(JSONNode node) => default; // 0x00000001849D9190-0x00000001849D9510
	// [XID] // 0x0000000189766FE0-0x0000000189767000
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001849D83C0-0x00000001849D8880
	// [XID] // 0x000000018976E540-0x000000018976E560
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF94D1 */, bool useObjectPool = false /* Metadata: 0x00AF94D5 */) => default; // 0x00000001849D98C0-0x00000001849D9BC0
	// [XID] // 0x0000000189775EE0-0x0000000189775F00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF94D6 */, bool useObjectPool = false /* Metadata: 0x00AF94DA */) => default; // 0x00000001849D8DE0-0x00000001849D9190
	[BlackList] // 0x000000018977D580-0x000000018977D5C0
	// [XID] // 0x000000018977D580-0x000000018977D5C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001849D8880-0x00000001849D8B50
	// [XID] // 0x0000000189787D00-0x0000000189787D20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849D9D80-0x00000001849DA1C0
	[BlackList] // 0x000000018978F220-0x000000018978F260
	// [XID] // 0x000000018978F220-0x000000018978F260
	public virtual void AutoAllocTypeFields() {} // 0x00000001849D8C20-0x00000001849D8CC0
	[BlackList] // 0x00000001897998B0-0x00000001897998F0
	// [XID] // 0x00000001897998B0-0x00000001897998F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001849D8CC0-0x00000001849D8DE0
	[BlackList] // 0x00000001897A4890-0x00000001897A48D0
	// [XID] // 0x00000001897A4890-0x00000001897A48D0
	public virtual void ReturnToObjectPool() {} // 0x00000001849DA570-0x00000001849DA610
	[BlackList] // 0x00000001897AF1D0-0x00000001897AF210
	// [XID] // 0x00000001897AF1D0-0x00000001897AF210
	public virtual void OnPoolAllocated() {} // 0x00000001849DA4D0-0x00000001849DA570
	[BlackList] // 0x00000001897B9AF0-0x00000001897B9B30
	// [XID] // 0x00000001897B9AF0-0x00000001897B9B30
	public virtual void OnBeforePoolRecycled() {} // 0x00000001849DA430-0x00000001849DA4D0
}

