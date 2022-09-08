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
public class AudioStateOp : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16309
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _group; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _value; // 0x18

	// Properties
	public ConfigWwiseString group { /* [XID] */ /* 0x00000001899616E0-0x0000000189961700 */ get => default; /* [XID] */ /* 0x0000000189826610-0x0000000189826630 */ private set {} } // 0x00000001837404D0-0x0000000183740570 0x00000001837408F0-0x00000001837409A0
	public ConfigWwiseString value { /* [XID] */ /* 0x000000018982DCA0-0x000000018982DCC0 */ get => default; /* [XID] */ /* 0x0000000189835330-0x0000000189835350 */ private set {} } // 0x0000000183740430-0x00000001837404D0 0x0000000183740380-0x0000000183740430

	// Constructors
	public AudioStateOp() {} // 0x00000001837412F0-0x0000000183741350

	// Methods
	// [XID] // 0x000000018983CA50-0x000000018983CA70
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183741010-0x0000000183741110
	// [XID] // 0x00000001898441E0-0x0000000189844200
	public void InitEmpty() {} // 0x00000001837409A0-0x0000000183740A90
	[BlackList] // 0x000000018984B5F0-0x000000018984B630
	// [XID] // 0x000000018984B5F0-0x000000018984B630
	public bool FromJson(JSONNode node) => default; // 0x0000000183740570-0x00000001837408F0
	// [XID] // 0x00000001896BF890-0x00000001896BF8B0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018373F850-0x000000018373FB50
	// [XID] // 0x000000018999F3C0-0x000000018999F3E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3738 */, bool useObjectPool = false /* Metadata: 0x00AF373C */) => default; // 0x0000000183740A90-0x0000000183740D90
	// [XID] // 0x00000001899AE5A0-0x00000001899AE5C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF373D */, bool useObjectPool = false /* Metadata: 0x00AF3741 */) => default; // 0x0000000183740060-0x0000000183740380
	[BlackList] // 0x000000018986BAE0-0x000000018986BB20
	// [XID] // 0x000000018986BAE0-0x000000018986BB20
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018373FB50-0x000000018373FE20
	// [XID] // 0x0000000189875F00-0x0000000189875F20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183740D90-0x0000000183741010
	[BlackList] // 0x000000018987DAA0-0x000000018987DAE0
	// [XID] // 0x000000018987DAA0-0x000000018987DAE0
	public virtual void AutoAllocTypeFields() {} // 0x000000018373FE20-0x000000018373FEC0
	[BlackList] // 0x0000000189887B20-0x0000000189887B60
	// [XID] // 0x0000000189887B20-0x0000000189887B60
	public virtual void AutoRecycleTypeFields() {} // 0x000000018373FEC0-0x0000000183740060
	[BlackList] // 0x0000000189891D80-0x0000000189891DC0
	// [XID] // 0x0000000189891D80-0x0000000189891DC0
	public virtual void ReturnToObjectPool() {} // 0x0000000183741250-0x00000001837412F0
	[BlackList] // 0x000000018989C3E0-0x000000018989C420
	// [XID] // 0x000000018989C3E0-0x000000018989C420
	public virtual void OnPoolAllocated() {} // 0x00000001837411B0-0x0000000183741250
	[BlackList] // 0x00000001898A6B20-0x00000001898A6B60
	// [XID] // 0x00000001898A6B20-0x00000001898A6B60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183741110-0x00000001837411B0
}

