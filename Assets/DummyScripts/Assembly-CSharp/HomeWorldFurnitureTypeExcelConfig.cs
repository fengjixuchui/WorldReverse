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
public class HomeWorldFurnitureTypeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15705
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 typeIDRawNum; // 0x10
	protected uint _typeNameTextMapHash; // 0x14
	protected uint _typeName2TextMapHash; // 0x18
	protected string _tabIcon; // 0x20
	protected FurnitureDeployType _sceneType; // 0x28
	protected SimpleSafeUInt32 cameraIDRawNum; // 0x2C
	protected bool _isShowInBag; // 0x30
	protected SimpleSafeUInt32 limitRawNum; // 0x34

	// Properties
	public uint typeID { /* [XID] */ /* 0x00000001897643E0-0x0000000189764400 */ get => default; /* [XID] */ /* 0x000000018976BD60-0x000000018976BD80 */ protected set {} } // 0x00000001828F59C0-0x00000001828F5A90 0x00000001828F4F70-0x00000001828F5050
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint typeNameTextMapHash { /* [XID] */ /* 0x00000001897732E0-0x0000000189773300 */ get => default; /* [XID] */ /* 0x000000018977A8A0-0x000000018977A8C0 */ protected set {} } // 0x00000001828F3F50-0x00000001828F3FF0 0x00000001828F4EC0-0x00000001828F4F70
	public string typeName { /* [XID] */ /* 0x00000001897824E0-0x0000000189782500 */ get => default; } // 0x00000001828F4A40-0x00000001828F4BC0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint typeName2TextMapHash { /* [XID] */ /* 0x0000000189789800-0x0000000189789820 */ get => default; /* [XID] */ /* 0x0000000189790F30-0x0000000189790F50 */ protected set {} } // 0x00000001828F5EA0-0x00000001828F5F40 0x00000001828F5CB0-0x00000001828F5D60
	public string typeName2 { /* [XID] */ /* 0x0000000189798760-0x0000000189798780 */ get => default; } // 0x00000001828F4BC0-0x00000001828F4D40 
	public string tabIcon { /* [XID] */ /* 0x00000001897A05B0-0x00000001897A05D0 */ get => default; /* [XID] */ /* 0x00000001897A7B60-0x00000001897A7B80 */ protected set {} } // 0x00000001828F4D40-0x00000001828F4DE0 0x00000001828F5910-0x00000001828F59C0
	public FurnitureDeployType sceneType { /* [XID] */ /* 0x00000001897AF610-0x00000001897AF630 */ get => default; /* [XID] */ /* 0x00000001897B7510-0x00000001897B7530 */ protected set {} } // 0x00000001828F3DD0-0x00000001828F3E70 0x00000001828F5120-0x00000001828F51D0
	public uint cameraID { /* [XID] */ /* 0x00000001897BF3D0-0x00000001897BF3F0 */ get => default; /* [XID] */ /* 0x00000001897C6A80-0x00000001897C6AA0 */ protected set {} } // 0x00000001828F5A90-0x00000001828F5B60 0x00000001828F4DE0-0x00000001828F4EC0
	public bool isShowInBag { /* [XID] */ /* 0x00000001897CE240-0x00000001897CE260 */ get => default; /* [XID] */ /* 0x00000001897D5750-0x00000001897D5770 */ protected set {} } // 0x00000001828F5B60-0x00000001828F5C00 0x00000001828F5C00-0x00000001828F5CB0
	public uint limit { /* [XID] */ /* 0x00000001897DCE70-0x00000001897DCE90 */ get => default; /* [XID] */ /* 0x00000001897E47B0-0x00000001897E47D0 */ protected set {} } // 0x00000001828F5050-0x00000001828F5120 0x00000001828F3E70-0x00000001828F3F50

	// Constructors
	public HomeWorldFurnitureTypeExcelConfig() {} // 0x00000001828F5FE0-0x00000001828F6040

	// Methods
	// [IDTag] // 0x00000001897EC360-0x00000001897EC3A0
	// [XID] // 0x00000001897EC360-0x00000001897EC3A0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001828F3FF0-0x00000001828F4520
	// [IDTag] // 0x00000001897F6920-0x00000001897F6960
	// [XID] // 0x00000001897F6920-0x00000001897F6960
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001828F4520-0x00000001828F4A40
	// [XID] // 0x0000000189801360-0x0000000189801380
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23BE */, bool useObjectPool = false /* Metadata: 0x00AF23C2 */) => default; // 0x00000001828F51D0-0x00000001828F5910
	[BlackList] // 0x0000000189808780-0x00000001898087C0
	// [XID] // 0x0000000189808780-0x00000001898087C0
	public virtual void AutoAllocTypeFields() {} // 0x00000001828F3C30-0x00000001828F3CD0
	[BlackList] // 0x0000000189812EE0-0x0000000189812F20
	// [XID] // 0x0000000189812EE0-0x0000000189812F20
	public virtual void AutoRecycleTypeFields() {} // 0x00000001828F3CD0-0x00000001828F3DD0
	[BlackList] // 0x000000018981D990-0x000000018981D9D0
	// [XID] // 0x000000018981D990-0x000000018981D9D0
	public virtual void ReturnToObjectPool() {} // 0x00000001828F5F40-0x00000001828F5FE0
	[BlackList] // 0x00000001898281E0-0x0000000189828220
	// [XID] // 0x00000001898281E0-0x0000000189828220
	public virtual void OnPoolAllocated() {} // 0x00000001828F5E00-0x00000001828F5EA0
	[BlackList] // 0x00000001898324B0-0x00000001898324F0
	// [XID] // 0x00000001898324B0-0x00000001898324F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001828F5D60-0x00000001828F5E00
}

