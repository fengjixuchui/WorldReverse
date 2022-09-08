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
public class AudioWeatherVoTrigger : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17636
{
	// Fields
	private ConfigWeatherType[] _weatherTypeList; // 0x10
	private bool _weatherTypeIsInclude; // 0x18
	private string[] _weatherList; // 0x20
	private bool _weatherIsInclude; // 0x28
	private ConfigWeatherType[] _previousWeatherTypeList; // 0x30
	private bool _previousWeatherTypeIsInclude; // 0x38
	private string[] _previousWeatherList; // 0x40
	private bool _previousWeatherIsInclude; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private VoiceTriggerIdentity _voTrigger; // 0x50

	// Properties
	public ConfigWeatherType[] weatherTypeList { /* [XID] */ /* 0x0000000189861050-0x0000000189861070 */ get => default; /* [XID] */ /* 0x00000001898688B0-0x00000001898688D0 */ private set {} } // 0x0000000183397C90-0x0000000183397D30 0x00000001833978D0-0x0000000183397980
	public bool weatherTypeIsInclude { /* [XID] */ /* 0x000000018986FCA0-0x000000018986FCC0 */ get => default; /* [XID] */ /* 0x00000001898773D0-0x00000001898773F0 */ private set {} } // 0x0000000183396290-0x0000000183396330 0x00000001833961E0-0x0000000183396290
	public string[] weatherList { /* [XID] */ /* 0x000000018987EC80-0x000000018987ECA0 */ get => default; /* [XID] */ /* 0x0000000189886120-0x0000000189886140 */ private set {} } // 0x0000000183397010-0x00000001833970B0 0x0000000183396D60-0x0000000183396E10
	public bool weatherIsInclude { /* [XID] */ /* 0x000000018988D3A0-0x000000018988D3C0 */ get => default; /* [XID] */ /* 0x0000000189894AD0-0x0000000189894AF0 */ private set {} } // 0x0000000183396CC0-0x0000000183396D60 0x0000000183397820-0x00000001833978D0
	public ConfigWeatherType[] previousWeatherTypeList { /* [XID] */ /* 0x000000018989C060-0x000000018989C080 */ get => default; /* [XID] */ /* 0x00000001898A3700-0x00000001898A3720 */ private set {} } // 0x0000000183396F70-0x0000000183397010 0x0000000183396E10-0x0000000183396EC0
	public bool previousWeatherTypeIsInclude { /* [XID] */ /* 0x00000001898AAB40-0x00000001898AAB60 */ get => default; /* [XID] */ /* 0x00000001898B2470-0x00000001898B2490 */ private set {} } // 0x00000001833957D0-0x0000000183395870 0x0000000183395A40-0x0000000183395AF0
	public string[] previousWeatherList { /* [XID] */ /* 0x00000001898BA1E0-0x00000001898BA200 */ get => default; /* [XID] */ /* 0x00000001898C1540-0x00000001898C1560 */ private set {} } // 0x00000001833966B0-0x0000000183396750 0x00000001833967F0-0x00000001833968A0
	public bool previousWeatherIsInclude { /* [XID] */ /* 0x00000001898C8F00-0x00000001898C8F20 */ get => default; /* [XID] */ /* 0x00000001898D06C0-0x00000001898D06E0 */ private set {} } // 0x0000000183395730-0x00000001833957D0 0x0000000183396EC0-0x0000000183396F70
	public VoiceTriggerIdentity voTrigger { /* [XID] */ /* 0x00000001898D7D40-0x00000001898D7D60 */ get => default; /* [XID] */ /* 0x00000001898DFAA0-0x00000001898DFAC0 */ private set {} } // 0x0000000183396750-0x00000001833967F0 0x00000001833970B0-0x0000000183397160

	// Constructors
	public AudioWeatherVoTrigger() {} // 0x0000000183397DD0-0x0000000183397E30

	// Methods
	// [XID] // 0x00000001898E7590-0x00000001898E75B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183397980-0x0000000183397B50
	// [XID] // 0x00000001898EED80-0x00000001898EEDA0
	public void InitEmpty() {} // 0x00000001833968A0-0x00000001833969C0
	[BlackList] // 0x00000001898F6660-0x00000001898F66A0
	// [XID] // 0x00000001898F6660-0x00000001898F66A0
	public bool FromJson(JSONNode node) => default; // 0x0000000183396330-0x00000001833966B0
	// [XID] // 0x0000000189900F70-0x0000000189900F90
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183394A30-0x0000000183395280
	// [XID] // 0x0000000189908770-0x0000000189908790
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF759F */, bool useObjectPool = false /* Metadata: 0x00AF75A3 */) => default; // 0x00000001833969C0-0x0000000183396CC0
	// [XID] // 0x000000018990FD90-0x000000018990FDB0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75A4 */, bool useObjectPool = false /* Metadata: 0x00AF75A8 */) => default; // 0x0000000183395AF0-0x00000001833961E0
	[BlackList] // 0x0000000189917920-0x0000000189917960
	// [XID] // 0x0000000189917920-0x0000000189917960
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183395280-0x0000000183395550
	// [XID] // 0x0000000189922140-0x0000000189922160
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183397160-0x0000000183397820
	// [XID] // 0x0000000189929900-0x0000000189929920
	public bool CheckConditions(ConfigWeatherType targetWeatherType, string targetWeather, ConfigWeatherType previousWeatherType, string previousWeather) => default; // 0x0000000183395870-0x0000000183395A40
	[BlackList] // 0x0000000189930F00-0x0000000189930F40
	// [XID] // 0x0000000189930F00-0x0000000189930F40
	public virtual void AutoAllocTypeFields() {} // 0x0000000183395550-0x00000001833955F0
	[BlackList] // 0x000000018993B870-0x000000018993B8B0
	// [XID] // 0x000000018993B870-0x000000018993B8B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833955F0-0x0000000183395730
	[BlackList] // 0x0000000189945C00-0x0000000189945C40
	// [XID] // 0x0000000189945C00-0x0000000189945C40
	public virtual void ReturnToObjectPool() {} // 0x0000000183397D30-0x0000000183397DD0
	[BlackList] // 0x00000001899503B0-0x00000001899503F0
	// [XID] // 0x00000001899503B0-0x00000001899503F0
	public virtual void OnPoolAllocated() {} // 0x0000000183397BF0-0x0000000183397C90
	[BlackList] // 0x000000018995A990-0x000000018995A9D0
	// [XID] // 0x000000018995A990-0x000000018995A9D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183397B50-0x0000000183397BF0
}

