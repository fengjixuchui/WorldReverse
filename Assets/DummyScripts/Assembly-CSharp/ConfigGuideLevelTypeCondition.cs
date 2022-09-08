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
public class ConfigGuideLevelTypeCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18278
{
	// Fields
	private GuideLevelType _type; // 0x20

	// Properties
	public GuideLevelType type { /* [XID] */ /* 0x0000000189800DA0-0x0000000189800DC0 */ get => default; /* [XID] */ /* 0x0000000189808300-0x0000000189808320 */ private set {} } // 0x000000018374A730-0x000000018374A7D0 0x000000018374A390-0x000000018374A440

	// Constructors
	public ConfigGuideLevelTypeCondition() {} // 0x000000018374A870-0x000000018374A8D0

	// Methods
	// [XID] // 0x000000018980FD30-0x000000018980FD50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018374A640-0x000000018374A730
	// [XID] // 0x0000000189817380-0x00000001898173A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018374A260-0x000000018374A310
	// [XID] // 0x000000018981ECE0-0x000000018981ED00
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF92A3 */) => default; // 0x0000000183749E70-0x0000000183749F50
	// [XID] // 0x00000001898261D0-0x00000001898261F0
	public override int GetHashNum() => default; // 0x0000000183748B10-0x0000000183748BE0
	// [XID] // 0x000000018982D780-0x000000018982D7A0
	public override void InitEmpty() {} // 0x0000000183749900-0x00000001837499A0
	[BlackList] // 0x0000000189834F70-0x0000000189834FB0
	// [XID] // 0x0000000189834F70-0x0000000189834FB0
	public override bool FromJson(JSONNode node) => default; // 0x00000001837490A0-0x0000000183749420
	// [XID] // 0x000000018983F590-0x000000018983F5B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001837483B0-0x00000001837485D0
	[BlackList] // 0x0000000189846C10-0x0000000189846C50
	// [XID] // 0x0000000189846C10-0x0000000189846C50
	public static new ConfigGuideLevelTypeCondition ParseFromJson(JSONNode node) => default; // 0x0000000183749FB0-0x000000018374A200
	// [XID] // 0x00000001898510F0-0x0000000189851110
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92A4 */, bool useObjectPool = false /* Metadata: 0x00AF92A8 */) => default; // 0x0000000183749B70-0x0000000183749E70
	// [XID] // 0x00000001898585C0-0x00000001898585E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92A9 */, bool useObjectPool = false /* Metadata: 0x00AF92AD */) => default; // 0x0000000183748CC0-0x0000000183748EF0
	// [XID] // 0x000000018985F630-0x000000018985F650
	public static new ConfigGuideLevelTypeCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92AE */, bool useObjectPool = false /* Metadata: 0x00AF92B2 */) => default; // 0x0000000183749420-0x0000000183749640
	[BlackList] // 0x0000000189866EF0-0x0000000189866F30
	// [XID] // 0x0000000189866EF0-0x0000000189866F30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001837485D0-0x00000001837488A0
	// [XID] // 0x0000000189871290-0x00000001898712B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018374A440-0x000000018374A640
	[BlackList] // 0x0000000189878C70-0x0000000189878CB0
	// [XID] // 0x0000000189878C70-0x0000000189878CB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183749A80-0x0000000183749B70
	// [XID] // 0x0000000189882D30-0x0000000189882D50
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000183748FF0-0x00000001837490A0
	// [XID] // 0x000000018988A4D0-0x000000018988A4F0
	public override bool Ready(object body = null) => default; // 0x00000001837496B0-0x0000000183749880
	[BlackList] // 0x0000000189891940-0x0000000189891980
	// [XID] // 0x0000000189891940-0x0000000189891980
	public override void AutoAllocTypeFields() {} // 0x00000001837488A0-0x0000000183748940
	[BlackList] // 0x000000018989BF00-0x000000018989BF40
	// [XID] // 0x000000018989BF00-0x000000018989BF40
	public override void AutoRecycleTypeFields() {} // 0x0000000183748940-0x00000001837489F0
	[BlackList] // 0x00000001898A6700-0x00000001898A6740
	// [XID] // 0x00000001898A6700-0x00000001898A6740
	public override void ReturnToObjectPool() {} // 0x000000018374A7D0-0x000000018374A870
}

