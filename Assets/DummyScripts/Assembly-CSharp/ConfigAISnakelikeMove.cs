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
public class ConfigAISnakelikeMove : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17409
{
	// Fields
	private SimpleSafeFloat minCurvatureRawNum; // 0x10
	private SimpleSafeFloat maxCurvatrueRawNum; // 0x14
	private SimpleSafeFloat minSegmentDistanceRawNum; // 0x18
	private SimpleSafeFloat segmentDistanceRawNum; // 0x1C
	private SimpleSafeInt32 segmentCountRawNum; // 0x20

	// Properties
	public float minCurvature { /* [XID] */ /* 0x0000000189A07470-0x0000000189A07490 */ get => default; /* [XID] */ /* 0x0000000189A0E930-0x0000000189A0E950 */ private set {} } // 0x0000000182755F80-0x0000000182756060 0x0000000182755370-0x0000000182755450
	public float maxCurvatrue { /* [XID] */ /* 0x000000018974BB10-0x000000018974BB30 */ get => default; /* [XID] */ /* 0x0000000189A1D620-0x0000000189A1D640 */ private set {} } // 0x0000000182755EA0-0x0000000182755F80 0x0000000182755450-0x0000000182755530
	public float minSegmentDistance { /* [XID] */ /* 0x0000000189716FC0-0x0000000189716FE0 */ get => default; /* [XID] */ /* 0x0000000189A2C0B0-0x0000000189A2C0D0 */ private set {} } // 0x0000000182756630-0x0000000182756710 0x0000000182756550-0x0000000182756630
	public float segmentDistance { /* [XID] */ /* 0x0000000189A337C0-0x0000000189A337E0 */ get => default; /* [XID] */ /* 0x0000000189A3AF20-0x0000000189A3AF40 */ private set {} } // 0x00000001827569B0-0x0000000182756A90 0x0000000182756060-0x0000000182756140
	public int segmentCount { /* [XID] */ /* 0x0000000189A427F0-0x0000000189A42810 */ get => default; /* [XID] */ /* 0x0000000189A49D80-0x0000000189A49DA0 */ private set {} } // 0x00000001827558B0-0x0000000182755980 0x0000000182755AC0-0x0000000182755BA0

	// Constructors
	public ConfigAISnakelikeMove() {} // 0x0000000182756B30-0x0000000182756C40

	// Methods
	// [XID] // 0x0000000189A51730-0x0000000189A51750
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182756710-0x0000000182756870
	// [XID] // 0x0000000189A58EC0-0x0000000189A58EE0
	public void InitEmpty() {} // 0x0000000182755980-0x0000000182755AC0
	[BlackList] // 0x0000000189A60800-0x0000000189A60840
	// [XID] // 0x0000000189A60800-0x0000000189A60840
	public bool FromJson(JSONNode node) => default; // 0x0000000182755530-0x00000001827558B0
	// [XID] // 0x0000000189A6B2D0-0x0000000189A6B2F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001827544E0-0x0000000182754AF0
	// [XID] // 0x0000000189A72B00-0x0000000189A72B20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D91 */, bool useObjectPool = false /* Metadata: 0x00AF6D95 */) => default; // 0x0000000182755BA0-0x0000000182755EA0
	// [XID] // 0x0000000189A7A5D0-0x0000000189A7A5F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D96 */, bool useObjectPool = false /* Metadata: 0x00AF6D9A */) => default; // 0x0000000182754FA0-0x0000000182755370
	[BlackList] // 0x0000000189A81AB0-0x0000000189A81AF0
	// [XID] // 0x0000000189A81AB0-0x0000000189A81AF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182754AF0-0x0000000182754DC0
	// [XID] // 0x0000000189A8C510-0x0000000189A8C530
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182756140-0x0000000182756550
	[BlackList] // 0x0000000189A93930-0x0000000189A93970
	// [XID] // 0x0000000189A93930-0x0000000189A93970
	public virtual void AutoAllocTypeFields() {} // 0x0000000182754DC0-0x0000000182754E60
	[BlackList] // 0x0000000189A9DF50-0x0000000189A9DF90
	// [XID] // 0x0000000189A9DF50-0x0000000189A9DF90
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182754E60-0x0000000182754FA0
	[BlackList] // 0x0000000189AA84A0-0x0000000189AA84E0
	// [XID] // 0x0000000189AA84A0-0x0000000189AA84E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182756A90-0x0000000182756B30
	[BlackList] // 0x0000000189AB3100-0x0000000189AB3140
	// [XID] // 0x0000000189AB3100-0x0000000189AB3140
	public virtual void OnPoolAllocated() {} // 0x0000000182756910-0x00000001827569B0
	[BlackList] // 0x0000000189ABDB90-0x0000000189ABDBD0
	// [XID] // 0x0000000189ABDB90-0x0000000189ABDBD0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182756870-0x0000000182756910
}

