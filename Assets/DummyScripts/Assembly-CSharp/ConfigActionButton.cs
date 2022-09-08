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
public class ConfigActionButton : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18798
{
	// Fields
	private ActionBtnType _type; // 0x10
	private bool _forceShow; // 0x14

	// Properties
	public ActionBtnType type { /* [XID] */ /* 0x00000001899DE9B0-0x00000001899DE9D0 */ get => default; /* [XID] */ /* 0x00000001899E6670-0x00000001899E6690 */ private set {} } // 0x00000001830376A0-0x0000000183037740 0x0000000183037160-0x0000000183037210
	public bool forceShow { /* [XID] */ /* 0x00000001899EDC80-0x00000001899EDCA0 */ get => default; /* [XID] */ /* 0x00000001899F55B0-0x00000001899F55D0 */ private set {} } // 0x00000001830370C0-0x0000000183037160 0x00000001830366A0-0x0000000183036750

	// Constructors
	public ConfigActionButton() {} // 0x00000001830377E0-0x0000000183037850

	// Methods
	// [XID] // 0x00000001899FCC50-0x00000001899FCC70
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183037450-0x0000000183037560
	// [XID] // 0x0000000189A040B0-0x0000000189A040D0
	public void InitEmpty() {} // 0x0000000183036D20-0x0000000183036DC0
	[BlackList] // 0x0000000189A0B810-0x0000000189A0B850
	// [XID] // 0x0000000189A0B810-0x0000000189A0B850
	public bool FromJson(JSONNode node) => default; // 0x00000001830369A0-0x0000000183036D20
	// [XID] // 0x0000000189A15E00-0x0000000189A15E20
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183035FF0-0x0000000183036290
	// [XID] // 0x0000000189A1D340-0x0000000189A1D360
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD09 */, bool useObjectPool = false /* Metadata: 0x00AFAD0D */) => default; // 0x0000000183036DC0-0x00000001830370C0
	// [XID] // 0x0000000189A24810-0x0000000189A24830
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD0E */, bool useObjectPool = false /* Metadata: 0x00AFAD12 */) => default; // 0x0000000183036750-0x00000001830369A0
	[BlackList] // 0x0000000189A2BD50-0x0000000189A2BD90
	// [XID] // 0x0000000189A2BD50-0x0000000189A2BD90
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183036290-0x0000000183036560
	// [XID] // 0x0000000189A367D0-0x0000000189A367F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183037210-0x0000000183037450
	[BlackList] // 0x0000000189A3DDF0-0x0000000189A3DE30
	// [XID] // 0x0000000189A3DDF0-0x0000000189A3DE30
	public virtual void AutoAllocTypeFields() {} // 0x0000000183036560-0x0000000183036600
	[BlackList] // 0x0000000189A48530-0x0000000189A48570
	// [XID] // 0x0000000189A48530-0x0000000189A48570
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183036600-0x00000001830366A0
	[BlackList] // 0x0000000189A52B00-0x0000000189A52B40
	// [XID] // 0x0000000189A52B00-0x0000000189A52B40
	public virtual void ReturnToObjectPool() {} // 0x0000000183037740-0x00000001830377E0
	[BlackList] // 0x0000000189A5D620-0x0000000189A5D660
	// [XID] // 0x0000000189A5D620-0x0000000189A5D660
	public virtual void OnPoolAllocated() {} // 0x0000000183037600-0x00000001830376A0
	[BlackList] // 0x0000000189A68270-0x0000000189A682B0
	// [XID] // 0x0000000189A68270-0x0000000189A682B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183037560-0x0000000183037600
}

