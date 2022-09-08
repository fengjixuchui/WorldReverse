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
public class ConfigSpecialCamera : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17696
{
	// Fields
	private SimpleSafeFloat priorityRawNum; // 0x10
	private SimpleSafeFloat enterRadiusRawNum; // 0x14
	private SimpleSafeFloat exitRadiusRawNum; // 0x18
	private SimpleSafeFloat heightAdjustRawNum; // 0x1C
	private SimpleSafeFloat fovRawNum; // 0x20
	private SimpleSafeFloat zoomRawNum; // 0x24
	private SimpleSafeFloat sphericalYRawNum; // 0x28
	private bool _lockSphericalY; // 0x2C
	private SimpleSafeFloat sphericalYUpRawNum; // 0x30
	private SimpleSafeFloat sphericalYDownRawNum; // 0x34
	private SimpleSafeFloat autoTurnStartMinRawNum; // 0x38
	private SimpleSafeFloat autoTurnStartMaxRawNum; // 0x3C
	private SimpleSafeFloat autoTurnEndMinRawNum; // 0x40
	private SimpleSafeFloat autoTurnEndMaxRawNum; // 0x44

	// Properties
	public float priority { /* [XID] */ /* 0x00000001896AD590-0x00000001896AD5B0 */ get => default; /* [XID] */ /* 0x00000001896B4C90-0x00000001896B4CB0 */ private set {} } // 0x0000000185A683D0-0x0000000185A684B0 0x0000000185A674E0-0x0000000185A675C0
	public float enterRadius { /* [XID] */ /* 0x00000001896BC060-0x00000001896BC080 */ get => default; /* [XID] */ /* 0x00000001896C3580-0x00000001896C35A0 */ private set {} } // 0x0000000185A68630-0x0000000185A68710 0x0000000185A675C0-0x0000000185A676A0
	public float exitRadius { /* [XID] */ /* 0x00000001896CAAF0-0x00000001896CAB10 */ get => default; /* [XID] */ /* 0x00000001896D21A0-0x00000001896D21C0 */ private set {} } // 0x0000000185A676A0-0x0000000185A67780 0x0000000185A67F10-0x0000000185A67FF0
	public float heightAdjust { /* [XID] */ /* 0x00000001896D9AB0-0x00000001896D9AD0 */ get => default; /* [XID] */ /* 0x00000001896E11B0-0x00000001896E11D0 */ private set {} } // 0x0000000185A682F0-0x0000000185A683D0 0x0000000185A67160-0x0000000185A67240
	public float fov { /* [XID] */ /* 0x00000001896E8440-0x00000001896E8460 */ get => default; /* [XID] */ /* 0x00000001896EF9E0-0x00000001896EFA00 */ private set {} } // 0x0000000185A684B0-0x0000000185A68590 0x0000000185A67C90-0x0000000185A67D70
	public float zoom { /* [XID] */ /* 0x00000001896F73F0-0x00000001896F7410 */ get => default; /* [XID] */ /* 0x00000001896FED70-0x00000001896FED90 */ private set {} } // 0x0000000185A687F0-0x0000000185A688D0 0x0000000185A66320-0x0000000185A66400
	public float sphericalY { /* [XID] */ /* 0x0000000189705F00-0x0000000189705F20 */ get => default; /* [XID] */ /* 0x000000018970D850-0x000000018970D870 */ private set {} } // 0x0000000185A666A0-0x0000000185A66780 0x0000000185A66400-0x0000000185A664E0
	public bool lockSphericalY { /* [XID] */ /* 0x0000000189714CD0-0x0000000189714CF0 */ get => default; /* [XID] */ /* 0x000000018971C7C0-0x000000018971C7E0 */ private set {} } // 0x0000000185A68590-0x0000000185A68630 0x0000000185A67780-0x0000000185A67830
	public float sphericalYUp { /* [XID] */ /* 0x0000000189723BD0-0x0000000189723BF0 */ get => default; /* [XID] */ /* 0x000000018972B2B0-0x000000018972B2D0 */ private set {} } // 0x0000000185A664E0-0x0000000185A665C0 0x0000000185A69290-0x0000000185A69370
	public float sphericalYDown { /* [XID] */ /* 0x0000000189732B20-0x0000000189732B40 */ get => default; /* [XID] */ /* 0x000000018973A230-0x000000018973A250 */ private set {} } // 0x0000000185A691B0-0x0000000185A69290 0x0000000185A68710-0x0000000185A687F0
	public float autoTurnStartMin { /* [XID] */ /* 0x0000000189741D40-0x0000000189741D60 */ get => default; /* [XID] */ /* 0x0000000189749720-0x0000000189749740 */ private set {} } // 0x0000000185A67320-0x0000000185A67400 0x0000000185A65D10-0x0000000185A65DF0
	public float autoTurnStartMax { /* [XID] */ /* 0x0000000189750BE0-0x0000000189750C00 */ get => default; /* [XID] */ /* 0x0000000189757FD0-0x0000000189757FF0 */ private set {} } // 0x0000000185A67400-0x0000000185A674E0 0x0000000185A67240-0x0000000185A67320
	public float autoTurnEndMin { /* [XID] */ /* 0x000000018975FB50-0x000000018975FB70 */ get => default; /* [XID] */ /* 0x0000000189767100-0x0000000189767120 */ private set {} } // 0x0000000185A64C90-0x0000000185A64D70 0x0000000185A665C0-0x0000000185A666A0
	public float autoTurnEndMax { /* [XID] */ /* 0x000000018976E620-0x000000018976E640 */ get => default; /* [XID] */ /* 0x0000000189776020-0x0000000189776040 */ private set {} } // 0x0000000185A69370-0x0000000185A69450 0x0000000185A67BB0-0x0000000185A67C90

