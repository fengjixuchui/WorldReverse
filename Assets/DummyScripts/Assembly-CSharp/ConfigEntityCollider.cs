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
public class ConfigEntityCollider : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18629
{
	// Fields
	private EntityColliderType _type; // 0x10

	// Properties
	public EntityColliderType type { /* [XID] */ /* 0x000000018969AF10-0x000000018969AF30 */ get => default; /* [XID] */ /* 0x00000001896F26D0-0x00000001896F26F0 */ private set {} } // 0x0000000184E739E0-0x0000000184E73A80 0x0000000184E73560-0x0000000184E73610

	// Constructors
	public ConfigEntityCollider() {} // 0x0000000184E73B20-0x0000000184E73B80

	// Methods
	// [XID] // 0x00000001896F9FF0-0x00000001896FA010
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184E737C0-0x0000000184E738A0
	// [XID] // 0x00000001897017E0-0x0000000189701800
	public void InitEmpty() {} // 0x0000000184E731C0-0x0000000184E73260
	[BlackList] // 0x0000000189709020-0x0000000189709060
	// [XID] // 0x0000000189709020-0x0000000189709060
	public bool FromJson(JSONNode node) => default; // 0x0000000184E72E40-0x0000000184E731C0
	// [XID] // 0x00000001897137E0-0x0000000189713800
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184E72680-0x0000000184E72860
	// [XID] // 0x000000018971B000-0x000000018971B020
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA651 */, bool useObjectPool = false /* Metadata: 0x00AFA655 */) => default; // 0x0000000184E73260-0x0000000184E73560
	// [XID] // 0x00000001897223C0-0x00000001897223E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA656 */, bool useObjectPool = false /* Metadata: 0x00AFA65A */) => default; // 0x0000000184E72C70-0x0000000184E72E40
	[BlackList] // 0x0000000189729AC0-0x0000000189729B00
	// [XID] // 0x0000000189729AC0-0x0000000189729B00
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184E72860-0x0000000184E72B30
	// [XID] // 0x00000001897341D0-0x00000001897341F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184E73610-0x0000000184E737C0
	[BlackList] // 0x000000018973B990-0x000000018973B9D0
	// [XID] // 0x000000018973B990-0x000000018973B9D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184E72B30-0x0000000184E72BD0
	[BlackList] // 0x0000000189746280-0x00000001897462C0
	// [XID] // 0x0000000189746280-0x00000001897462C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184E72BD0-0x0000000184E72C70
	[BlackList] // 0x0000000189750A60-0x0000000189750AA0
	// [XID] // 0x0000000189750A60-0x0000000189750AA0
	public virtual void ReturnToObjectPool() {} // 0x0000000184E73A80-0x0000000184E73B20
	[BlackList] // 0x000000018975AEC0-0x000000018975AF00
	// [XID] // 0x000000018975AEC0-0x000000018975AF00
	public virtual void OnPoolAllocated() {} // 0x0000000184E73940-0x0000000184E739E0
	[BlackList] // 0x0000000189765550-0x0000000189765590
	// [XID] // 0x0000000189765550-0x0000000189765590
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184E738A0-0x0000000184E73940
}

