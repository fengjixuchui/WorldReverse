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
public class ConfigMoveSyncInterval : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18099
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigSpecificFloatValue _lod0; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigSpecificFloatValue _lod1; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigSpecificFloatValue _lod2; // 0x20

	// Properties
	public ConfigSpecificFloatValue lod0 { /* [XID] */ /* 0x0000000189875B60-0x0000000189875B80 */ get => default; /* [XID] */ /* 0x000000018987D7A0-0x000000018987D7C0 */ private set {} } // 0x0000000181B0AA90-0x0000000181B0AB30 0x0000000181B0A5C0-0x0000000181B0A670
	public ConfigSpecificFloatValue lod1 { /* [XID] */ /* 0x0000000189884630-0x0000000189884650 */ get => default; /* [XID] */ /* 0x000000018988BC80-0x000000018988BCA0 */ private set {} } // 0x0000000181B0A9F0-0x0000000181B0AA90 0x0000000181B0A070-0x0000000181B0A120
	public ConfigSpecificFloatValue lod2 { /* [XID] */ /* 0x00000001898933F0-0x0000000189893410 */ get => default; /* [XID] */ /* 0x000000018989AAF0-0x000000018989AB10 */ private set {} } // 0x0000000181B0AF30-0x0000000181B0AFD0 0x0000000181B0A120-0x0000000181B0A1D0

	// Constructors
	public ConfigMoveSyncInterval() {} // 0x0000000181B0B610-0x0000000181B0B670

	// Methods
	// [XID] // 0x00000001898A1D60-0x00000001898A1D80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181B0B300-0x0000000181B0B430
	// [XID] // 0x00000001898A95D0-0x00000001898A95F0
	public void InitEmpty() {} // 0x0000000181B0AB30-0x0000000181B0AC30
	[BlackList] // 0x00000001898B0E00-0x00000001898B0E40
	// [XID] // 0x00000001898B0E00-0x00000001898B0E40
	public bool FromJson(JSONNode node) => default; // 0x0000000181B0A670-0x0000000181B0A9F0
	// [XID] // 0x00000001898BB830-0x00000001898BB850
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181B096F0-0x0000000181B09AE0
	// [XID] // 0x00000001898C2A60-0x00000001898C2A80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AF5 */, bool useObjectPool = false /* Metadata: 0x00AF8AF9 */) => default; // 0x0000000181B0AC30-0x0000000181B0AF30
	// [XID] // 0x00000001898CA460-0x00000001898CA480
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AFA */, bool useObjectPool = false /* Metadata: 0x00AF8AFE */) => default; // 0x0000000181B0A1D0-0x0000000181B0A5C0
	[BlackList] // 0x00000001898D1CB0-0x00000001898D1CF0
	// [XID] // 0x00000001898D1CB0-0x00000001898D1CF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181B09AE0-0x0000000181B09DB0
	// [XID] // 0x00000001898DC670-0x00000001898DC690
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181B0AFD0-0x0000000181B0B300
	[BlackList] // 0x00000001898E4100-0x00000001898E4140
	// [XID] // 0x00000001898E4100-0x00000001898E4140
	public virtual void AutoAllocTypeFields() {} // 0x0000000181B09DB0-0x0000000181B09E50
	[BlackList] // 0x00000001898EECC0-0x00000001898EED00
	// [XID] // 0x00000001898EECC0-0x00000001898EED00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181B09E50-0x0000000181B0A070
	[BlackList] // 0x00000001898F9530-0x00000001898F9570
	// [XID] // 0x00000001898F9530-0x00000001898F9570
	public virtual void ReturnToObjectPool() {} // 0x0000000181B0B570-0x0000000181B0B610
	[BlackList] // 0x0000000189903E70-0x0000000189903EB0
	// [XID] // 0x0000000189903E70-0x0000000189903EB0
	public virtual void OnPoolAllocated() {} // 0x0000000181B0B4D0-0x0000000181B0B570
	[BlackList] // 0x000000018990E670-0x000000018990E6B0
	// [XID] // 0x000000018990E670-0x000000018990E6B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181B0B430-0x0000000181B0B4D0
}