	// Constructors
	public ConfigSpecialCamera() {} // 0x0000000185A69870-0x0000000185A69950

	// Methods
	// [XID] // 0x000000018977D700-0x000000018977D720
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185A69450-0x0000000185A69690
	// [XID] // 0x0000000189784FE0-0x0000000189785000
	public void InitEmpty() {} // 0x0000000185A67D70-0x0000000185A67F10
	[BlackList] // 0x000000018978C470-0x000000018978C4B0
	// [XID] // 0x000000018978C470-0x000000018978C4B0
	public bool FromJson(JSONNode node) => default; // 0x0000000185A67830-0x0000000185A67BB0
	// [XID] // 0x0000000189796BF0-0x0000000189796C10
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185A64D70-0x0000000185A65D10
	// [XID] // 0x000000018979EC90-0x000000018979ECB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF781B */, bool useObjectPool = false /* Metadata: 0x00AF781F */) => default; // 0x0000000185A67FF0-0x0000000185A682F0
	// [XID] // 0x00000001897A6300-0x00000001897A6320
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7820 */, bool useObjectPool = false /* Metadata: 0x00AF7824 */) => default; // 0x0000000185A66780-0x0000000185A67160
	[BlackList] // 0x00000001897AD7F0-0x00000001897AD830
	// [XID] // 0x00000001897AD7F0-0x00000001897AD830
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185A65DF0-0x0000000185A660C0
	// [XID] // 0x00000001897B86C0-0x00000001897B86E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185A688D0-0x0000000185A691B0
	[BlackList] // 0x00000001897C06E0-0x00000001897C0720
	// [XID] // 0x00000001897C06E0-0x00000001897C0720
	public virtual void AutoAllocTypeFields() {} // 0x0000000185A660C0-0x0000000185A66160
	[BlackList] // 0x00000001897CAC90-0x00000001897CACD0
	// [XID] // 0x00000001897CAC90-0x00000001897CACD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185A66160-0x0000000185A66320
	[BlackList] // 0x00000001897D52F0-0x00000001897D5330
	// [XID] // 0x00000001897D52F0-0x00000001897D5330
	public virtual void ReturnToObjectPool() {} // 0x0000000185A697D0-0x0000000185A69870
	[BlackList] // 0x00000001897DFBF0-0x00000001897DFC30
	// [XID] // 0x00000001897DFBF0-0x00000001897DFC30
	public virtual void OnPoolAllocated() {} // 0x0000000185A69730-0x0000000185A697D0
	[BlackList] // 0x00000001897EA5A0-0x00000001897EA5E0
	// [XID] // 0x00000001897EA5A0-0x00000001897EA5E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185A69690-0x0000000185A69730
}

