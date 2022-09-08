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
public class ConfigAICombatFollowMoveData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17438
{
	// Fields
	private SimpleSafeFloat startDistanceRawNum; // 0x10
	private SimpleSafeFloat stopDistanceRawNum; // 0x14
	private SimpleSafeFloat middleDistanceRawNum; // 0x18
	private SimpleSafeFloat innerDistanceRawNum; // 0x1C
	private SimpleSafeInt32 speedLevelOuterRawNum; // 0x20
	private SimpleSafeInt32 speedLevelMiddleRawNum; // 0x24
	private SimpleSafeInt32 speedLevelInnerRawNum; // 0x28
	private SimpleSafeFloat startAngleRawNum; // 0x2C
	private SimpleSafeFloat outerAngleRawNum; // 0x30
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x34
	private SimpleSafeFloat turnSpeedOverrideOuterRawNum; // 0x38
	private bool _useMeleeSlot; // 0x3C
	private SimpleSafeFloat moveOutDampRangeRawNum; // 0x40

	// Properties
	public float startDistance { /* [XID] */ /* 0x000000018980E5B0-0x000000018980E5D0 */ get => default; /* [XID] */ /* 0x0000000189815D70-0x0000000189815D90 */ private set {} } // 0x00000001839F0520-0x00000001839F0600 0x00000001839EE950-0x00000001839EEA30
	public float stopDistance { /* [XID] */ /* 0x000000018981D6D0-0x000000018981D6F0 */ get => default; /* [XID] */ /* 0x0000000189824BA0-0x0000000189824BC0 */ private set {} } // 0x00000001839F1780-0x00000001839F1860 0x00000001839EE870-0x00000001839EE950
	public float middleDistance { /* [XID] */ /* 0x000000018982C510-0x000000018982C530 */ get => default; /* [XID] */ /* 0x0000000189833A80-0x0000000189833AA0 */ private set {} } // 0x00000001839EFC10-0x00000001839EFCF0 0x00000001839F0290-0x00000001839F0370
	public float innerDistance { /* [XID] */ /* 0x000000018983AFE0-0x000000018983B000 */ get => default; /* [XID] */ /* 0x0000000189842820-0x0000000189842840 */ private set {} } // 0x00000001839F0370-0x00000001839F0450 0x00000001839F15C0-0x00000001839F16A0
	public int speedLevelOuter { /* [XID] */ /* 0x0000000189849AD0-0x0000000189849AF0 */ get => default; /* [XID] */ /* 0x0000000189851230-0x0000000189851250 */ private set {} } // 0x00000001839F0450-0x00000001839F0520 0x00000001839F1860-0x00000001839F1940
	public int speedLevelMiddle { /* [XID] */ /* 0x0000000189858780-0x00000001898587A0 */ get => default; /* [XID] */ /* 0x000000018985F850-0x000000018985F870 */ private set {} } // 0x00000001839F1180-0x00000001839F1250 0x00000001839EFB30-0x00000001839EFC10
	public int speedLevelInner { /* [XID] */ /* 0x0000000189867090-0x00000001898670B0 */ get => default; /* [XID] */ /* 0x000000018986E8B0-0x000000018986E8D0 */ private set {} } // 0x00000001839EFEC0-0x00000001839EFF90 0x00000001839F06E0-0x00000001839F07C0
	public float startAngle { /* [XID] */ /* 0x0000000189875D80-0x0000000189875DA0 */ get => default; /* [XID] */ /* 0x000000018987D900-0x000000018987D920 */ private set {} } // 0x00000001839F16A0-0x00000001839F1780 0x00000001839F0600-0x00000001839F06E0
	public float outerAngle { /* [XID] */ /* 0x0000000189884830-0x0000000189884850 */ get => default; /* [XID] */ /* 0x000000018988BE60-0x000000018988BE80 */ private set {} } // 0x00000001839EEB10-0x00000001839EEBF0 0x00000001839EEBF0-0x00000001839EECD0
	public float turnSpeedOverride { /* [XID] */ /* 0x00000001898934F0-0x0000000189893510 */ get => default; /* [XID] */ /* 0x000000018989ABF0-0x000000018989AC10 */ private set {} } // 0x00000001839EEA30-0x00000001839EEB10 0x00000001839EF4A0-0x00000001839EF580
	public float turnSpeedOverrideOuter { /* [XID] */ /* 0x00000001898A1EA0-0x00000001898A1EC0 */ get => default; /* [XID] */ /* 0x00000001898A96D0-0x00000001898A96F0 */ private set {} } // 0x00000001839EE6B0-0x00000001839EE790 0x00000001839EF900-0x00000001839EF9E0
	public bool useMeleeSlot { /* [XID] */ /* 0x00000001898B0EE0-0x00000001898B0F00 */ get => default; /* [XID] */ /* 0x00000001898B8640-0x00000001898B8660 */ private set {} } // 0x00000001839EF9E0-0x00000001839EFA80 0x00000001839EFA80-0x00000001839EFB30
	public float moveOutDampRange { /* [XID] */ /* 0x00000001898BFE40-0x00000001898BFE60 */ get => default; /* [XID] */ /* 0x00000001898C7700-0x00000001898C7720 */ private set {} } // 0x00000001839EE790-0x00000001839EE870 0x00000001839F07C0-0x00000001839F08A0

