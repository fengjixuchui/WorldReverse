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
public class ConfigWidgetAction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19161
{
	// Constructors
	public ConfigWidgetAction() {} // 0x000000018205EEF0-0x000000018205EF50

	// Methods
	// [XID] // 0x00000001896C03A0-0x00000001896C03C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018205EC60-0x000000018205ED10
	// [XID] // 0x00000001896C7B30-0x00000001896C7B50
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018205EB00-0x000000018205EBB0
	// [XID] // 0x00000001896CF4F0-0x00000001896CF510
	public virtual ConfigWidgetAction Clone(bool useObjectPool = false /* Metadata: 0x00AFC3D7 */) => default; // 0x000000018205E820-0x000000018205E900
	// [XID] // 0x00000001896D66A0-0x00000001896D66C0
	public virtual int GetHashNum() => default; // 0x000000018205DBD0-0x000000018205DCA0
	// [XID] // 0x00000001896DDD00-0x00000001896DDD20
	public virtual void InitEmpty() {} // 0x000000018205E2D0-0x000000018205E370
	[BlackList] // 0x00000001896E5310-0x00000001896E5350
	// [XID] // 0x00000001896E5310-0x00000001896E5350
	public virtual bool FromJson(JSONNode node) => default; // 0x000000018205DD80-0x000000018205E100
	// [XID] // 0x00000001896EF7C0-0x00000001896EF7E0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018205D710-0x000000018205D7C0
	[BlackList] // 0x00000001896F70D0-0x00000001896F7110
	// [XID] // 0x00000001896F70D0-0x00000001896F7110
	public static ConfigWidgetAction ParseFromJson(JSONNode node) => default; // 0x000000018205E900-0x000000018205EB00
	// [XID] // 0x0000000189701620-0x0000000189701640
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC3D8 */, bool useObjectPool = false /* Metadata: 0x00AFC3DC */) => default; // 0x000000018205E460-0x000000018205E760
	// [XID] // 0x0000000189708EA0-0x0000000189708EC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC3DD */, bool useObjectPool = false /* Metadata: 0x00AFC3E1 */) => default; // 0x000000018205DCA0-0x000000018205DD80
	// [XID] // 0x0000000189710750-0x0000000189710770
	public static ConfigWidgetAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC3E2 */, bool useObjectPool = false /* Metadata: 0x00AFC3E6 */) => default; // 0x000000018205E100-0x000000018205E2D0
	[BlackList] // 0x0000000189717B50-0x0000000189717B90
	// [XID] // 0x0000000189717B50-0x0000000189717B90
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018205D7C0-0x000000018205DA90
	// [XID] // 0x0000000189722280-0x00000001897222A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018205EBB0-0x000000018205EC60
	[BlackList] // 0x00000001897299A0-0x00000001897299E0
	// [XID] // 0x00000001897299A0-0x00000001897299E0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018205E370-0x000000018205E460
	[BlackList] // 0x00000001897340D0-0x0000000189734110
	// [XID] // 0x00000001897340D0-0x0000000189734110
	public virtual void AutoAllocTypeFields() {} // 0x000000018205DA90-0x000000018205DB30
	[BlackList] // 0x000000018973EF00-0x000000018973EF40
	// [XID] // 0x000000018973EF00-0x000000018973EF40
	public virtual void AutoRecycleTypeFields() {} // 0x000000018205DB30-0x000000018205DBD0
	[BlackList] // 0x00000001897494A0-0x00000001897494E0
	// [XID] // 0x00000001897494A0-0x00000001897494E0
	public virtual void ReturnToObjectPool() {} // 0x000000018205EE50-0x000000018205EEF0
	[BlackList] // 0x00000001897537E0-0x0000000189753820
	// [XID] // 0x00000001897537E0-0x0000000189753820
	public virtual void OnPoolAllocated() {} // 0x000000018205EDB0-0x000000018205EE50
	[BlackList] // 0x000000018975DDB0-0x000000018975DDF0
	// [XID] // 0x000000018975DDB0-0x000000018975DDF0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018205ED10-0x000000018205EDB0
	// [XID] // 0x0000000189768560-0x0000000189768580
	public virtual void DoAction(LCWidget lcWidget, QuickWidgetGeneral widget) {} // 0x000000018205E760-0x000000018205E820
}

