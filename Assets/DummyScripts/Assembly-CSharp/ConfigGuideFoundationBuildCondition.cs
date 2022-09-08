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
public class ConfigGuideFoundationBuildCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18290
{
	// Fields
	private SimpleSafeInt32 numRawNum; // 0x20
	private GuideOperator _opt; // 0x24
	private bool _isBuild; // 0x28
	private static NotifyTypes[] _curNotifyList; // 0x00

	// Properties
	public int num { /* [XID] */ /* 0x000000018962AEA0-0x000000018962AEC0 */ get => default; /* [XID] */ /* 0x00000001896325E0-0x0000000189632600 */ private set {} } // 0x0000000181635C20-0x0000000181635CF0 0x00000001816356D0-0x00000001816357B0
	public GuideOperator opt { /* [XID] */ /* 0x000000018963A050-0x000000018963A070 */ get => default; /* [XID] */ /* 0x00000001896415C0-0x00000001896415E0 */ private set {} } // 0x0000000181633960-0x0000000181633A00 0x0000000181634E00-0x0000000181634EB0
	public bool isBuild { /* [XID] */ /* 0x0000000189648F80-0x0000000189648FA0 */ get => default; /* [XID] */ /* 0x0000000189650590-0x00000001896505B0 */ private set {} } // 0x0000000181633A00-0x0000000181633AA0 0x0000000181633ED0-0x0000000181633F80

	// Constructors
	public ConfigGuideFoundationBuildCondition() {} // 0x0000000181635E40-0x0000000181635EB0
	static ConfigGuideFoundationBuildCondition() {} // 0x0000000181635D90-0x0000000181635E40

	// Methods
	// [XID] // 0x0000000189657ED0-0x0000000189657EF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181635AF0-0x0000000181635C20
	// [XID] // 0x000000018965F500-0x000000018965F520
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001816355A0-0x0000000181635650
	// [XID] // 0x0000000189666DD0-0x0000000189666DF0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF92FF */) => default; // 0x00000001816351B0-0x0000000181635290
	// [XID] // 0x000000018966E500-0x000000018966E520
	public override int GetHashNum() => default; // 0x0000000181633890-0x0000000181633960
	// [XID] // 0x00000001896761C0-0x00000001896761E0
	public override void InitEmpty() {} // 0x0000000181634B60-0x0000000181634C30
	[BlackList] // 0x000000018967DA40-0x000000018967DA80
	// [XID] // 0x000000018967DA40-0x000000018967DA80
	public override bool FromJson(JSONNode node) => default; // 0x0000000181634170-0x00000001816344F0
	// [XID] // 0x00000001896885A0-0x00000001896885C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181632F00-0x0000000181633320
	[BlackList] // 0x000000018968FEA0-0x000000018968FEE0
	// [XID] // 0x000000018968FEA0-0x000000018968FEE0
	public static new ConfigGuideFoundationBuildCondition ParseFromJson(JSONNode node) => default; // 0x00000001816352F0-0x0000000181635540
	// [XID] // 0x000000018969A410-0x000000018969A430
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9300 */, bool useObjectPool = false /* Metadata: 0x00AF9304 */) => default; // 0x0000000181634EB0-0x00000001816351B0
	// [XID] // 0x00000001896A1CE0-0x00000001896A1D00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9305 */, bool useObjectPool = false /* Metadata: 0x00AF9309 */) => default; // 0x0000000181633B80-0x0000000181633ED0
	// [XID] // 0x00000001896A9100-0x00000001896A9120
	public static new ConfigGuideFoundationBuildCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF930A */, bool useObjectPool = false /* Metadata: 0x00AF930E */) => default; // 0x00000001816344F0-0x0000000181634710
	[BlackList] // 0x00000001896B0290-0x00000001896B02D0
	// [XID] // 0x00000001896B0290-0x00000001896B02D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181633320-0x00000001816335F0
	// [XID] // 0x00000001896BAA30-0x00000001896BAA50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001816357B0-0x0000000181635AF0
	[BlackList] // 0x00000001896C1A80-0x00000001896C1AC0
	// [XID] // 0x00000001896C1A80-0x00000001896C1AC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181634D10-0x0000000181634E00
	// [XID] // 0x00000001896CC250-0x00000001896CC270
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000181634080-0x0000000181634170
	// [XID] // 0x00000001896D3480-0x00000001896D34A0
	public override bool Ready(object body = null) => default; // 0x0000000181634780-0x0000000181634AE0
	[BlackList] // 0x00000001896DB080-0x00000001896DB0C0
	// [XID] // 0x00000001896DB080-0x00000001896DB0C0
	public override void AutoAllocTypeFields() {} // 0x00000001816335F0-0x0000000181633690
	[BlackList] // 0x00000001896E54B0-0x00000001896E54F0
	// [XID] // 0x00000001896E54B0-0x00000001896E54F0
	public override void AutoRecycleTypeFields() {} // 0x0000000181633690-0x0000000181633770
	[BlackList] // 0x00000001896EF940-0x00000001896EF980
	// [XID] // 0x00000001896EF940-0x00000001896EF980
	public override void ReturnToObjectPool() {} // 0x0000000181635CF0-0x0000000181635D90
}

