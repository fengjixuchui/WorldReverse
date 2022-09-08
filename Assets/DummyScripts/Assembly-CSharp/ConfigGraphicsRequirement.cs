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
public class ConfigGraphicsRequirement : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18170
{
	// Fields
	private string _Info; // 0x10
	private string[] _Values; // 0x18

	// Properties
	public string Info { /* [XID] */ /* 0x00000001895F0900-0x00000001895F0920 */ get => default; /* [XID] */ /* 0x00000001895F8290-0x00000001895F82B0 */ private set {} } // 0x00000001836E2D00-0x00000001836E2DA0 0x00000001836E3870-0x00000001836E3920
	public string[] Values { /* [XID] */ /* 0x0000000189739640-0x0000000189739660 */ get => default; /* [XID] */ /* 0x0000000189607000-0x0000000189607020 */ private set {} } // 0x00000001836E3920-0x00000001836E39C0 0x00000001836E33E0-0x00000001836E3490

	// Constructors
	public ConfigGraphicsRequirement() {} // 0x00000001836E3F20-0x00000001836E3F80

	// Methods
	// [XID] // 0x000000018960EA20-0x000000018960EA40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001836E3C30-0x00000001836E3D40
	// [XID] // 0x0000000189616040-0x0000000189616060
	public void InitEmpty() {} // 0x00000001836E3490-0x00000001836E3570
	[BlackList] // 0x000000018961D810-0x000000018961D850
	// [XID] // 0x000000018961D810-0x000000018961D850
	public bool FromJson(JSONNode node) => default; // 0x00000001836E3060-0x00000001836E33E0
	// [XID] // 0x0000000189627D90-0x0000000189627DB0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001836E2620-0x00000001836E28F0
	// [XID] // 0x000000018962F6C0-0x000000018962F6E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DB7 */, bool useObjectPool = false /* Metadata: 0x00AF8DBB */) => default; // 0x00000001836E3570-0x00000001836E3870
	// [XID] // 0x0000000189637220-0x0000000189637240
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DBC */, bool useObjectPool = false /* Metadata: 0x00AF8DC0 */) => default; // 0x00000001836E2DA0-0x00000001836E3060
	[BlackList] // 0x000000018963E700-0x000000018963E740
	// [XID] // 0x000000018963E700-0x000000018963E740
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001836E28F0-0x00000001836E2BC0
	// [XID] // 0x0000000189648FE0-0x0000000189649000
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001836E39C0-0x00000001836E3C30
	[BlackList] // 0x00000001896505B0-0x00000001896505F0
	// [XID] // 0x00000001896505B0-0x00000001896505F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001836E2BC0-0x00000001836E2C60
	[BlackList] // 0x000000018965AE90-0x000000018965AED0
	// [XID] // 0x000000018965AE90-0x000000018965AED0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836E2C60-0x00000001836E2D00
	[BlackList] // 0x0000000189665410-0x0000000189665450
	// [XID] // 0x0000000189665410-0x0000000189665450
	public virtual void ReturnToObjectPool() {} // 0x00000001836E3E80-0x00000001836E3F20
	[BlackList] // 0x00000001896701B0-0x00000001896701F0
	// [XID] // 0x00000001896701B0-0x00000001896701F0
	public virtual void OnPoolAllocated() {} // 0x00000001836E3DE0-0x00000001836E3E80
	[BlackList] // 0x000000018967A840-0x000000018967A880
	// [XID] // 0x000000018967A840-0x000000018967A880
	public virtual void OnBeforePoolRecycled() {} // 0x00000001836E3D40-0x00000001836E3DE0
}

