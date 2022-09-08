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
public class ConfigAIBrownianMotionData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17484
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x14
	private SimpleSafeFloat moveCdMinRawNum; // 0x18
	private SimpleSafeFloat moveCdMaxRawNum; // 0x1C
	private SimpleSafeFloat terrainOffsetMinRawNum; // 0x20
	private SimpleSafeFloat terrainOffsetMaxRawNum; // 0x24
	private SimpleSafeFloat motionRadiusRawNum; // 0x28
	private bool _recalcCenterOnLeaveCurrentZone; // 0x2C
	private bool _recalcCenterOnAttachPosChange; // 0x2D

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189A58E80-0x0000000189A58EA0 */ get => default; /* [XID] */ /* 0x0000000189A60780-0x0000000189A607A0 */ private set {} } // 0x00000001842EC690-0x00000001842EC760 0x00000001842EC9D0-0x00000001842ECAB0
	public float turnSpeedOverride { /* [XID] */ /* 0x0000000189A685F0-0x0000000189A68610 */ get => default; /* [XID] */ /* 0x0000000189A6F920-0x0000000189A6F940 */ private set {} } // 0x00000001842EC810-0x00000001842EC8F0 0x00000001842ED160-0x00000001842ED240
	public float moveCdMin { /* [XID] */ /* 0x0000000189A770D0-0x0000000189A770F0 */ get => default; /* [XID] */ /* 0x0000000189A7EB20-0x0000000189A7EB40 */ private set {} } // 0x00000001842EC5B0-0x00000001842EC690 0x00000001842EE8D0-0x00000001842EE9B0
	public float moveCdMax { /* [XID] */ /* 0x0000000189A86330-0x0000000189A86350 */ get => default; /* [XID] */ /* 0x0000000189A8DD30-0x0000000189A8DD50 */ private set {} } // 0x00000001842EDD00-0x00000001842EDDE0 0x00000001842EDEC0-0x00000001842EDFA0
	public float terrainOffsetMin { /* [XID] */ /* 0x0000000189A95310-0x0000000189A95330 */ get => default; /* [XID] */ /* 0x0000000189A9CAD0-0x0000000189A9CAF0 */ private set {} } // 0x00000001842EC8F0-0x00000001842EC9D0 0x00000001842EE9B0-0x00000001842EEA90
	public float terrainOffsetMax { /* [XID] */ /* 0x0000000189AA42C0-0x0000000189AA42E0 */ get => default; /* [XID] */ /* 0x0000000189AAB7D0-0x0000000189AAB7F0 */ private set {} } // 0x00000001842EDC20-0x00000001842EDD00 0x00000001842EB6C0-0x00000001842EB7A0
	public float motionRadius { /* [XID] */ /* 0x0000000189AB30E0-0x0000000189AB3100 */ get => default; /* [XID] */ /* 0x0000000189ABAD90-0x0000000189ABADB0 */ private set {} } // 0x00000001842EDDE0-0x00000001842EDEC0 0x00000001842ED080-0x00000001842ED160
	public bool recalcCenterOnLeaveCurrentZone { /* [XID] */ /* 0x0000000189AC2680-0x0000000189AC26A0 */ get => default; /* [XID] */ /* 0x0000000189AC9D20-0x0000000189AC9D40 */ private set {} } // 0x00000001842ED660-0x00000001842ED700 0x00000001842EC760-0x00000001842EC810
	public bool recalcCenterOnAttachPosChange { /* [XID] */ /* 0x0000000189AD15F0-0x0000000189AD1610 */ get => default; /* [XID] */ /* 0x0000000189AD92F0-0x0000000189AD9310 */ private set {} } // 0x00000001842ED5C0-0x00000001842ED660 0x00000001842EDB70-0x00000001842EDC20

	// Constructors
	public ConfigAIBrownianMotionData() {} // 0x00000001842EEB30-0x00000001842EEC70

	// Methods
	// [XID] // 0x0000000189AE0E20-0x0000000189AE0E40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842EE5D0-0x00000001842EE790
	// [XID] // 0x0000000189AE8270-0x0000000189AE8290
	public void InitEmpty() {} // 0x00000001842ED700-0x00000001842ED870
	[BlackList] // 0x0000000189AF00F0-0x0000000189AF0130
	// [XID] // 0x0000000189AF00F0-0x0000000189AF0130
	public bool FromJson(JSONNode node) => default; // 0x00000001842ED240-0x00000001842ED5C0
	// [XID] // 0x0000000189AFA720-0x0000000189AFA740
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001842EB7A0-0x00000001842EC0D0
	// [XID] // 0x0000000189B01CD0-0x0000000189B01CF0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7031 */, bool useObjectPool = false /* Metadata: 0x00AF7035 */) => default; // 0x00000001842ED870-0x00000001842EDB70
	// [XID] // 0x0000000189B09250-0x0000000189B09270
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7036 */, bool useObjectPool = false /* Metadata: 0x00AF703A */) => default; // 0x00000001842ECAB0-0x00000001842ED080
	[BlackList] // 0x0000000189B10C90-0x0000000189B10CD0
	// [XID] // 0x0000000189B10C90-0x0000000189B10CD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001842EC0D0-0x00000001842EC3A0
	// [XID] // 0x0000000189B1AE80-0x0000000189B1AEA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842EDFA0-0x00000001842EE5D0
	[BlackList] // 0x0000000189B22530-0x0000000189B22570
	// [XID] // 0x0000000189B22530-0x0000000189B22570
	public virtual void AutoAllocTypeFields() {} // 0x00000001842EC3A0-0x00000001842EC440
	[BlackList] // 0x0000000189B2CA10-0x0000000189B2CA50
	// [XID] // 0x0000000189B2CA10-0x0000000189B2CA50
	public virtual void AutoRecycleTypeFields() {} // 0x00000001842EC440-0x00000001842EC5B0
	[BlackList] // 0x0000000189B36F30-0x0000000189B36F70
	// [XID] // 0x0000000189B36F30-0x0000000189B36F70
	public virtual void ReturnToObjectPool() {} // 0x00000001842EEA90-0x00000001842EEB30
	[BlackList] // 0x0000000189B41A70-0x0000000189B41AB0
	// [XID] // 0x0000000189B41A70-0x0000000189B41AB0
	public virtual void OnPoolAllocated() {} // 0x00000001842EE830-0x00000001842EE8D0
	[BlackList] // 0x0000000189B4C300-0x0000000189B4C340
	// [XID] // 0x0000000189B4C300-0x0000000189B4C340
	public virtual void OnBeforePoolRecycled() {} // 0x00000001842EE790-0x00000001842EE830
}

