/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class SelectActionPointByTargetOrientation : ConfigActionPointSelectType, IAutoAllocRecycle // TypeDefIndex: 17891
{
	// Fields
	private SimpleSafeUInt32[] _actionPointIDs; // 0x10
	private SimpleSafeFloat angleRawNum; // 0x18
	private bool _signType; // 0x1C
	public static Action<SelectActionPointByTargetOrientation, bool> postProcessData; // 0x00
	public static Action<SelectActionPointByTargetOrientation> postInitEmpty; // 0x08
	// [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
	private HashSet<uint> actionPointIdSet; // 0x20

	// Properties
	public SimpleSafeUInt32[] actionPointIDs { /* [XID] */ /* 0x000000018976E600-0x000000018976E620 */ get => default; /* [XID] */ /* 0x0000000189776000-0x0000000189776020 */ private set {} } // 0x00000001817D63E0-0x00000001817D6480 0x00000001817D5BF0-0x00000001817D5CA0
	public float angle { /* [XID] */ /* 0x000000018977D6E0-0x000000018977D700 */ get => default; /* [XID] */ /* 0x0000000189784F60-0x0000000189784F80 */ private set {} } // 0x00000001817D5D00-0x00000001817D5DE0 0x00000001817D7400-0x00000001817D74E0
	public bool signType { /* [XID] */ /* 0x000000018978C410-0x000000018978C430 */ get => default; /* [XID] */ /* 0x0000000189793960-0x0000000189793980 */ private set {} } // 0x00000001817D7F80-0x00000001817D8020 0x00000001817D75E0-0x00000001817D7690

	// Constructors
	public SelectActionPointByTargetOrientation() {} // 0x00000001817D8CB0-0x00000001817D8D60
	static SelectActionPointByTargetOrientation() {} // 0x00000001817D8AD0-0x00000001817D8CB0

	// Methods
	// [XID] // 0x000000018979BC50-0x000000018979BC70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817D8700-0x00000001817D8830
	// [XID] // 0x00000001897A3100-0x00000001897A3120
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001817D82D0-0x00000001817D83B0
	// [XID] // 0x00000001897AA6E0-0x00000001897AA700
	public override ConfigActionPointSelectType Clone(bool useObjectPool = false /* Metadata: 0x00AF8059 */) => default; // 0x00000001817D7E40-0x00000001817D7F20
	// [XID] // 0x00000001897B21B0-0x00000001897B21D0
	public override int GetHashNum() => default; // 0x00000001817D5B20-0x00000001817D5BF0
	// [XID] // 0x00000001897B9BD0-0x00000001897B9BF0
	public override void InitEmpty() {} // 0x00000001817D7760-0x00000001817D78F0
	[BlackList] // 0x00000001897C1CF0-0x00000001897C1D30
	// [XID] // 0x00000001897C1CF0-0x00000001897C1D30
	public override bool FromJson(JSONNode node) => default; // 0x00000001817D6500-0x00000001817D6900
	// [XID] // 0x00000001897CC250-0x00000001897CC270
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001817D51B0-0x00000001817D55B0
	[BlackList] // 0x00000001897D3BA0-0x00000001897D3BE0
	// [XID] // 0x00000001897D3BA0-0x00000001897D3BE0
	public static new SelectActionPointByTargetOrientation ParseFromJson(JSONNode node) => default; // 0x00000001817D8020-0x00000001817D8270
	// [XID] // 0x00000001897DE270-0x00000001897DE290
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF805A */, bool useObjectPool = false /* Metadata: 0x00AF805E */) => default; // 0x00000001817D7AC0-0x00000001817D7E40
	// [XID] // 0x00000001897E5D30-0x00000001897E5D50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF805F */, bool useObjectPool = false /* Metadata: 0x00AF8063 */) => default; // 0x00000001817D6000-0x00000001817D6360
	// [XID] // 0x00000001897ED710-0x00000001897ED730
	public static new SelectActionPointByTargetOrientation ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8064 */, bool useObjectPool = false /* Metadata: 0x00AF8068 */) => default; // 0x00000001817D7180-0x00000001817D73A0
	[BlackList] // 0x00000001897F4F50-0x00000001897F4F90
	// [XID] // 0x00000001897F4F50-0x00000001897F4F90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001817D55B0-0x00000001817D5880
	// [XID] // 0x00000001897FF770-0x00000001897FF790
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817D83B0-0x00000001817D8700
	[BlackList] // 0x0000000189806EF0-0x0000000189806F30
	// [XID] // 0x0000000189806EF0-0x0000000189806F30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001817D79D0-0x00000001817D7AC0
	// [XID] // 0x0000000189811400-0x0000000189811420
	public override void OnPoolAllocated() {} // 0x00000001817D8930-0x00000001817D89D0
	// [XID] // 0x0000000189818EF0-0x0000000189818F10
	public override void OnBeforePoolRecycled() {} // 0x00000001817D8830-0x00000001817D8930
	// [XID] // 0x00000001898206F0-0x0000000189820710
	private static void OnPostInitEmpty(SelectActionPointByTargetOrientation data) {} // 0x00000001817D7690-0x00000001817D7760
	// [XID] // 0x0000000189827D20-0x0000000189827D40
	private static void OnPostProcessData(SelectActionPointByTargetOrientation data, bool usePool) {} // 0x00000001817D5DE0-0x00000001817D5F80
	// [XID] // 0x000000018982F0C0-0x000000018982F0E0
	public override LevelActionPoint GetActionPoint(ActionPointType actionPointType, BaseEntity targetEntity, BaseEntity selfEntity) => default; // 0x00000001817D6900-0x00000001817D7180
	[BlackList] // 0x0000000189836950-0x0000000189836990
	// [XID] // 0x0000000189836950-0x0000000189836990
	public override void AutoAllocTypeFields() {} // 0x00000001817D5880-0x00000001817D5920
	[BlackList] // 0x0000000189840D00-0x0000000189840D40
	// [XID] // 0x0000000189840D00-0x0000000189840D40
	public override void AutoRecycleTypeFields() {} // 0x00000001817D5920-0x00000001817D5A00
	[BlackList] // 0x000000018984B350-0x000000018984B390
	// [XID] // 0x000000018984B350-0x000000018984B390
	public override void ReturnToObjectPool() {} // 0x00000001817D8A30-0x00000001817D8AD0
}

