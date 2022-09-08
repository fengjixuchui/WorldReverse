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
public class ConfigVMapMark : ConfigVBaseMark, IAutoAllocRecycle // TypeDefIndex: 18557
{
	// Fields
	private MarkVisibleType _visibleTypeMiniMap; // 0x20
	private MarkVisibleType _visibleTypeLevelMap; // 0x24
	private MarkLayerType _layerType; // 0x28

	// Properties
	public MarkVisibleType visibleTypeMiniMap { /* [XID] */ /* 0x0000000189B8EDB0-0x0000000189B8EDD0 */ get => default; /* [XID] */ /* 0x0000000189B961A0-0x0000000189B961C0 */ private set {} } // 0x000000018587D870-0x000000018587D910 0x000000018587F6F0-0x000000018587F7A0
	public MarkVisibleType visibleTypeLevelMap { /* [XID] */ /* 0x0000000189B9D760-0x0000000189B9D780 */ get => default; /* [XID] */ /* 0x0000000189BA5230-0x0000000189BA5250 */ private set {} } // 0x000000018587EB20-0x000000018587EBC0 0x000000018587EC30-0x000000018587ECE0
	public MarkLayerType layerType { /* [XID] */ /* 0x0000000189BAC3D0-0x0000000189BAC3F0 */ get => default; /* [XID] */ /* 0x0000000189BB3C10-0x0000000189BB3C30 */ private set {} } // 0x000000018587E860-0x000000018587E900 0x000000018587E430-0x000000018587E4E0

	// Constructors
	public ConfigVMapMark() {} // 0x000000018587FC80-0x000000018587FCE0

	// Methods
	// [XID] // 0x0000000189BBB1D0-0x0000000189BBB1F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018587FAB0-0x000000018587FBE0
	// [XID] // 0x0000000189BC2FF0-0x0000000189BC3010
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018587F640-0x000000018587F6F0
	// [XID] // 0x0000000189BCA870-0x0000000189BCA890
	public override ConfigVBaseMark Clone(bool useObjectPool = false /* Metadata: 0x00AFA3D1 */) => default; // 0x000000018587F250-0x000000018587F330
	// [XID] // 0x0000000189BD1E60-0x0000000189BD1E80
	public override int GetHashNum() => default; // 0x000000018587DE50-0x000000018587DF20
	// [XID] // 0x0000000189BD9500-0x0000000189BD9520
	public override void InitEmpty() {} // 0x000000018587ECE0-0x000000018587ED80
	[BlackList] // 0x00000001895E6070-0x00000001895E60B0
	// [XID] // 0x00000001895E6070-0x00000001895E60B0
	public override bool FromJson(JSONNode node) => default; // 0x000000018587E4E0-0x000000018587E860
	// [XID] // 0x00000001895F08C0-0x00000001895F08E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018587D4A0-0x000000018587D870
	[BlackList] // 0x00000001895F8230-0x00000001895F8270
	// [XID] // 0x00000001895F8230-0x00000001895F8270
	public static new ConfigVMapMark ParseFromJson(JSONNode node) => default; // 0x000000018587F390-0x000000018587F5E0
	// [XID] // 0x0000000189602810-0x0000000189602830
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3D2 */, bool useObjectPool = false /* Metadata: 0x00AFA3D6 */) => default; // 0x000000018587EF50-0x000000018587F250
	// [XID] // 0x000000018960A1B0-0x000000018960A1D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3D7 */, bool useObjectPool = false /* Metadata: 0x00AFA3DB */) => default; // 0x000000018587E000-0x000000018587E330
	// [XID] // 0x0000000189611940-0x0000000189611960
	public static new ConfigVMapMark ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3DC */, bool useObjectPool = false /* Metadata: 0x00AFA3E0 */) => default; // 0x000000018587E900-0x000000018587EB20
	[BlackList] // 0x0000000189619240-0x0000000189619280
	// [XID] // 0x0000000189619240-0x0000000189619280
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018587D910-0x000000018587DBE0
	// [XID] // 0x0000000189623520-0x0000000189623540
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018587F7A0-0x000000018587FAB0
	[BlackList] // 0x000000018962ADC0-0x000000018962AE00
	// [XID] // 0x000000018962ADC0-0x000000018962AE00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018587EE60-0x000000018587EF50
	[BlackList] // 0x0000000189635AB0-0x0000000189635AF0
	// [XID] // 0x0000000189635AB0-0x0000000189635AF0
	public override void AutoAllocTypeFields() {} // 0x000000018587DBE0-0x000000018587DC80
	[BlackList] // 0x000000018963FE70-0x000000018963FEB0
	// [XID] // 0x000000018963FE70-0x000000018963FEB0
	public override void AutoRecycleTypeFields() {} // 0x000000018587DC80-0x000000018587DD30
	[BlackList] // 0x000000018964A6C0-0x000000018964A700
	// [XID] // 0x000000018964A6C0-0x000000018964A700
	public override void ReturnToObjectPool() {} // 0x000000018587FBE0-0x000000018587FC80
}

