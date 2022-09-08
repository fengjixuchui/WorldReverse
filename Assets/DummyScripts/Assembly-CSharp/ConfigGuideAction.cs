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
public class ConfigGuideAction : ConfigBaseGuide, IAutoAllocRecycle // TypeDefIndex: 18193
{
	// Fields
	private bool isStart; // 0x10
	private bool isStop; // 0x11

	// Constructors
	public ConfigGuideAction() {} // 0x0000000182B88A30-0x0000000182B88AA0

	// Methods
	// [XID] // 0x0000000189B20B30-0x0000000189B20B50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B888E0-0x0000000182B88990
	// [XID] // 0x0000000189B28250-0x0000000189B28270
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182B885B0-0x0000000182B88660
	// [XID] // 0x0000000189B2F5B0-0x0000000189B2F5D0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF8FC9 */) => default; // 0x0000000182B881C0-0x0000000182B882A0
	// [XID] // 0x0000000189B36E30-0x0000000189B36E50
	public override int GetHashNum() => default; // 0x0000000182B87180-0x0000000182B87250
	// [XID] // 0x0000000189B3E700-0x0000000189B3E720
	public override void InitEmpty() {} // 0x0000000182B87C50-0x0000000182B87CF0
	[BlackList] // 0x0000000189B461A0-0x0000000189B461E0
	// [XID] // 0x0000000189B461A0-0x0000000189B461E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182B87640-0x0000000182B879C0
	// [XID] // 0x0000000189B50920-0x0000000189B50940
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182B86B50-0x0000000182B86C40
	[BlackList] // 0x0000000189B58200-0x0000000189B58240
	// [XID] // 0x0000000189B58200-0x0000000189B58240
	public static new ConfigGuideAction ParseFromJson(JSONNode node) => default; // 0x0000000182B88300-0x0000000182B88550
	// [XID] // 0x0000000189B624B0-0x0000000189B624D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FCA */, bool useObjectPool = false /* Metadata: 0x00AF8FCE */) => default; // 0x0000000182B87EC0-0x0000000182B881C0
	// [XID] // 0x0000000189B6A0D0-0x0000000189B6A0F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FCF */, bool useObjectPool = false /* Metadata: 0x00AF8FD3 */) => default; // 0x0000000182B87410-0x0000000182B87540
	// [XID] // 0x0000000189B717D0-0x0000000189B717F0
	public static new ConfigGuideAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FD4 */, bool useObjectPool = false /* Metadata: 0x00AF8FD8 */) => default; // 0x0000000182B879C0-0x0000000182B87BE0
	[BlackList] // 0x0000000189B78C80-0x0000000189B78CC0
	// [XID] // 0x0000000189B78C80-0x0000000189B78CC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B86C40-0x0000000182B86F10
	// [XID] // 0x0000000189B833E0-0x0000000189B83400
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B887F0-0x0000000182B888E0
	[BlackList] // 0x0000000189B8A810-0x0000000189B8A850
	// [XID] // 0x0000000189B8A810-0x0000000189B8A850
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182B87DD0-0x0000000182B87EC0
	// [XID] // 0x0000000189B94BF0-0x0000000189B94C10
	public bool DoStart(ConfigGuideTask taskBelonged) => default; // 0x0000000182B88660-0x0000000182B88730
	// [XID] // 0x0000000189B9C340-0x0000000189B9C360
	protected virtual bool Start(ConfigGuideTask taskBelonged) => default; // 0x0000000182B87330-0x0000000182B87410
	// [XID] // 0x0000000189BA39D0-0x0000000189BA39F0
	protected virtual bool Stop() => default; // 0x0000000182B86A80-0x0000000182B86B50
	// [XID] // 0x0000000189BAAE40-0x0000000189BAAE60
	public bool DoStop() => default; // 0x0000000182B88730-0x0000000182B887F0
	[BlackList] // 0x0000000189BB2490-0x0000000189BB24D0
	// [XID] // 0x0000000189BB2490-0x0000000189BB24D0
	public override void AutoAllocTypeFields() {} // 0x0000000182B86F10-0x0000000182B86FB0
	[BlackList] // 0x0000000189BBC990-0x0000000189BBC9D0
	// [XID] // 0x0000000189BBC990-0x0000000189BBC9D0
	public override void AutoRecycleTypeFields() {} // 0x0000000182B86FB0-0x0000000182B87060
	[BlackList] // 0x0000000189BC7440-0x0000000189BC7480
	// [XID] // 0x0000000189BC7440-0x0000000189BC7480
	public override void ReturnToObjectPool() {} // 0x0000000182B88990-0x0000000182B88A30
}

