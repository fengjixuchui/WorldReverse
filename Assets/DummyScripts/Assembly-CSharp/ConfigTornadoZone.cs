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
public class ConfigTornadoZone : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16939
{
	// Fields
	private string _shapeName; // 0x10
	private MoleMole.Config.Vector _offset; // 0x18
	private MoleMole.Config.Vector _dir; // 0x24
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _strength; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _attenuation; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _innerRadius; // 0x40
	private string _modifierName; // 0x48
	private SimpleSafeUInt32 maxNumRawNum; // 0x50
	private SimpleSafeFloat forceGrowthRawNum; // 0x54
	private SimpleSafeFloat forceFallenRawNum; // 0x58
	private SimpleSafeFloat durationRawNum; // 0x5C

	// Properties
	public string shapeName { /* [XID] */ /* 0x000000018989C1A0-0x000000018989C1C0 */ get => default; /* [XID] */ /* 0x00000001898A3820-0x00000001898A3840 */ private set {} } // 0x0000000181122900-0x00000001811229A0 0x0000000181123FD0-0x0000000181124080
	public MoleMole.Config.Vector offset { /* [XID] */ /* 0x00000001898AAC20-0x00000001898AAC40 */ get => default; /* [XID] */ /* 0x00000001898B2510-0x00000001898B2530 */ private set {} } // 0x00000001811223C0-0x00000001811224A0 0x00000001811232A0-0x0000000181123370
	public MoleMole.Config.Vector dir { /* [XID] */ /* 0x00000001898BA360-0x00000001898BA380 */ get => default; /* [XID] */ /* 0x00000001898C16C0-0x00000001898C16E0 */ private set {} } // 0x00000001811235D0-0x00000001811236B0 0x00000001811231D0-0x00000001811232A0
	public DynamicFloat strength { /* [XID] */ /* 0x00000001898C8FC0-0x00000001898C8FE0 */ get => default; /* [XID] */ /* 0x00000001898D07E0-0x00000001898D0800 */ private set {} } // 0x0000000181120860-0x0000000181120900 0x0000000181121360-0x0000000181121410
	public DynamicFloat attenuation { /* [XID] */ /* 0x00000001898D7EA0-0x00000001898D7EC0 */ get => default; /* [XID] */ /* 0x00000001898DFCA0-0x00000001898DFCC0 */ private set {} } // 0x0000000181123370-0x0000000181123410 0x00000001811229A0-0x0000000181122A50
	public DynamicFloat innerRadius { /* [XID] */ /* 0x00000001898E76F0-0x00000001898E7710 */ get => default; /* [XID] */ /* 0x00000001898EEEC0-0x00000001898EEEE0 */ private set {} } // 0x0000000181122D60-0x0000000181122E00 0x0000000181124080-0x0000000181124130
	public string modifierName { /* [XID] */ /* 0x00000001898F67C0-0x00000001898F67E0 */ get => default; /* [XID] */ /* 0x00000001898FDF00-0x00000001898FDF20 */ private set {} } // 0x00000001811244F0-0x0000000181124590 0x0000000181122CB0-0x0000000181122D60
	public uint maxNum { /* [XID] */ /* 0x00000001899056E0-0x0000000189905700 */ get => default; /* [XID] */ /* 0x000000018990CF30-0x000000018990CF50 */ private set {} } // 0x0000000181123100-0x00000001811231D0 0x0000000181123EF0-0x0000000181123FD0
	public float forceGrowth { /* [XID] */ /* 0x0000000189914700-0x0000000189914720 */ get => default; /* [XID] */ /* 0x000000018991C280-0x000000018991C2A0 */ private set {} } // 0x00000001811234F0-0x00000001811235D0 0x0000000181122A50-0x0000000181122B30
	public float forceFallen { /* [XID] */ /* 0x0000000189923A00-0x0000000189923A20 */ get => default; /* [XID] */ /* 0x000000018992B040-0x000000018992B060 */ private set {} } // 0x0000000181123410-0x00000001811234F0 0x0000000181122820-0x0000000181122900
	public float duration { /* [XID] */ /* 0x00000001899326E0-0x0000000189932700 */ get => default; /* [XID] */ /* 0x000000018993A0F0-0x000000018993A110 */ private set {} } // 0x0000000181121A30-0x0000000181121B10 0x00000001811222E0-0x00000001811223C0

	// Constructors
	public ConfigTornadoZone() {} // 0x0000000181124630-0x0000000181124780

	// Methods
	// [XID] // 0x00000001899412C0-0x00000001899412E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181124130-0x00000001811243B0
	// [XID] // 0x0000000189948E20-0x0000000189948E40
	public void InitEmpty() {} // 0x0000000181122B30-0x0000000181122CB0
	[BlackList] // 0x00000001899505F0-0x0000000189950630
	// [XID] // 0x00000001899505F0-0x0000000189950630
	public bool FromJson(JSONNode node) => default; // 0x00000001811224A0-0x0000000181122820
	// [XID] // 0x000000018995ABD0-0x000000018995ABF0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181120900-0x0000000181121360
	// [XID] // 0x00000001899626F0-0x0000000189962710
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E2D */, bool useObjectPool = false /* Metadata: 0x00AF5E31 */) => default; // 0x0000000181122E00-0x0000000181123100
	// [XID] // 0x0000000189969AA0-0x0000000189969AC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E32 */, bool useObjectPool = false /* Metadata: 0x00AF5E36 */) => default; // 0x0000000181121B10-0x00000001811222E0
	[BlackList] // 0x0000000189971860-0x00000001899718A0
	// [XID] // 0x0000000189971860-0x00000001899718A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181121410-0x00000001811216E0
	// [XID] // 0x000000018997BB20-0x000000018997BB40
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001811236B0-0x0000000181123EF0
	[BlackList] // 0x0000000189983650-0x0000000189983690
	// [XID] // 0x0000000189983650-0x0000000189983690
	public virtual void AutoAllocTypeFields() {} // 0x00000001811216E0-0x0000000181121780
	[BlackList] // 0x000000018998DE20-0x000000018998DE60
	// [XID] // 0x000000018998DE20-0x000000018998DE60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181121780-0x0000000181121A30
	[BlackList] // 0x0000000189998990-0x00000001899989D0
	// [XID] // 0x0000000189998990-0x00000001899989D0
	public virtual void ReturnToObjectPool() {} // 0x0000000181124590-0x0000000181124630
	[BlackList] // 0x00000001899A3210-0x00000001899A3250
	// [XID] // 0x00000001899A3210-0x00000001899A3250
	public virtual void OnPoolAllocated() {} // 0x0000000181124450-0x00000001811244F0
	[BlackList] // 0x00000001899ADD00-0x00000001899ADD40
	// [XID] // 0x00000001899ADD00-0x00000001899ADD40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001811243B0-0x0000000181124450
}

