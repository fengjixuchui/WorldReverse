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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigShapeSphere : ConfigBaseShape, IAutoAllocRecycle // TypeDefIndex: 18992
{
	// Fields
	private SimpleSafeFloat radiusRawNum; // 0x20

	// Properties
	public float radius { /* [XID] */ /* 0x0000000189A96760-0x0000000189A96780 */ get => default; /* [XID] */ /* 0x0000000189A9DCB0-0x0000000189A9DCD0 */ private set {} } // 0x0000000183282A30-0x0000000183282B10 0x0000000183282E00-0x0000000183282EE0

	// Constructors
	public ConfigShapeSphere() {} // 0x0000000183282F80-0x0000000183282FE0

	// Methods
	// [XID] // 0x0000000189AA5720-0x0000000189AA5740
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183282D00-0x0000000183282E00
	// [XID] // 0x0000000189AACE20-0x0000000189AACE40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183282980-0x0000000183282A30
	// [XID] // 0x0000000189AB4690-0x0000000189AB46B0
	public override ConfigBaseShape Clone(bool useObjectPool = false /* Metadata: 0x00AFB68F */) => default; // 0x0000000183282590-0x0000000183282670
	// [XID] // 0x0000000189ABC500-0x0000000189ABC520
	public override int GetHashNum() => default; // 0x0000000183281210-0x00000001832812E0
	// [XID] // 0x0000000189AC3E20-0x0000000189AC3E40
	public override void InitEmpty() {} // 0x0000000183281FF0-0x00000001832820C0
	[BlackList] // 0x0000000189ACB1C0-0x0000000189ACB200
	// [XID] // 0x0000000189ACB1C0-0x0000000189ACB200
	public override bool FromJson(JSONNode node) => default; // 0x0000000183281730-0x0000000183281AB0
	// [XID] // 0x0000000189AD6100-0x0000000189AD6120
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183280A30-0x0000000183280CA0
	[BlackList] // 0x0000000189ADDA10-0x0000000189ADDA50
	// [XID] // 0x0000000189ADDA10-0x0000000189ADDA50
	public static new ConfigShapeSphere ParseFromJson(JSONNode node) => default; // 0x00000001832826D0-0x0000000183282920
	// [XID] // 0x0000000189AE7FF0-0x0000000189AE8010
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB690 */, bool useObjectPool = false /* Metadata: 0x00AFB694 */) => default; // 0x0000000183282290-0x0000000183282590
	// [XID] // 0x0000000189AEFDC0-0x0000000189AEFDE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB695 */, bool useObjectPool = false /* Metadata: 0x00AFB699 */) => default; // 0x00000001832813C0-0x0000000183281630
	// [XID] // 0x0000000189AF7300-0x0000000189AF7320
	public static new ConfigShapeSphere ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB69A */, bool useObjectPool = false /* Metadata: 0x00AFB69E */) => default; // 0x0000000183281BA0-0x0000000183281DC0
	[BlackList] // 0x0000000189AFE970-0x0000000189AFE9B0
	// [XID] // 0x0000000189AFE970-0x0000000189AFE9B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183280CA0-0x0000000183280F70
	// [XID] // 0x0000000189B08F10-0x0000000189B08F30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183282B10-0x0000000183282D00
	[BlackList] // 0x0000000189B10990-0x0000000189B109D0
	// [XID] // 0x0000000189B10990-0x0000000189B109D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001832821A0-0x0000000183282290
	[BlackList] // 0x0000000189B1ACE0-0x0000000189B1AD20
	// [XID] // 0x0000000189B1ACE0-0x0000000189B1AD20
	public override void AutoAllocTypeFields() {} // 0x0000000183280F70-0x0000000183281010
	[BlackList] // 0x0000000189B25260-0x0000000189B252A0
	// [XID] // 0x0000000189B25260-0x0000000189B252A0
	public override void AutoRecycleTypeFields() {} // 0x0000000183281010-0x00000001832810F0
	[BlackList] // 0x0000000189B2F390-0x0000000189B2F3D0
	// [XID] // 0x0000000189B2F390-0x0000000189B2F3D0
	public override void ReturnToObjectPool() {} // 0x0000000183282EE0-0x0000000183282F80
	// [XID] // 0x0000000189B39E10-0x0000000189B39E30
	public override BaseShape CreateShape(Vector3 position, Vector3 direction, bool useHeight, float height, float sizeRatio) => default; // 0x0000000183281DC0-0x0000000183281F80
}

