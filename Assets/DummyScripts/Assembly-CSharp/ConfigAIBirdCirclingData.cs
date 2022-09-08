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
public class ConfigAIBirdCirclingData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17472
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat radiusRawNum; // 0x14

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189A5C100-0x0000000189A5C120 */ get => default; /* [XID] */ /* 0x0000000189A63A30-0x0000000189A63A50 */ private set {} } // 0x0000000182061C40-0x0000000182061D10 0x0000000182061D10-0x0000000182061DF0
	public float radius { /* [XID] */ /* 0x0000000189A6B270-0x0000000189A6B290 */ get => default; /* [XID] */ /* 0x0000000189A72AE0-0x0000000189A72B00 */ private set {} } // 0x00000001820627C0-0x00000001820628A0 0x0000000182062D60-0x0000000182062E40

	// Constructors
	public ConfigAIBirdCirclingData() {} // 0x0000000182062EE0-0x0000000182062FB0

	// Methods
	// [XID] // 0x0000000189A7A5B0-0x0000000189A7A5D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182062B10-0x0000000182062C20
	// [XID] // 0x0000000189A81A50-0x0000000189A81A70
	public void InitEmpty() {} // 0x00000001820623C0-0x00000001820624C0
	[BlackList] // 0x0000000189A895D0-0x0000000189A89610
	// [XID] // 0x0000000189A895D0-0x0000000189A89610
	public bool FromJson(JSONNode node) => default; // 0x0000000182062040-0x00000001820623C0
	// [XID] // 0x0000000189A938F0-0x0000000189A93910
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001820614C0-0x00000001820617D0
	// [XID] // 0x0000000189A9B500-0x0000000189A9B520
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FC9 */, bool useObjectPool = false /* Metadata: 0x00AF6FCD */) => default; // 0x00000001820624C0-0x00000001820627C0
	// [XID] // 0x0000000189AA2840-0x0000000189AA2860
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FCE */, bool useObjectPool = false /* Metadata: 0x00AF6FD2 */) => default; // 0x0000000182061DF0-0x0000000182062040
	[BlackList] // 0x0000000189AA9E20-0x0000000189AA9E60
	// [XID] // 0x0000000189AA9E20-0x0000000189AA9E60
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001820617D0-0x0000000182061AA0
	// [XID] // 0x0000000189AB4970-0x0000000189AB4990
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820628A0-0x0000000182062B10
	[BlackList] // 0x0000000189ABC6C0-0x0000000189ABC700
	// [XID] // 0x0000000189ABC6C0-0x0000000189ABC700
	public virtual void AutoAllocTypeFields() {} // 0x0000000182061AA0-0x0000000182061B40
	[BlackList] // 0x0000000189AC6DA0-0x0000000189AC6DE0
	// [XID] // 0x0000000189AC6DA0-0x0000000189AC6DE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182061B40-0x0000000182061C40
	[BlackList] // 0x0000000189AD1610-0x0000000189AD1650
	// [XID] // 0x0000000189AD1610-0x0000000189AD1650
	public virtual void ReturnToObjectPool() {} // 0x0000000182062E40-0x0000000182062EE0
	[BlackList] // 0x0000000189ADC220-0x0000000189ADC260
	// [XID] // 0x0000000189ADC220-0x0000000189ADC260
	public virtual void OnPoolAllocated() {} // 0x0000000182062CC0-0x0000000182062D60
	[BlackList] // 0x0000000189AE6C30-0x0000000189AE6C70
	// [XID] // 0x0000000189AE6C30-0x0000000189AE6C70
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182062C20-0x0000000182062CC0
}

