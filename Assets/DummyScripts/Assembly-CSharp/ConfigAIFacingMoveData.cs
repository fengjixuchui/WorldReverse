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
public class ConfigAIFacingMoveData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17445
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat rangeMinRawNum; // 0x14
	private SimpleSafeFloat rangeMaxRawNum; // 0x18
	private SimpleSafeFloat restTimeMinRawNum; // 0x1C
	private SimpleSafeFloat restTimeMaxRawNum; // 0x20
	private SimpleSafeFloat facingMoveTurnIntervalRawNum; // 0x24
	private SimpleSafeFloat facingMoveMinAvoidanceVelecityRawNum; // 0x28
	private SimpleSafeFloat obstacleDetectRangeRawNum; // 0x2C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFacingMoveWeight _facingMoveWeight; // 0x30

	// Properties
	public int speedLevel { /* [XID] */ /* 0x00000001896A9240-0x00000001896A9260 */ get => default; /* [XID] */ /* 0x00000001896B03B0-0x00000001896B03D0 */ private set {} } // 0x00000001844EC110-0x00000001844EC1E0 0x00000001844EC2C0-0x00000001844EC3A0
	public float rangeMin { /* [XID] */ /* 0x00000001896B7DB0-0x00000001896B7DD0 */ get => default; /* [XID] */ /* 0x00000001896BED50-0x00000001896BED70 */ private set {} } // 0x00000001844ED260-0x00000001844ED340 0x00000001844ED0A0-0x00000001844ED180
	public float rangeMax { /* [XID] */ /* 0x00000001896C66F0-0x00000001896C6710 */ get => default; /* [XID] */ /* 0x00000001896CDC50-0x00000001896CDC70 */ private set {} } // 0x00000001844ECAB0-0x00000001844ECB90 0x00000001844ED800-0x00000001844ED8E0
	public float restTimeMin { /* [XID] */ /* 0x00000001896D52A0-0x00000001896D52C0 */ get => default; /* [XID] */ /* 0x00000001896DC7C0-0x00000001896DC7E0 */ private set {} } // 0x00000001844EE360-0x00000001844EE440 0x00000001844ED180-0x00000001844ED260
	public float restTimeMax { /* [XID] */ /* 0x00000001896E4150-0x00000001896E4170 */ get => default; /* [XID] */ /* 0x00000001896EB600-0x00000001896EB620 */ private set {} } // 0x00000001844EC1E0-0x00000001844EC2C0 0x00000001844ECF10-0x00000001844ECFF0
	public float facingMoveTurnInterval { /* [XID] */ /* 0x00000001896F29D0-0x00000001896F29F0 */ get => default; /* [XID] */ /* 0x00000001896FA2D0-0x00000001896FA2F0 */ private set {} } // 0x00000001844EB0E0-0x00000001844EB1C0 0x00000001844EDB40-0x00000001844EDC20
	public float facingMoveMinAvoidanceVelecity { /* [XID] */ /* 0x0000000189701A00-0x0000000189701A20 */ get => default; /* [XID] */ /* 0x0000000189709300-0x0000000189709320 */ private set {} } // 0x00000001844ED9C0-0x00000001844EDAA0 0x00000001844EE280-0x00000001844EE360
	public float obstacleDetectRange { /* [XID] */ /* 0x0000000189710C50-0x0000000189710C70 */ get => default; /* [XID] */ /* 0x0000000189717EF0-0x0000000189717F10 */ private set {} } // 0x00000001844EC9D0-0x00000001844ECAB0 0x00000001844ED8E0-0x00000001844ED9C0
	public ConfigAIFacingMoveWeight facingMoveWeight { /* [XID] */ /* 0x000000018971F870-0x000000018971F890 */ get => default; /* [XID] */ /* 0x0000000189726EE0-0x0000000189726F00 */ private set {} } // 0x00000001844EDAA0-0x00000001844EDB40 0x00000001844ECFF0-0x00000001844ED0A0

	// Constructors
	public ConfigAIFacingMoveData() {} // 0x00000001844EE7F0-0x00000001844EE930

	// Methods
	// [XID] // 0x000000018972E410-0x000000018972E430
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001844EE440-0x00000001844EE610
	// [XID] // 0x0000000189735BA0-0x0000000189735BC0
	public void InitEmpty() {} // 0x00000001844ED340-0x00000001844ED500
	[BlackList] // 0x000000018973D730-0x000000018973D770
	// [XID] // 0x000000018973D730-0x000000018973D770
	public bool FromJson(JSONNode node) => default; // 0x00000001844ECB90-0x00000001844ECF10
	// [XID] // 0x0000000189747E20-0x0000000189747E40
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001844EB1C0-0x00000001844EBB90
	// [XID] // 0x000000018974F510-0x000000018974F530
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EDF */, bool useObjectPool = false /* Metadata: 0x00AF6EE3 */) => default; // 0x00000001844ED500-0x00000001844ED800
	// [XID] // 0x0000000189756BA0-0x0000000189756BC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EE4 */, bool useObjectPool = false /* Metadata: 0x00AF6EE8 */) => default; // 0x00000001844EC3A0-0x00000001844EC9D0
	[BlackList] // 0x000000018975E070-0x000000018975E0B0
	// [XID] // 0x000000018975E070-0x000000018975E0B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001844EBB90-0x00000001844EBE60
	// [XID] // 0x00000001897687A0-0x00000001897687C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001844EDC20-0x00000001844EE280
	[BlackList] // 0x000000018976FE70-0x000000018976FEB0
	// [XID] // 0x000000018976FE70-0x000000018976FEB0
	public virtual void AutoAllocTypeFields() {} // 0x00000001844EBE60-0x00000001844EBF00
	[BlackList] // 0x000000018977A560-0x000000018977A5A0
	// [XID] // 0x000000018977A560-0x000000018977A5A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001844EBF00-0x00000001844EC110
	[BlackList] // 0x00000001897850A0-0x00000001897850E0
	// [XID] // 0x00000001897850A0-0x00000001897850E0
	public virtual void ReturnToObjectPool() {} // 0x00000001844EE750-0x00000001844EE7F0
	[BlackList] // 0x000000018978F4C0-0x000000018978F500
	// [XID] // 0x000000018978F4C0-0x000000018978F500
	public virtual void OnPoolAllocated() {} // 0x00000001844EE6B0-0x00000001844EE750
	[BlackList] // 0x0000000189799A70-0x0000000189799AB0
	// [XID] // 0x0000000189799A70-0x0000000189799AB0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001844EE610-0x00000001844EE6B0
}

