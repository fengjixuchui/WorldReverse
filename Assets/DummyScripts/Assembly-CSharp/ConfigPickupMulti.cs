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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigPickupMulti : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17990
{
	// Fields
	private MoleMole.Config.Vector _dirMinVec; // 0x10
	private MoleMole.Config.Vector _dirMaxVec; // 0x1C
	private SimpleSafeUInt32 maxNumRawNum; // 0x28
	private SimpleSafeUInt32 minNumRawNum; // 0x2C
	private SimpleSafeFloat attractSpeedRawNum; // 0x30
	private bool _useWorldTrans; // 0x34
	private bool _isAutoAttract; // 0x35

	// Properties
	public MoleMole.Config.Vector dirMinVec { /* [XID] */ /* 0x0000000189801A30-0x0000000189801A50 */ get => default; /* [XID] */ /* 0x0000000189650670-0x0000000189650690 */ private set {} } // 0x0000000182A44AA0-0x0000000182A44B80 0x0000000182A450D0-0x0000000182A451A0
	public MoleMole.Config.Vector dirMaxVec { /* [XID] */ /* 0x0000000189808E90-0x0000000189808EB0 */ get => default; /* [XID] */ /* 0x000000018965F580-0x000000018965F5A0 */ private set {} } // 0x0000000182A456D0-0x0000000182A457B0 0x0000000182A45D80-0x0000000182A45E50
	public uint maxNum { /* [XID] */ /* 0x0000000189666EB0-0x0000000189666ED0 */ get => default; /* [XID] */ /* 0x000000018966E600-0x000000018966E620 */ private set {} } // 0x0000000182A45C10-0x0000000182A45CE0 0x0000000182A464F0-0x0000000182A465D0
	public uint minNum { /* [XID] */ /* 0x0000000189676260-0x0000000189676280 */ get => default; /* [XID] */ /* 0x000000018967DAC0-0x000000018967DAE0 */ private set {} } // 0x0000000182A451A0-0x0000000182A45270 0x0000000182A46410-0x0000000182A464F0
	public float attractSpeed { /* [XID] */ /* 0x0000000189685100-0x0000000189685120 */ get => default; /* [XID] */ /* 0x000000018968CC00-0x000000018968CC20 */ private set {} } // 0x0000000182A465D0-0x0000000182A466B0 0x0000000182A45270-0x0000000182A45350
	public bool useWorldTrans { /* [XID] */ /* 0x0000000189694760-0x0000000189694780 */ get => default; /* [XID] */ /* 0x000000018969BD80-0x000000018969BDA0 */ private set {} } // 0x0000000182A45CE0-0x0000000182A45D80 0x0000000182A469C0-0x0000000182A46A70
	public bool isAutoAttract { /* [XID] */ /* 0x0000000189852C30-0x0000000189852C50 */ get => default; /* [XID] */ /* 0x00000001896AA790-0x00000001896AA7B0 */ private set {} } // 0x0000000182A43D50-0x0000000182A43DF0 0x0000000182A449F0-0x0000000182A44AA0

	// Constructors
	public ConfigPickupMulti() {} // 0x0000000182A46B10-0x0000000182A46BB0

	// Methods
	// [XID] // 0x00000001896B1870-0x00000001896B1890
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A466B0-0x0000000182A46880
	// [XID] // 0x00000001896B91F0-0x00000001896B9210
	public void InitEmpty() {} // 0x0000000182A457B0-0x0000000182A45910
	[BlackList] // 0x00000001896C0640-0x00000001896C0680
	// [XID] // 0x00000001896C0640-0x00000001896C0680
	public bool FromJson(JSONNode node) => default; // 0x0000000182A45350-0x0000000182A456D0
	// [XID] // 0x00000001896CA9D0-0x00000001896CA9F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182A43DF0-0x0000000182A44540
	// [XID] // 0x00000001896D2100-0x00000001896D2120
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85DF */, bool useObjectPool = false /* Metadata: 0x00AF85E3 */) => default; // 0x0000000182A45910-0x0000000182A45C10
	// [XID] // 0x00000001896D9A50-0x00000001896D9A70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85E4 */, bool useObjectPool = false /* Metadata: 0x00AF85E8 */) => default; // 0x0000000182A44B80-0x0000000182A450D0
	[BlackList] // 0x00000001896E1110-0x00000001896E1150
	// [XID] // 0x00000001896E1110-0x00000001896E1150
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A44540-0x0000000182A44810
	// [XID] // 0x00000001896EB520-0x00000001896EB540
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A45E50-0x0000000182A46410
	[BlackList] // 0x00000001896F2870-0x00000001896F28B0
	// [XID] // 0x00000001896F2870-0x00000001896F28B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182A44810-0x0000000182A448B0
	[BlackList] // 0x00000001896FD350-0x00000001896FD390
	// [XID] // 0x00000001896FD350-0x00000001896FD390
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182A448B0-0x0000000182A449F0
	[BlackList] // 0x00000001897077D0-0x0000000189707810
	// [XID] // 0x00000001897077D0-0x0000000189707810
	public virtual void ReturnToObjectPool() {} // 0x0000000182A46A70-0x0000000182A46B10
	[BlackList] // 0x00000001897122B0-0x00000001897122F0
	// [XID] // 0x00000001897122B0-0x00000001897122F0
	public virtual void OnPoolAllocated() {} // 0x0000000182A46920-0x0000000182A469C0
	[BlackList] // 0x000000018971C700-0x000000018971C740
	// [XID] // 0x000000018971C700-0x000000018971C740
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182A46880-0x0000000182A46920
}

