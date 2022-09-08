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
public class ConfigClimateInfoBase : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17651
{
	// Constructors
	public ConfigClimateInfoBase() {} // 0x000000018414B0E0-0x000000018414B140

	// Methods
	// [XID] // 0x000000018963D2B0-0x000000018963D2D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018414AE50-0x000000018414AF00
	// [XID] // 0x00000001896447F0-0x0000000189644810
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018414ACF0-0x000000018414ADA0
	// [XID] // 0x000000018964C0B0-0x000000018964C0D0
	public virtual ConfigClimateInfoBase Clone(bool useObjectPool = false /* Metadata: 0x00AF7625 */) => default; // 0x000000018414AA10-0x000000018414AAF0
	// [XID] // 0x0000000189653720-0x0000000189653740
	public virtual int GetHashNum() => default; // 0x0000000184149E80-0x0000000184149F50
	// [XID] // 0x000000018965B030-0x000000018965B050
	public virtual void InitEmpty() {} // 0x000000018414A580-0x000000018414A620
	[BlackList] // 0x0000000189662480-0x00000001896624C0
	// [XID] // 0x0000000189662480-0x00000001896624C0
	public virtual bool FromJson(JSONNode node) => default; // 0x000000018414A030-0x000000018414A3B0
	// [XID] // 0x000000018966CC40-0x000000018966CC60
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001841499C0-0x0000000184149A70
	[BlackList] // 0x0000000189674B30-0x0000000189674B70
	// [XID] // 0x0000000189674B30-0x0000000189674B70
	public static ConfigClimateInfoBase ParseFromJson(JSONNode node) => default; // 0x000000018414AAF0-0x000000018414ACF0
	// [XID] // 0x000000018967F140-0x000000018967F160
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7626 */, bool useObjectPool = false /* Metadata: 0x00AF762A */) => default; // 0x000000018414A710-0x000000018414AA10
	// [XID] // 0x0000000189686A50-0x0000000189686A70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF762B */, bool useObjectPool = false /* Metadata: 0x00AF762F */) => default; // 0x0000000184149F50-0x000000018414A030
	// [XID] // 0x000000018968E870-0x000000018968E890
	public static ConfigClimateInfoBase ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7630 */, bool useObjectPool = false /* Metadata: 0x00AF7634 */) => default; // 0x000000018414A3B0-0x000000018414A580
	[BlackList] // 0x00000001896962F0-0x0000000189696330
	// [XID] // 0x00000001896962F0-0x0000000189696330
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000184149A70-0x0000000184149D40
	// [XID] // 0x00000001896A04F0-0x00000001896A0510
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018414ADA0-0x000000018414AE50
	[BlackList] // 0x00000001896A7A40-0x00000001896A7A80
	// [XID] // 0x00000001896A7A40-0x00000001896A7A80
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018414A620-0x000000018414A710
	[BlackList] // 0x00000001896B1890-0x00000001896B18D0
	// [XID] // 0x00000001896B1890-0x00000001896B18D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184149D40-0x0000000184149DE0
	[BlackList] // 0x00000001896BC080-0x00000001896BC0C0
	// [XID] // 0x00000001896BC080-0x00000001896BC0C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184149DE0-0x0000000184149E80
	[BlackList] // 0x00000001896C6670-0x00000001896C66B0
	// [XID] // 0x00000001896C6670-0x00000001896C66B0
	public virtual void ReturnToObjectPool() {} // 0x000000018414B040-0x000000018414B0E0
	[BlackList] // 0x00000001896D0B80-0x00000001896D0BC0
	// [XID] // 0x00000001896D0B80-0x00000001896D0BC0
	public virtual void OnPoolAllocated() {} // 0x000000018414AFA0-0x000000018414B040
	[BlackList] // 0x00000001896DB100-0x00000001896DB140
	// [XID] // 0x00000001896DB100-0x00000001896DB140
	public virtual void OnBeforePoolRecycled() {} // 0x000000018414AF00-0x000000018414AFA0
}

