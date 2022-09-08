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
public class ConfigModel : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17952
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigMatLinearChangedByDistance[] _matLinearChangedByDistance; // 0x10
	private string _bornEffect; // 0x18
	private string _attachEffect; // 0x20
	private bool _canBakeMesh; // 0x28

	// Properties
	public ConfigMatLinearChangedByDistance[] matLinearChangedByDistance { /* [XID] */ /* 0x00000001896749F0-0x0000000189674A10 */ get => default; /* [XID] */ /* 0x000000018967C300-0x000000018967C320 */ private set {} } // 0x0000000181F961A0-0x0000000181F96240 0x0000000181F95790-0x0000000181F95840
	public string bornEffect { /* [XID] */ /* 0x0000000189B5BE20-0x0000000189B5BE40 */ get => default; /* [XID] */ /* 0x000000018968B6B0-0x000000018968B6D0 */ private set {} } // 0x0000000181F964C0-0x0000000181F96560 0x0000000181F96560-0x0000000181F96610
	public string attachEffect { /* [XID] */ /* 0x0000000189BBBDF0-0x0000000189BBBE10 */ get => default; /* [XID] */ /* 0x000000018969A4D0-0x000000018969A4F0 */ private set {} } // 0x0000000181F95930-0x0000000181F959D0 0x0000000181F94F90-0x0000000181F95040
	public bool canBakeMesh { /* [XID] */ /* 0x00000001896A1DC0-0x00000001896A1DE0 */ get => default; /* [XID] */ /* 0x00000001896A91C0-0x00000001896A91E0 */ private set {} } // 0x0000000181F96100-0x0000000181F961A0 0x0000000181F95CD0-0x0000000181F95D80

	// Constructors
	public ConfigModel() {} // 0x0000000181F966B0-0x0000000181F96720

	// Methods
	// [XID] // 0x00000001896B0330-0x00000001896B0350
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181F96240-0x0000000181F96380
	// [XID] // 0x00000001896B7C10-0x00000001896B7C30
	public void InitEmpty() {} // 0x0000000181F95840-0x0000000181F95930
	[BlackList] // 0x00000001896BEBD0-0x00000001896BEC10
	// [XID] // 0x00000001896BEBD0-0x00000001896BEC10
	public bool FromJson(JSONNode node) => default; // 0x0000000181F95410-0x0000000181F95790
	// [XID] // 0x00000001896C91D0-0x00000001896C91F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181F94710-0x0000000181F94B70
	// [XID] // 0x00000001896D0B20-0x00000001896D0B40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8497 */, bool useObjectPool = false /* Metadata: 0x00AF849B */) => default; // 0x0000000181F959D0-0x0000000181F95CD0
	// [XID] // 0x00000001896D8050-0x00000001896D8070
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF849C */, bool useObjectPool = false /* Metadata: 0x00AF84A0 */) => default; // 0x0000000181F95040-0x0000000181F95410
	[BlackList] // 0x00000001896DF9A0-0x00000001896DF9E0
	// [XID] // 0x00000001896DF9A0-0x00000001896DF9E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181F94B70-0x0000000181F94E40
	// [XID] // 0x00000001896E9E60-0x00000001896E9E80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181F95D80-0x0000000181F96100
	[BlackList] // 0x00000001896F0EC0-0x00000001896F0F00
	// [XID] // 0x00000001896F0EC0-0x00000001896F0F00
	public virtual void AutoAllocTypeFields() {} // 0x0000000181F94E40-0x0000000181F94EE0
	[BlackList] // 0x00000001896FBB70-0x00000001896FBBB0
	// [XID] // 0x00000001896FBB70-0x00000001896FBBB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181F94EE0-0x0000000181F94F90
	[BlackList] // 0x0000000189705EA0-0x0000000189705EE0
	// [XID] // 0x0000000189705EA0-0x0000000189705EE0
	public virtual void ReturnToObjectPool() {} // 0x0000000181F96610-0x0000000181F966B0
	[BlackList] // 0x0000000189710A50-0x0000000189710A90
	// [XID] // 0x0000000189710A50-0x0000000189710A90
	public virtual void OnPoolAllocated() {} // 0x0000000181F96420-0x0000000181F964C0
	[BlackList] // 0x000000018971B1C0-0x000000018971B200
	// [XID] // 0x000000018971B1C0-0x000000018971B200
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181F96380-0x0000000181F96420
}

