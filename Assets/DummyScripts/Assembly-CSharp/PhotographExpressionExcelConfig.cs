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
public class PhotographExpressionExcelConfig : FetterConfig, IAutoAllocRecycle // TypeDefIndex: 15948
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected string _emotionName; // 0x28
	protected string _phonemeName; // 0x30
	protected string _icon; // 0x38
	protected uint _emotionDescriptionTextMapHash; // 0x40
	protected uint _unlockDescTextMapHash; // 0x44

	// Properties
	public string emotionName { /* [XID] */ /* 0x00000001899DEFB0-0x00000001899DEFD0 */ get => default; /* [XID] */ /* 0x00000001899E6C10-0x00000001899E6C30 */ protected set {} } // 0x00000001819AF4F0-0x00000001819AF590 0x00000001819AD670-0x00000001819AD720
	public string phonemeName { /* [XID] */ /* 0x00000001899EE0A0-0x00000001899EE0C0 */ get => default; /* [XID] */ /* 0x00000001899F5950-0x00000001899F5970 */ protected set {} } // 0x00000001819AD530-0x00000001819AD5D0 0x00000001819AE660-0x00000001819AE710
	public string icon { /* [XID] */ /* 0x00000001899FD110-0x00000001899FD130 */ get => default; /* [XID] */ /* 0x0000000189A045D0-0x0000000189A045F0 */ protected set {} } // 0x00000001819AD330-0x00000001819AD3D0 0x00000001819AF5F0-0x00000001819AF6A0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint emotionDescriptionTextMapHash { /* [XID] */ /* 0x0000000189A0BD50-0x0000000189A0BD70 */ get => default; /* [XID] */ /* 0x0000000189A13600-0x0000000189A13620 */ protected set {} } // 0x00000001819AD720-0x00000001819AD7C0 0x00000001819AF440-0x00000001819AF4F0
	public string emotionDescription { /* [XID] */ /* 0x0000000189A1A770-0x0000000189A1A790 */ get => default; } // 0x00000001819AF2C0-0x00000001819AF440 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unlockDescTextMapHash { /* [XID] */ /* 0x0000000189A21FF0-0x0000000189A22010 */ get => default; /* [XID] */ /* 0x0000000189A29440-0x0000000189A29460 */ protected set {} } // 0x00000001819AE890-0x00000001819AE930 0x00000001819AE930-0x00000001819AE9E0
	public string unlockDesc { /* [XID] */ /* 0x0000000189A30A10-0x0000000189A30A30 */ get => default; } // 0x00000001819AE710-0x00000001819AE890 

	// Constructors
	public PhotographExpressionExcelConfig() {} // 0x00000001819AF740-0x00000001819AF7A0

	// Methods
	// [IDTag] // 0x0000000189A38430-0x0000000189A38470
	// [XID] // 0x0000000189A38430-0x0000000189A38470
	public virtual bool ParseFromLine(string line) => default; // 0x00000001819ADEE0-0x00000001819AE660
	// [IDTag] // 0x0000000189A42BF0-0x0000000189A42C30
	// [XID] // 0x0000000189A42BF0-0x0000000189A42C30
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001819AD820-0x00000001819ADEE0
	// [XID] // 0x0000000189A4D200-0x0000000189A4D220
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BF7 */, bool useObjectPool = false /* Metadata: 0x00AF2BFB */) => default; // 0x00000001819AEAD0-0x00000001819AF2C0
	[BlackList] // 0x0000000189A54930-0x0000000189A54970
	// [XID] // 0x0000000189A54930-0x0000000189A54970
	public override void AutoAllocTypeFields() {} // 0x00000001819AD3D0-0x00000001819AD470
	[BlackList] // 0x0000000189A5F2D0-0x0000000189A5F310
	// [XID] // 0x0000000189A5F2D0-0x0000000189A5F310
	public override void AutoRecycleTypeFields() {} // 0x00000001819AD470-0x00000001819AD530
	[BlackList] // 0x0000000189A69E90-0x0000000189A69ED0
	// [XID] // 0x0000000189A69E90-0x0000000189A69ED0
	public override void ReturnToObjectPool() {} // 0x00000001819AF6A0-0x00000001819AF740
}

