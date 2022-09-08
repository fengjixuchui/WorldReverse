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
public class ConfigGadgetPredicate : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14962
{
	// Constructors
	public ConfigGadgetPredicate() {} // 0x0000000183688E20-0x0000000183688E80

	// Methods
	// [XID] // 0x00000001897DA5D0-0x00000001897DA5F0
	public virtual bool IsTrue(BaseEntity entity, int param = 0 /* Metadata: 0x00AEFC4D */) => default; // 0x0000000183687BC0-0x0000000183687C90
	// [XID] // 0x00000001897E1A20-0x00000001897E1A40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183688B90-0x0000000183688C40
	// [XID] // 0x00000001897E9230-0x00000001897E9250
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183688A30-0x0000000183688AE0
	// [XID] // 0x00000001897F0DE0-0x00000001897F0E00
	public virtual ConfigGadgetPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AEFC51 */) => default; // 0x0000000183688750-0x0000000183688830
	// [XID] // 0x00000001897F8680-0x00000001897F86A0
	public virtual int GetHashNum() => default; // 0x0000000183687AF0-0x0000000183687BC0
	// [XID] // 0x00000001897FFD90-0x00000001897FFDB0
	public virtual void InitEmpty() {} // 0x00000001836882C0-0x0000000183688360
	[BlackList] // 0x00000001898073F0-0x0000000189807430
	// [XID] // 0x00000001898073F0-0x0000000189807430
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183687D70-0x00000001836880F0
	// [XID] // 0x00000001898119A0-0x00000001898119C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183687630-0x00000001836876E0
	[BlackList] // 0x00000001898195D0-0x0000000189819610
	// [XID] // 0x00000001898195D0-0x0000000189819610
	public static ConfigGadgetPredicate ParseFromJson(JSONNode node) => default; // 0x0000000183688830-0x0000000183688A30
	// [XID] // 0x0000000189823710-0x0000000189823730
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC52 */, bool useObjectPool = false /* Metadata: 0x00AEFC56 */) => default; // 0x0000000183688450-0x0000000183688750
	// [XID] // 0x000000018982B030-0x000000018982B050
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC57 */, bool useObjectPool = false /* Metadata: 0x00AEFC5B */) => default; // 0x0000000183687C90-0x0000000183687D70
	// [XID] // 0x00000001898325D0-0x00000001898325F0
	public static ConfigGadgetPredicate ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC5C */, bool useObjectPool = false /* Metadata: 0x00AEFC60 */) => default; // 0x00000001836880F0-0x00000001836882C0
	[BlackList] // 0x0000000189839C40-0x0000000189839C80
	// [XID] // 0x0000000189839C40-0x0000000189839C80
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001836876E0-0x00000001836879B0
	// [XID] // 0x0000000189844420-0x0000000189844440
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183688AE0-0x0000000183688B90
	[BlackList] // 0x000000018984B870-0x000000018984B8B0
	// [XID] // 0x000000018984B870-0x000000018984B8B0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183688360-0x0000000183688450
	[BlackList] // 0x0000000189855970-0x00000001898559B0
	// [XID] // 0x0000000189855970-0x00000001898559B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001836879B0-0x0000000183687A50
	[BlackList] // 0x000000018985FE50-0x000000018985FE90
	// [XID] // 0x000000018985FE50-0x000000018985FE90
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183687A50-0x0000000183687AF0
	[BlackList] // 0x000000018986A600-0x000000018986A640
	// [XID] // 0x000000018986A600-0x000000018986A640
	public virtual void ReturnToObjectPool() {} // 0x0000000183688D80-0x0000000183688E20
	[BlackList] // 0x0000000189874680-0x00000001898746C0
	// [XID] // 0x0000000189874680-0x00000001898746C0
	public virtual void OnPoolAllocated() {} // 0x0000000183688CE0-0x0000000183688D80
	[BlackList] // 0x000000018987F100-0x000000018987F140
	// [XID] // 0x000000018987F100-0x000000018987F140
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183688C40-0x0000000183688CE0
}

