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
public class ConfigGuideMapClickCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18284
{
	// Fields
	private SimpleSafeUInt32 markIDRawNum; // 0x20
	private bool _onlySingleClick; // 0x24
	private NotifyTypes[] _curNotifyList; // 0x28
	private bool _isReady; // 0x30

	// Properties
	public uint markID { /* [XID] */ /* 0x00000001899BE2F0-0x00000001899BE310 */ get => default; /* [XID] */ /* 0x00000001899C5AB0-0x00000001899C5AD0 */ private set {} } // 0x00000001813DE9A0-0x00000001813DEA70 0x00000001813E03E0-0x00000001813E04C0
	public bool onlySingleClick { /* [XID] */ /* 0x00000001899CD110-0x00000001899CD130 */ get => default; /* [XID] */ /* 0x00000001899D4670-0x00000001899D4690 */ private set {} } // 0x00000001813DEFB0-0x00000001813DF050 0x00000001813E0070-0x00000001813E0120

	// Constructors
	public ConfigGuideMapClickCondition() {} // 0x00000001813E0670-0x00000001813E0750

	// Methods
	// [XID] // 0x00000001899DBD30-0x00000001899DBD50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001813E04C0-0x00000001813E05D0
	// [XID] // 0x00000001899E3750-0x00000001899E3770
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001813DFF40-0x00000001813DFFF0
	// [XID] // 0x00000001899EAB00-0x00000001899EAB20
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF92CF */) => default; // 0x00000001813DFB50-0x00000001813DFC30
	// [XID] // 0x00000001899F2700-0x00000001899F2720
	public override int GetHashNum() => default; // 0x00000001813DE510-0x00000001813DE5E0
	// [XID] // 0x00000001899F9C10-0x00000001899F9C30
	public override void InitEmpty() {} // 0x00000001813DF5B0-0x00000001813DF680
	[BlackList] // 0x0000000189A00FF0-0x0000000189A01030
	// [XID] // 0x0000000189A00FF0-0x0000000189A01030
	public override bool FromJson(JSONNode node) => default; // 0x00000001813DEC30-0x00000001813DEFB0
	// [XID] // 0x0000000189A0B8D0-0x0000000189A0B8F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001813DDC70-0x00000001813DDF90
	[BlackList] // 0x0000000189A13100-0x0000000189A13140
	// [XID] // 0x0000000189A13100-0x0000000189A13140
	public static new ConfigGuideMapClickCondition ParseFromJson(JSONNode node) => default; // 0x00000001813DFC90-0x00000001813DFEE0
	// [XID] // 0x0000000189A1D3E0-0x0000000189A1D400
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92D0 */, bool useObjectPool = false /* Metadata: 0x00AF92D4 */) => default; // 0x00000001813DF850-0x00000001813DFB50
	// [XID] // 0x0000000189A248B0-0x0000000189A248D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92D5 */, bool useObjectPool = false /* Metadata: 0x00AF92D9 */) => default; // 0x00000001813DE6C0-0x00000001813DE9A0
	// [XID] // 0x0000000189A2BEB0-0x0000000189A2BED0
	public static new ConfigGuideMapClickCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92DA */, bool useObjectPool = false /* Metadata: 0x00AF92DE */) => default; // 0x00000001813DF050-0x00000001813DF270
	[BlackList] // 0x0000000189A33580-0x0000000189A335C0
	// [XID] // 0x0000000189A33580-0x0000000189A335C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001813DDF90-0x00000001813DE260
	// [XID] // 0x0000000189A3DF10-0x0000000189A3DF30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001813E0120-0x00000001813E03E0
	[BlackList] // 0x0000000189A456A0-0x0000000189A456E0
	// [XID] // 0x0000000189A456A0-0x0000000189A456E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001813DF760-0x00000001813DF850
	// [XID] // 0x0000000189A4FE60-0x0000000189A4FE80
	protected override bool Prepare(GuideManager manager) => default; // 0x00000001813DEB70-0x00000001813DEC30
	// [XID] // 0x0000000189A573B0-0x0000000189A573D0
	public override bool Ready(object body = null) => default; // 0x00000001813DF2E0-0x00000001813DF530
	[BlackList] // 0x0000000189A5EF10-0x0000000189A5EF50
	// [XID] // 0x0000000189A5EF10-0x0000000189A5EF50
	public override void AutoAllocTypeFields() {} // 0x00000001813DE260-0x00000001813DE300
	[BlackList] // 0x0000000189A69BD0-0x0000000189A69C10
	// [XID] // 0x0000000189A69BD0-0x0000000189A69C10
	public override void AutoRecycleTypeFields() {} // 0x00000001813DE300-0x00000001813DE3F0
	[BlackList] // 0x0000000189A73F70-0x0000000189A73FB0
	// [XID] // 0x0000000189A73F70-0x0000000189A73FB0
	public override void ReturnToObjectPool() {} // 0x00000001813E05D0-0x00000001813E0670
}

