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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigSpatialPortal : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19012
{
	// Fields
	private string _name; // 0x10
	private MoleMole.Config.Vector _position; // 0x18
	private MoleMole.Config.Vector _rotation; // 0x24
	private MoleMole.Config.Vector _size; // 0x30
	private bool _enabled; // 0x3C
	private string _frontRoomName; // 0x40
	private string _backRoomName; // 0x48

	// Properties
	public string name { /* [XID] */ /* 0x00000001899CAD90-0x00000001899CADB0 */ get => default; /* [XID] */ /* 0x00000001898F49E0-0x00000001898F4A00 */ private set {} } // 0x0000000181BCB750-0x0000000181BCB7F0 0x0000000181BCA370-0x0000000181BCA420
	public MoleMole.Config.Vector position { /* [XID] */ /* 0x00000001898FC290-0x00000001898FC2B0 */ get => default; /* [XID] */ /* 0x0000000189903CF0-0x0000000189903D10 */ private set {} } // 0x0000000181BCAB10-0x0000000181BCABF0 0x0000000181BCA530-0x0000000181BCA600
	public MoleMole.Config.Vector rotation { /* [XID] */ /* 0x00000001899D9BA0-0x00000001899D9BC0 */ get => default; /* [XID] */ /* 0x0000000189912E60-0x0000000189912E80 */ private set {} } // 0x0000000181BCABF0-0x0000000181BCACD0 0x0000000181BCA1F0-0x0000000181BCA2C0
	public MoleMole.Config.Vector size { /* [XID] */ /* 0x000000018991A730-0x000000018991A750 */ get => default; /* [XID] */ /* 0x0000000189921EE0-0x0000000189921F00 */ private set {} } // 0x0000000181BCB340-0x0000000181BCB420 0x0000000181BCA600-0x0000000181BCA6D0
	public bool enabled { /* [XID] */ /* 0x00000001899296A0-0x00000001899296C0 */ get => default; /* [XID] */ /* 0x0000000189930C60-0x0000000189930C80 */ private set {} } // 0x0000000181BCAA70-0x0000000181BCAB10 0x0000000181BCACD0-0x0000000181BCAD80
	public string frontRoomName { /* [XID] */ /* 0x0000000189A35CE0-0x0000000189A35D00 */ get => default; /* [XID] */ /* 0x000000018993FAE0-0x000000018993FB00 */ private set {} } // 0x0000000181BCA9D0-0x0000000181BCAA70 0x0000000181BC9880-0x0000000181BC9930
	public string backRoomName { /* [XID] */ /* 0x00000001899471A0-0x00000001899471C0 */ get => default; /* [XID] */ /* 0x000000018994E800-0x000000018994E820 */ private set {} } // 0x0000000181BC97E0-0x0000000181BC9880 0x0000000181BCA2C0-0x0000000181BCA370

	// Constructors
	public ConfigSpatialPortal() {} // 0x0000000181BCB890-0x0000000181BCB910

	// Methods
	// [XID] // 0x0000000189955E60-0x0000000189955E80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181BCB420-0x0000000181BCB610
	// [XID] // 0x000000018995D990-0x000000018995D9B0
	public void InitEmpty() {} // 0x0000000181BCA420-0x0000000181BCA530
	[BlackList] // 0x00000001899650B0-0x00000001899650F0
	// [XID] // 0x00000001899650B0-0x00000001899650F0
	public bool FromJson(JSONNode node) => default; // 0x0000000181BC9E70-0x0000000181BCA1F0
	// [XID] // 0x000000018996F360-0x000000018996F380
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181BC8CF0-0x0000000181BC9380
	// [XID] // 0x0000000189A9EAF0-0x0000000189A9EB10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB751 */, bool useObjectPool = false /* Metadata: 0x00AFB755 */) => default; // 0x0000000181BCA6D0-0x0000000181BCA9D0
	// [XID] // 0x0000000189AA65A0-0x0000000189AA65C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB756 */, bool useObjectPool = false /* Metadata: 0x00AFB75A */) => default; // 0x0000000181BC9930-0x0000000181BC9E70
	[BlackList] // 0x0000000189985E50-0x0000000189985E90
	// [XID] // 0x0000000189985E50-0x0000000189985E90
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181BC9380-0x0000000181BC9650
	// [XID] // 0x0000000189990A70-0x0000000189990A90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181BCAD80-0x0000000181BCB340
	[BlackList] // 0x0000000189998510-0x0000000189998550
	// [XID] // 0x0000000189998510-0x0000000189998550
	public virtual void AutoAllocTypeFields() {} // 0x0000000181BC9650-0x0000000181BC96F0
	[BlackList] // 0x00000001899A2DD0-0x00000001899A2E10
	// [XID] // 0x00000001899A2DD0-0x00000001899A2E10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181BC96F0-0x0000000181BC97E0
	[BlackList] // 0x00000001899AD840-0x00000001899AD880
	// [XID] // 0x00000001899AD840-0x00000001899AD880
	public virtual void ReturnToObjectPool() {} // 0x0000000181BCB7F0-0x0000000181BCB890
	[BlackList] // 0x00000001899B7E50-0x00000001899B7E90
	// [XID] // 0x00000001899B7E50-0x00000001899B7E90
	public virtual void OnPoolAllocated() {} // 0x0000000181BCB6B0-0x0000000181BCB750
	[BlackList] // 0x00000001899C2860-0x00000001899C28A0
	// [XID] // 0x00000001899C2860-0x00000001899C28A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181BCB610-0x0000000181BCB6B0
}

