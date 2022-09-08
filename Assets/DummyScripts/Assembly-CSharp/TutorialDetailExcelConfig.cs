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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TutorialDetailExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16250
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected TutorialDetailType _type; // 0x14
	protected uint _nameTextMapHash; // 0x18
	protected string[] _imageNameList; // 0x20
	protected uint _descriptTextMapHash; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189777870-0x0000000189777890 */ get => default; /* [XID] */ /* 0x000000018977EEE0-0x000000018977EF00 */ protected set {} } // 0x00000001833800C0-0x0000000183380190 0x000000018337F6A0-0x000000018337F780
	public TutorialDetailType type { /* [XID] */ /* 0x00000001897868E0-0x0000000189786900 */ get => default; /* [XID] */ /* 0x000000018978DEF0-0x000000018978DF10 */ protected set {} } // 0x0000000183380190-0x0000000183380230 0x000000018337FE30-0x000000018337FEE0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189795660-0x0000000189795680 */ get => default; /* [XID] */ /* 0x000000018979DAD0-0x000000018979DAF0 */ protected set {} } // 0x000000018337EA10-0x000000018337EAB0 0x000000018337FD80-0x000000018337FE30
	public string name { /* [XID] */ /* 0x00000001897A4DF0-0x00000001897A4E10 */ get => default; } // 0x0000000183380230-0x00000001833803B0 
	public string[] imageNameList { /* [XID] */ /* 0x00000001897AC360-0x00000001897AC380 */ get => default; /* [XID] */ /* 0x00000001897B4310-0x00000001897B4330 */ protected set {} } // 0x000000018337FEE0-0x000000018337FF80 0x000000018337FCD0-0x000000018337FD80
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descriptTextMapHash { /* [XID] */ /* 0x00000001897BBFB0-0x00000001897BBFD0 */ get => default; /* [XID] */ /* 0x00000001897C3750-0x00000001897C3770 */ protected set {} } // 0x000000018337EAB0-0x000000018337EB50 0x00000001833803B0-0x0000000183380460
	public string descript { /* [XID] */ /* 0x00000001897CAF30-0x00000001897CAF50 */ get => default; } // 0x000000018337E710-0x000000018337E890 

	// Constructors
	public TutorialDetailExcelConfig() {} // 0x0000000183380500-0x0000000183380560

	// Methods
	// [IDTag] // 0x00000001897D2610-0x00000001897D2650
	// [XID] // 0x00000001897D2610-0x00000001897D2650
	public virtual bool ParseFromLine(string line) => default; // 0x000000018337EB50-0x000000018337F110
	// [IDTag] // 0x00000001897DCD90-0x00000001897DCDD0
	// [XID] // 0x00000001897DCD90-0x00000001897DCDD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018337F110-0x000000018337F6A0
	// [XID] // 0x00000001897E7610-0x00000001897E7630
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF358A */, bool useObjectPool = false /* Metadata: 0x00AF358E */) => default; // 0x000000018337F780-0x000000018337FCD0
	[BlackList] // 0x00000001897EF1B0-0x00000001897EF1F0
	// [XID] // 0x00000001897EF1B0-0x00000001897EF1F0
	public virtual void AutoAllocTypeFields() {} // 0x000000018337E890-0x000000018337E930
	[BlackList] // 0x00000001897F9CA0-0x00000001897F9CE0
	// [XID] // 0x00000001897F9CA0-0x00000001897F9CE0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018337E930-0x000000018337EA10
	[BlackList] // 0x00000001898041D0-0x0000000189804210
	// [XID] // 0x00000001898041D0-0x0000000189804210
	public virtual void ReturnToObjectPool() {} // 0x0000000183380460-0x0000000183380500
	[BlackList] // 0x000000018980E790-0x000000018980E7D0
	// [XID] // 0x000000018980E790-0x000000018980E7D0
	public virtual void OnPoolAllocated() {} // 0x0000000183380020-0x00000001833800C0
	[BlackList] // 0x0000000189819290-0x00000001898192D0
	// [XID] // 0x0000000189819290-0x00000001898192D0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018337FF80-0x0000000183380020
}

