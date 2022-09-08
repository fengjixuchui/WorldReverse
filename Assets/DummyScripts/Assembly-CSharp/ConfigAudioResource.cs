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
public class ConfigAudioResource : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17619
{
	// Fields
	private string _soundBankPackageName; // 0x10
	private string _externalSourcePackageName; // 0x18
	private string _streamedMusicPackageName; // 0x20
	private string _streamedFilePackageName; // 0x28
	private SimpleSafeUInt8 nSoundBankSplitBitsRawNum; // 0x30
	private SimpleSafeUInt8 nExternalSourceSplitBitsRawNum; // 0x31
	private SimpleSafeUInt8 nStreamedMusicSplitBitsRawNum; // 0x32
	private SimpleSafeUInt8 nStreamedFileSplitBitsRawNum; // 0x33
	private string _packageFileExtension; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigAudioIncrementalResources> _incrementals; // 0x40

	// Properties
	public string soundBankPackageName { /* [XID] */ /* 0x0000000189AAE800-0x0000000189AAE820 */ get => default; /* [XID] */ /* 0x0000000189AB60A0-0x0000000189AB60C0 */ private set {} } // 0x00000001833631B0-0x0000000183363250 0x0000000183363BF0-0x0000000183363CA0
	public string externalSourcePackageName { /* [XID] */ /* 0x000000018997C1D0-0x000000018997C1F0 */ get => default; /* [XID] */ /* 0x0000000189AC5690-0x0000000189AC56B0 */ private set {} } // 0x0000000183363CA0-0x0000000183363D40 0x0000000183362350-0x0000000183362400
	public string streamedMusicPackageName { /* [XID] */ /* 0x0000000189ACCB00-0x0000000189ACCB20 */ get => default; /* [XID] */ /* 0x0000000189AD4900-0x0000000189AD4920 */ private set {} } // 0x0000000183363110-0x00000001833631B0 0x0000000183363400-0x00000001833634B0
	public string streamedFilePackageName { /* [XID] */ /* 0x000000018979A660-0x000000018979A680 */ get => default; /* [XID] */ /* 0x0000000189AE3BD0-0x0000000189AE3BF0 */ private set {} } // 0x0000000183363A00-0x0000000183363AA0 0x00000001833647D0-0x0000000183364880
	public byte nSoundBankSplitBits { /* [XID] */ /* 0x00000001897A2600-0x00000001897A2620 */ get => default; /* [XID] */ /* 0x0000000189AF2E30-0x0000000189AF2E50 */ private set {} } // 0x0000000183362100-0x00000001833621D0 0x0000000183362C00-0x0000000183362CE0
	public byte nExternalSourceSplitBits { /* [XID] */ /* 0x0000000189AFA6A0-0x0000000189AFA6C0 */ get => default; /* [XID] */ /* 0x0000000189B01C30-0x0000000189B01C50 */ private set {} } // 0x0000000183363250-0x0000000183363320 0x0000000183362020-0x0000000183362100
	public byte nStreamedMusicSplitBits { /* [XID] */ /* 0x00000001897B9000-0x00000001897B9020 */ get => default; /* [XID] */ /* 0x0000000189B10C30-0x0000000189B10C50 */ private set {} } // 0x0000000183364880-0x0000000183364950 0x0000000183363320-0x0000000183363400
	public byte nStreamedFileSplitBits { /* [XID] */ /* 0x0000000189B17E00-0x0000000189B17E20 */ get => default; /* [XID] */ /* 0x0000000189B1F660-0x0000000189B1F680 */ private set {} } // 0x0000000183363930-0x0000000183363A00 0x0000000183362270-0x0000000183362350
	public string packageFileExtension { /* [XID] */ /* 0x0000000189784410-0x0000000189784430 */ get => default; /* [XID] */ /* 0x0000000189B2E0D0-0x0000000189B2E0F0 */ private set {} } // 0x0000000183363B50-0x0000000183363BF0 0x0000000183363AA0-0x0000000183363B50
	public Dictionary<string, ConfigAudioIncrementalResources> incrementals { /* [XID] */ /* 0x0000000189B35440-0x0000000189B35460 */ get => default; /* [XID] */ /* 0x0000000189B3CD20-0x0000000189B3CD40 */ private set {} } // 0x00000001833621D0-0x0000000183362270 0x0000000183362CE0-0x0000000183362D90

	// Constructors
	public ConfigAudioResource() {} // 0x00000001833649F0-0x0000000183364A50

	// Methods
	// [XID] // 0x0000000189B44A30-0x0000000189B44A50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833644B0-0x0000000183364690
	// [XID] // 0x0000000189B4C280-0x0000000189B4C2A0
	public void InitEmpty() {} // 0x00000001833634B0-0x0000000183363630
	[BlackList] // 0x0000000189B538A0-0x0000000189B538E0
	// [XID] // 0x0000000189B538A0-0x0000000189B538E0
	public bool FromJson(JSONNode node) => default; // 0x0000000183362D90-0x0000000183363110
	// [XID] // 0x0000000189B5E3A0-0x0000000189B5E3C0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001833610E0-0x0000000183361B60
	// [XID] // 0x0000000189B658C0-0x0000000189B658E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74F7 */, bool useObjectPool = false /* Metadata: 0x00AF74FB */) => default; // 0x0000000183363630-0x0000000183363930
	// [XID] // 0x0000000189B6CE40-0x0000000189B6CE60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74FC */, bool useObjectPool = false /* Metadata: 0x00AF7500 */) => default; // 0x0000000183362400-0x0000000183362C00
	[BlackList] // 0x0000000189B74630-0x0000000189B74670
	// [XID] // 0x0000000189B74630-0x0000000189B74670
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183361B60-0x0000000183361E30
	// [XID] // 0x0000000189B7E980-0x0000000189B7E9A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183363D40-0x00000001833644B0
	[BlackList] // 0x0000000189B86640-0x0000000189B86680
	// [XID] // 0x0000000189B86640-0x0000000189B86680
	public virtual void AutoAllocTypeFields() {} // 0x0000000183361E30-0x0000000183361ED0
	[BlackList] // 0x0000000189B908B0-0x0000000189B908F0
	// [XID] // 0x0000000189B908B0-0x0000000189B908F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183361ED0-0x0000000183362020
	[BlackList] // 0x0000000189B9ABC0-0x0000000189B9AC00
	// [XID] // 0x0000000189B9ABC0-0x0000000189B9AC00
	public virtual void ReturnToObjectPool() {} // 0x0000000183364950-0x00000001833649F0
	[BlackList] // 0x0000000189BA5330-0x0000000189BA5370
	// [XID] // 0x0000000189BA5330-0x0000000189BA5370
	public virtual void OnPoolAllocated() {} // 0x0000000183364730-0x00000001833647D0
	[BlackList] // 0x0000000189BAF4A0-0x0000000189BAF4E0
	// [XID] // 0x0000000189BAF4A0-0x0000000189BAF4E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183364690-0x0000000183364730
}

