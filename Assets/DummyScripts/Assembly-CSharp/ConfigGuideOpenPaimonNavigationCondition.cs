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
public sealed class ConfigGuideOpenPaimonNavigationCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18264
{
	// Fields
	private NotifyTypes[] _curNotifyList; // 0x20
	private bool _isChecked; // 0x28

	// Constructors
	public ConfigGuideOpenPaimonNavigationCondition() {} // 0x00000001823DC7A0-0x00000001823DC860

	// Methods
	// [XID] // 0x0000000189AF16B0-0x0000000189AF16D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001823DC650-0x00000001823DC700
	// [XID] // 0x0000000189AF8D70-0x0000000189AF8D90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001823DC430-0x00000001823DC4E0
	// [XID] // 0x0000000189B00250-0x0000000189B00270
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF91EB */) => default; // 0x00000001823DC060-0x00000001823DC150
	// [XID] // 0x0000000189B077D0-0x0000000189B077F0
	public override int GetHashNum() => default; // 0x00000001823DAF20-0x00000001823DAFF0
	// [XID] // 0x0000000189B0F090-0x0000000189B0F0B0
	public override void InitEmpty() {} // 0x00000001823DBAF0-0x00000001823DBB90
	[BlackList] // 0x0000000189B163D0-0x0000000189B16410
	// [XID] // 0x0000000189B163D0-0x0000000189B16410
	public override bool FromJson(JSONNode node) => default; // 0x00000001823DB3C0-0x00000001823DB740
	// [XID] // 0x0000000189B20AF0-0x0000000189B20B10
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001823DA8F0-0x00000001823DA9E0
	[BlackList] // 0x0000000189B281F0-0x0000000189B28230
	// [XID] // 0x0000000189B281F0-0x0000000189B28230
	public static new ConfigGuideOpenPaimonNavigationCondition ParseFromJson(JSONNode node) => default; // 0x00000001823DC1B0-0x00000001823DC3D0
	// [XID] // 0x0000000189B326A0-0x0000000189B326C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91EC */, bool useObjectPool = false /* Metadata: 0x00AF91F0 */) => default; // 0x00000001823DBD60-0x00000001823DC060
	// [XID] // 0x0000000189B39F70-0x0000000189B39F90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91F1 */, bool useObjectPool = false /* Metadata: 0x00AF91F5 */) => default; // 0x00000001823DB0D0-0x00000001823DB200
	// [XID] // 0x0000000189B418D0-0x0000000189B418F0
	public static new ConfigGuideOpenPaimonNavigationCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91F6 */, bool useObjectPool = false /* Metadata: 0x00AF91FA */) => default; // 0x00000001823DB740-0x00000001823DB930
	[BlackList] // 0x0000000189B492A0-0x0000000189B492E0
	// [XID] // 0x0000000189B492A0-0x0000000189B492E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001823DA9E0-0x00000001823DACB0
	// [XID] // 0x0000000189B537A0-0x0000000189B537C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001823DC560-0x00000001823DC650
	[BlackList] // 0x0000000189B5AFD0-0x0000000189B5B010
	// [XID] // 0x0000000189B5AFD0-0x0000000189B5B010
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001823DBC70-0x00000001823DBD60
	// [XID] // 0x0000000189B65720-0x0000000189B65740
	protected override bool Prepare(GuideManager manager) => default; // 0x00000001823DB300-0x00000001823DB3C0
	// [XID] // 0x0000000189B6CCA0-0x0000000189B6CCC0
	public override bool Ready(object body = null) => default; // 0x00000001823DB9A0-0x00000001823DBA70
	[BlackList] // 0x0000000189B74470-0x0000000189B744B0
	// [XID] // 0x0000000189B74470-0x0000000189B744B0
	public override void AutoAllocTypeFields() {} // 0x00000001823DACB0-0x00000001823DAD50
	[BlackList] // 0x0000000189B7E860-0x0000000189B7E8A0
	// [XID] // 0x0000000189B7E860-0x0000000189B7E8A0
	public override void AutoRecycleTypeFields() {} // 0x00000001823DAD50-0x00000001823DAE00
	[BlackList] // 0x0000000189B89170-0x0000000189B891B0
	// [XID] // 0x0000000189B89170-0x0000000189B891B0
	public override void ReturnToObjectPool() {} // 0x00000001823DC700-0x00000001823DC7A0
}

