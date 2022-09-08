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
public class SECTR_LayerGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18969
{
	// Fields
	private string _groupName; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private SECTR_StreamLayer[] _layerInfos; // 0x18

	// Properties
	public string groupName { /* [XID] */ /* 0x0000000189708F20-0x0000000189708F40 */ get => default; /* [XID] */ /* 0x00000001897107F0-0x0000000189710810 */ private set {} } // 0x00000001810B95E0-0x00000001810B9680 0x00000001810B9680-0x00000001810B9730
	public SECTR_StreamLayer[] layerInfos { /* [XID] */ /* 0x0000000189717BF0-0x0000000189717C10 */ get => default; /* [XID] */ /* 0x000000018971F690-0x000000018971F6B0 */ private set {} } // 0x00000001810B9540-0x00000001810B95E0 0x00000001810BA150-0x00000001810BA200

	// Constructors
	public SECTR_LayerGroup() {} // 0x00000001810BA760-0x00000001810BA7C0

	// Methods
	// [XID] // 0x0000000189726C00-0x0000000189726C20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001810BA470-0x00000001810BA580
	// [XID] // 0x000000018972E1B0-0x000000018972E1D0
	public void InitEmpty() {} // 0x00000001810B9D70-0x00000001810B9E50
	[BlackList] // 0x0000000189735860-0x00000001897358A0
	// [XID] // 0x0000000189735860-0x00000001897358A0
	public bool FromJson(JSONNode node) => default; // 0x00000001810B99F0-0x00000001810B9D70
	// [XID] // 0x00000001897407A0-0x00000001897407C0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001810B8E50-0x00000001810B9120
	// [XID] // 0x0000000189747AB0-0x0000000189747AD0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5DF */, bool useObjectPool = false /* Metadata: 0x00AFB5E3 */) => default; // 0x00000001810B9E50-0x00000001810BA150
	// [XID] // 0x000000018974F2D0-0x000000018974F2F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5E4 */, bool useObjectPool = false /* Metadata: 0x00AFB5E8 */) => default; // 0x00000001810B9730-0x00000001810B99F0
	[BlackList] // 0x0000000189756960-0x00000001897569A0
	// [XID] // 0x0000000189756960-0x00000001897569A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001810B9120-0x00000001810B93F0
	// [XID] // 0x0000000189761270-0x0000000189761290
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001810BA200-0x00000001810BA470
	[BlackList] // 0x0000000189768600-0x0000000189768640
	// [XID] // 0x0000000189768600-0x0000000189768640
	public virtual void AutoAllocTypeFields() {} // 0x00000001810B93F0-0x00000001810B9490
	[BlackList] // 0x0000000189772C60-0x0000000189772CA0
	// [XID] // 0x0000000189772C60-0x0000000189772CA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001810B9490-0x00000001810B9540
	[BlackList] // 0x000000018977D440-0x000000018977D480
	// [XID] // 0x000000018977D440-0x000000018977D480
	public virtual void ReturnToObjectPool() {} // 0x00000001810BA6C0-0x00000001810BA760
	[BlackList] // 0x0000000189787BA0-0x0000000189787BE0
	// [XID] // 0x0000000189787BA0-0x0000000189787BE0
	public virtual void OnPoolAllocated() {} // 0x00000001810BA620-0x00000001810BA6C0
	[BlackList] // 0x00000001897921C0-0x0000000189792200
	// [XID] // 0x00000001897921C0-0x0000000189792200
	public virtual void OnBeforePoolRecycled() {} // 0x00000001810BA580-0x00000001810BA620
}

