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
public class WeatherTemplateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16278
{
	// Fields
	protected string _templateName; // 0x10
	protected ClimateType _weatherType; // 0x18
	protected SimpleSafeFloat sunnyProbRawNum; // 0x1C
	protected SimpleSafeFloat cloudyProbRawNum; // 0x20
	protected SimpleSafeFloat rainProbRawNum; // 0x24
	protected SimpleSafeFloat thunderstormProbRawNum; // 0x28
	protected SimpleSafeFloat snowProbRawNum; // 0x2C
	protected SimpleSafeFloat mistProbRawNum; // 0x30

	// Properties
	public string templateName { /* [XID] */ /* 0x0000000189BB9C60-0x0000000189BB9C80 */ get => default; /* [XID] */ /* 0x0000000189BC1C90-0x0000000189BC1CB0 */ protected set {} } // 0x00000001833423C0-0x0000000183342460 0x0000000183341370-0x0000000183341420
	public ClimateType weatherType { /* [XID] */ /* 0x0000000189BC9200-0x0000000189BC9220 */ get => default; /* [XID] */ /* 0x0000000189BD0AB0-0x0000000189BD0AD0 */ protected set {} } // 0x0000000183341110-0x00000001833411B0 0x0000000183341060-0x0000000183341110
	public float sunnyProb { /* [XID] */ /* 0x0000000189BD8010-0x0000000189BD8030 */ get => default; /* [XID] */ /* 0x0000000189BDFB40-0x0000000189BDFB60 */ protected set {} } // 0x0000000183341290-0x0000000183341370 0x0000000183341FE0-0x00000001833420C0
	public float cloudyProb { /* [XID] */ /* 0x00000001895EC750-0x00000001895EC770 */ get => default; /* [XID] */ /* 0x00000001895F3C10-0x00000001895F3C30 */ protected set {} } // 0x0000000183341F00-0x0000000183341FE0 0x00000001833420C0-0x00000001833421A0
	public float rainProb { /* [XID] */ /* 0x00000001895FB550-0x00000001895FB570 */ get => default; /* [XID] */ /* 0x0000000189602C50-0x0000000189602C70 */ protected set {} } // 0x0000000183341E20-0x0000000183341F00 0x0000000183341420-0x0000000183341500
	public float thunderstormProb { /* [XID] */ /* 0x000000018960A590-0x000000018960A5B0 */ get => default; /* [XID] */ /* 0x0000000189611D20-0x0000000189611D40 */ protected set {} } // 0x0000000183340530-0x0000000183340610 0x00000001833415E0-0x00000001833416C0
	public float snowProb { /* [XID] */ /* 0x00000001896195E0-0x0000000189619600 */ get => default; /* [XID] */ /* 0x0000000189620B80-0x0000000189620BA0 */ protected set {} } // 0x0000000183342460-0x0000000183342540 0x00000001833411B0-0x0000000183341290
	public float mistProb { /* [XID] */ /* 0x00000001896281B0-0x00000001896281D0 */ get => default; /* [XID] */ /* 0x000000018962F9E0-0x000000018962FA00 */ protected set {} } // 0x0000000183341500-0x00000001833415E0 0x00000001833421A0-0x0000000183342280

	// Constructors
	public WeatherTemplateExcelConfig() {} // 0x00000001833425E0-0x0000000183342640

	// Methods
	// [IDTag] // 0x0000000189637560-0x00000001896375A0
	// [XID] // 0x0000000189637560-0x00000001896375A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183340610-0x0000000183340B40
	// [IDTag] // 0x0000000189641A40-0x0000000189641A80
	// [XID] // 0x0000000189641A40-0x0000000189641A80
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183340B40-0x0000000183341060
	// [XID] // 0x000000018964C3D0-0x000000018964C3F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF363F */, bool useObjectPool = false /* Metadata: 0x00AF3643 */) => default; // 0x00000001833416C0-0x0000000183341E20
	[BlackList] // 0x0000000189653A40-0x0000000189653A80
	// [XID] // 0x0000000189653A40-0x0000000189653A80
	public virtual void AutoAllocTypeFields() {} // 0x0000000183340350-0x00000001833403F0
	[BlackList] // 0x000000018965E050-0x000000018965E090
	// [XID] // 0x000000018965E050-0x000000018965E090
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833403F0-0x0000000183340530
	[BlackList] // 0x0000000189668AE0-0x0000000189668B20
	// [XID] // 0x0000000189668AE0-0x0000000189668B20
	public virtual void ReturnToObjectPool() {} // 0x0000000183342540-0x00000001833425E0
	[BlackList] // 0x00000001896733A0-0x00000001896733E0
	// [XID] // 0x00000001896733A0-0x00000001896733E0
	public virtual void OnPoolAllocated() {} // 0x0000000183342320-0x00000001833423C0
	[BlackList] // 0x000000018967DC40-0x000000018967DC80
	// [XID] // 0x000000018967DC40-0x000000018967DC80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183342280-0x0000000183342320
}

