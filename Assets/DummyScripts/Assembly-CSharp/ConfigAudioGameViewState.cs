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
public class ConfigAudioGameViewState : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17586
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stateGroupName; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _normalStateValue; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _focusedStateValue; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _sneakInStateValue; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _menuStateValue; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _pauseMenuStateValue; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _dialogStateValue; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _videoStateValue; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _elementViewStateValue; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _musicGameSoloStateValue; // 0x58
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _musicGameFreePlayStateValue; // 0x60
	private string[] _uiPageIgnoreList; // 0x68

	// Properties
	public ConfigWwiseString stateGroupName { /* [XID] */ /* 0x0000000189B31BF0-0x0000000189B31C10 */ get => default; /* [XID] */ /* 0x00000001897BF050-0x00000001897BF070 */ private set {} } // 0x000000018549E6F0-0x000000018549E790 0x000000018549F160-0x000000018549F210
	public ConfigWwiseString normalStateValue { /* [XID] */ /* 0x00000001897C6620-0x00000001897C6640 */ get => default; /* [XID] */ /* 0x00000001897CDE40-0x00000001897CDE60 */ private set {} } // 0x000000018549F420-0x000000018549F4C0 0x000000018549F0B0-0x000000018549F160
	public ConfigWwiseString focusedStateValue { /* [XID] */ /* 0x00000001897D5350-0x00000001897D5370 */ get => default; /* [XID] */ /* 0x00000001897DCA70-0x00000001897DCA90 */ private set {} } // 0x00000001854A0380-0x00000001854A0420 0x00000001854A02D0-0x00000001854A0380
	public ConfigWwiseString sneakInStateValue { /* [XID] */ /* 0x00000001897E4490-0x00000001897E44B0 */ get => default; /* [XID] */ /* 0x00000001897EBFE0-0x00000001897EC000 */ private set {} } // 0x000000018549ED80-0x000000018549EE20 0x00000001854A0220-0x00000001854A02D0
	public ConfigWwiseString menuStateValue { /* [XID] */ /* 0x00000001897F3950-0x00000001897F3970 */ get => default; /* [XID] */ /* 0x00000001897FB350-0x00000001897FB370 */ private set {} } // 0x000000018549EED0-0x000000018549EF70 0x000000018549D570-0x000000018549D620
	public ConfigWwiseString pauseMenuStateValue { /* [XID] */ /* 0x00000001899961E0-0x0000000189996200 */ get => default; /* [XID] */ /* 0x0000000189809D90-0x0000000189809DB0 */ private set {} } // 0x000000018549E180-0x000000018549E220 0x000000018549E930-0x000000018549E9E0
	public ConfigWwiseString dialogStateValue { /* [XID] */ /* 0x00000001898114C0-0x00000001898114E0 */ get => default; /* [XID] */ /* 0x0000000189818F90-0x0000000189818FB0 */ private set {} } // 0x000000018549F010-0x000000018549F0B0 0x000000018549BE40-0x000000018549BEF0
	public ConfigWwiseString videoStateValue { /* [XID] */ /* 0x00000001898207D0-0x00000001898207F0 */ get => default; /* [XID] */ /* 0x0000000189827E20-0x0000000189827E40 */ private set {} } // 0x000000018549E650-0x000000018549E6F0 0x000000018549F2C0-0x000000018549F370
	public ConfigWwiseString elementViewStateValue { /* [XID] */ /* 0x000000018999DC20-0x000000018999DC40 */ get => default; /* [XID] */ /* 0x00000001898369B0-0x00000001898369D0 */ private set {} } // 0x000000018549EF70-0x000000018549F010 0x000000018549F210-0x000000018549F2C0
	public ConfigWwiseString musicGameSoloStateValue { /* [XID] */ /* 0x000000018983DD80-0x000000018983DDA0 */ get => default; /* [XID] */ /* 0x00000001898455B0-0x00000001898455D0 */ private set {} } // 0x000000018549D4D0-0x000000018549D570 0x000000018549EE20-0x000000018549EED0
	public ConfigWwiseString musicGameFreePlayStateValue { /* [XID] */ /* 0x000000018984CAE0-0x000000018984CB00 */ get => default; /* [XID] */ /* 0x0000000189853B80-0x0000000189853BA0 */ private set {} } // 0x000000018549BEF0-0x000000018549BF90 0x000000018549E5A0-0x000000018549E650
	public string[] uiPageIgnoreList { /* [XID] */ /* 0x000000018985B590-0x000000018985B5B0 */ get => default; /* [XID] */ /* 0x0000000189862B70-0x0000000189862B90 */ private set {} } // 0x000000018549E9E0-0x000000018549EA80 0x000000018549F370-0x000000018549F420

	// Constructors
	public ConfigAudioGameViewState() {} // 0x00000001854A04C0-0x00000001854A0520

	// Methods
	// [XID] // 0x000000018986A020-0x000000018986A040
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018549FDF0-0x00000001854A00E0
	// [XID] // 0x0000000189871390-0x00000001898713B0
	public void InitEmpty() {} // 0x000000018549E790-0x000000018549E930
	[BlackList] // 0x0000000189878D70-0x0000000189878DB0
	// [XID] // 0x0000000189878D70-0x0000000189878DB0
	public bool FromJson(JSONNode node) => default; // 0x000000018549E220-0x000000018549E5A0
	// [XID] // 0x0000000189882DD0-0x0000000189882DF0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018549BF90-0x000000018549CBD0
	// [XID] // 0x000000018988A630-0x000000018988A650
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73CF */, bool useObjectPool = false /* Metadata: 0x00AF73D3 */) => default; // 0x000000018549EA80-0x000000018549ED80
	// [XID] // 0x0000000189891AA0-0x0000000189891AC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73D4 */, bool useObjectPool = false /* Metadata: 0x00AF73D8 */) => default; // 0x000000018549D620-0x000000018549E180
	[BlackList] // 0x00000001898993D0-0x0000000189899410
	// [XID] // 0x00000001898993D0-0x0000000189899410
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018549CBD0-0x000000018549CEA0
	// [XID] // 0x00000001898A3720-0x00000001898A3740
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018549F4C0-0x000000018549FDF0
	[BlackList] // 0x00000001898AAB60-0x00000001898AABA0
	// [XID] // 0x00000001898AAB60-0x00000001898AABA0
	public virtual void AutoAllocTypeFields() {} // 0x000000018549CEA0-0x000000018549CF40
	[BlackList] // 0x00000001898B54D0-0x00000001898B5510
	// [XID] // 0x00000001898B54D0-0x00000001898B5510
	public virtual void AutoRecycleTypeFields() {} // 0x000000018549CF40-0x000000018549D4D0
	[BlackList] // 0x00000001898BFD80-0x00000001898BFDC0
	// [XID] // 0x00000001898BFD80-0x00000001898BFDC0
	public virtual void ReturnToObjectPool() {} // 0x00000001854A0420-0x00000001854A04C0
	[BlackList] // 0x00000001898CA560-0x00000001898CA5A0
	// [XID] // 0x00000001898CA560-0x00000001898CA5A0
	public virtual void OnPoolAllocated() {} // 0x00000001854A0180-0x00000001854A0220
	[BlackList] // 0x00000001898D4D30-0x00000001898D4D70
	// [XID] // 0x00000001898D4D30-0x00000001898D4D70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001854A00E0-0x00000001854A0180
}

