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
public class ConfigCrowdSceneTagRestriction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17767
{
	// Fields
	private string[] _sceneTags; // 0x10
	private bool _isActive; // 0x18

	// Properties
	public string[] sceneTags { /* [XID] */ /* 0x0000000189872B50-0x0000000189872B70 */ get => default; /* [XID] */ /* 0x000000018987A870-0x000000018987A890 */ private set {} } // 0x0000000181547F10-0x0000000181547FB0 0x00000001815485F0-0x00000001815486A0
	public bool isActive { /* [XID] */ /* 0x00000001898819E0-0x0000000189881A00 */ get => default; /* [XID] */ /* 0x0000000189889020-0x0000000189889040 */ private set {} } // 0x00000001815486A0-0x0000000181548740 0x0000000181547AE0-0x0000000181547B90

	// Constructors
	public ConfigCrowdSceneTagRestriction() {} // 0x0000000181548A30-0x0000000181548AA0

	// Methods
	// [XID] // 0x0000000189890360-0x0000000189890380
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181548740-0x0000000181548850
	// [XID] // 0x00000001898978A0-0x00000001898978C0
	public void InitEmpty() {} // 0x0000000181547FB0-0x0000000181548080
	[BlackList] // 0x000000018989ED40-0x000000018989ED80
	// [XID] // 0x000000018989ED40-0x000000018989ED80
	public bool FromJson(JSONNode node) => default; // 0x0000000181547B90-0x0000000181547F10
	// [XID] // 0x00000001898A9650-0x00000001898A9670
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181547170-0x0000000181547420
	// [XID] // 0x00000001898B0E60-0x00000001898B0E80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B7F */, bool useObjectPool = false /* Metadata: 0x00AF7B83 */) => default; // 0x0000000181548080-0x0000000181548380
	// [XID] // 0x00000001898B8580-0x00000001898B85A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B84 */, bool useObjectPool = false /* Metadata: 0x00AF7B88 */) => default; // 0x0000000181547840-0x0000000181547AE0
	[BlackList] // 0x00000001898BFCE0-0x00000001898BFD20
	// [XID] // 0x00000001898BFCE0-0x00000001898BFD20
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181547420-0x00000001815476F0
	// [XID] // 0x00000001898CA4A0-0x00000001898CA4C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181548380-0x00000001815485F0
	[BlackList] // 0x00000001898D1D50-0x00000001898D1D90
	// [XID] // 0x00000001898D1D50-0x00000001898D1D90
	public virtual void AutoAllocTypeFields() {} // 0x00000001815476F0-0x0000000181547790
	[BlackList] // 0x00000001898DC710-0x00000001898DC750
	// [XID] // 0x00000001898DC710-0x00000001898DC750
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181547790-0x0000000181547840
	[BlackList] // 0x00000001898E74F0-0x00000001898E7530
	// [XID] // 0x00000001898E74F0-0x00000001898E7530
	public virtual void ReturnToObjectPool() {} // 0x0000000181548990-0x0000000181548A30
	[BlackList] // 0x00000001898F1D30-0x00000001898F1D70
	// [XID] // 0x00000001898F1D30-0x00000001898F1D70
	public virtual void OnPoolAllocated() {} // 0x00000001815488F0-0x0000000181548990
	[BlackList] // 0x00000001898FC430-0x00000001898FC470
	// [XID] // 0x00000001898FC430-0x00000001898FC470
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181548850-0x00000001815488F0
}

