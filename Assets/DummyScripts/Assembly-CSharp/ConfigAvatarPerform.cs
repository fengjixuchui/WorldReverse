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
public class ConfigAvatarPerform : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18020
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigStandbyPerform _standby; // 0x10

	// Properties
	public ConfigStandbyPerform standby { /* [XID] */ /* 0x00000001895F6C20-0x00000001895F6C40 */ get => default; /* [XID] */ /* 0x00000001895FDFC0-0x00000001895FDFE0 */ private set {} } // 0x00000001830F3320-0x00000001830F33C0 0x00000001830F2E70-0x00000001830F2F20

	// Constructors
	public ConfigAvatarPerform() {} // 0x00000001830F3460-0x00000001830F34C0

	// Methods
	// [XID] // 0x0000000189605790-0x00000001896057B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830F3100-0x00000001830F31E0
	// [XID] // 0x000000018960D180-0x000000018960D1A0
	public void InitEmpty() {} // 0x00000001830F2AA0-0x00000001830F2B70
	[BlackList] // 0x0000000189614820-0x0000000189614860
	// [XID] // 0x0000000189614820-0x0000000189614860
	public bool FromJson(JSONNode node) => default; // 0x00000001830F2720-0x00000001830F2AA0
	// [XID] // 0x000000018961F120-0x000000018961F140
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001830F1E40-0x00000001830F2040
	// [XID] // 0x0000000189626560-0x0000000189626580
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86E9 */, bool useObjectPool = false /* Metadata: 0x00AF86ED */) => default; // 0x00000001830F2B70-0x00000001830F2E70
	// [XID] // 0x000000018962DEB0-0x000000018962DED0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86EE */, bool useObjectPool = false /* Metadata: 0x00AF86F2 */) => default; // 0x00000001830F24D0-0x00000001830F2720
	[BlackList] // 0x0000000189635B30-0x0000000189635B70
	// [XID] // 0x0000000189635B30-0x0000000189635B70
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001830F2040-0x00000001830F2310
	// [XID] // 0x000000018963FF10-0x000000018963FF30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001830F2F20-0x00000001830F3100
	[BlackList] // 0x00000001896477D0-0x0000000189647810
	// [XID] // 0x00000001896477D0-0x0000000189647810
	public virtual void AutoAllocTypeFields() {} // 0x00000001830F2310-0x00000001830F23B0
	[BlackList] // 0x0000000189651F00-0x0000000189651F40
	// [XID] // 0x0000000189651F00-0x0000000189651F40
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830F23B0-0x00000001830F24D0
	[BlackList] // 0x000000018965C780-0x000000018965C7C0
	// [XID] // 0x000000018965C780-0x000000018965C7C0
	public virtual void ReturnToObjectPool() {} // 0x00000001830F33C0-0x00000001830F3460
	[BlackList] // 0x0000000189666E70-0x0000000189666EB0
	// [XID] // 0x0000000189666E70-0x0000000189666EB0
	public virtual void OnPoolAllocated() {} // 0x00000001830F3280-0x00000001830F3320
	[BlackList] // 0x0000000189671C20-0x0000000189671C60
	// [XID] // 0x0000000189671C20-0x0000000189671C60
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830F31E0-0x00000001830F3280
}

