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
public class ConfigAIMeleeChargeData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17441
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x14
	private SimpleSafeFloat startDistanceMinRawNum; // 0x18
	private SimpleSafeFloat startDistanceMaxRawNum; // 0x1C
	private SimpleSafeFloat stopDistanceRawNum; // 0x20
	private SimpleSafeFloat innerDistanceRawNum; // 0x24
	private SimpleSafeInt32 speedLevelInnerRawNum; // 0x28
	private bool _useMeleeSlot; // 0x2C

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189A160C0-0x0000000189A160E0 */ get => default; /* [XID] */ /* 0x0000000189A1D5C0-0x0000000189A1D5E0 */ private set {} } // 0x0000000184BDF1C0-0x0000000184BDF290 0x0000000184BDF530-0x0000000184BDF610
	public float turnSpeedOverride { /* [XID] */ /* 0x0000000189A24A50-0x0000000189A24A70 */ get => default; /* [XID] */ /* 0x0000000189A2C090-0x0000000189A2C0B0 */ private set {} } // 0x0000000184BDF370-0x0000000184BDF450 0x0000000184BDFB40-0x0000000184BDFC20
	public float startDistanceMin { /* [XID] */ /* 0x0000000189A337A0-0x0000000189A337C0 */ get => default; /* [XID] */ /* 0x0000000189A3AF00-0x0000000189A3AF20 */ private set {} } // 0x0000000184BE0620-0x0000000184BE0700 0x0000000184BDF450-0x0000000184BDF530
	public float startDistanceMax { /* [XID] */ /* 0x0000000189A427D0-0x0000000189A427F0 */ get => default; /* [XID] */ /* 0x0000000189A49D60-0x0000000189A49D80 */ private set {} } // 0x0000000184BE09A0-0x0000000184BE0A80 0x0000000184BE07E0-0x0000000184BE08C0
	public float stopDistance { /* [XID] */ /* 0x0000000189AC2F30-0x0000000189AC2F50 */ get => default; /* [XID] */ /* 0x0000000189A58EA0-0x0000000189A58EC0 */ private set {} } // 0x0000000184BE1420-0x0000000184BE1500 0x0000000184BDF290-0x0000000184BDF370
	public float innerDistance { /* [XID] */ /* 0x0000000189A607E0-0x0000000189A60800 */ get => default; /* [XID] */ /* 0x0000000189A68610-0x0000000189A68630 */ private set {} } // 0x0000000184BE0700-0x0000000184BE07E0 0x0000000184BE1340-0x0000000184BE1420
	public int speedLevelInner { /* [XID] */ /* 0x0000000189A6F940-0x0000000189A6F960 */ get => default; /* [XID] */ /* 0x0000000189A770F0-0x0000000189A77110 */ private set {} } // 0x0000000184BE0250-0x0000000184BE0320 0x0000000184BE08C0-0x0000000184BE09A0
	public bool useMeleeSlot { /* [XID] */ /* 0x0000000189A7EB40-0x0000000189A7EB60 */ get => default; /* [XID] */ /* 0x0000000189A86350-0x0000000189A86370 */ private set {} } // 0x0000000184BDFFA0-0x0000000184BE0040 0x0000000184BE0040-0x0000000184BE00F0

	// Constructors
	public ConfigAIMeleeChargeData() {} // 0x0000000184BE15A0-0x0000000184BE16D0

	// Methods
	// [XID] // 0x0000000189A8DD50-0x0000000189A8DD70
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184BE1050-0x0000000184BE1200
	// [XID] // 0x0000000189A95330-0x0000000189A95350
	public void InitEmpty() {} // 0x0000000184BE00F0-0x0000000184BE0250
	[BlackList] // 0x0000000189A9CAF0-0x0000000189A9CB30
	// [XID] // 0x0000000189A9CAF0-0x0000000189A9CB30
	public bool FromJson(JSONNode node) => default; // 0x0000000184BDFC20-0x0000000184BDFFA0
	// [XID] // 0x0000000189AA71A0-0x0000000189AA71C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184BDE470-0x0000000184BDECE0
	// [XID] // 0x0000000189AAE840-0x0000000189AAE860
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EBB */, bool useObjectPool = false /* Metadata: 0x00AF6EBF */) => default; // 0x0000000184BE0320-0x0000000184BE0620
	// [XID] // 0x0000000189AB6140-0x0000000189AB6160
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EC0 */, bool useObjectPool = false /* Metadata: 0x00AF6EC4 */) => default; // 0x0000000184BDF610-0x0000000184BDFB40
	[BlackList] // 0x0000000189ABDB50-0x0000000189ABDB90
	// [XID] // 0x0000000189ABDB50-0x0000000189ABDB90
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184BDECE0-0x0000000184BDEFB0
	// [XID] // 0x0000000189AC8530-0x0000000189AC8550
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184BE0A80-0x0000000184BE1050
	[BlackList] // 0x0000000189ACFC30-0x0000000189ACFC70
	// [XID] // 0x0000000189ACFC30-0x0000000189ACFC70
	public virtual void AutoAllocTypeFields() {} // 0x0000000184BDEFB0-0x0000000184BDF050
	[BlackList] // 0x0000000189ADA960-0x0000000189ADA9A0
	// [XID] // 0x0000000189ADA960-0x0000000189ADA9A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184BDF050-0x0000000184BDF1C0
	[BlackList] // 0x0000000189AE5660-0x0000000189AE56A0
	// [XID] // 0x0000000189AE5660-0x0000000189AE56A0
	public virtual void ReturnToObjectPool() {} // 0x0000000184BE1500-0x0000000184BE15A0
	[BlackList] // 0x0000000189AF0150-0x0000000189AF0190
	// [XID] // 0x0000000189AF0150-0x0000000189AF0190
	public virtual void OnPoolAllocated() {} // 0x0000000184BE12A0-0x0000000184BE1340
	[BlackList] // 0x0000000189AFA740-0x0000000189AFA780
	// [XID] // 0x0000000189AFA740-0x0000000189AFA780
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184BE1200-0x0000000184BE12A0
}

