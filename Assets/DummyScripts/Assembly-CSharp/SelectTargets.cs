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
public class SelectTargets : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16831
{
	// Fields
	private SimpleSafeInt32 topLimitRawNum; // 0x10
	private EntityType[] _entityTypePriority; // 0x18
	private SelectTargetsSortType _sortType; // 0x20

	// Properties
	public int topLimit { /* [XID] */ /* 0x000000018998E650-0x000000018998E670 */ get => default; /* [XID] */ /* 0x000000018997CC30-0x000000018997CC50 */ private set {} } // 0x0000000184AB53D0-0x0000000184AB54A0 0x0000000184AB42A0-0x0000000184AB4380
	public EntityType[] entityTypePriority { /* [XID] */ /* 0x00000001899849D0-0x00000001899849F0 */ get => default; /* [XID] */ /* 0x000000018998C530-0x000000018998C550 */ private set {} } // 0x0000000184AB5670-0x0000000184AB5710 0x0000000184AB4380-0x0000000184AB4430
	public SelectTargetsSortType sortType { /* [XID] */ /* 0x0000000189994230-0x0000000189994250 */ get => default; /* [XID] */ /* 0x000000018999BAA0-0x000000018999BAC0 */ private set {} } // 0x0000000184AB6060-0x0000000184AB6100 0x0000000184AB5CE0-0x0000000184AB5D90

	// Constructors
	public SelectTargets() {} // 0x0000000184AB6720-0x0000000184AB6790

	// Methods
	// [XID] // 0x00000001899A3270-0x00000001899A3290
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184AB6420-0x0000000184AB6540
	// [XID] // 0x00000001899AAD00-0x00000001899AAD20
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184AB5F90-0x0000000184AB6060
	// [XID] // 0x00000001899B2790-0x00000001899B27B0
	public virtual SelectTargets Clone(bool useObjectPool = false /* Metadata: 0x00AF47F0 */) => default; // 0x0000000184AB5C00-0x0000000184AB5CE0
	// [XID] // 0x00000001899B9A10-0x00000001899B9A30
	public virtual int GetHashNum() => default; // 0x0000000184AB4C50-0x0000000184AB4D20
	// [XID] // 0x00000001899C1590-0x00000001899C15B0
	public virtual void InitEmpty() {} // 0x0000000184AB5710-0x0000000184AB5810
	[BlackList] // 0x00000001899C8AE0-0x00000001899C8B20
	// [XID] // 0x00000001899C8AE0-0x00000001899C8B20
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000184AB5050-0x0000000184AB53D0
	// [XID] // 0x00000001899D3310-0x00000001899D3330
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184AB4430-0x0000000184AB4800
	[BlackList] // 0x00000001899DA880-0x00000001899DA8C0
	// [XID] // 0x00000001899DA880-0x00000001899DA8C0
	public static SelectTargets ParseFromJson(JSONNode node) => default; // 0x0000000184AB5D90-0x0000000184AB5F90
	// [XID] // 0x0000000189828880-0x00000001898288A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF47F1 */, bool useObjectPool = false /* Metadata: 0x00AF47F5 */) => default; // 0x0000000184AB5900-0x0000000184AB5C00
	// [XID] // 0x00000001899EC6F0-0x00000001899EC710
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF47F6 */, bool useObjectPool = false /* Metadata: 0x00AF47FA */) => default; // 0x0000000184AB4D20-0x0000000184AB5050
	// [XID] // 0x00000001896AF710-0x00000001896AF730
	public static SelectTargets ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF47FB */, bool useObjectPool = false /* Metadata: 0x00AF47FF */) => default; // 0x0000000184AB54A0-0x0000000184AB5670
	[BlackList] // 0x00000001899FB9F0-0x00000001899FBA30
	// [XID] // 0x00000001899FB9F0-0x00000001899FBA30
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000184AB4800-0x0000000184AB4AD0
	// [XID] // 0x0000000189A05F50-0x0000000189A05F70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184AB6100-0x0000000184AB6420
	[BlackList] // 0x0000000189A0D3E0-0x0000000189A0D420
	// [XID] // 0x0000000189A0D3E0-0x0000000189A0D420
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184AB5810-0x0000000184AB5900
	[BlackList] // 0x0000000189A176D0-0x0000000189A17710
	// [XID] // 0x0000000189A176D0-0x0000000189A17710
	public virtual void AutoAllocTypeFields() {} // 0x0000000184AB4AD0-0x0000000184AB4B70
	[BlackList] // 0x0000000189A21DB0-0x0000000189A21DF0
	// [XID] // 0x0000000189A21DB0-0x0000000189A21DF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184AB4B70-0x0000000184AB4C50
	[BlackList] // 0x0000000189A2C150-0x0000000189A2C190
	// [XID] // 0x0000000189A2C150-0x0000000189A2C190
	public virtual void ReturnToObjectPool() {} // 0x0000000184AB6680-0x0000000184AB6720
	[BlackList] // 0x0000000189A36C10-0x0000000189A36C50
	// [XID] // 0x0000000189A36C10-0x0000000189A36C50
	public virtual void OnPoolAllocated() {} // 0x0000000184AB65E0-0x0000000184AB6680
	[BlackList] // 0x0000000189A41270-0x0000000189A412B0
	// [XID] // 0x0000000189A41270-0x0000000189A412B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184AB6540-0x0000000184AB65E0
}