	// Constructors
	public ConfigAICombatFollowMoveData() {} // 0x00000001839F19E0-0x00000001839F1B70

	// Methods
	// [XID] // 0x00000001898CED10-0x00000001898CED30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839F1250-0x00000001839F1480
	// [XID] // 0x00000001898D6720-0x00000001898D6740
	public void InitEmpty() {} // 0x00000001839EFCF0-0x00000001839EFEC0
	[BlackList] // 0x00000001898DE380-0x00000001898DE3C0
	// [XID] // 0x00000001898DE380-0x00000001898DE3C0
	public bool FromJson(JSONNode node) => default; // 0x00000001839EF580-0x00000001839EF900
	// [XID] // 0x00000001898E8D80-0x00000001898E8DA0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001839ED430-0x00000001839EE170
	// [XID] // 0x00000001898F04E0-0x00000001898F0500
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EA1 */, bool useObjectPool = false /* Metadata: 0x00AF6EA5 */) => default; // 0x00000001839EFF90-0x00000001839F0290
	// [XID] // 0x00000001898F7F30-0x00000001898F7F50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EA6 */, bool useObjectPool = false /* Metadata: 0x00AF6EAA */) => default; // 0x00000001839EECD0-0x00000001839EF4A0
	[BlackList] // 0x00000001898FF590-0x00000001898FF5D0
	// [XID] // 0x00000001898FF590-0x00000001898FF5D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001839EE170-0x00000001839EE440
	// [XID] // 0x0000000189909D00-0x0000000189909D20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001839F08A0-0x00000001839F1180
	[BlackList] // 0x0000000189911500-0x0000000189911540
	// [XID] // 0x0000000189911500-0x0000000189911540
	public virtual void AutoAllocTypeFields() {} // 0x00000001839EE440-0x00000001839EE4E0
	[BlackList] // 0x000000018991C200-0x000000018991C240
	// [XID] // 0x000000018991C200-0x000000018991C240
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839EE4E0-0x00000001839EE6B0
	[BlackList] // 0x0000000189926940-0x0000000189926980
	// [XID] // 0x0000000189926940-0x0000000189926980
	public virtual void ReturnToObjectPool() {} // 0x00000001839F1940-0x00000001839F19E0
	[BlackList] // 0x0000000189930F40-0x0000000189930F80
	// [XID] // 0x0000000189930F40-0x0000000189930F80
	public virtual void OnPoolAllocated() {} // 0x00000001839F1520-0x00000001839F15C0
	[BlackList] // 0x000000018993B910-0x000000018993B950
	// [XID] // 0x000000018993B910-0x000000018993B950
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839F1480-0x00000001839F1520
}

