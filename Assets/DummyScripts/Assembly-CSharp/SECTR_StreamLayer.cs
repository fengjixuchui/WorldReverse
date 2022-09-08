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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class SECTR_StreamLayer : IEmptyInitable, IHashable, IAutoAllocRecycle, ISerializationCallbackReceiver // TypeDefIndex: 18968
{
	// Fields
	private string _sectorName; // 0x10
	private string _layerName; // 0x18
	private SECTR_LayerType _type; // 0x20
	private string _layerFullName; // 0x28
	private MoleMole.Config.Vector _position; // 0x30
	private ulong _hlodPattern; // 0x40
	private MoleMole.Config.Vector _sectorSize; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private SECTR_CombineStreamPathInfo _layerPathInfo; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private SECTR_AttachStreamLayer[] _attachLayers; // 0x60

	// Properties
	public string sectorName { /* [XID] */ /* 0x00000001895E7690-0x00000001895E76B0 */ get => default; /* [XID] */ /* 0x00000001895EEFE0-0x00000001895EF000 */ private set {} } // 0x0000000181510AD0-0x0000000181510B70 0x0000000181511A30-0x0000000181511AE0
	public string layerName { /* [XID] */ /* 0x00000001895F69A0-0x00000001895F69C0 */ get => default; /* [XID] */ /* 0x00000001895FDD60-0x00000001895FDD80 */ private set {} } // 0x0000000181512BE0-0x0000000181512C80 0x0000000181511F50-0x0000000181512000
	public SECTR_LayerType type { /* [XID] */ /* 0x00000001896055D0-0x00000001896055F0 */ get => default; /* [XID] */ /* 0x000000018960CFC0-0x000000018960CFE0 */ private set {} } // 0x0000000181513270-0x0000000181513310 0x00000001815123B0-0x0000000181512460
	public string layerFullName { /* [XID] */ /* 0x0000000189614620-0x0000000189614640 */ get => default; /* [XID] */ /* 0x000000018961BF30-0x000000018961BF50 */ private set {} } // 0x0000000181512460-0x0000000181512500 0x0000000181510B70-0x0000000181510C20
	public MoleMole.Config.Vector position { /* [XID] */ /* 0x00000001896234C0-0x00000001896234E0 */ get => default; /* [XID] */ /* 0x000000018962AD00-0x000000018962AD20 */ private set {} } // 0x0000000181512000-0x00000001815120E0 0x0000000181511AE0-0x0000000181511BB0
	public ulong hlodPattern { /* [XID] */ /* 0x00000001896324A0-0x00000001896324C0 */ get => default; /* [XID] */ /* 0x0000000189639F30-0x0000000189639F50 */ private set {} } // 0x0000000181511BB0-0x0000000181511C50 0x0000000181512300-0x00000001815123B0
	public MoleMole.Config.Vector sectorSize { /* [XID] */ /* 0x0000000189641440-0x0000000189641460 */ get => default; /* [XID] */ /* 0x0000000189648E40-0x0000000189648E60 */ private set {} } // 0x00000001815109F0-0x0000000181510AD0 0x0000000181512230-0x0000000181512300
	public SECTR_CombineStreamPathInfo layerPathInfo { /* [XID] */ /* 0x00000001896503F0-0x0000000189650410 */ get => default; /* [XID] */ /* 0x0000000189657D50-0x0000000189657D70 */ private set {} } // 0x0000000181511330-0x00000001815113D0 0x00000001815131C0-0x0000000181513270
	public SECTR_AttachStreamLayer[] attachLayers { /* [XID] */ /* 0x000000018965F400-0x000000018965F420 */ get => default; /* [XID] */ /* 0x0000000189666C90-0x0000000189666CB0 */ private set {} } // 0x0000000181512190-0x0000000181512230 0x00000001815120E0-0x0000000181512190

	// Constructors
	public SECTR_StreamLayer() {} // 0x00000001815133B0-0x0000000181513410

	// Methods
	// [XID] // 0x000000018966E360-0x000000018966E380
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181512C80-0x0000000181512EA0
	// [XID] // 0x00000001896760E0-0x0000000189676100
	public void InitEmpty() {} // 0x00000001815118F0-0x0000000181511A30
	[BlackList] // 0x000000018967D980-0x000000018967D9C0
	// [XID] // 0x000000018967D980-0x000000018967D9C0
	public bool FromJson(JSONNode node) => default; // 0x0000000181511570-0x00000001815118F0
	// [XID] // 0x0000000189688520-0x0000000189688540
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018150FC80-0x0000000181510520
	// [XID] // 0x000000018968FDE0-0x000000018968FE00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5D5 */, bool useObjectPool = false /* Metadata: 0x00AFB5D9 */) => default; // 0x0000000181511C50-0x0000000181511F50
	// [XID] // 0x00000001896977A0-0x00000001896977C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5DA */, bool useObjectPool = false /* Metadata: 0x00AFB5DE */) => default; // 0x0000000181510C20-0x0000000181511330
	[BlackList] // 0x000000018969EC10-0x000000018969EC50
	// [XID] // 0x000000018969EC10-0x000000018969EC50
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181510520-0x00000001815107F0
	// [XID] // 0x00000001896A8FE0-0x00000001896A9000
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181512500-0x0000000181512BE0
	[BlackList] // 0x00000001896B0170-0x00000001896B01B0
	// [XID] // 0x00000001896B0170-0x00000001896B01B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001815107F0-0x0000000181510890
	[BlackList] // 0x00000001896BA850-0x00000001896BA890
	// [XID] // 0x00000001896BA850-0x00000001896BA890
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181510890-0x00000001815109F0
	[BlackList] // 0x00000001896C4C70-0x00000001896C4CB0
	// [XID] // 0x00000001896C4C70-0x00000001896C4CB0
	public virtual void ReturnToObjectPool() {} // 0x0000000181513310-0x00000001815133B0
	[BlackList] // 0x00000001896CF570-0x00000001896CF5B0
	// [XID] // 0x00000001896CF570-0x00000001896CF5B0
	public virtual void OnPoolAllocated() {} // 0x0000000181513120-0x00000001815131C0
	[BlackList] // 0x00000001896D97D0-0x00000001896D9810
	// [XID] // 0x00000001896D97D0-0x00000001896D9810
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181512FE0-0x0000000181513080
	// [XID] // 0x00000001896E3ED0-0x00000001896E3EF0
	public void OnBeforeSerialize() {} // 0x0000000181513080-0x0000000181513120
	// [XID] // 0x00000001896EB2C0-0x00000001896EB2E0
	public void OnAfterDeserialize() {} // 0x0000000181512EA0-0x0000000181512FE0
	// [XID] // 0x00000001896F2610-0x00000001896F2630
	public Bounds BoundsOverride() => default; // 0x00000001815113D0-0x0000000181511570
}

