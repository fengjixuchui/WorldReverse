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
public class IndicatorLogic : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18488
{
	// Fields
	private IndicatorOperator _iOperator; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private IndicatorCondition[] _iConditions; // 0x18

	// Properties
	public IndicatorOperator iOperator { /* [XID] */ /* 0x0000000189660D10-0x0000000189660D30 */ get => default; /* [XID] */ /* 0x0000000189668620-0x0000000189668640 */ private set {} } // 0x000000018364F7D0-0x000000018364F870 0x000000018364F720-0x000000018364F7D0
	public IndicatorCondition[] iConditions { /* [XID] */ /* 0x0000000189670090-0x00000001896700B0 */ get => default; /* [XID] */ /* 0x00000001896779F0-0x0000000189677A10 */ private set {} } // 0x00000001836501F0-0x0000000183650290 0x00000001836509E0-0x0000000183650A90

	// Constructors
	public IndicatorLogic() {} // 0x0000000183650FF0-0x0000000183651050

	// Methods
	// [XID] // 0x000000018967EF20-0x000000018967EF40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183650D00-0x0000000183650E10
	// [XID] // 0x0000000189686890-0x00000001896868B0
	public void InitEmpty() {} // 0x0000000183650610-0x00000001836506E0
	[BlackList] // 0x000000018968E690-0x000000018968E6D0
	// [XID] // 0x000000018968E690-0x000000018968E6D0
	public bool FromJson(JSONNode node) => default; // 0x0000000183650290-0x0000000183650610
	// [XID] // 0x0000000189698E40-0x0000000189698E60
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018364F870-0x000000018364FB30
	// [XID] // 0x00000001896A03B0-0x00000001896A03D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F1D */, bool useObjectPool = false /* Metadata: 0x00AF9F21 */) => default; // 0x00000001836506E0-0x00000001836509E0
	// [XID] // 0x00000001896A78A0-0x00000001896A78C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F22 */, bool useObjectPool = false /* Metadata: 0x00AF9F26 */) => default; // 0x000000018364FF50-0x00000001836501F0
	[BlackList] // 0x00000001896AECD0-0x00000001896AED10
	// [XID] // 0x00000001896AECD0-0x00000001896AED10
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018364FB30-0x000000018364FE00
	// [XID] // 0x00000001896B9110-0x00000001896B9130
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183650A90-0x0000000183650D00
	[BlackList] // 0x00000001896C0520-0x00000001896C0560
	// [XID] // 0x00000001896C0520-0x00000001896C0560
	public virtual void AutoAllocTypeFields() {} // 0x000000018364FE00-0x000000018364FEA0
	[BlackList] // 0x00000001896CA930-0x00000001896CA970
	// [XID] // 0x00000001896CA930-0x00000001896CA970
	public virtual void AutoRecycleTypeFields() {} // 0x000000018364FEA0-0x000000018364FF50
	[BlackList] // 0x00000001896D50A0-0x00000001896D50E0
	// [XID] // 0x00000001896D50A0-0x00000001896D50E0
	public virtual void ReturnToObjectPool() {} // 0x0000000183650F50-0x0000000183650FF0
	[BlackList] // 0x00000001896DF8A0-0x00000001896DF8E0
	// [XID] // 0x00000001896DF8A0-0x00000001896DF8E0
	public virtual void OnPoolAllocated() {} // 0x0000000183650EB0-0x0000000183650F50
	[BlackList] // 0x00000001896E9D80-0x00000001896E9DC0
	// [XID] // 0x00000001896E9D80-0x00000001896E9DC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183650E10-0x0000000183650EB0
}

