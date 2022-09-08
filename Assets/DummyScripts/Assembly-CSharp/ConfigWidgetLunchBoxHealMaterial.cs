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
public class ConfigWidgetLunchBoxHealMaterial : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19131
{
	// Fields
	private SimpleSafeUInt32[] _noticeAddHpMaterials; // 0x10
	private SimpleSafeUInt32[] _otherAddHpMaterials; // 0x18

	// Properties
	public SimpleSafeUInt32[] noticeAddHpMaterials { /* [XID] */ /* 0x0000000189BD1DA0-0x0000000189BD1DC0 */ get => default; /* [XID] */ /* 0x0000000189BD9440-0x0000000189BD9460 */ private set {} } // 0x0000000181714D40-0x0000000181714DE0 0x00000001817158D0-0x0000000181715980
	public SimpleSafeUInt32[] otherAddHpMaterials { /* [XID] */ /* 0x00000001895E5FD0-0x00000001895E5FF0 */ get => default; /* [XID] */ /* 0x00000001895ED950-0x00000001895ED970 */ private set {} } // 0x0000000181715E70-0x0000000181715F10 0x0000000181715430-0x00000001817154E0

	// Constructors
	public ConfigWidgetLunchBoxHealMaterial() {} // 0x0000000181715FB0-0x0000000181716010

	// Methods
	// [XID] // 0x00000001895F50B0-0x00000001895F50D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181715C20-0x0000000181715D30
	// [XID] // 0x00000001895FC690-0x00000001895FC6B0
	public void InitEmpty() {} // 0x00000001817154E0-0x00000001817155D0
	[BlackList] // 0x0000000189604090-0x00000001896040D0
	// [XID] // 0x0000000189604090-0x00000001896040D0
	public bool FromJson(JSONNode node) => default; // 0x00000001817150B0-0x0000000181715430
	// [XID] // 0x000000018960E760-0x000000018960E780
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181714660-0x0000000181714930
	// [XID] // 0x0000000189615E00-0x0000000189615E20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2E3 */, bool useObjectPool = false /* Metadata: 0x00AFC2E7 */) => default; // 0x00000001817155D0-0x00000001817158D0
	// [XID] // 0x000000018961D710-0x000000018961D730
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC2E8 */, bool useObjectPool = false /* Metadata: 0x00AFC2EC */) => default; // 0x0000000181714DE0-0x00000001817150B0
	[BlackList] // 0x0000000189624B50-0x0000000189624B90
	// [XID] // 0x0000000189624B50-0x0000000189624B90
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181714930-0x0000000181714C00
	// [XID] // 0x000000018962F540-0x000000018962F560
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181715980-0x0000000181715C20
	[BlackList] // 0x0000000189637040-0x0000000189637080
	// [XID] // 0x0000000189637040-0x0000000189637080
	public virtual void AutoAllocTypeFields() {} // 0x0000000181714C00-0x0000000181714CA0
	[BlackList] // 0x00000001896413A0-0x00000001896413E0
	// [XID] // 0x00000001896413A0-0x00000001896413E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181714CA0-0x0000000181714D40
	[BlackList] // 0x000000018964BE30-0x000000018964BE70
	// [XID] // 0x000000018964BE30-0x000000018964BE70
	public virtual void ReturnToObjectPool() {} // 0x0000000181715F10-0x0000000181715FB0
	[BlackList] // 0x00000001896564D0-0x0000000189656510
	// [XID] // 0x00000001896564D0-0x0000000189656510
	public virtual void OnPoolAllocated() {} // 0x0000000181715DD0-0x0000000181715E70
	[BlackList] // 0x0000000189660B70-0x0000000189660BB0
	// [XID] // 0x0000000189660B70-0x0000000189660BB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181715D30-0x0000000181715DD0
}

