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
public class ConfigGuidePageCheckBaseCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18294
{
	// Fields
	protected BasePageContext _baseContext; // 0x20
	private static NotifyTypes[] _curNotifyList; // 0x00

	// Constructors
	public ConfigGuidePageCheckBaseCondition() {} // 0x0000000183252230-0x0000000183252290
	static ConfigGuidePageCheckBaseCondition() {} // 0x0000000183252160-0x0000000183252230

	// Methods
	// [XID] // 0x00000001897E1360-0x00000001897E1380
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183252010-0x00000001832520C0
	// [XID] // 0x00000001897E8BB0-0x00000001897E8BD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183251CC0-0x0000000183251D70
	// [XID] // 0x00000001897F0800-0x00000001897F0820
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF931F */) => default; // 0x00000001832518D0-0x00000001832519B0
	// [XID] // 0x00000001897F7F40-0x00000001897F7F60
	public override int GetHashNum() => default; // 0x00000001832503B0-0x0000000183250480
	// [XID] // 0x00000001897FF5D0-0x00000001897FF5F0
	public override void InitEmpty() {} // 0x0000000183251360-0x0000000183251400
	[BlackList] // 0x0000000189806D10-0x0000000189806D50
	// [XID] // 0x0000000189806D10-0x0000000189806D50
	public override bool FromJson(JSONNode node) => default; // 0x00000001832509D0-0x0000000183250D50
	// [XID] // 0x0000000189811300-0x0000000189811320
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018324FD80-0x000000018324FE70
	[BlackList] // 0x0000000189818DB0-0x0000000189818DF0
	// [XID] // 0x0000000189818DB0-0x0000000189818DF0
	public static new ConfigGuidePageCheckBaseCondition ParseFromJson(JSONNode node) => default; // 0x0000000183251A10-0x0000000183251C60
	// [XID] // 0x00000001898230B0-0x00000001898230D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9320 */, bool useObjectPool = false /* Metadata: 0x00AF9324 */) => default; // 0x00000001832515D0-0x00000001832518D0
	// [XID] // 0x000000018982AB10-0x000000018982AB30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9325 */, bool useObjectPool = false /* Metadata: 0x00AF9329 */) => default; // 0x0000000183250600-0x0000000183250730
	// [XID] // 0x0000000189831FD0-0x0000000189831FF0
	public static new ConfigGuidePageCheckBaseCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF932A */, bool useObjectPool = false /* Metadata: 0x00AF932E */) => default; // 0x0000000183250DF0-0x0000000183251010
	[BlackList] // 0x00000001898396C0-0x0000000189839700
	// [XID] // 0x00000001898396C0-0x0000000189839700
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018324FE70-0x0000000183250140
	// [XID] // 0x0000000189843D80-0x0000000189843DA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183251F20-0x0000000183252010
	[BlackList] // 0x000000018984B290-0x000000018984B2D0
	// [XID] // 0x000000018984B290-0x000000018984B2D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001832514E0-0x00000001832515D0
	// [XID] // 0x0000000189855390-0x00000001898553B0
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000183250830-0x0000000183250920
	// [XID] // 0x000000018985CA10-0x000000018985CA30
	protected override void Finish(GuideManager manager) {} // 0x0000000183251DF0-0x0000000183251EA0
	// [XID] // 0x0000000189864290-0x00000001898642B0
	private void ReleaseCache() {} // 0x0000000183250D50-0x0000000183250DF0
	// [XID] // 0x000000018986B780-0x000000018986B7A0
	private void CheckCurPage() {} // 0x0000000183251080-0x0000000183251190
	// [XID] // 0x0000000189872A70-0x0000000189872A90
	public override bool Ready(object body = null) => default; // 0x0000000183251190-0x00000001832512E0
	// [XID] // 0x000000018987A6F0-0x000000018987A710
	protected virtual bool CheckPageCurrent(BasePageContext context) => default; // 0x0000000183250920-0x00000001832509D0
	// [XID] // 0x00000001898818C0-0x00000001898818E0
	protected virtual bool CheckPageCondition() => default; // 0x00000001832504E0-0x0000000183250580
	[BlackList] // 0x0000000189888EA0-0x0000000189888EE0
	// [XID] // 0x0000000189888EA0-0x0000000189888EE0
	public override void AutoAllocTypeFields() {} // 0x0000000183250140-0x00000001832501E0
	[BlackList] // 0x00000001898933B0-0x00000001898933F0
	// [XID] // 0x00000001898933B0-0x00000001898933F0
	public override void AutoRecycleTypeFields() {} // 0x00000001832501E0-0x0000000183250290
	[BlackList] // 0x000000018989D580-0x000000018989D5C0
	// [XID] // 0x000000018989D580-0x000000018989D5C0
	public override void ReturnToObjectPool() {} // 0x00000001832520C0-0x0000000183252160
}

