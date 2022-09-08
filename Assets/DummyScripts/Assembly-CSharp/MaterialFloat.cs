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
public class MaterialFloat : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18871
{
	// Fields
	private string _name; // 0x10
	private SimpleSafeFloat valueRawNum; // 0x18

	// Properties
	public string name { /* [XID] */ /* 0x00000001898338A0-0x00000001898338C0 */ get => default; /* [XID] */ /* 0x000000018983ADC0-0x000000018983ADE0 */ private set {} } // 0x000000018146CDB0-0x000000018146CE50 0x000000018146C470-0x000000018146C520
	public float value { /* [XID] */ /* 0x0000000189842420-0x0000000189842440 */ get => default; /* [XID] */ /* 0x0000000189849890-0x00000001898498B0 */ private set {} } // 0x000000018146C010-0x000000018146C0F0 0x000000018146BF30-0x000000018146C010

	// Constructors
	public MaterialFloat() {} // 0x000000018146CEF0-0x000000018146CF50

	// Methods
	// [XID] // 0x0000000189851070-0x0000000189851090
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018146CB60-0x000000018146CC70
	// [XID] // 0x0000000189858540-0x0000000189858560
	public void InitEmpty() {} // 0x000000018146C520-0x000000018146C620
	[BlackList] // 0x000000018985F530-0x000000018985F570
	// [XID] // 0x000000018985F530-0x000000018985F570
	public bool FromJson(JSONNode node) => default; // 0x000000018146C0F0-0x000000018146C470
	// [XID] // 0x0000000189869DE0-0x0000000189869E00
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018146B500-0x000000018146B820
	// [XID] // 0x00000001898711D0-0x00000001898711F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1CB */, bool useObjectPool = false /* Metadata: 0x00AFB1CF */) => default; // 0x000000018146C620-0x000000018146C920
	// [XID] // 0x0000000189878AF0-0x0000000189878B10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1D0 */, bool useObjectPool = false /* Metadata: 0x00AFB1D4 */) => default; // 0x000000018146BC70-0x000000018146BF30
	[BlackList] // 0x00000001898800E0-0x0000000189880120
	// [XID] // 0x00000001898800E0-0x0000000189880120
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018146B820-0x000000018146BAF0
	// [XID] // 0x000000018988A390-0x000000018988A3B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018146C920-0x000000018146CB60
	[BlackList] // 0x0000000189891820-0x0000000189891860
	// [XID] // 0x0000000189891820-0x0000000189891860
	public virtual void AutoAllocTypeFields() {} // 0x000000018146BAF0-0x000000018146BB90
	[BlackList] // 0x000000018989BE40-0x000000018989BE80
	// [XID] // 0x000000018989BE40-0x000000018989BE80
	public virtual void AutoRecycleTypeFields() {} // 0x000000018146BB90-0x000000018146BC70
	[BlackList] // 0x00000001898A6640-0x00000001898A6680
	// [XID] // 0x00000001898A6640-0x00000001898A6680
	public virtual void ReturnToObjectPool() {} // 0x000000018146CE50-0x000000018146CEF0
	[BlackList] // 0x00000001898B0D40-0x00000001898B0D80
	// [XID] // 0x00000001898B0D40-0x00000001898B0D80
	public virtual void OnPoolAllocated() {} // 0x000000018146CD10-0x000000018146CDB0
	[BlackList] // 0x00000001898BB710-0x00000001898BB750
	// [XID] // 0x00000001898BB710-0x00000001898BB750
	public virtual void OnBeforePoolRecycled() {} // 0x000000018146CC70-0x000000018146CD10
}

