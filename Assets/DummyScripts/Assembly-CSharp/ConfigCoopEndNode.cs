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
public class ConfigCoopEndNode : ConfigCoopBaseNode, IAutoAllocRecycle // TypeDefIndex: 17758
{
	// Fields
	private uint _savePointId; // 0x20

	// Properties
	public uint savePointId { /* [XID] */ /* 0x000000018980FE10-0x000000018980FE30 */ get => default; /* [XID] */ /* 0x0000000189817420-0x0000000189817440 */ private set {} } // 0x0000000183084160-0x0000000183084200 0x0000000183082D90-0x0000000183082E40

	// Constructors
	public ConfigCoopEndNode() {} // 0x00000001830846A0-0x0000000183084700

	// Methods
	// [XID] // 0x000000018981EDA0-0x000000018981EDC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183084510-0x0000000183084600
	// [XID] // 0x0000000189826310-0x0000000189826330
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183084260-0x0000000183084310
	// [XID] // 0x000000018982D8C0-0x000000018982D8E0
	public override ConfigCoopBaseNode Clone(bool useObjectPool = false /* Metadata: 0x00AF7B1F */) => default; // 0x0000000183083DD0-0x0000000183083EB0
	// [XID] // 0x0000000189835090-0x00000001898350B0
	public override int GetHashNum() => default; // 0x0000000183082CC0-0x0000000183082D90
	// [XID] // 0x000000018983C750-0x000000018983C770
	public override void InitEmpty() {} // 0x0000000183083860-0x0000000183083900
	[BlackList] // 0x0000000189843F20-0x0000000189843F60
	// [XID] // 0x0000000189843F20-0x0000000189843F60
	public override bool FromJson(JSONNode node) => default; // 0x0000000183083250-0x00000001830835D0
	// [XID] // 0x000000018984E300-0x000000018984E320
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183082580-0x0000000183082780
	[BlackList] // 0x0000000189855490-0x00000001898554D0
	// [XID] // 0x0000000189855490-0x00000001898554D0
	public static new ConfigCoopEndNode ParseFromJson(JSONNode node) => default; // 0x0000000183083F10-0x0000000183084160
	// [XID] // 0x000000018985F790-0x000000018985F7B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B20 */, bool useObjectPool = false /* Metadata: 0x00AF7B24 */) => default; // 0x0000000183083AD0-0x0000000183083DD0
	// [XID] // 0x0000000189866FF0-0x0000000189867010
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B25 */, bool useObjectPool = false /* Metadata: 0x00AF7B29 */) => default; // 0x0000000183082F20-0x0000000183083150
	// [XID] // 0x000000018986E7D0-0x000000018986E7F0
	public static new ConfigCoopEndNode ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B2A */, bool useObjectPool = false /* Metadata: 0x00AF7B2E */) => default; // 0x00000001830835D0-0x00000001830837F0
	[BlackList] // 0x0000000189875C60-0x0000000189875CA0
	// [XID] // 0x0000000189875C60-0x0000000189875CA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183082780-0x0000000183082A50
	// [XID] // 0x00000001898803A0-0x00000001898803C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183084310-0x0000000183084510
	[BlackList] // 0x0000000189887820-0x0000000189887860
	// [XID] // 0x0000000189887820-0x0000000189887860
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001830839E0-0x0000000183083AD0
	[BlackList] // 0x0000000189891A40-0x0000000189891A80
	// [XID] // 0x0000000189891A40-0x0000000189891A80
	public override void AutoAllocTypeFields() {} // 0x0000000183082A50-0x0000000183082AF0
	[BlackList] // 0x000000018989C000-0x000000018989C040
	// [XID] // 0x000000018989C000-0x000000018989C040
	public override void AutoRecycleTypeFields() {} // 0x0000000183082AF0-0x0000000183082BA0
	[BlackList] // 0x00000001898A67C0-0x00000001898A6800
	// [XID] // 0x00000001898A67C0-0x00000001898A6800
	public override void ReturnToObjectPool() {} // 0x0000000183084600-0x00000001830846A0
}

