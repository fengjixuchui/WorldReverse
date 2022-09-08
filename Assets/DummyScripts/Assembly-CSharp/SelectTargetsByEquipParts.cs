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
public class SelectTargetsByEquipParts : SelectTargets, IAutoAllocRecycle // TypeDefIndex: 16834
{
	// Fields
	private string[] _equipPartNames; // 0x28

	// Properties
	public string[] equipPartNames { /* [XID] */ /* 0x0000000189A52FC0-0x0000000189A52FE0 */ get => default; /* [XID] */ /* 0x0000000189A5A7B0-0x0000000189A5A7D0 */ private set {} } // 0x000000018514CF20-0x000000018514CFC0 0x000000018514D100-0x000000018514D1B0

	// Constructors
	public SelectTargetsByEquipParts() {} // 0x000000018514D580-0x000000018514D5E0

	// Methods
	// [XID] // 0x0000000189A61F30-0x0000000189A61F50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018514D3F0-0x000000018514D4E0
	// [XID] // 0x0000000189A69D70-0x0000000189A69D90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018514D020-0x000000018514D100
	// [XID] // 0x0000000189A71040-0x0000000189A71060
	public override SelectTargets Clone(bool useObjectPool = false /* Metadata: 0x00AF4800 */) => default; // 0x000000018514CB90-0x000000018514CC70
	// [XID] // 0x0000000189A78C20-0x0000000189A78C40
	public override int GetHashNum() => default; // 0x000000018514BAC0-0x000000018514BB90
	// [XID] // 0x0000000189A80160-0x0000000189A80180
	public override void InitEmpty() {} // 0x000000018514C5F0-0x000000018514C6C0
	[BlackList] // 0x0000000189A87E60-0x0000000189A87EA0
	// [XID] // 0x0000000189A87E60-0x0000000189A87EA0
	public override bool FromJson(JSONNode node) => default; // 0x000000018514BFE0-0x000000018514C360
	// [XID] // 0x0000000189A92510-0x0000000189A92530
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018514B350-0x000000018514B580
	[BlackList] // 0x0000000189A99F80-0x0000000189A99FC0
	// [XID] // 0x0000000189A99F80-0x0000000189A99FC0
	public static new SelectTargetsByEquipParts ParseFromJson(JSONNode node) => default; // 0x000000018514CCD0-0x000000018514CF20
	// [XID] // 0x0000000189AA4400-0x0000000189AA4420
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4801 */, bool useObjectPool = false /* Metadata: 0x00AF4805 */) => default; // 0x000000018514C890-0x000000018514CB90
	// [XID] // 0x0000000189AAB8F0-0x0000000189AAB910
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4806 */, bool useObjectPool = false /* Metadata: 0x00AF480A */) => default; // 0x000000018514BC70-0x000000018514BEE0
	// [XID] // 0x0000000189AB3200-0x0000000189AB3220
	public static new SelectTargetsByEquipParts ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF480B */, bool useObjectPool = false /* Metadata: 0x00AF480F */) => default; // 0x000000018514C360-0x000000018514C580
	[BlackList] // 0x0000000189ABAF50-0x0000000189ABAF90
	// [XID] // 0x0000000189ABAF50-0x0000000189ABAF90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018514B580-0x000000018514B850
	// [XID] // 0x0000000189AC58B0-0x0000000189AC58D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018514D1B0-0x000000018514D3F0
	[BlackList] // 0x0000000189ACCDE0-0x0000000189ACCE20
	// [XID] // 0x0000000189ACCDE0-0x0000000189ACCE20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018514C7A0-0x000000018514C890
	[BlackList] // 0x0000000189AD7B80-0x0000000189AD7BC0
	// [XID] // 0x0000000189AD7B80-0x0000000189AD7BC0
	public override void AutoAllocTypeFields() {} // 0x000000018514B850-0x000000018514B8F0
	[BlackList] // 0x0000000189AE2280-0x0000000189AE22C0
	// [XID] // 0x0000000189AE2280-0x0000000189AE22C0
	public override void AutoRecycleTypeFields() {} // 0x000000018514B8F0-0x000000018514B9A0
	[BlackList] // 0x0000000189AECC00-0x0000000189AECC40
	// [XID] // 0x0000000189AECC00-0x0000000189AECC40
	public override void ReturnToObjectPool() {} // 0x000000018514D4E0-0x000000018514D580
}

