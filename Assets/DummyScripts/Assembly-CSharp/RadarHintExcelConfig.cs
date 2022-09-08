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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class RadarHintExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15641
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _name; // 0x18
	protected SimpleSafeFloat radiusRawNum; // 0x20
	protected SimpleSafeFloat offsetRadiusRawNum; // 0x24
	protected SimpleSafeFloat areaRadiusRawNum; // 0x28
	protected string _effectName; // 0x30
	protected string _iconName; // 0x38
	protected string _audioName; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189641C40-0x0000000189641C60 */ get => default; /* [XID] */ /* 0x0000000189649500-0x0000000189649520 */ protected set {} } // 0x00000001817192F0-0x00000001817193C0 0x0000000181718420-0x0000000181718500
	public string name { /* [XID] */ /* 0x0000000189650B30-0x0000000189650B50 */ get => default; /* [XID] */ /* 0x0000000189658350-0x0000000189658370 */ protected set {} } // 0x0000000181719550-0x00000001817195F0 0x0000000181718370-0x0000000181718420
	public float radius { /* [XID] */ /* 0x000000018965F940-0x000000018965F960 */ get => default; /* [XID] */ /* 0x00000001896673D0-0x00000001896673F0 */ protected set {} } // 0x0000000181719030-0x0000000181719110 0x0000000181719470-0x0000000181719550
	public float offsetRadius { /* [XID] */ /* 0x000000018966EBE0-0x000000018966EC00 */ get => default; /* [XID] */ /* 0x0000000189676600-0x0000000189676620 */ protected set {} } // 0x0000000181718D30-0x0000000181718E10 0x0000000181717920-0x0000000181717A00
	public float areaRadius { /* [XID] */ /* 0x000000018967DDC0-0x000000018967DDE0 */ get => default; /* [XID] */ /* 0x00000001896854E0-0x0000000189685500 */ protected set {} } // 0x0000000181718E10-0x0000000181718EF0 0x0000000181718500-0x00000001817185E0
	public string effectName { /* [XID] */ /* 0x000000018968CFA0-0x000000018968CFC0 */ get => default; /* [XID] */ /* 0x0000000189694B60-0x0000000189694B80 */ protected set {} } // 0x0000000181719110-0x00000001817191B0 0x00000001817175E0-0x0000000181717690
	public string iconName { /* [XID] */ /* 0x000000018969C2E0-0x000000018969C300 */ get => default; /* [XID] */ /* 0x00000001896A37C0-0x00000001896A37E0 */ protected set {} } // 0x0000000181718F90-0x0000000181719030 0x00000001817193C0-0x0000000181719470
	public string audioName { /* [XID] */ /* 0x00000001896AAC30-0x00000001896AAC50 */ get => default; /* [XID] */ /* 0x00000001896B1C10-0x00000001896B1C30 */ protected set {} } // 0x0000000181718EF0-0x0000000181718F90 0x0000000181717690-0x0000000181717740

	// Constructors
	public RadarHintExcelConfig() {} // 0x0000000181719690-0x00000001817196F0

	// Methods
	// [IDTag] // 0x00000001896B96B0-0x00000001896B96F0
	// [XID] // 0x00000001896B96B0-0x00000001896B96F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181717EB0-0x0000000181718370
	// [IDTag] // 0x00000001896C3A20-0x00000001896C3A60
	// [XID] // 0x00000001896C3A20-0x00000001896C3A60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181717A00-0x0000000181717EB0
	// [XID] // 0x00000001896CE150-0x00000001896CE170
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2170 */, bool useObjectPool = false /* Metadata: 0x00AF2174 */) => default; // 0x00000001817185E0-0x0000000181718D30
	[BlackList] // 0x00000001896D5680-0x00000001896D56C0
	// [XID] // 0x00000001896D5680-0x00000001896D56C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181717740-0x00000001817177E0
	[BlackList] // 0x00000001896DFE60-0x00000001896DFEA0
	// [XID] // 0x00000001896DFE60-0x00000001896DFEA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817177E0-0x0000000181717920
	[BlackList] // 0x00000001896EA2A0-0x00000001896EA2E0
	// [XID] // 0x00000001896EA2A0-0x00000001896EA2E0
	public virtual void ReturnToObjectPool() {} // 0x00000001817195F0-0x0000000181719690
	[BlackList] // 0x00000001896F4780-0x00000001896F47C0
	// [XID] // 0x00000001896F4780-0x00000001896F47C0
	public virtual void OnPoolAllocated() {} // 0x0000000181719250-0x00000001817192F0
	[BlackList] // 0x00000001896FF130-0x00000001896FF170
	// [XID] // 0x00000001896FF130-0x00000001896FF170
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817191B0-0x0000000181719250
}

