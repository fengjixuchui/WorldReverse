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
public class ConfigAICombatFixedMoveData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17454
{
	// Fields
	private ActionPointType _pointType; // 0x10
	private SimpleSafeFloat cdActionPointRawNum; // 0x14
	private SimpleSafeInt32 speedLevelRawNum; // 0x18
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x1C
	private SimpleSafeFloat detectDistanceRawNum; // 0x20
	private SimpleSafeFloat overtimeRawNum; // 0x24
	private SimpleSafeUInt32 skillIDRawNum; // 0x28

	// Properties
	public ActionPointType pointType { /* [XID] */ /* 0x0000000189BD2040-0x0000000189BD2060 */ get => default; /* [XID] */ /* 0x0000000189BD96C0-0x0000000189BD96E0 */ private set {} } // 0x00000001833B8110-0x00000001833B81B0 0x00000001833B7D60-0x00000001833B7E10
	public float cdActionPoint { /* [XID] */ /* 0x00000001895E6170-0x00000001895E6190 */ get => default; /* [XID] */ /* 0x00000001895EDB30-0x00000001895EDB50 */ private set {} } // 0x00000001833B81B0-0x00000001833B8290 0x00000001833B8370-0x00000001833B8450
	public int speedLevel { /* [XID] */ /* 0x00000001895F5430-0x00000001895F5450 */ get => default; /* [XID] */ /* 0x00000001895FC9B0-0x00000001895FC9D0 */ private set {} } // 0x00000001833B6CA0-0x00000001833B6D70 0x00000001833B7010-0x00000001833B70F0
	public float turnSpeedOverride { /* [XID] */ /* 0x0000000189604390-0x00000001896043B0 */ get => default; /* [XID] */ /* 0x000000018960BB20-0x000000018960BB40 */ private set {} } // 0x00000001833B6E50-0x00000001833B6F30 0x00000001833B75E0-0x00000001833B76C0
	public float detectDistance { /* [XID] */ /* 0x0000000189613120-0x0000000189613140 */ get => default; /* [XID] */ /* 0x000000018961A980-0x000000018961A9A0 */ private set {} } // 0x00000001833B6F30-0x00000001833B7010 0x00000001833B8290-0x00000001833B8370
	public float overtime { /* [XID] */ /* 0x0000000189621FA0-0x0000000189621FC0 */ get => default; /* [XID] */ /* 0x0000000189629990-0x00000001896299B0 */ private set {} } // 0x00000001833B6D70-0x00000001833B6E50 0x00000001833B7A40-0x00000001833B7B20
	public uint skillID { /* [XID] */ /* 0x0000000189940690-0x00000001899406B0 */ get => default; /* [XID] */ /* 0x0000000189638B70-0x0000000189638B90 */ private set {} } // 0x00000001833B7B20-0x00000001833B7BF0 0x00000001833B89A0-0x00000001833B8A80

	// Constructors
	public ConfigAICombatFixedMoveData() {} // 0x00000001833B8DF0-0x00000001833B8F00

	// Methods
	// [XID] // 0x000000018963FFD0-0x000000018963FFF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833B8A80-0x00000001833B8C10
	// [XID] // 0x0000000189647890-0x00000001896478B0
	public void InitEmpty() {} // 0x00000001833B7BF0-0x00000001833B7D60
	[BlackList] // 0x000000018964EEA0-0x000000018964EEE0
	// [XID] // 0x000000018964EEA0-0x000000018964EEE0
	public bool FromJson(JSONNode node) => default; // 0x00000001833B76C0-0x00000001833B7A40
	// [XID] // 0x0000000189659730-0x0000000189659750
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001833B5FF0-0x00000001833B67B0
	// [XID] // 0x0000000189660E70-0x0000000189660E90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F2D */, bool useObjectPool = false /* Metadata: 0x00AF6F31 */) => default; // 0x00000001833B7E10-0x00000001833B8110
	// [XID] // 0x00000001896687E0-0x0000000189668800
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F32 */, bool useObjectPool = false /* Metadata: 0x00AF6F36 */) => default; // 0x00000001833B70F0-0x00000001833B75E0
	[BlackList] // 0x0000000189670350-0x0000000189670390
	// [XID] // 0x0000000189670350-0x0000000189670390
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001833B67B0-0x00000001833B6A80
	// [XID] // 0x000000018967A9C0-0x000000018967A9E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833B8450-0x00000001833B89A0
	[BlackList] // 0x0000000189682250-0x0000000189682290
	// [XID] // 0x0000000189682250-0x0000000189682290
	public virtual void AutoAllocTypeFields() {} // 0x00000001833B6A80-0x00000001833B6B20
	[BlackList] // 0x000000018968CCC0-0x000000018968CD00
	// [XID] // 0x000000018968CCC0-0x000000018968CD00
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833B6B20-0x00000001833B6CA0
	[BlackList] // 0x0000000189697A20-0x0000000189697A60
	// [XID] // 0x0000000189697A20-0x0000000189697A60
	public virtual void ReturnToObjectPool() {} // 0x00000001833B8D50-0x00000001833B8DF0
	[BlackList] // 0x00000001896A1EE0-0x00000001896A1F20
	// [XID] // 0x00000001896A1EE0-0x00000001896A1F20
	public virtual void OnPoolAllocated() {} // 0x00000001833B8CB0-0x00000001833B8D50
	[BlackList] // 0x00000001896AC190-0x00000001896AC1D0
	// [XID] // 0x00000001896AC190-0x00000001896AC1D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833B8C10-0x00000001833B8CB0
}

