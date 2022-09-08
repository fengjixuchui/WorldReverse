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
public class ConfigBeHitEffect : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17925
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private EntityBeHitEffect _entity; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private SceneBeHitEffect _scene; // 0x18

	// Properties
	public EntityBeHitEffect entity { /* [XID] */ /* 0x00000001896F28B0-0x00000001896F28D0 */ get => default; /* [XID] */ /* 0x00000001896FA190-0x00000001896FA1B0 */ private set {} } // 0x0000000181A84B10-0x0000000181A84BB0 0x0000000181A84240-0x0000000181A842F0
	public SceneBeHitEffect scene { /* [XID] */ /* 0x0000000189701960-0x0000000189701980 */ get => default; /* [XID] */ /* 0x0000000189709220-0x0000000189709240 */ private set {} } // 0x0000000181A83E80-0x0000000181A83F20 0x0000000181A84670-0x0000000181A84720

	// Constructors
	public ConfigBeHitEffect() {} // 0x0000000181A85110-0x0000000181A85170

	// Methods
	// [XID] // 0x0000000189710A90-0x0000000189710AB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A84E30-0x0000000181A84F30
	// [XID] // 0x0000000189717DD0-0x0000000189717DF0
	public void InitEmpty() {} // 0x0000000181A84720-0x0000000181A84810
	[BlackList] // 0x000000018971F7B0-0x000000018971F7F0
	// [XID] // 0x000000018971F7B0-0x000000018971F7F0
	public bool FromJson(JSONNode node) => default; // 0x0000000181A842F0-0x0000000181A84670
	// [XID] // 0x0000000189729BE0-0x0000000189729C00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181A83670-0x0000000181A83970
	// [XID] // 0x000000018984BE90-0x000000018984BEB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF823B */, bool useObjectPool = false /* Metadata: 0x00AF823F */) => default; // 0x0000000181A84810-0x0000000181A84B10
	// [XID] // 0x0000000189852DD0-0x0000000189852DF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8240 */, bool useObjectPool = false /* Metadata: 0x00AF8244 */) => default; // 0x0000000181A83F20-0x0000000181A84240
	[BlackList] // 0x00000001897408E0-0x0000000189740920
	// [XID] // 0x00000001897408E0-0x0000000189740920
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181A83970-0x0000000181A83C40
	// [XID] // 0x000000018974B0A0-0x000000018974B0C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A84BB0-0x0000000181A84E30
	[BlackList] // 0x0000000189752110-0x0000000189752150
	// [XID] // 0x0000000189752110-0x0000000189752150
	public virtual void AutoAllocTypeFields() {} // 0x0000000181A83C40-0x0000000181A83CE0
	[BlackList] // 0x000000018975C790-0x000000018975C7D0
	// [XID] // 0x000000018975C790-0x000000018975C7D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181A83CE0-0x0000000181A83E80
	[BlackList] // 0x00000001897670C0-0x0000000189767100
	// [XID] // 0x00000001897670C0-0x0000000189767100
	public virtual void ReturnToObjectPool() {} // 0x0000000181A85070-0x0000000181A85110
	[BlackList] // 0x0000000189771810-0x0000000189771850
	// [XID] // 0x0000000189771810-0x0000000189771850
	public virtual void OnPoolAllocated() {} // 0x0000000181A84FD0-0x0000000181A85070
	[BlackList] // 0x000000018977BD20-0x000000018977BD60
	// [XID] // 0x000000018977BD20-0x000000018977BD60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181A84F30-0x0000000181A84FD0
}

