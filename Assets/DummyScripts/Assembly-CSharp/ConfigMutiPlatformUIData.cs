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
public class ConfigMutiPlatformUIData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18637
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigPlatformUIData> _multiPlatform; // 0x10

	// Properties
	public Dictionary<string, ConfigPlatformUIData> multiPlatform { /* [XID] */ /* 0x0000000189B18A30-0x0000000189B18A50 */ get => default; /* [XID] */ /* 0x0000000189728410-0x0000000189728430 */ private set {} } // 0x000000018402DE40-0x000000018402DEE0 0x000000018402E470-0x000000018402E520

	// Constructors
	public ConfigMutiPlatformUIData() {} // 0x000000018402EDA0-0x000000018402EE00

	// Methods
	// [XID] // 0x000000018972FB70-0x000000018972FB90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018402EAE0-0x000000018402EBC0
	// [XID] // 0x00000001897375A0-0x00000001897375C0
	public void InitEmpty() {} // 0x000000018402E520-0x000000018402E5F0
	[BlackList] // 0x000000018973EFE0-0x000000018973F020
	// [XID] // 0x000000018973EFE0-0x000000018973F020
	public bool FromJson(JSONNode node) => default; // 0x000000018402E0F0-0x000000018402E470
	// [XID] // 0x0000000189A91740-0x0000000189A91760
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018402D830-0x000000018402DA10
	// [XID] // 0x0000000189750A40-0x0000000189750A60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA69D */, bool useObjectPool = false /* Metadata: 0x00AFA6A1 */) => default; // 0x000000018402E5F0-0x000000018402E8F0
	// [XID] // 0x0000000189757E70-0x0000000189757E90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA6A2 */, bool useObjectPool = false /* Metadata: 0x00AFA6A6 */) => default; // 0x000000018402DEE0-0x000000018402E0F0
	[BlackList] // 0x000000018975F990-0x000000018975F9D0
	// [XID] // 0x000000018975F990-0x000000018975F9D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018402DA10-0x000000018402DCE0
	// [XID] // 0x0000000189769E90-0x0000000189769EB0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018402E8F0-0x000000018402EAE0
	[BlackList] // 0x0000000189771630-0x0000000189771670
	// [XID] // 0x0000000189771630-0x0000000189771670
	public virtual void AutoAllocTypeFields() {} // 0x000000018402DCE0-0x000000018402DD80
	[BlackList] // 0x000000018977BC00-0x000000018977BC40
	// [XID] // 0x000000018977BC00-0x000000018977BC40
	public virtual void AutoRecycleTypeFields() {} // 0x000000018402DD80-0x000000018402DE40
	[BlackList] // 0x0000000189786500-0x0000000189786540
	// [XID] // 0x0000000189786500-0x0000000189786540
	public virtual void ReturnToObjectPool() {} // 0x000000018402ED00-0x000000018402EDA0
	[BlackList] // 0x0000000189790A50-0x0000000189790A90
	// [XID] // 0x0000000189790A50-0x0000000189790A90
	public virtual void OnPoolAllocated() {} // 0x000000018402EC60-0x000000018402ED00
	[BlackList] // 0x000000018979BB10-0x000000018979BB50
	// [XID] // 0x000000018979BB10-0x000000018979BB50
	public virtual void OnBeforePoolRecycled() {} // 0x000000018402EBC0-0x000000018402EC60
}

