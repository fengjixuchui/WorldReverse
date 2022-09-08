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
public class ConfigLocalTrigger : ConfigLocalEntity, IAutoAllocRecycle // TypeDefIndex: 18932
{
	// Fields
	private TriggerFlag _triggerFlag; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBaseShape _shape; // 0x70
	private SimpleSafeInt16 checkCountRawNum; // 0x78
	private SimpleSafeFloat triggerIntervalRawNum; // 0x7C
	private MoleMole.Config.Vector _vectorParam; // 0x80
	private SimpleSafeFloat floatParamRawNum; // 0x8C
	private string _stringParam; // 0x90

	// Properties
	public TriggerFlag triggerFlag { /* [XID] */ /* 0x0000000189993EF0-0x0000000189993F10 */ get => default; /* [XID] */ /* 0x000000018999B740-0x000000018999B760 */ private set {} } // 0x0000000185063300-0x00000001850633A0 0x0000000185062F40-0x0000000185062FF0
	public ConfigBaseShape shape { /* [XID] */ /* 0x00000001899A2E90-0x00000001899A2EB0 */ get => default; /* [XID] */ /* 0x00000001899AA940-0x00000001899AA960 */ private set {} } // 0x0000000185061370-0x0000000185061410 0x0000000185061B60-0x0000000185061C10
	public short checkCount { /* [XID] */ /* 0x00000001899B22F0-0x00000001899B2310 */ get => default; /* [XID] */ /* 0x00000001899B96B0-0x00000001899B96D0 */ private set {} } // 0x0000000185063230-0x0000000185063300 0x0000000185062FF0-0x00000001850630D0
	public float triggerInterval { /* [XID] */ /* 0x00000001899C10D0-0x00000001899C10F0 */ get => default; /* [XID] */ /* 0x00000001899C86E0-0x00000001899C8700 */ private set {} } // 0x0000000185062420-0x0000000185062500 0x0000000185062E60-0x0000000185062F40
	public MoleMole.Config.Vector vectorParam { /* [XID] */ /* 0x00000001899D00D0-0x00000001899D00F0 */ get => default; /* [XID] */ /* 0x00000001899D7530-0x00000001899D7550 */ private set {} } // 0x0000000185063C40-0x0000000185063D20 0x0000000185062A30-0x0000000185062B00
	public float floatParam { /* [XID] */ /* 0x000000018987E310-0x000000018987E330 */ get => default; /* [XID] */ /* 0x00000001899E6650-0x00000001899E6670 */ private set {} } // 0x00000001850633A0-0x0000000185063480 0x0000000185061230-0x0000000185061310
	public string stringParam { /* [XID] */ /* 0x0000000189893CF0-0x0000000189893D10 */ get => default; /* [XID] */ /* 0x00000001899F5590-0x00000001899F55B0 */ private set {} } // 0x0000000185060A40-0x0000000185060AF0 0x0000000185062B60-0x0000000185062C10

	// Constructors
	public ConfigLocalTrigger() {} // 0x0000000185063DC0-0x0000000185063E60

	// Methods
	// [XID] // 0x00000001899FCC30-0x00000001899FCC50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185063A70-0x0000000185063C40
	// [XID] // 0x0000000189A04090-0x0000000189A040B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185063130-0x0000000185063230
	// [XID] // 0x0000000189A0B7F0-0x0000000189A0B810
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AFB40B */) => default; // 0x0000000185062950-0x0000000185062A30
	// [XID] // 0x0000000189A13020-0x0000000189A13040
	public override int GetHashNum() => default; // 0x0000000185061160-0x0000000185061230
	// [XID] // 0x0000000189A1A330-0x0000000189A1A350
	public override void InitEmpty() {} // 0x0000000185062220-0x00000001850623A0
	[BlackList] // 0x0000000189A21910-0x0000000189A21950
	// [XID] // 0x0000000189A21910-0x0000000189A21950
	public override bool FromJson(JSONNode node) => default; // 0x0000000185061C10-0x0000000185061F90
	// [XID] // 0x0000000189A2BD10-0x0000000189A2BD30
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185060250-0x0000000185060A40
	[BlackList] // 0x0000000189A33340-0x0000000189A33380
	// [XID] // 0x0000000189A33340-0x0000000189A33380
	public static new ConfigLocalTrigger ParseFromJson(JSONNode node) => default; // 0x0000000185062C10-0x0000000185062E60
	// [XID] // 0x0000000189A3DD70-0x0000000189A3DD90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB40C */, bool useObjectPool = false /* Metadata: 0x00AFB410 */) => default; // 0x0000000185062650-0x0000000185062950
	// [XID] // 0x0000000189A45560-0x0000000189A45580
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB411 */, bool useObjectPool = false /* Metadata: 0x00AFB415 */) => default; // 0x0000000185061490-0x0000000185061A60
	// [XID] // 0x0000000189A4CB80-0x0000000189A4CBA0
	public static new ConfigLocalTrigger ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB416 */, bool useObjectPool = false /* Metadata: 0x00AFB41A */) => default; // 0x0000000185061F90-0x00000001850621B0
	[BlackList] // 0x0000000189A54370-0x0000000189A543B0
	// [XID] // 0x0000000189A54370-0x0000000189A543B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185060AF0-0x0000000185060DC0
	// [XID] // 0x0000000189A5EE10-0x0000000189A5EE30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185063480-0x0000000185063A70
	[BlackList] // 0x0000000189A666A0-0x0000000189A666E0
	// [XID] // 0x0000000189A666A0-0x0000000189A666E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185062560-0x0000000185062650
	[BlackList] // 0x0000000189A70E20-0x0000000189A70E60
	// [XID] // 0x0000000189A70E20-0x0000000189A70E60
	public override void AutoAllocTypeFields() {} // 0x0000000185060DC0-0x0000000185060E60
	[BlackList] // 0x0000000189A7B900-0x0000000189A7B940
	// [XID] // 0x0000000189A7B900-0x0000000189A7B940
	public override void AutoRecycleTypeFields() {} // 0x0000000185060E60-0x0000000185061040
	[BlackList] // 0x0000000189A860D0-0x0000000189A86110
	// [XID] // 0x0000000189A860D0-0x0000000189A86110
	public override void ReturnToObjectPool() {} // 0x0000000185063D20-0x0000000185063DC0
}

