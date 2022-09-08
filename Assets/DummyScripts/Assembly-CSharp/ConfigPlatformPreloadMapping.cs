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
public class ConfigPlatformPreloadMapping : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18805
{
	// Fields
	private Dictionary<ConfigPreloadType, ConfigPreloadType[]> _editor; // 0x10
	private Dictionary<ConfigPreloadType, ConfigPreloadType[]> _win; // 0x18
	private Dictionary<ConfigPreloadType, ConfigPreloadType[]> _android; // 0x20
	private Dictionary<ConfigPreloadType, ConfigPreloadType[]> _ps4; // 0x28
	private Dictionary<ConfigPreloadType, ConfigPreloadType[]> _ios; // 0x30

	// Properties
	public Dictionary<ConfigPreloadType, ConfigPreloadType[]> editor { /* [XID] */ /* 0x0000000189737500-0x0000000189737520 */ get => default; /* [XID] */ /* 0x000000018973EFC0-0x000000018973EFE0 */ private set {} } // 0x00000001849BE3F0-0x00000001849BE490 0x00000001849BCA20-0x00000001849BCAD0
	public Dictionary<ConfigPreloadType, ConfigPreloadType[]> win { /* [XID] */ /* 0x00000001897461E0-0x0000000189746200 */ get => default; /* [XID] */ /* 0x000000018974DDB0-0x000000018974DDD0 */ private set {} } // 0x00000001849BE540-0x00000001849BE5E0 0x00000001849BDB00-0x00000001849BDBB0
	public Dictionary<ConfigPreloadType, ConfigPreloadType[]> android { /* [XID] */ /* 0x0000000189755450-0x0000000189755470 */ get => default; /* [XID] */ /* 0x000000018975C5D0-0x000000018975C5F0 */ private set {} } // 0x00000001849BDA60-0x00000001849BDB00 0x00000001849BD030-0x00000001849BD0E0
	public Dictionary<ConfigPreloadType, ConfigPreloadType[]> ps4 { /* [XID] */ /* 0x0000000189763EE0-0x0000000189763F00 */ get => default; /* [XID] */ /* 0x000000018976B740-0x000000018976B760 */ private set {} } // 0x00000001849BE350-0x00000001849BE3F0 0x00000001849BE490-0x00000001849BE540
	public Dictionary<ConfigPreloadType, ConfigPreloadType[]> ios { /* [XID] */ /* 0x0000000189772CE0-0x0000000189772D00 */ get => default; /* [XID] */ /* 0x000000018977A3A0-0x000000018977A3C0 */ private set {} } // 0x00000001849BED40-0x00000001849BEDE0 0x00000001849BD500-0x00000001849BD5B0

	// Constructors
	public ConfigPlatformPreloadMapping() {} // 0x00000001849BEE80-0x00000001849BEEE0

	// Methods
	// [XID] // 0x0000000189781FE0-0x0000000189782000
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849BEAA0-0x00000001849BEC00
	// [XID] // 0x0000000189789380-0x00000001897893A0
	public void InitEmpty() {} // 0x00000001849BDF30-0x00000001849BE050
	[BlackList] // 0x00000001897909F0-0x0000000189790A30
	// [XID] // 0x00000001897909F0-0x0000000189790A30
	public bool FromJson(JSONNode node) => default; // 0x00000001849BDBB0-0x00000001849BDF30
	// [XID] // 0x000000018979BAF0-0x000000018979BB10
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001849BCAD0-0x00000001849BD030
	// [XID] // 0x00000001897A2F80-0x00000001897A2FA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD43 */, bool useObjectPool = false /* Metadata: 0x00AFAD47 */) => default; // 0x00000001849BE050-0x00000001849BE350
	// [XID] // 0x00000001897AA5A0-0x00000001897AA5C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD48 */, bool useObjectPool = false /* Metadata: 0x00AFAD4C */) => default; // 0x00000001849BD5B0-0x00000001849BDA60
	[BlackList] // 0x00000001897B2010-0x00000001897B2050
	// [XID] // 0x00000001897B2010-0x00000001897B2050
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001849BD0E0-0x00000001849BD3B0
	// [XID] // 0x00000001897BD480-0x00000001897BD4A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849BE5E0-0x00000001849BEAA0
	[BlackList] // 0x00000001897C4840-0x00000001897C4880
	// [XID] // 0x00000001897C4840-0x00000001897C4880
	public virtual void AutoAllocTypeFields() {} // 0x00000001849BD3B0-0x00000001849BD450
	[BlackList] // 0x00000001897CF1D0-0x00000001897CF210
	// [XID] // 0x00000001897CF1D0-0x00000001897CF210
	public virtual void AutoRecycleTypeFields() {} // 0x00000001849BD450-0x00000001849BD500
	[BlackList] // 0x00000001897D9FB0-0x00000001897D9FF0
	// [XID] // 0x00000001897D9FB0-0x00000001897D9FF0
	public virtual void ReturnToObjectPool() {} // 0x00000001849BEDE0-0x00000001849BEE80
	[BlackList] // 0x00000001897E4370-0x00000001897E43B0
	// [XID] // 0x00000001897E4370-0x00000001897E43B0
	public virtual void OnPoolAllocated() {} // 0x00000001849BECA0-0x00000001849BED40
	[BlackList] // 0x00000001897EEDD0-0x00000001897EEE10
	// [XID] // 0x00000001897EEDD0-0x00000001897EEE10
	public virtual void OnBeforePoolRecycled() {} // 0x00000001849BEC00-0x00000001849BECA0
}

