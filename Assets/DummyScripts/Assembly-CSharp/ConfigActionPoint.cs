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
public class ConfigActionPoint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18465
{
	// Fields
	private SimpleSafeUInt32 localIdRawNum; // 0x10
	private ActionPointType _type; // 0x14
	private MoleMole.Config.Vector _pos; // 0x18
	private MoleMole.Config.Vector _rot; // 0x24
	private SimpleSafeInt32 capacityRawNum; // 0x30
	private SimpleSafeFloat actZoneInnerRadiusRawNum; // 0x34
	private SimpleSafeFloat actZoneOuterRadiusRawNum; // 0x38
	private SimpleSafeInt32 freestyleRawNum; // 0x3C
	private bool _faceCenter; // 0x40

	// Properties
	public uint localId { /* [XID] */ /* 0x0000000189BC3050-0x0000000189BC3070 */ get => default; /* [XID] */ /* 0x0000000189BCA890-0x0000000189BCA8B0 */ private set {} } // 0x00000001827F5B10-0x00000001827F5BE0 0x00000001827F43B0-0x00000001827F4490
	public ActionPointType type { /* [XID] */ /* 0x0000000189BD1E80-0x0000000189BD1EA0 */ get => default; /* [XID] */ /* 0x0000000189BD9540-0x0000000189BD9560 */ private set {} } // 0x00000001827F68B0-0x00000001827F6950 0x00000001827F5BE0-0x00000001827F5C90
	public MoleMole.Config.Vector pos { /* [XID] */ /* 0x00000001895E60F0-0x00000001895E6110 */ get => default; /* [XID] */ /* 0x00000001895ED9F0-0x00000001895EDA10 */ private set {} } // 0x00000001827F5280-0x00000001827F5360 0x00000001827F4490-0x00000001827F4560
	public MoleMole.Config.Vector rot { /* [XID] */ /* 0x00000001895F5210-0x00000001895F5230 */ get => default; /* [XID] */ /* 0x00000001895FC7D0-0x00000001895FC7F0 */ private set {} } // 0x00000001827F33E0-0x00000001827F34C0 0x00000001827F42E0-0x00000001827F43B0
	public int capacity { /* [XID] */ /* 0x0000000189604170-0x0000000189604190 */ get => default; /* [XID] */ /* 0x000000018960BA00-0x000000018960BA20 */ private set {} } // 0x00000001827F4D50-0x00000001827F4E20 0x00000001827F5360-0x00000001827F5440
	public float actZoneInnerRadius { /* [XID] */ /* 0x0000000189612FE0-0x0000000189613000 */ get => default; /* [XID] */ /* 0x000000018961A780-0x000000018961A7A0 */ private set {} } // 0x00000001827F5980-0x00000001827F5A60 0x00000001827F67D0-0x00000001827F68B0
	public float actZoneOuterRadius { /* [XID] */ /* 0x0000000189621D40-0x0000000189621D60 */ get => default; /* [XID] */ /* 0x00000001896296F0-0x0000000189629710 */ private set {} } // 0x00000001827F51A0-0x00000001827F5280 0x00000001827F4C70-0x00000001827F4D50
	public int freestyle { /* [XID] */ /* 0x0000000189631020-0x0000000189631040 */ get => default; /* [XID] */ /* 0x0000000189638A90-0x0000000189638AB0 */ private set {} } // 0x00000001827F4560-0x00000001827F4630 0x00000001827F5C90-0x00000001827F5D70
	public bool faceCenter { /* [XID] */ /* 0x000000018963FEB0-0x000000018963FED0 */ get => default; /* [XID] */ /* 0x0000000189647710-0x0000000189647730 */ private set {} } // 0x00000001827F55E0-0x00000001827F5680 0x00000001827F5A60-0x00000001827F5B10

	// Constructors
	public ConfigActionPoint() {} // 0x00000001827F69F0-0x00000001827F6AE0

	// Methods
	// [XID] // 0x000000018964ECE0-0x000000018964ED00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001827F6480-0x00000001827F6690
	// [XID] // 0x0000000189656570-0x0000000189656590
	public void InitEmpty() {} // 0x00000001827F5440-0x00000001827F55E0
	[BlackList] // 0x000000018965DC90-0x000000018965DCD0
	// [XID] // 0x000000018965DC90-0x000000018965DCD0
	public bool FromJson(JSONNode node) => default; // 0x00000001827F4E20-0x00000001827F51A0
	// [XID] // 0x0000000189668640-0x0000000189668660
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001827F34C0-0x00000001827F3DF0
	// [XID] // 0x00000001896700B0-0x00000001896700D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9E71 */, bool useObjectPool = false /* Metadata: 0x00AF9E75 */) => default; // 0x00000001827F5680-0x00000001827F5980
	// [XID] // 0x0000000189677A10-0x0000000189677A30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9E76 */, bool useObjectPool = false /* Metadata: 0x00AF9E7A */) => default; // 0x00000001827F4630-0x00000001827F4C70
	[BlackList] // 0x000000018967EF40-0x000000018967EF80
	// [XID] // 0x000000018967EF40-0x000000018967EF80
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001827F3DF0-0x00000001827F40C0
	// [XID] // 0x0000000189689AB0-0x0000000189689AD0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001827F5D70-0x00000001827F6480
	[BlackList] // 0x00000001896918D0-0x0000000189691910
	// [XID] // 0x00000001896918D0-0x0000000189691910
	public virtual void AutoAllocTypeFields() {} // 0x00000001827F40C0-0x00000001827F4160
	[BlackList] // 0x000000018969BCC0-0x000000018969BD00
	// [XID] // 0x000000018969BCC0-0x000000018969BD00
	public virtual void AutoRecycleTypeFields() {} // 0x00000001827F4160-0x00000001827F42E0
	[BlackList] // 0x00000001896A5F90-0x00000001896A5FD0
	// [XID] // 0x00000001896A5F90-0x00000001896A5FD0
	public virtual void ReturnToObjectPool() {} // 0x00000001827F6950-0x00000001827F69F0
	[BlackList] // 0x00000001896B0250-0x00000001896B0290
	// [XID] // 0x00000001896B0250-0x00000001896B0290
	public virtual void OnPoolAllocated() {} // 0x00000001827F6730-0x00000001827F67D0
	[BlackList] // 0x00000001896BA9B0-0x00000001896BA9F0
	// [XID] // 0x00000001896BA9B0-0x00000001896BA9F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001827F6690-0x00000001827F6730
}

