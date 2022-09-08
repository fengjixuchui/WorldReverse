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
public class ConfigPartController : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18008
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigControlPart[] _parts; // 0x10

	// Properties
	public ConfigControlPart[] parts { /* [XID] */ /* 0x0000000189918F40-0x0000000189918F60 */ get => default; /* [XID] */ /* 0x0000000189920570-0x0000000189920590 */ private set {} } // 0x0000000183502A70-0x0000000183502B10 0x00000001835027B0-0x0000000183502860

	// Constructors
	public ConfigPartController() {} // 0x0000000183503710-0x0000000183503770

	// Methods
	// [XID] // 0x0000000189927E90-0x0000000189927EB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183503450-0x0000000183503530
	// [XID] // 0x000000018992F540-0x000000018992F560
	public void InitEmpty() {} // 0x0000000183502E90-0x0000000183502F60
	[BlackList] // 0x0000000189936970-0x00000001899369B0
	// [XID] // 0x0000000189936970-0x00000001899369B0
	public bool FromJson(JSONNode node) => default; // 0x0000000183502B10-0x0000000183502E90
	// [XID] // 0x0000000189941080-0x00000001899410A0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001835021C0-0x00000001835023A0
	// [XID] // 0x0000000189948B80-0x0000000189948BA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8669 */, bool useObjectPool = false /* Metadata: 0x00AF866D */) => default; // 0x0000000183502F60-0x0000000183503260
	// [XID] // 0x0000000189950310-0x0000000189950330
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF866E */, bool useObjectPool = false /* Metadata: 0x00AF8672 */) => default; // 0x0000000183502860-0x0000000183502A70
	[BlackList] // 0x0000000189957920-0x0000000189957960
	// [XID] // 0x0000000189957920-0x0000000189957960
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001835023A0-0x0000000183502670
	// [XID] // 0x0000000189962470-0x0000000189962490
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183503260-0x0000000183503450
	[BlackList] // 0x0000000189969900-0x0000000189969940
	// [XID] // 0x0000000189969900-0x0000000189969940
	public virtual void AutoAllocTypeFields() {} // 0x0000000183502670-0x0000000183502710
	[BlackList] // 0x0000000189974250-0x0000000189974290
	// [XID] // 0x0000000189974250-0x0000000189974290
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183502710-0x00000001835027B0
	[BlackList] // 0x000000018997E4E0-0x000000018997E520
	// [XID] // 0x000000018997E4E0-0x000000018997E520
	public virtual void ReturnToObjectPool() {} // 0x0000000183503670-0x0000000183503710
	[BlackList] // 0x0000000189989460-0x00000001899894A0
	// [XID] // 0x0000000189989460-0x00000001899894A0
	public virtual void OnPoolAllocated() {} // 0x00000001835035D0-0x0000000183503670
	[BlackList] // 0x0000000189993FB0-0x0000000189993FF0
	// [XID] // 0x0000000189993FB0-0x0000000189993FF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183503530-0x00000001835035D0
}

