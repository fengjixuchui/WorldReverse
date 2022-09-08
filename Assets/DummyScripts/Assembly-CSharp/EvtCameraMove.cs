/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtCameraMove : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20077
{
	// Fields
	private string _cfgPath; // 0x30
	private ConfigCameraMove _cameraMoveConfig; // 0x38
	private int _shotType; // 0x40
	private uint _fromID; // 0x44

	// Properties
	public string cfgPath { /* [XID] */ /* 0x00000001899983B0-0x00000001899983D0 */ get => default; } // 0x0000000181B49B80-0x0000000181B49C20 
	public ConfigCameraMove cameraMoveConfig { /* [XID] */ /* 0x000000018999FB90-0x000000018999FBB0 */ get => default; } // 0x0000000181B499C0-0x0000000181B49A60 
	public int shotType { /* [XID] */ /* 0x0000000189B88660-0x0000000189B88680 */ get => default; } // 0x0000000181B49700-0x0000000181B497A0 
	public uint fromID { /* [XID] */ /* 0x0000000189B80A70-0x0000000189B80A90 */ get => default; } // 0x0000000181B49800-0x0000000181B498A0 

	// Constructors
	public EvtCameraMove() {} // 0x0000000181B49D70-0x0000000181B49DE0

	// Methods
	[BlackList] // 0x0000000189978BD0-0x0000000189978C10
	// [XID] // 0x0000000189978BD0-0x0000000189978C10
	public override void AutoAllocTypeFields() {} // 0x0000000181B495B0-0x0000000181B49650
	[BlackList] // 0x0000000189983190-0x00000001899831D0
	// [XID] // 0x0000000189983190-0x00000001899831D0
	public override void AutoRecycleTypeFields() {} // 0x0000000181B49650-0x0000000181B49700
	[BlackList] // 0x000000018998D8C0-0x000000018998D900
	// [XID] // 0x000000018998D8C0-0x000000018998D900
	public override void ReturnToObjectPool() {} // 0x0000000181B49CD0-0x0000000181B49D70
	// [XID] // 0x00000001899B6470-0x00000001899B6490
	public override void OnPoolAllocated() {} // 0x0000000181B49C20-0x0000000181B49CD0
	// [XID] // 0x00000001899BE050-0x00000001899BE070
	public void Init(uint targetID, uint fromID, string cfgPath, ConfigCameraMove cameraMoveConfig, int sShotType) {} // 0x0000000181B498A0-0x0000000181B499C0
}

