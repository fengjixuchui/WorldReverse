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
public class ConfigWidgetTakePhoto : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19147
{
	// Fields
	private bool _hasCameraEffect; // 0x30
	private string _cameraUIEffect; // 0x38
	private string _cameraScreenEffect; // 0x40
	private string _mainCameraEffect; // 0x48

	// Properties
	public bool hasCameraEffect { /* [XID] */ /* 0x00000001896E8140-0x00000001896E8160 */ get => default; /* [XID] */ /* 0x00000001896EF7E0-0x00000001896EF800 */ private set {} } // 0x0000000184FBCD90-0x0000000184FBCE30 0x0000000184FBC2C0-0x0000000184FBC370
	public string cameraUIEffect { /* [XID] */ /* 0x00000001896F7110-0x00000001896F7130 */ get => default; /* [XID] */ /* 0x00000001896FEAF0-0x00000001896FEB10 */ private set {} } // 0x0000000184FBC370-0x0000000184FBC410 0x0000000184FBE1C0-0x0000000184FBE270
	public string cameraScreenEffect { /* [XID] */ /* 0x0000000189705DA0-0x0000000189705DC0 */ get => default; /* [XID] */ /* 0x000000018970D6F0-0x000000018970D710 */ private set {} } // 0x0000000184FBD8C0-0x0000000184FBD960 0x0000000184FBD960-0x0000000184FBDA10
	public string mainCameraEffect { /* [XID] */ /* 0x0000000189714B50-0x0000000189714B70 */ get => default; /* [XID] */ /* 0x000000018971C520-0x000000018971C540 */ private set {} } // 0x0000000184FBD0C0-0x0000000184FBD160 0x0000000184FBD2E0-0x0000000184FBD390

	// Constructors
	public ConfigWidgetTakePhoto() {} // 0x0000000184FBE460-0x0000000184FBE4D0

	// Methods
	// [XID] // 0x0000000189723A50-0x0000000189723A70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184FBE270-0x0000000184FBE3C0
	// [XID] // 0x000000018972B110-0x000000018972B130
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184FBDD20-0x0000000184FBDE30
	// [XID] // 0x00000001897328C0-0x00000001897328E0
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC35D */) => default; // 0x0000000184FBD7E0-0x0000000184FBD8C0
	// [XID] // 0x000000018973A030-0x000000018973A050
	public override int GetHashNum() => default; // 0x0000000184FBC1F0-0x0000000184FBC2C0
	// [XID] // 0x0000000189741BC0-0x0000000189741BE0
	public override void InitEmpty() {} // 0x0000000184FBD160-0x0000000184FBD260
	[BlackList] // 0x00000001897494E0-0x0000000189749520
	// [XID] // 0x00000001897494E0-0x0000000189749520
	public override bool FromJson(JSONNode node) => default; // 0x0000000184FBCA10-0x0000000184FBCD90
	// [XID] // 0x0000000189753820-0x0000000189753840
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184FBB810-0x0000000184FBBCB0
	[BlackList] // 0x000000018975AD40-0x000000018975AD80
	// [XID] // 0x000000018975AD40-0x000000018975AD80
	public static new ConfigWidgetTakePhoto ParseFromJson(JSONNode node) => default; // 0x0000000184FBDA70-0x0000000184FBDCC0
	// [XID] // 0x0000000189765410-0x0000000189765430
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC35E */, bool useObjectPool = false /* Metadata: 0x00AFC362 */) => default; // 0x0000000184FBD4E0-0x0000000184FBD7E0
	// [XID] // 0x000000018976CE60-0x000000018976CE80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC363 */, bool useObjectPool = false /* Metadata: 0x00AFC367 */) => default; // 0x0000000184FBC4F0-0x0000000184FBC910
	// [XID] // 0x00000001897742D0-0x00000001897742F0
	public static new ConfigWidgetTakePhoto ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC368 */, bool useObjectPool = false /* Metadata: 0x00AFC36C */) => default; // 0x0000000184FBCE30-0x0000000184FBD050
	[BlackList] // 0x000000018977BAE0-0x000000018977BB20
	// [XID] // 0x000000018977BAE0-0x000000018977BB20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184FBBCB0-0x0000000184FBBF80
	// [XID] // 0x0000000189786440-0x0000000189786460
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184FBDE30-0x0000000184FBE1C0
	[BlackList] // 0x000000018978DAB0-0x000000018978DAF0
	// [XID] // 0x000000018978DAB0-0x000000018978DAF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184FBD3F0-0x0000000184FBD4E0
	[BlackList] // 0x00000001897982C0-0x0000000189798300
	// [XID] // 0x00000001897982C0-0x0000000189798300
	public override void AutoAllocTypeFields() {} // 0x0000000184FBBF80-0x0000000184FBC020
	[BlackList] // 0x00000001897A2EA0-0x00000001897A2EE0
	// [XID] // 0x00000001897A2EA0-0x00000001897A2EE0
	public override void AutoRecycleTypeFields() {} // 0x0000000184FBC020-0x0000000184FBC0D0
	[BlackList] // 0x00000001897AD610-0x00000001897AD650
	// [XID] // 0x00000001897AD610-0x00000001897AD650
	public override void ReturnToObjectPool() {} // 0x0000000184FBE3C0-0x0000000184FBE460
}

