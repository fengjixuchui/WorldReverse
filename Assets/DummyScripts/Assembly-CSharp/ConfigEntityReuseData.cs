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
public class ConfigEntityReuseData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18052
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityReuse[] _entityReuseList; // 0x10

	// Properties
	public ConfigEntityReuse[] entityReuseList { /* [XID] */ /* 0x0000000189AC9C00-0x0000000189AC9C20 */ get => default; /* [XID] */ /* 0x0000000189AD1410-0x0000000189AD1430 */ private set {} } // 0x000000018360EC30-0x000000018360ECD0 0x000000018360E880-0x000000018360E930

	// Constructors
	public ConfigEntityReuseData() {} // 0x000000018360F180-0x000000018360F1E0

	// Methods
	// [XID] // 0x0000000189AD91D0-0x0000000189AD91F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018360EEC0-0x000000018360EFA0
	// [XID] // 0x0000000189AE0C40-0x0000000189AE0C60
	public void InitEmpty() {} // 0x000000018360E7B0-0x000000018360E880
	[BlackList] // 0x0000000189AE8110-0x0000000189AE8150
	// [XID] // 0x0000000189AE8110-0x0000000189AE8150
	public bool FromJson(JSONNode node) => default; // 0x000000018360E430-0x000000018360E7B0
	// [XID] // 0x0000000189AF2D30-0x0000000189AF2D50
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018360DC30-0x000000018360DE10
	// [XID] // 0x0000000189AFA600-0x0000000189AFA620
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87FB */, bool useObjectPool = false /* Metadata: 0x00AF87FF */) => default; // 0x000000018360E930-0x000000018360EC30
	// [XID] // 0x0000000189B01B10-0x0000000189B01B30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8800 */, bool useObjectPool = false /* Metadata: 0x00AF8804 */) => default; // 0x000000018360E220-0x000000018360E430
	[BlackList] // 0x0000000189B090D0-0x0000000189B09110
	// [XID] // 0x0000000189B090D0-0x0000000189B09110
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018360DE10-0x000000018360E0E0
	// [XID] // 0x0000000189B136F0-0x0000000189B13710
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018360ECD0-0x000000018360EEC0
	[BlackList] // 0x0000000189B1ADC0-0x0000000189B1AE00
	// [XID] // 0x0000000189B1ADC0-0x0000000189B1AE00
	public virtual void AutoAllocTypeFields() {} // 0x000000018360E0E0-0x000000018360E180
	[BlackList] // 0x0000000189B253A0-0x0000000189B253E0
	// [XID] // 0x0000000189B253A0-0x0000000189B253E0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018360E180-0x000000018360E220
	[BlackList] // 0x0000000189B2F5F0-0x0000000189B2F630
	// [XID] // 0x0000000189B2F5F0-0x0000000189B2F630
	public virtual void ReturnToObjectPool() {} // 0x000000018360F0E0-0x000000018360F180
	[BlackList] // 0x0000000189B39FF0-0x0000000189B3A030
	// [XID] // 0x0000000189B39FF0-0x0000000189B3A030
	public virtual void OnPoolAllocated() {} // 0x000000018360F040-0x000000018360F0E0
	[BlackList] // 0x0000000189B44990-0x0000000189B449D0
	// [XID] // 0x0000000189B44990-0x0000000189B449D0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018360EFA0-0x000000018360F040
}

