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
public class AnimatorRecordState : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18866
{
	// Fields
	private SimpleSafeUInt32 shortNameHashRawNum; // 0x10
	private SimpleSafeFloat stateLengthRawNum; // 0x14
	private SimpleSafeFloat normalizedTimeRawNum; // 0x18

	// Properties
	public uint shortNameHash { /* [XID] */ /* 0x0000000189A8F2B0-0x0000000189A8F2D0 */ get => default; /* [XID] */ /* 0x0000000189A96800-0x0000000189A96820 */ private set {} } // 0x000000018399C050-0x000000018399C120 0x000000018399CA90-0x000000018399CB70
	public float stateLength { /* [XID] */ /* 0x0000000189A9DD10-0x0000000189A9DD30 */ get => default; /* [XID] */ /* 0x0000000189AA57A0-0x0000000189AA57C0 */ private set {} } // 0x000000018399C9B0-0x000000018399CA90 0x000000018399C8D0-0x000000018399C9B0
	public float normalizedTime { /* [XID] */ /* 0x0000000189AACE60-0x0000000189AACE80 */ get => default; /* [XID] */ /* 0x0000000189AB46F0-0x0000000189AB4710 */ private set {} } // 0x000000018399CF70-0x000000018399D050 0x000000018399C470-0x000000018399C550

	// Constructors
	public AnimatorRecordState() {} // 0x000000018399D650-0x000000018399D6B0

	// Methods
	// [XID] // 0x0000000189ABC520-0x0000000189ABC540
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018399D350-0x000000018399D470
	// [XID] // 0x0000000189AC3E40-0x0000000189AC3E60
	public void InitEmpty() {} // 0x000000018399CB70-0x000000018399CC70
	[BlackList] // 0x0000000189ACB240-0x0000000189ACB280
	// [XID] // 0x0000000189ACB240-0x0000000189ACB280
	public bool FromJson(JSONNode node) => default; // 0x000000018399C550-0x000000018399C8D0
	// [XID] // 0x0000000189AD6180-0x0000000189AD61A0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018399B760-0x000000018399BBD0
	// [XID] // 0x0000000189ADDA90-0x0000000189ADDAB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB199 */, bool useObjectPool = false /* Metadata: 0x00AFB19D */) => default; // 0x000000018399CC70-0x000000018399CF70
	// [XID] // 0x0000000189AE5380-0x0000000189AE53A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB19E */, bool useObjectPool = false /* Metadata: 0x00AFB1A2 */) => default; // 0x000000018399C120-0x000000018399C470
	[BlackList] // 0x0000000189AEC900-0x0000000189AEC940
	// [XID] // 0x0000000189AEC900-0x0000000189AEC940
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018399BBD0-0x000000018399BEA0
	// [XID] // 0x0000000189AF7340-0x0000000189AF7360
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018399D050-0x000000018399D350
	[BlackList] // 0x0000000189AFEA10-0x0000000189AFEA50
	// [XID] // 0x0000000189AFEA10-0x0000000189AFEA50
	public virtual void AutoAllocTypeFields() {} // 0x000000018399BEA0-0x000000018399BF40
	[BlackList] // 0x0000000189B08F70-0x0000000189B08FB0
	// [XID] // 0x0000000189B08F70-0x0000000189B08FB0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018399BF40-0x000000018399C050
	[BlackList] // 0x0000000189B13580-0x0000000189B135C0
	// [XID] // 0x0000000189B13580-0x0000000189B135C0
	public virtual void ReturnToObjectPool() {} // 0x000000018399D5B0-0x000000018399D650
	[BlackList] // 0x0000000189B1D970-0x0000000189B1D9B0
	// [XID] // 0x0000000189B1D970-0x0000000189B1D9B0
	public virtual void OnPoolAllocated() {} // 0x000000018399D510-0x000000018399D5B0
	[BlackList] // 0x0000000189B28050-0x0000000189B28090
	// [XID] // 0x0000000189B28050-0x0000000189B28090
	public virtual void OnBeforePoolRecycled() {} // 0x000000018399D470-0x000000018399D510
}

