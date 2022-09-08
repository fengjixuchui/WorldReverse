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
public class DynamicString : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14795
{
	// Fields
	private bool _isDynamic; // 0x10
	private string _dynamicKey; // 0x18
	private string _fixedValue; // 0x20

	// Properties
	public bool isDynamic { /* [XID] */ /* 0x00000001898ACC00-0x00000001898ACC20 */ get => default; /* [XID] */ /* 0x00000001898B4060-0x00000001898B4080 */ private set {} } // 0x000000018656BCB0-0x000000018656BD50 0x000000018656BC00-0x000000018656BCB0
	public string dynamicKey { /* [XID] */ /* 0x00000001898BBD30-0x00000001898BBD50 */ get => default; /* [XID] */ /* 0x00000001898C3280-0x00000001898C32A0 */ private set {} } // 0x000000018656C100-0x000000018656C1A0 0x000000018656C050-0x000000018656C100
	public string fixedValue { /* [XID] */ /* 0x00000001898CAC60-0x00000001898CAC80 */ get => default; /* [XID] */ /* 0x00000001898D2330-0x00000001898D2350 */ private set {} } // 0x000000018656BB60-0x000000018656BC00 0x000000018656BFA0-0x000000018656C050

	// Constructors
	public DynamicString() {} // 0x000000018656C4A0-0x000000018656C500

	// Methods
	// [XID] // 0x000000018988F1C0-0x000000018988F1E0
	public bool FromJson(JSONNode node) => default; // 0x000000018656B9A0-0x000000018656BB60
	// [XID] // 0x0000000189896740-0x0000000189896760
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF5C5 */, bool useObjectPool = false /* Metadata: 0x00AEF5C9 */) => default; // 0x000000018656BE30-0x000000018656BFA0
	// [XID] // 0x000000018989DCA0-0x000000018989DCC0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018656B570-0x000000018656B6C0
	// [XID] // 0x00000001898A5660-0x00000001898A5680
	public static implicit operator DynamicString(string fixedValue) => default; // 0x000000018656B450-0x000000018656B570
	// [XID] // 0x00000001898D9BF0-0x00000001898D9C10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018656C1A0-0x000000018656C2C0
	// [XID] // 0x00000001898E17B0-0x00000001898E17D0
	public void Copy(DynamicString other) {} // 0x000000018656B8C0-0x000000018656B9A0
	// [XID] // 0x00000001898E9340-0x00000001898E9360
	public void Reset() {} // 0x000000018656B810-0x000000018656B8C0
	// [XID] // 0x00000001898F0B00-0x00000001898F0B20
	public void InitEmpty() {} // 0x000000018656BD50-0x000000018656BE30
	[BlackList] // 0x00000001898F8430-0x00000001898F8470
	// [XID] // 0x00000001898F8430-0x00000001898F8470
	public virtual void AutoAllocTypeFields() {} // 0x000000018656B6C0-0x000000018656B760
	[BlackList] // 0x0000000189902BC0-0x0000000189902C00
	// [XID] // 0x0000000189902BC0-0x0000000189902C00
	public virtual void AutoRecycleTypeFields() {} // 0x000000018656B760-0x000000018656B810
	[BlackList] // 0x000000018990D3F0-0x000000018990D430
	// [XID] // 0x000000018990D3F0-0x000000018990D430
	public virtual void ReturnToObjectPool() {} // 0x000000018656C400-0x000000018656C4A0
	[BlackList] // 0x0000000189917D60-0x0000000189917DA0
	// [XID] // 0x0000000189917D60-0x0000000189917DA0
	public virtual void OnPoolAllocated() {} // 0x000000018656C360-0x000000018656C400
	[BlackList] // 0x0000000189922500-0x0000000189922540
	// [XID] // 0x0000000189922500-0x0000000189922540
	public virtual void OnBeforePoolRecycled() {} // 0x000000018656C2C0-0x000000018656C360
}

