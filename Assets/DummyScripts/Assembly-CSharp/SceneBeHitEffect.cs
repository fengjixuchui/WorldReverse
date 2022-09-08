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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class SceneBeHitEffect : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17924
{
	// Fields
	private Dictionary<string, Dictionary<string, string>> _hitSceneEffect; // 0x10

	// Properties
	public Dictionary<string, Dictionary<string, string>> hitSceneEffect { /* [XID] */ /* 0x0000000189657FD0-0x0000000189657FF0 */ get => default; /* [XID] */ /* 0x000000018965F5A0-0x000000018965F5C0 */ private set {} } // 0x0000000184564B30-0x0000000184564BD0 0x0000000184564700-0x00000001845647B0

	// Constructors
	public SceneBeHitEffect() {} // 0x0000000184565450-0x00000001845654B0

	// Methods
	// [XID] // 0x0000000189666ED0-0x0000000189666EF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184565190-0x0000000184565270
	// [XID] // 0x000000018966E620-0x000000018966E640
	public void InitEmpty() {} // 0x0000000184564BD0-0x0000000184564CA0
	[BlackList] // 0x0000000189676280-0x00000001896762C0
	// [XID] // 0x0000000189676280-0x00000001896762C0
	public bool FromJson(JSONNode node) => default; // 0x00000001845647B0-0x0000000184564B30
	// [XID] // 0x00000001896F6870-0x00000001896F6890
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184563F00-0x00000001845640E0
	// [XID] // 0x0000000189688660-0x0000000189688680
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8231 */, bool useObjectPool = false /* Metadata: 0x00AF8235 */) => default; // 0x0000000184564CA0-0x0000000184564FA0
	// [XID] // 0x000000018968FF60-0x000000018968FF80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8236 */, bool useObjectPool = false /* Metadata: 0x00AF823A */) => default; // 0x00000001845644F0-0x0000000184564700
	[BlackList] // 0x00000001896978A0-0x00000001896978E0
	// [XID] // 0x00000001896978A0-0x00000001896978E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001845640E0-0x00000001845643B0
	// [XID] // 0x00000001896A1DE0-0x00000001896A1E00
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184564FA0-0x0000000184565190
	[BlackList] // 0x00000001896A91E0-0x00000001896A9220
	// [XID] // 0x00000001896A91E0-0x00000001896A9220
	public virtual void AutoAllocTypeFields() {} // 0x00000001845643B0-0x0000000184564450
	[BlackList] // 0x00000001896B3310-0x00000001896B3350
	// [XID] // 0x00000001896B3310-0x00000001896B3350
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184564450-0x00000001845644F0
	[BlackList] // 0x00000001896BD720-0x00000001896BD760
	// [XID] // 0x00000001896BD720-0x00000001896BD760
	public virtual void ReturnToObjectPool() {} // 0x00000001845653B0-0x0000000184565450
	[BlackList] // 0x00000001896C7D70-0x00000001896C7DB0
	// [XID] // 0x00000001896C7D70-0x00000001896C7DB0
	public virtual void OnPoolAllocated() {} // 0x0000000184565310-0x00000001845653B0
	[BlackList] // 0x00000001896D2120-0x00000001896D2160
	// [XID] // 0x00000001896D2120-0x00000001896D2160
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184565270-0x0000000184565310
}

