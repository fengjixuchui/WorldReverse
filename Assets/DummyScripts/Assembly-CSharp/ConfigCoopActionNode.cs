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
public class ConfigCoopActionNode : ConfigCoopBaseNode, IAutoAllocRecycle // TypeDefIndex: 17756
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCoopAction[] _actionList; // 0x20

	// Properties
	public ConfigCoopAction[] actionList { /* [XID] */ /* 0x0000000189764060-0x0000000189764080 */ get => default; /* [XID] */ /* 0x000000018976B900-0x000000018976B920 */ private set {} } // 0x000000018209F8F0-0x000000018209F990 0x000000018209F740-0x000000018209F7F0

	// Constructors
	public ConfigCoopActionNode() {} // 0x00000001820A0DE0-0x00000001820A0E40

	// Methods
	// [XID] // 0x0000000189772DA0-0x0000000189772DC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820A0C50-0x00000001820A0D40
	// [XID] // 0x000000018977A4E0-0x000000018977A500
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001820A0930-0x00000001820A0A10
	// [XID] // 0x00000001897820A0-0x00000001897820C0
	public override ConfigCoopBaseNode Clone(bool useObjectPool = false /* Metadata: 0x00AF7B0F */) => default; // 0x00000001820A0540-0x00000001820A0620
	// [XID] // 0x0000000189789480-0x00000001897894A0
	public override int GetHashNum() => default; // 0x000000018209F320-0x000000018209F3F0
	// [XID] // 0x0000000189790B70-0x0000000189790B90
	public override void InitEmpty() {} // 0x000000018209FFA0-0x00000001820A0070
	[BlackList] // 0x0000000189798500-0x0000000189798540
	// [XID] // 0x0000000189798500-0x0000000189798540
	public override bool FromJson(JSONNode node) => default; // 0x000000018209F990-0x000000018209FD10
	// [XID] // 0x00000001897A3140-0x00000001897A3160
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018209EBB0-0x000000018209EDE0
	[BlackList] // 0x00000001897AA740-0x00000001897AA780
	// [XID] // 0x00000001897AA740-0x00000001897AA780
	public static new ConfigCoopActionNode ParseFromJson(JSONNode node) => default; // 0x00000001820A0680-0x00000001820A08D0
	// [XID] // 0x00000001897B5930-0x00000001897B5950
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B10 */, bool useObjectPool = false /* Metadata: 0x00AF7B14 */) => default; // 0x00000001820A0240-0x00000001820A0540
	// [XID] // 0x00000001897BD660-0x00000001897BD680
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B15 */, bool useObjectPool = false /* Metadata: 0x00AF7B19 */) => default; // 0x000000018209F4D0-0x000000018209F740
	// [XID] // 0x00000001897C4A40-0x00000001897C4A60
	public static new ConfigCoopActionNode ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B1A */, bool useObjectPool = false /* Metadata: 0x00AF7B1E */) => default; // 0x000000018209FD10-0x000000018209FF30
	[BlackList] // 0x00000001897CC2B0-0x00000001897CC2F0
	// [XID] // 0x00000001897CC2B0-0x00000001897CC2F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018209EDE0-0x000000018209F0B0
	// [XID] // 0x00000001897D6BA0-0x00000001897D6BC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820A0A10-0x00000001820A0C50
	[BlackList] // 0x00000001897DE290-0x00000001897DE2D0
	// [XID] // 0x00000001897DE290-0x00000001897DE2D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001820A0150-0x00000001820A0240
	[BlackList] // 0x00000001897E8C70-0x00000001897E8CB0
	// [XID] // 0x00000001897E8C70-0x00000001897E8CB0
	public override void AutoAllocTypeFields() {} // 0x000000018209F0B0-0x000000018209F150
	[BlackList] // 0x00000001897F38F0-0x00000001897F3930
	// [XID] // 0x00000001897F38F0-0x00000001897F3930
	public override void AutoRecycleTypeFields() {} // 0x000000018209F150-0x000000018209F200
	[BlackList] // 0x00000001897FDCA0-0x00000001897FDCE0
	// [XID] // 0x00000001897FDCA0-0x00000001897FDCE0
	public override void ReturnToObjectPool() {} // 0x00000001820A0D40-0x00000001820A0DE0
}

