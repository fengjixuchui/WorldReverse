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
public class ConfigNPCMove : ConfigAnimatorMove, IAutoAllocRecycle // TypeDefIndex: 18588
{
	// Fields
	private SimpleSafeFloat velocityRatioRawNum; // 0x48

	// Properties
	public float velocityRatio { /* [XID] */ /* 0x0000000189A849A0-0x0000000189A849C0 */ get => default; /* [XID] */ /* 0x0000000189A8C270-0x0000000189A8C290 */ private set {} } // 0x0000000183C090F0-0x0000000183C091D0 0x0000000183C07DB0-0x0000000183C07E90

	// Constructors
	public ConfigNPCMove() {} // 0x0000000183C09370-0x0000000183C09410

	// Methods
	// [XID] // 0x0000000189A93730-0x0000000189A93750
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C091D0-0x0000000183C092D0
	// [XID] // 0x0000000189A9B340-0x0000000189A9B360
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183C08E40-0x0000000183C08EF0
	// [XID] // 0x0000000189AA2600-0x0000000189AA2620
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA4FF */) => default; // 0x0000000183C08A50-0x0000000183C08B30
	// [XID] // 0x0000000189AA9B80-0x0000000189AA9BA0
	public override int GetHashNum() => default; // 0x0000000183C078D0-0x0000000183C079A0
	// [XID] // 0x0000000189AB1AE0-0x0000000189AB1B00
	public override void InitEmpty() {} // 0x0000000183C084A0-0x0000000183C08580
	[BlackList] // 0x0000000189AB8DB0-0x0000000189AB8DF0
	// [XID] // 0x0000000189AB8DB0-0x0000000189AB8DF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183C07E90-0x0000000183C08210
	// [XID] // 0x0000000189AC3EA0-0x0000000189AC3EC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183C07110-0x0000000183C07360
	[BlackList] // 0x0000000189ACB2D0-0x0000000189ACB310
	// [XID] // 0x0000000189ACB2D0-0x0000000189ACB310
	public static new ConfigNPCMove ParseFromJson(JSONNode node) => default; // 0x0000000183C08B90-0x0000000183C08DE0
	// [XID] // 0x0000000189AD61C0-0x0000000189AD61E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA500 */, bool useObjectPool = false /* Metadata: 0x00AFA504 */) => default; // 0x0000000183C08750-0x0000000183C08A50
	// [XID] // 0x0000000189ADDB40-0x0000000189ADDB60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA505 */, bool useObjectPool = false /* Metadata: 0x00AFA509 */) => default; // 0x0000000183C07A80-0x0000000183C07CB0
	// [XID] // 0x0000000189AE5480-0x0000000189AE54A0
	public static new ConfigNPCMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA50A */, bool useObjectPool = false /* Metadata: 0x00AFA50E */) => default; // 0x0000000183C08210-0x0000000183C08430
	[BlackList] // 0x0000000189AEC980-0x0000000189AEC9C0
	// [XID] // 0x0000000189AEC980-0x0000000189AEC9C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C07360-0x0000000183C07630
	// [XID] // 0x0000000189AF7380-0x0000000189AF73A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C08EF0-0x0000000183C090F0
	[BlackList] // 0x0000000189AFEA90-0x0000000189AFEAD0
	// [XID] // 0x0000000189AFEA90-0x0000000189AFEAD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183C08660-0x0000000183C08750
	[BlackList] // 0x0000000189B08FF0-0x0000000189B09030
	// [XID] // 0x0000000189B08FF0-0x0000000189B09030
	public override void AutoAllocTypeFields() {} // 0x0000000183C07630-0x0000000183C076D0
	[BlackList] // 0x0000000189B13630-0x0000000189B13670
	// [XID] // 0x0000000189B13630-0x0000000189B13670
	public override void AutoRecycleTypeFields() {} // 0x0000000183C076D0-0x0000000183C077B0
	[BlackList] // 0x0000000189B1DA10-0x0000000189B1DA50
	// [XID] // 0x0000000189B1DA10-0x0000000189B1DA50
	public override void ReturnToObjectPool() {} // 0x0000000183C092D0-0x0000000183C09370
}

