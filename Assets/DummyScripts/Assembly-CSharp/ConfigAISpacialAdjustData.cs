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
public class ConfigAISpacialAdjustData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17469
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat yLowRawNum; // 0x14
	private SimpleSafeFloat yHighRawNum; // 0x18

	// Properties
	public int speedLevel { /* [XID] */ /* 0x00000001898E8D60-0x00000001898E8D80 */ get => default; /* [XID] */ /* 0x00000001898F04C0-0x00000001898F04E0 */ private set {} } // 0x00000001837815A0-0x0000000183781670 0x0000000183781670-0x0000000183781750
	public float yLow { /* [XID] */ /* 0x00000001898F7EF0-0x00000001898F7F10 */ get => default; /* [XID] */ /* 0x00000001898FF550-0x00000001898FF570 */ private set {} } // 0x00000001837828D0-0x00000001837829B0 0x0000000183782290-0x0000000183782370
	public float yHigh { /* [XID] */ /* 0x0000000189906D30-0x0000000189906D50 */ get => default; /* [XID] */ /* 0x000000018990E770-0x000000018990E790 */ private set {} } // 0x0000000183781DA0-0x0000000183781E80 0x0000000183780C30-0x0000000183780D10

	// Constructors
	public ConfigAISpacialAdjustData() {} // 0x0000000183782A50-0x0000000183782B30

	// Methods
	// [XID] // 0x0000000189915DE0-0x0000000189915E00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183782670-0x0000000183782790
	// [XID] // 0x000000018991D8F0-0x000000018991D910
	public void InitEmpty() {} // 0x0000000183781E80-0x0000000183781F90
	[BlackList] // 0x0000000189925060-0x00000001899250A0
	// [XID] // 0x0000000189925060-0x00000001899250A0
	public bool FromJson(JSONNode node) => default; // 0x0000000183781A20-0x0000000183781DA0
	// [XID] // 0x000000018992F640-0x000000018992F660
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183780D10-0x0000000183781120
	// [XID] // 0x0000000189936A90-0x0000000189936AB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FAF */, bool useObjectPool = false /* Metadata: 0x00AF6FB3 */) => default; // 0x0000000183781F90-0x0000000183782290
	// [XID] // 0x000000018993E610-0x000000018993E630
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FB4 */, bool useObjectPool = false /* Metadata: 0x00AF6FB8 */) => default; // 0x0000000183781750-0x0000000183781A20
	[BlackList] // 0x0000000189945C80-0x0000000189945CC0
	// [XID] // 0x0000000189945C80-0x0000000189945CC0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183781120-0x00000001837813F0
	// [XID] // 0x0000000189950470-0x0000000189950490
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183782370-0x0000000183782670
	[BlackList] // 0x0000000189957A00-0x0000000189957A40
	// [XID] // 0x0000000189957A00-0x0000000189957A40
	public virtual void AutoAllocTypeFields() {} // 0x00000001837813F0-0x0000000183781490
	[BlackList] // 0x0000000189962590-0x00000001899625D0
	// [XID] // 0x0000000189962590-0x00000001899625D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183781490-0x00000001837815A0
	[BlackList] // 0x000000018996C930-0x000000018996C970
	// [XID] // 0x000000018996C930-0x000000018996C970
	public virtual void ReturnToObjectPool() {} // 0x00000001837829B0-0x0000000183782A50
	[BlackList] // 0x00000001899772E0-0x0000000189977320
	// [XID] // 0x00000001899772E0-0x0000000189977320
	public virtual void OnPoolAllocated() {} // 0x0000000183782830-0x00000001837828D0
	[BlackList] // 0x0000000189981C40-0x0000000189981C80
	// [XID] // 0x0000000189981C40-0x0000000189981C80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183782790-0x0000000183782830
}

