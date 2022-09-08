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
public class GlobalValuePair : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16398
{
	// Fields
	private string _key; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x18
	private bool _useLimitRange; // 0x20
	private bool _randomInRange; // 0x21
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _maxValue; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _minValue; // 0x30

	// Properties
	public string key { /* [XID] */ /* 0x00000001899FFDC0-0x00000001899FFDE0 */ get => default; /* [XID] */ /* 0x0000000189A07650-0x0000000189A07670 */ private set {} } // 0x0000000182153920-0x00000001821539C0 0x0000000182154B30-0x0000000182154BE0
	public DynamicFloat value { /* [XID] */ /* 0x0000000189A0EAD0-0x0000000189A0EAF0 */ get => default; /* [XID] */ /* 0x0000000189A16280-0x0000000189A162A0 */ private set {} } // 0x0000000182154000-0x00000001821540A0 0x0000000182153F50-0x0000000182154000
	public bool useLimitRange { /* [XID] */ /* 0x0000000189A1D7E0-0x0000000189A1D800 */ get => default; /* [XID] */ /* 0x0000000189A24B90-0x0000000189A24BB0 */ private set {} } // 0x00000001821539C0-0x0000000182153A60 0x0000000182155090-0x0000000182155140
	public bool randomInRange { /* [XID] */ /* 0x0000000189A2C250-0x0000000189A2C270 */ get => default; /* [XID] */ /* 0x0000000189A33940-0x0000000189A33960 */ private set {} } // 0x00000001821544D0-0x0000000182154570 0x00000001821549E0-0x0000000182154A90
	public DynamicFloat maxValue { /* [XID] */ /* 0x0000000189A3B0E0-0x0000000189A3B100 */ get => default; /* [XID] */ /* 0x0000000189A42A30-0x0000000189A42A50 */ private set {} } // 0x0000000182154570-0x0000000182154610 0x0000000182153870-0x0000000182153920
	public DynamicFloat minValue { /* [XID] */ /* 0x0000000189A49F60-0x0000000189A49F80 */ get => default; /* [XID] */ /* 0x0000000189A518F0-0x0000000189A51910 */ private set {} } // 0x0000000182154A90-0x0000000182154B30 0x00000001821540A0-0x0000000182154150

	// Constructors
	public GlobalValuePair() {} // 0x00000001821554D0-0x0000000182155590

	// Methods
	// [XID] // 0x0000000189A591A0-0x0000000189A591C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182155140-0x00000001821552F0
	// [XID] // 0x0000000189A60A40-0x0000000189A60A60
	public void InitEmpty() {} // 0x0000000182154610-0x00000001821546E0
	[BlackList] // 0x0000000189A68850-0x0000000189A68890
	// [XID] // 0x0000000189A68850-0x0000000189A68890
	public bool FromJson(JSONNode node) => default; // 0x0000000182154150-0x00000001821544D0
	// [XID] // 0x0000000189A72C80-0x0000000189A72CA0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182152D60-0x00000001821532F0
	// [XID] // 0x0000000189A7A7D0-0x0000000189A7A7F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A40 */, bool useObjectPool = false /* Metadata: 0x00AF3A44 */) => default; // 0x00000001821546E0-0x00000001821549E0
	// [XID] // 0x0000000189A81CF0-0x0000000189A81D10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A45 */, bool useObjectPool = false /* Metadata: 0x00AF3A49 */) => default; // 0x0000000182153A60-0x0000000182153F50
	[BlackList] // 0x0000000189A897D0-0x0000000189A89810
	// [XID] // 0x0000000189A897D0-0x0000000189A89810
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001821532F0-0x00000001821535C0
	// [XID] // 0x0000000189A93B10-0x0000000189A93B30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182154BE0-0x0000000182155090
	[BlackList] // 0x0000000189A9B600-0x0000000189A9B640
	// [XID] // 0x0000000189A9B600-0x0000000189A9B640
	public virtual void AutoAllocTypeFields() {} // 0x00000001821535C0-0x0000000182153660
	[BlackList] // 0x0000000189AA5B40-0x0000000189AA5B80
	// [XID] // 0x0000000189AA5B40-0x0000000189AA5B80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182153660-0x0000000182153870
	[BlackList] // 0x0000000189AB03A0-0x0000000189AB03E0
	// [XID] // 0x0000000189AB03A0-0x0000000189AB03E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182155430-0x00000001821554D0
	[BlackList] // 0x0000000189ABB0B0-0x0000000189ABB0F0
	// [XID] // 0x0000000189ABB0B0-0x0000000189ABB0F0
	public virtual void OnPoolAllocated() {} // 0x0000000182155390-0x0000000182155430
	[BlackList] // 0x0000000189AC5970-0x0000000189AC59B0
	// [XID] // 0x0000000189AC5970-0x0000000189AC59B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001821552F0-0x0000000182155390
}

