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
public class ConfigCanChangeAvatar : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19024
{
	// Fields
	private SimpleSafeFloat normalizeStartRawNum; // 0x10
	private SimpleSafeFloat normalizeEndRawNum; // 0x14

	// Properties
	public float normalizeStart { /* [XID] */ /* 0x0000000189648E20-0x0000000189648E40 */ get => default; /* [XID] */ /* 0x00000001896503D0-0x00000001896503F0 */ private set {} } // 0x0000000185783D40-0x0000000185783E20 0x0000000185783E20-0x0000000185783F00
	public float normalizeEnd { /* [XID] */ /* 0x0000000189657CF0-0x0000000189657D10 */ get => default; /* [XID] */ /* 0x000000018965F3E0-0x000000018965F400 */ private set {} } // 0x0000000185784150-0x0000000185784230 0x0000000185783810-0x00000001857838F0

	// Constructors
	public ConfigCanChangeAvatar() {} // 0x0000000185784EC0-0x0000000185784F70

	// Methods
	// [XID] // 0x0000000189666C70-0x0000000189666C90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185784BD0-0x0000000185784CE0
	// [XID] // 0x000000018966E300-0x000000018966E320
	public void InitEmpty() {} // 0x00000001857845B0-0x0000000185784690
	[BlackList] // 0x00000001896760A0-0x00000001896760E0
	// [XID] // 0x00000001896760A0-0x00000001896760E0
	public bool FromJson(JSONNode node) => default; // 0x0000000185784230-0x00000001857845B0
	// [XID] // 0x0000000189680A20-0x0000000189680A40
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185783500-0x0000000185783810
	// [XID] // 0x0000000189688500-0x0000000189688520
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7D5 */, bool useObjectPool = false /* Metadata: 0x00AFB7D9 */) => default; // 0x0000000185784690-0x0000000185784990
	// [XID] // 0x000000018968FDC0-0x000000018968FDE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7DA */, bool useObjectPool = false /* Metadata: 0x00AFB7DE */) => default; // 0x0000000185783F00-0x0000000185784150
	[BlackList] // 0x0000000189697760-0x00000001896977A0
	// [XID] // 0x0000000189697760-0x00000001896977A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001857838F0-0x0000000185783BC0
	// [XID] // 0x00000001896A1BA0-0x00000001896A1BC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185784990-0x0000000185784BD0
	[BlackList] // 0x00000001896A8FA0-0x00000001896A8FE0
	// [XID] // 0x00000001896A8FA0-0x00000001896A8FE0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185783BC0-0x0000000185783C60
	[BlackList] // 0x00000001896B30B0-0x00000001896B30F0
	// [XID] // 0x00000001896B30B0-0x00000001896B30F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185783C60-0x0000000185783D40
	[BlackList] // 0x00000001896BD5C0-0x00000001896BD600
	// [XID] // 0x00000001896BD5C0-0x00000001896BD600
	public virtual void ReturnToObjectPool() {} // 0x0000000185784E20-0x0000000185784EC0
	[BlackList] // 0x00000001896C7BD0-0x00000001896C7C10
	// [XID] // 0x00000001896C7BD0-0x00000001896C7C10
	public virtual void OnPoolAllocated() {} // 0x0000000185784D80-0x0000000185784E20
	[BlackList] // 0x00000001896D1F80-0x00000001896D1FC0
	// [XID] // 0x00000001896D1F80-0x00000001896D1FC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185784CE0-0x0000000185784D80
}

