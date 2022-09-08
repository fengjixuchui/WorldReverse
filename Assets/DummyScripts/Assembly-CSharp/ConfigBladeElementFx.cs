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
using SimpleJSON;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigBladeElementFx : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18102
{
	// Fields
	private string _slash; // 0x10
	private string _colorA; // 0x18
	private string _colorB; // 0x20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public Color color1; // 0x28
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public Color color2; // 0x38
	private bool _parsed; // 0x48

	// Properties
	public string slash { /* [XID] */ /* 0x0000000189A8C330-0x0000000189A8C350 */ get => default; /* [XID] */ /* 0x0000000189A937B0-0x0000000189A937D0 */ private set {} } // 0x0000000184547950-0x00000001845479F0 0x0000000184548210-0x00000001845482C0
	public string colorA { /* [XID] */ /* 0x0000000189A9B3C0-0x0000000189A9B3E0 */ get => default; /* [XID] */ /* 0x0000000189AA2740-0x0000000189AA2760 */ private set {} } // 0x0000000184548580-0x0000000184548620 0x0000000184547E60-0x0000000184547F10
	public string colorB { /* [XID] */ /* 0x00000001899EE730-0x00000001899EE750 */ get => default; /* [XID] */ /* 0x0000000189AB1BC0-0x0000000189AB1BE0 */ private set {} } // 0x0000000184546CD0-0x0000000184546D70 0x00000001845478A0-0x0000000184547950

	// Constructors
	public ConfigBladeElementFx() {} // 0x0000000184548BF0-0x0000000184548C50

	// Methods
	// [XID] // 0x0000000189AB8EF0-0x0000000189AB8F10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184548620-0x0000000184548740
	// [XID] // 0x0000000189AC0970-0x0000000189AC0990
	public void InitEmpty() {} // 0x0000000184547D70-0x0000000184547E60
	[BlackList] // 0x0000000189AC8390-0x0000000189AC83D0
	// [XID] // 0x0000000189AC8390-0x0000000189AC83D0
	public bool FromJson(JSONNode node) => default; // 0x00000001845479F0-0x0000000184547D70
	// [XID] // 0x0000000189AD2DE0-0x0000000189AD2E00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184546D70-0x0000000184547110
	// [XID] // 0x0000000189ADA8A0-0x0000000189ADA8C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B13 */, bool useObjectPool = false /* Metadata: 0x00AF8B17 */) => default; // 0x0000000184547F10-0x0000000184548210
	// [XID] // 0x0000000189AE2080-0x0000000189AE20A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B18 */, bool useObjectPool = false /* Metadata: 0x00AF8B1C */) => default; // 0x0000000184547550-0x00000001845478A0
	[BlackList] // 0x0000000189AE9910-0x0000000189AE9950
	// [XID] // 0x0000000189AE9910-0x0000000189AE9950
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184547110-0x00000001845473E0
	// [XID] // 0x0000000189AF4410-0x0000000189AF4430
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845482C0-0x0000000184548580
	// [XID] // 0x0000000189AFBB60-0x0000000189AFBB80
	public void ParseColor() {} // 0x0000000184548880-0x0000000184548B50
	[BlackList] // 0x0000000189B032D0-0x0000000189B03310
	// [XID] // 0x0000000189B032D0-0x0000000189B03310
	public virtual void AutoAllocTypeFields() {} // 0x00000001845473E0-0x0000000184547480
	[BlackList] // 0x0000000189B0DA10-0x0000000189B0DA50
	// [XID] // 0x0000000189B0DA10-0x0000000189B0DA50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184547480-0x0000000184547550
	[BlackList] // 0x0000000189B17C60-0x0000000189B17CA0
	// [XID] // 0x0000000189B17C60-0x0000000189B17CA0
	public virtual void ReturnToObjectPool() {} // 0x0000000184548B50-0x0000000184548BF0
	[BlackList] // 0x0000000189B223F0-0x0000000189B22430
	// [XID] // 0x0000000189B223F0-0x0000000189B22430
	public virtual void OnPoolAllocated() {} // 0x00000001845487E0-0x0000000184548880
	[BlackList] // 0x0000000189B2C930-0x0000000189B2C970
	// [XID] // 0x0000000189B2C930-0x0000000189B2C970
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184548740-0x00000001845487E0
}

