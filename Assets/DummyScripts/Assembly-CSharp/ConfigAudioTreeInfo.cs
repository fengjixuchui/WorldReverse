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
public class ConfigAudioTreeInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17549
{
	// Fields
	private SimpleSafeFloat detectRadiusRawNum; // 0x10
	private string _dataAssetFolder; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _treeSoundEventName; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _treeNumRtpcName; // 0x28
	private MultiPositionType _multiPositionType; // 0x30
	private AudioTreeDataAssetNamePattern[] _dataAssetNamePatterns; // 0x38

	// Properties
	public float detectRadius { /* [XID] */ /* 0x0000000189A9BE30-0x0000000189A9BE50 */ get => default; /* [XID] */ /* 0x00000001897B7210-0x00000001897B7230 */ private set {} } // 0x00000001840E5570-0x00000001840E5650 0x00000001840E5110-0x00000001840E51F0
	public string dataAssetFolder { /* [XID] */ /* 0x00000001897BF0B0-0x00000001897BF0D0 */ get => default; /* [XID] */ /* 0x00000001897C6640-0x00000001897C6660 */ private set {} } // 0x00000001840E4BA0-0x00000001840E4C40 0x00000001840E2DC0-0x00000001840E2E70
	public ConfigWwiseString treeSoundEventName { /* [XID] */ /* 0x00000001897CDE80-0x00000001897CDEA0 */ get => default; /* [XID] */ /* 0x00000001897D5390-0x00000001897D53B0 */ private set {} } // 0x00000001840E4090-0x00000001840E4130 0x00000001840E4750-0x00000001840E4800
	public ConfigWwiseString treeNumRtpcName { /* [XID] */ /* 0x00000001897DCAD0-0x00000001897DCAF0 */ get => default; /* [XID] */ /* 0x00000001897E4530-0x00000001897E4550 */ private set {} } // 0x00000001840E4B00-0x00000001840E4BA0 0x00000001840E3A60-0x00000001840E3B10
	public MultiPositionType multiPositionType { /* [XID] */ /* 0x00000001897EC000-0x00000001897EC020 */ get => default; /* [XID] */ /* 0x00000001897F3970-0x00000001897F3990 */ private set {} } // 0x00000001840E5650-0x00000001840E56F0 0x00000001840E4130-0x00000001840E41E0
	public AudioTreeDataAssetNamePattern[] dataAssetNamePatterns { /* [XID] */ /* 0x00000001897FB370-0x00000001897FB390 */ get => default; /* [XID] */ /* 0x0000000189802740-0x0000000189802760 */ private set {} } // 0x00000001840E51F0-0x00000001840E5290 0x00000001840E41E0-0x00000001840E4290

	// Constructors
	public ConfigAudioTreeInfo() {} // 0x00000001840E5790-0x00000001840E57F0

	// Methods
	// [XID] // 0x0000000189809DB0-0x0000000189809DD0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840E5290-0x00000001840E5430
	// [XID] // 0x00000001898114E0-0x0000000189811500
	public void InitEmpty() {} // 0x00000001840E4610-0x00000001840E4750
	[BlackList] // 0x0000000189818FF0-0x0000000189819030
	// [XID] // 0x0000000189818FF0-0x0000000189819030
	public bool FromJson(JSONNode node) => default; // 0x00000001840E4290-0x00000001840E4610
	// [XID] // 0x0000000189823290-0x00000001898232B0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001840E2E70-0x00000001840E3520
	// [XID] // 0x000000018982ACB0-0x000000018982ACD0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7289 */, bool useObjectPool = false /* Metadata: 0x00AF728D */) => default; // 0x00000001840E4800-0x00000001840E4B00
	// [XID] // 0x0000000189832150-0x0000000189832170
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF728E */, bool useObjectPool = false /* Metadata: 0x00AF7292 */) => default; // 0x00000001840E3B10-0x00000001840E4090
	[BlackList] // 0x00000001898398A0-0x00000001898398E0
	// [XID] // 0x00000001898398A0-0x00000001898398E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001840E3520-0x00000001840E37F0
	// [XID] // 0x0000000189843F60-0x0000000189843F80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840E4C40-0x00000001840E5110
	[BlackList] // 0x000000018984B3F0-0x000000018984B430
	// [XID] // 0x000000018984B3F0-0x000000018984B430
	public virtual void AutoAllocTypeFields() {} // 0x00000001840E37F0-0x00000001840E3890
	[BlackList] // 0x0000000189855510-0x0000000189855550
	// [XID] // 0x0000000189855510-0x0000000189855550
	public virtual void AutoRecycleTypeFields() {} // 0x00000001840E3890-0x00000001840E3A60
	[BlackList] // 0x000000018985F7F0-0x000000018985F830
	// [XID] // 0x000000018985F7F0-0x000000018985F830
	public virtual void ReturnToObjectPool() {} // 0x00000001840E56F0-0x00000001840E5790
	[BlackList] // 0x000000018986A060-0x000000018986A0A0
	// [XID] // 0x000000018986A060-0x000000018986A0A0
	public virtual void OnPoolAllocated() {} // 0x00000001840E54D0-0x00000001840E5570
	[BlackList] // 0x0000000189874120-0x0000000189874160
	// [XID] // 0x0000000189874120-0x0000000189874160
	public virtual void OnBeforePoolRecycled() {} // 0x00000001840E5430-0x00000001840E54D0
}

