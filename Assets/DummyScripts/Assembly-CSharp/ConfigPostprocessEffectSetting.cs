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
public class ConfigPostprocessEffectSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18158
{
	// Fields
	private bool _useHalfShadows; // 0x10
	private bool _useShadowCache; // 0x11
	private CheckboardType _checkboardType; // 0x14
	private SSAOMode _aoMode; // 0x18
	private bool _enableMotionBlur; // 0x1C
	private MotionBlurQuality _motionBlurQuality; // 0x20

	// Properties
	public bool useHalfShadows { /* [XID] */ /* 0x00000001897359C0-0x00000001897359E0 */ get => default; /* [XID] */ /* 0x000000018973D550-0x000000018973D570 */ private set {} } // 0x000000018423B5E0-0x000000018423B680 0x000000018423C480-0x000000018423C530
	public bool useShadowCache { /* [XID] */ /* 0x00000001897449F0-0x0000000189744A10 */ get => default; /* [XID] */ /* 0x000000018974C700-0x000000018974C720 */ private set {} } // 0x000000018423B540-0x000000018423B5E0 0x000000018423B490-0x000000018423B540
	public CheckboardType checkboardType { /* [XID] */ /* 0x0000000189753980-0x00000001897539A0 */ get => default; /* [XID] */ /* 0x000000018975AF80-0x000000018975AFA0 */ private set {} } // 0x000000018423BAC0-0x000000018423BB60 0x000000018423C680-0x000000018423C730
	public SSAOMode aoMode { /* [XID] */ /* 0x0000000189762910-0x0000000189762930 */ get => default; /* [XID] */ /* 0x0000000189769F30-0x0000000189769F50 */ private set {} } // 0x000000018423C5E0-0x000000018423C680 0x000000018423BEE0-0x000000018423BF90
	public bool enableMotionBlur { /* [XID] */ /* 0x0000000189771730-0x0000000189771750 */ get => default; /* [XID] */ /* 0x0000000189778EA0-0x0000000189778EC0 */ private set {} } // 0x000000018423BF90-0x000000018423C030 0x000000018423C530-0x000000018423C5E0
	public MotionBlurQuality motionBlurQuality { /* [XID] */ /* 0x00000001897805A0-0x00000001897805C0 */ get => default; /* [XID] */ /* 0x0000000189787DA0-0x0000000189787DC0 */ private set {} } // 0x000000018423AA20-0x000000018423AAC0 0x000000018423C0D0-0x000000018423C180

	// Constructors
	public ConfigPostprocessEffectSetting() {} // 0x000000018423CEC0-0x000000018423CF40

	// Methods
	// [XID] // 0x000000018978F2C0-0x000000018978F2E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018423CB70-0x000000018423CCE0
	// [XID] // 0x0000000189796A90-0x0000000189796AB0
	public void InitEmpty() {} // 0x000000018423C030-0x000000018423C0D0
	[BlackList] // 0x000000018979EC10-0x000000018979EC50
	// [XID] // 0x000000018979EC10-0x000000018979EC50
	public bool FromJson(JSONNode node) => default; // 0x000000018423BB60-0x000000018423BEE0
	// [XID] // 0x000000018978E7E0-0x000000018978E800
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018423AAC0-0x000000018423B070
	// [XID] // 0x00000001897B0900-0x00000001897B0920
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8D3B */, bool useObjectPool = false /* Metadata: 0x00AF8D3F */) => default; // 0x000000018423C180-0x000000018423C480
	// [XID] // 0x00000001897B85C0-0x00000001897B85E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8D40 */, bool useObjectPool = false /* Metadata: 0x00AF8D44 */) => default; // 0x000000018423B680-0x000000018423BAC0
	[BlackList] // 0x00000001897C0680-0x00000001897C06C0
	// [XID] // 0x00000001897C0680-0x00000001897C06C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018423B070-0x000000018423B340
	// [XID] // 0x00000001897CABD0-0x00000001897CABF0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018423C730-0x000000018423CB70
	[BlackList] // 0x00000001897D2230-0x00000001897D2270
	// [XID] // 0x00000001897D2230-0x00000001897D2270
	public virtual void AutoAllocTypeFields() {} // 0x000000018423B340-0x000000018423B3E0
	[BlackList] // 0x00000001897DC950-0x00000001897DC990
	// [XID] // 0x00000001897DC950-0x00000001897DC990
	public virtual void AutoRecycleTypeFields() {} // 0x000000018423B3E0-0x000000018423B490
	[BlackList] // 0x00000001897E7090-0x00000001897E70D0
	// [XID] // 0x00000001897E7090-0x00000001897E70D0
	public virtual void ReturnToObjectPool() {} // 0x000000018423CE20-0x000000018423CEC0
	[BlackList] // 0x00000001897F2110-0x00000001897F2150
	// [XID] // 0x00000001897F2110-0x00000001897F2150
	public virtual void OnPoolAllocated() {} // 0x000000018423CD80-0x000000018423CE20
	[BlackList] // 0x00000001897FC980-0x00000001897FC9C0
	// [XID] // 0x00000001897FC980-0x00000001897FC9C0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018423CCE0-0x000000018423CD80
}

