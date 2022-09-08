/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAttackTargetMapEvent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17682
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBaseAttackPattern _attackPattern; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<TargetType, ConfigAttackInfo> _attackInfoMap; // 0x18

	// Properties
	public ConfigBaseAttackPattern attackPattern { /* [XID] */ /* 0x0000000189909C00-0x0000000189909C20 */ get => default; /* [XID] */ /* 0x0000000189911440-0x0000000189911460 */ private set {} } // 0x00000001830FF430-0x00000001830FF4D0 0x00000001830FEB70-0x00000001830FEC20
	public Dictionary<TargetType, ConfigAttackInfo> attackInfoMap { /* [XID] */ /* 0x0000000189919040-0x0000000189919060 */ get => default; /* [XID] */ /* 0x00000001899205B0-0x00000001899205D0 */ private set {} } // 0x00000001830FF090-0x00000001830FF130 0x00000001830FEAC0-0x00000001830FEB70

	// Constructors
	public ConfigAttackTargetMapEvent() {} // 0x00000001830FFA60-0x00000001830FFAC0

	// Methods
	// [XID] // 0x0000000189927F30-0x0000000189927F50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830FF770-0x00000001830FF880
	// [XID] // 0x000000018992F580-0x000000018992F5A0
	public void InitEmpty() {} // 0x00000001830FEFA0-0x00000001830FF090
	[BlackList] // 0x00000001899369F0-0x0000000189936A30
	// [XID] // 0x00000001899369F0-0x0000000189936A30
	public bool FromJson(JSONNode node) => default; // 0x00000001830FEC20-0x00000001830FEFA0
	// [XID] // 0x0000000189941140-0x0000000189941160
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001830FE0B0-0x00000001830FE360
	// [XID] // 0x0000000189948C20-0x0000000189948C40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7781 */, bool useObjectPool = false /* Metadata: 0x00AF7785 */) => default; // 0x00000001830FF130-0x00000001830FF430
	// [XID] // 0x0000000189950390-0x00000001899503B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7786 */, bool useObjectPool = false /* Metadata: 0x00AF778A */) => default; // 0x00000001830FE810-0x00000001830FEAC0
	[BlackList] // 0x0000000189957980-0x00000001899579C0
	// [XID] // 0x0000000189957980-0x00000001899579C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001830FE360-0x00000001830FE630
	// [XID] // 0x00000001899624F0-0x0000000189962510
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001830FF4D0-0x00000001830FF770
	[BlackList] // 0x0000000189969960-0x00000001899699A0
	// [XID] // 0x0000000189969960-0x00000001899699A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001830FE630-0x00000001830FE6D0
	[BlackList] // 0x00000001899742D0-0x0000000189974310
	// [XID] // 0x00000001899742D0-0x0000000189974310
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830FE6D0-0x00000001830FE810
	[BlackList] // 0x000000018997E5A0-0x000000018997E5E0
	// [XID] // 0x000000018997E5A0-0x000000018997E5E0
	public virtual void ReturnToObjectPool() {} // 0x00000001830FF9C0-0x00000001830FFA60
	[BlackList] // 0x0000000189989520-0x0000000189989560
	// [XID] // 0x0000000189989520-0x0000000189989560
	public virtual void OnPoolAllocated() {} // 0x00000001830FF920-0x00000001830FF9C0
	[BlackList] // 0x0000000189994010-0x0000000189994050
	// [XID] // 0x0000000189994010-0x0000000189994050
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830FF880-0x00000001830FF920
}

