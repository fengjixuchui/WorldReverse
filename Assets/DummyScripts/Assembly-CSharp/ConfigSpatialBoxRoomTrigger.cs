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
public class ConfigSpatialBoxRoomTrigger : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19009
{
	// Fields
	private MoleMole.Config.Vector _position; // 0x10
	private MoleMole.Config.Vector _rotation; // 0x1C
	private MoleMole.Config.Vector _size; // 0x28

	// Properties
	public MoleMole.Config.Vector position { /* [XID] */ /* 0x0000000189978180-0x00000001899781A0 */ get => default; /* [XID] */ /* 0x00000001896867B0-0x00000001896867D0 */ private set {} } // 0x0000000184BD9CB0-0x0000000184BD9D90 0x0000000184BD9810-0x0000000184BD98E0
	public MoleMole.Config.Vector rotation { /* [XID] */ /* 0x000000018966C020-0x000000018966C040 */ get => default; /* [XID] */ /* 0x0000000189695F90-0x0000000189695FB0 */ private set {} } // 0x0000000184BD9D90-0x0000000184BD9E70 0x0000000184BD9640-0x0000000184BD9710
	public MoleMole.Config.Vector size { /* [XID] */ /* 0x000000018969D690-0x000000018969D6B0 */ get => default; /* [XID] */ /* 0x00000001896A4720-0x00000001896A4740 */ private set {} } // 0x0000000184BDA220-0x0000000184BDA300 0x0000000184BD98E0-0x0000000184BD99B0

	// Constructors
	public ConfigSpatialBoxRoomTrigger() {} // 0x0000000184BDA630-0x0000000184BDA690

	// Methods
	// [XID] // 0x00000001896ABEB0-0x00000001896ABED0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184BDA300-0x0000000184BDA450
	// [XID] // 0x00000001896B30F0-0x00000001896B3110
	public void InitEmpty() {} // 0x0000000184BD9710-0x0000000184BD9810
	[BlackList] // 0x00000001896BA810-0x00000001896BA850
	// [XID] // 0x00000001896BA810-0x00000001896BA850
	public bool FromJson(JSONNode node) => default; // 0x0000000184BD92C0-0x0000000184BD9640
	// [XID] // 0x0000000189B27720-0x0000000189B27740
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184BD87A0-0x0000000184BD8B40
	// [XID] // 0x00000001896CC010-0x00000001896CC030
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB733 */, bool useObjectPool = false /* Metadata: 0x00AFB737 */) => default; // 0x0000000184BD99B0-0x0000000184BD9CB0
	// [XID] // 0x00000001896D3340-0x00000001896D3360
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB738 */, bool useObjectPool = false /* Metadata: 0x00AFB73C */) => default; // 0x0000000184BD8F80-0x0000000184BD92C0
	[BlackList] // 0x00000001896DAEA0-0x00000001896DAEE0
	// [XID] // 0x00000001896DAEA0-0x00000001896DAEE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184BD8B40-0x0000000184BD8E10
	// [XID] // 0x00000001896E5370-0x00000001896E5390
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184BD9E70-0x0000000184BDA220
	[BlackList] // 0x00000001896EC900-0x00000001896EC940
	// [XID] // 0x00000001896EC900-0x00000001896EC940
	public virtual void AutoAllocTypeFields() {} // 0x0000000184BD8E10-0x0000000184BD8EB0
	[BlackList] // 0x00000001896F7150-0x00000001896F7190
	// [XID] // 0x00000001896F7150-0x00000001896F7190
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184BD8EB0-0x0000000184BD8F80
	[BlackList] // 0x00000001897016C0-0x0000000189701700
	// [XID] // 0x00000001897016C0-0x0000000189701700
	public virtual void ReturnToObjectPool() {} // 0x0000000184BDA590-0x0000000184BDA630
	[BlackList] // 0x000000018970BDD0-0x000000018970BE10
	// [XID] // 0x000000018970BDD0-0x000000018970BE10
	public virtual void OnPoolAllocated() {} // 0x0000000184BDA4F0-0x0000000184BDA590
	[BlackList] // 0x0000000189716480-0x00000001897164C0
	// [XID] // 0x0000000189716480-0x00000001897164C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184BDA450-0x0000000184BDA4F0
}

