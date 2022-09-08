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
public class ConfigWidgetToyTakePhoto : ConfigBaseWidgetToy, IAutoAllocRecycle // TypeDefIndex: 19226
{
	// Fields
	private bool _hasCameraEffect; // 0x30
	private string _cameraUIEffect; // 0x38
	private string _cameraScreenEffect; // 0x40
	private string _mainCameraEffect; // 0x48

	// Properties
	public bool hasCameraEffect { /* [XID] */ /* 0x000000018979D450-0x000000018979D470 */ get => default; /* [XID] */ /* 0x00000001897A4730-0x00000001897A4750 */ private set {} } // 0x0000000181928DD0-0x0000000181928E70 0x0000000181928300-0x00000001819283B0
	public string cameraUIEffect { /* [XID] */ /* 0x00000001897ABBE0-0x00000001897ABC00 */ get => default; /* [XID] */ /* 0x00000001897B3C10-0x00000001897B3C30 */ private set {} } // 0x00000001819283B0-0x0000000181928450 0x000000018192A200-0x000000018192A2B0
	public string cameraScreenEffect { /* [XID] */ /* 0x00000001897BB9D0-0x00000001897BB9F0 */ get => default; /* [XID] */ /* 0x00000001897C3290-0x00000001897C32B0 */ private set {} } // 0x0000000181929900-0x00000001819299A0 0x00000001819299A0-0x0000000181929A50
	public string mainCameraEffect { /* [XID] */ /* 0x00000001897CAA50-0x00000001897CAA70 */ get => default; /* [XID] */ /* 0x00000001897D2050-0x00000001897D2070 */ private set {} } // 0x0000000181929100-0x00000001819291A0 0x0000000181929320-0x00000001819293D0

	// Constructors
	public ConfigWidgetToyTakePhoto() {} // 0x000000018192A4A0-0x000000018192A510

	// Methods
	// [XID] // 0x00000001897D9ED0-0x00000001897D9EF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018192A2B0-0x000000018192A400
	// [XID] // 0x00000001897E11A0-0x00000001897E11C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181929D60-0x0000000181929E70
	// [XID] // 0x00000001897E8A10-0x00000001897E8A30
	public override ConfigBaseWidgetToy Clone(bool useObjectPool = false /* Metadata: 0x00AFC5E5 */) => default; // 0x0000000181929820-0x0000000181929900
	// [XID] // 0x00000001897F0640-0x00000001897F0660
	public override int GetHashNum() => default; // 0x0000000181928230-0x0000000181928300
	// [XID] // 0x00000001897F7D40-0x00000001897F7D60
	public override void InitEmpty() {} // 0x00000001819291A0-0x00000001819292A0
	[BlackList] // 0x00000001897FF410-0x00000001897FF450
	// [XID] // 0x00000001897FF410-0x00000001897FF450
	public override bool FromJson(JSONNode node) => default; // 0x0000000181928A50-0x0000000181928DD0
	// [XID] // 0x00000001898099D0-0x00000001898099F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181927850-0x0000000181927CF0
	[BlackList] // 0x0000000189811100-0x0000000189811140
	// [XID] // 0x0000000189811100-0x0000000189811140
	public static new ConfigWidgetToyTakePhoto ParseFromJson(JSONNode node) => default; // 0x0000000181929AB0-0x0000000181929D00
	// [XID] // 0x000000018981BB80-0x000000018981BBA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC5E6 */, bool useObjectPool = false /* Metadata: 0x00AFC5EA */) => default; // 0x0000000181929520-0x0000000181929820
	// [XID] // 0x0000000189822FD0-0x0000000189822FF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC5EB */, bool useObjectPool = false /* Metadata: 0x00AFC5EF */) => default; // 0x0000000181928530-0x0000000181928950
	// [XID] // 0x000000018982A9F0-0x000000018982AA10
	public static new ConfigWidgetToyTakePhoto ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC5F0 */, bool useObjectPool = false /* Metadata: 0x00AFC5F4 */) => default; // 0x0000000181928E70-0x0000000181929090
	[BlackList] // 0x0000000189831E70-0x0000000189831EB0
	// [XID] // 0x0000000189831E70-0x0000000189831EB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181927CF0-0x0000000181927FC0
	// [XID] // 0x000000018983C590-0x000000018983C5B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181929E70-0x000000018192A200
	[BlackList] // 0x0000000189843B60-0x0000000189843BA0
	// [XID] // 0x0000000189843B60-0x0000000189843BA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181929430-0x0000000181929520
	[BlackList] // 0x000000018984E0E0-0x000000018984E120
	// [XID] // 0x000000018984E0E0-0x000000018984E120
	public override void AutoAllocTypeFields() {} // 0x0000000181927FC0-0x0000000181928060
	[BlackList] // 0x0000000189858420-0x0000000189858460
	// [XID] // 0x0000000189858420-0x0000000189858460
	public override void AutoRecycleTypeFields() {} // 0x0000000181928060-0x0000000181928110
	[BlackList] // 0x0000000189862950-0x0000000189862990
	// [XID] // 0x0000000189862950-0x0000000189862990
	public override void ReturnToObjectPool() {} // 0x000000018192A400-0x000000018192A4A0
}

