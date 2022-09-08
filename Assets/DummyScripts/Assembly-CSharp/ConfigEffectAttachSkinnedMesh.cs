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
public class ConfigEffectAttachSkinnedMesh : ConfigEffectAttachShape, IAutoAllocRecycle // TypeDefIndex: 17704
{
	// Fields
	private string _mesh; // 0x10

	// Properties
	public string mesh { /* [XID] */ /* 0x0000000189A26340-0x0000000189A26360 */ get => default; /* [XID] */ /* 0x0000000189A2D5F0-0x0000000189A2D610 */ private set {} } // 0x0000000183B23B40-0x0000000183B23BE0 0x0000000183B24CE0-0x0000000183B24D90

	// Constructors
	public ConfigEffectAttachSkinnedMesh() {} // 0x0000000183B25120-0x0000000183B25180

	// Methods
	// [XID] // 0x0000000189A350B0-0x0000000189A350D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B24F90-0x0000000183B25080
	// [XID] // 0x0000000189A3C5B0-0x0000000189A3C5D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183B24C00-0x0000000183B24CE0
	// [XID] // 0x0000000189A440B0-0x0000000189A440D0
	public override ConfigEffectAttachShape Clone(bool useObjectPool = false /* Metadata: 0x00AF785B */) => default; // 0x0000000183B24810-0x0000000183B248F0
	// [XID] // 0x0000000189A4B620-0x0000000189A4B640
	public override int GetHashNum() => default; // 0x0000000183B236A0-0x0000000183B23770
	// [XID] // 0x0000000189A52D00-0x0000000189A52D20
	public override void InitEmpty() {} // 0x0000000183B24270-0x0000000183B24340
	[BlackList] // 0x0000000189A5A5D0-0x0000000189A5A610
	// [XID] // 0x0000000189A5A5D0-0x0000000189A5A610
	public override bool FromJson(JSONNode node) => default; // 0x0000000183B23C60-0x0000000183B23FE0
	// [XID] // 0x0000000189A650C0-0x0000000189A650E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183B22F30-0x0000000183B23160
	[BlackList] // 0x0000000189A6C820-0x0000000189A6C860
	// [XID] // 0x0000000189A6C820-0x0000000189A6C860
	public static new ConfigEffectAttachSkinnedMesh ParseFromJson(JSONNode node) => default; // 0x0000000183B24950-0x0000000183B24BA0
	// [XID] // 0x0000000189A76FF0-0x0000000189A77010
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF785C */, bool useObjectPool = false /* Metadata: 0x00AF7860 */) => default; // 0x0000000183B24510-0x0000000183B24810
	// [XID] // 0x0000000189A7EA40-0x0000000189A7EA60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7861 */, bool useObjectPool = false /* Metadata: 0x00AF7865 */) => default; // 0x0000000183B23850-0x0000000183B23AC0
	// [XID] // 0x0000000189A862B0-0x0000000189A862D0
	public static new ConfigEffectAttachSkinnedMesh ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7866 */, bool useObjectPool = false /* Metadata: 0x00AF786A */) => default; // 0x0000000183B23FE0-0x0000000183B24200
	[BlackList] // 0x0000000189A8DC10-0x0000000189A8DC50
	// [XID] // 0x0000000189A8DC10-0x0000000189A8DC50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B23160-0x0000000183B23430
	// [XID] // 0x0000000189A984C0-0x0000000189A984E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B24D90-0x0000000183B24F90
	[BlackList] // 0x0000000189A9F8D0-0x0000000189A9F910
	// [XID] // 0x0000000189A9F8D0-0x0000000189A9F910
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183B24420-0x0000000183B24510
	[BlackList] // 0x0000000189AA9D40-0x0000000189AA9D80
	// [XID] // 0x0000000189AA9D40-0x0000000189AA9D80
	public override void AutoAllocTypeFields() {} // 0x0000000183B23430-0x0000000183B234D0
	[BlackList] // 0x0000000189AB48B0-0x0000000189AB48F0
	// [XID] // 0x0000000189AB48B0-0x0000000189AB48F0
	public override void AutoRecycleTypeFields() {} // 0x0000000183B234D0-0x0000000183B23580
	[BlackList] // 0x0000000189ABF290-0x0000000189ABF2D0
	// [XID] // 0x0000000189ABF290-0x0000000189ABF2D0
	public override void ReturnToObjectPool() {} // 0x0000000183B25080-0x0000000183B25120
}

