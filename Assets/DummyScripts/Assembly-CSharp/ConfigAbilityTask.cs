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
public class ConfigAbilityTask : BaseAbilityLogic, IAutoAllocRecycle // TypeDefIndex: 17374
{
	// Fields
	private bool _isAsync; // 0x18
	private SimpleSafeFloat durationRawNum; // 0x1C
	private SimpleSafeFloat delayRawNum; // 0x20

	// Properties
	public bool isAsync { /* [XID] */ /* 0x0000000189747130-0x0000000189747150 */ get => default; /* [XID] */ /* 0x00000001899F28C0-0x00000001899F28E0 */ private set {} } // 0x00000001820DBD90-0x00000001820DBE30 0x00000001820DC720-0x00000001820DC7D0
	public float duration { /* [XID] */ /* 0x00000001899F9E10-0x00000001899F9E30 */ get => default; /* [XID] */ /* 0x0000000189A011F0-0x0000000189A01210 */ private set {} } // 0x00000001820DB160-0x00000001820DB240 0x00000001820DB640-0x00000001820DB720
	public float delay { /* [XID] */ /* 0x0000000189730870-0x0000000189730890 */ get => default; /* [XID] */ /* 0x0000000189A100D0-0x0000000189A100F0 */ private set {} } // 0x00000001820DA820-0x00000001820DA900 0x00000001820DC3E0-0x00000001820DC4C0

	// Constructors
	public ConfigAbilityTask() {} // 0x00000001820DCF00-0x00000001820DCF70

	// Methods
	// [XID] // 0x0000000189A17610-0x0000000189A17630
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820DCB50-0x00000001820DCC70
	// [XID] // 0x0000000189A1ED50-0x0000000189A1ED70
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001820DC7D0-0x00000001820DC880
	// [XID] // 0x0000000189A263C0-0x0000000189A263E0
	public virtual ConfigAbilityTask Clone(bool useObjectPool = false /* Metadata: 0x00AF6C0F */) => default; // 0x00000001820DC300-0x00000001820DC3E0
	// [XID] // 0x0000000189A2D690-0x0000000189A2D6B0
	public virtual int GetHashNum() => default; // 0x00000001820DB240-0x00000001820DB310
	// [XID] // 0x0000000189A351D0-0x0000000189A351F0
	public override void InitEmpty() {} // 0x00000001820DBE30-0x00000001820DBF10
	[BlackList] // 0x0000000189A3C6E0-0x0000000189A3C720
	// [XID] // 0x0000000189A3C6E0-0x0000000189A3C720
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001820DB840-0x00000001820DBBC0
	// [XID] // 0x0000000189A47010-0x0000000189A47030
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001820DA900-0x00000001820DAD10
	[BlackList] // 0x0000000189A4E910-0x0000000189A4E950
	// [XID] // 0x0000000189A4E910-0x0000000189A4E950
	public static ConfigAbilityTask ParseFromJson(JSONNode node) => default; // 0x00000001820DC520-0x00000001820DC720
	// [XID] // 0x0000000189A58F40-0x0000000189A58F60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C10 */, bool useObjectPool = false /* Metadata: 0x00AF6C14 */) => default; // 0x00000001820DC000-0x00000001820DC300
	// [XID] // 0x0000000189A60860-0x0000000189A60880
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C15 */, bool useObjectPool = false /* Metadata: 0x00AF6C19 */) => default; // 0x00000001820DB310-0x00000001820DB640
	// [XID] // 0x0000000189A68670-0x0000000189A68690
	public static ConfigAbilityTask ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C1A */, bool useObjectPool = false /* Metadata: 0x00AF6C1E */) => default; // 0x00000001820DBBC0-0x00000001820DBD90
	[BlackList] // 0x0000000189A6F960-0x0000000189A6F9A0
	// [XID] // 0x0000000189A6F960-0x0000000189A6F9A0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001820DAD10-0x00000001820DAFE0
	// [XID] // 0x0000000189A7A610-0x0000000189A7A630
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820DC880-0x00000001820DCB50
	[BlackList] // 0x0000000189A81B10-0x0000000189A81B50
	// [XID] // 0x0000000189A81B10-0x0000000189A81B50
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001820DBF10-0x00000001820DC000
	[BlackList] // 0x0000000189A8C530-0x0000000189A8C570
	// [XID] // 0x0000000189A8C530-0x0000000189A8C570
	public virtual void AutoAllocTypeFields() {} // 0x00000001820DAFE0-0x00000001820DB080
	[BlackList] // 0x0000000189A96B20-0x0000000189A96B60
	// [XID] // 0x0000000189A96B20-0x0000000189A96B60
	public virtual void AutoRecycleTypeFields() {} // 0x00000001820DB080-0x00000001820DB160
	[BlackList] // 0x0000000189AA0E00-0x0000000189AA0E40
	// [XID] // 0x0000000189AA0E00-0x0000000189AA0E40
	public virtual void ReturnToObjectPool() {} // 0x00000001820DCE60-0x00000001820DCF00
	[BlackList] // 0x0000000189AAB7F0-0x0000000189AAB830
	// [XID] // 0x0000000189AAB7F0-0x0000000189AAB830
	public virtual void OnPoolAllocated() {} // 0x00000001820DCD10-0x00000001820DCDB0
	[BlackList] // 0x0000000189AB6160-0x0000000189AB61A0
	// [XID] // 0x0000000189AB6160-0x0000000189AB61A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001820DCC70-0x00000001820DCD10
	// [XID] // 0x000000018966F2A0-0x000000018966F2C0
	public virtual AbilityTask CreateTaskFromConfig() => default; // 0x00000001820DCDB0-0x00000001820DCE60
	// [XID] // 0x0000000189AC8550-0x0000000189AC8570
	public virtual AbilityTaskBlackboard CreateTaskBlackboardFromConfig() => default; // 0x00000001820DB7A0-0x00000001820DB840
}

