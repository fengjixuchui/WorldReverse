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
public class ConfigAttackEvent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17681
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBaseAttackPattern _attackPattern; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAttackInfo _attackInfo; // 0x18

	// Properties
	public ConfigBaseAttackPattern attackPattern { /* [XID] */ /* 0x000000018985F7B0-0x000000018985F7D0 */ get => default; /* [XID] */ /* 0x0000000189867010-0x0000000189867030 */ private set {} } // 0x0000000182B34370-0x0000000182B34410 0x0000000182B33AB0-0x0000000182B33B60
	public ConfigAttackInfo attackInfo { /* [XID] */ /* 0x000000018986E7F0-0x000000018986E810 */ get => default; /* [XID] */ /* 0x0000000189875CA0-0x0000000189875CC0 */ private set {} } // 0x0000000182B342D0-0x0000000182B34370 0x0000000182B32F40-0x0000000182B32FF0

	// Constructors
	public ConfigAttackEvent() {} // 0x0000000182B34980-0x0000000182B349E0

	// Methods
	// [XID] // 0x0000000189A4A930-0x0000000189A4A950
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B346A0-0x0000000182B347A0
	// [XID] // 0x0000000189884750-0x0000000189884770
	public void InitEmpty() {} // 0x0000000182B33EE0-0x0000000182B33FD0
	[BlackList] // 0x000000018988BD80-0x000000018988BDC0
	// [XID] // 0x000000018988BD80-0x000000018988BDC0
	public bool FromJson(JSONNode node) => default; // 0x0000000182B33B60-0x0000000182B33EE0
	// [XID] // 0x00000001898960A0-0x00000001898960C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182B32FF0-0x0000000182B332C0
	// [XID] // 0x000000018989D680-0x000000018989D6A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7777 */, bool useObjectPool = false /* Metadata: 0x00AF777B */) => default; // 0x0000000182B33FD0-0x0000000182B342D0
	// [XID] // 0x00000001898A5080-0x00000001898A50A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF777C */, bool useObjectPool = false /* Metadata: 0x00AF7780 */) => default; // 0x0000000182B337D0-0x0000000182B33AB0
	[BlackList] // 0x00000001898AC4C0-0x00000001898AC500
	// [XID] // 0x00000001898AC4C0-0x00000001898AC500
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B332C0-0x0000000182B33590
	// [XID] // 0x00000001898B6D10-0x00000001898B6D30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B34410-0x0000000182B346A0
	[BlackList] // 0x00000001898BE420-0x00000001898BE460
	// [XID] // 0x00000001898BE420-0x00000001898BE460
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B33590-0x0000000182B33630
	[BlackList] // 0x00000001898C8EC0-0x00000001898C8F00
	// [XID] // 0x00000001898C8EC0-0x00000001898C8F00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B33630-0x0000000182B337D0
	[BlackList] // 0x00000001898D3510-0x00000001898D3550
	// [XID] // 0x00000001898D3510-0x00000001898D3550
	public virtual void ReturnToObjectPool() {} // 0x0000000182B348E0-0x0000000182B34980
	[BlackList] // 0x00000001898DE320-0x00000001898DE360
	// [XID] // 0x00000001898DE320-0x00000001898DE360
	public virtual void OnPoolAllocated() {} // 0x0000000182B34840-0x0000000182B348E0
	[BlackList] // 0x00000001898E8CC0-0x00000001898E8D00
	// [XID] // 0x00000001898E8CC0-0x00000001898E8D00
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B347A0-0x0000000182B34840
}

