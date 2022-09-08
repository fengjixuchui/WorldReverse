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
public class ConfigSpatialSphereRoomTrigger : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19010
{
	// Fields
	private MoleMole.Config.Vector _position; // 0x10
	private SimpleSafeFloat radiusRawNum; // 0x1C

	// Properties
	public MoleMole.Config.Vector position { /* [XID] */ /* 0x0000000189728330-0x0000000189728350 */ get => default; /* [XID] */ /* 0x000000018972FA90-0x000000018972FAB0 */ private set {} } // 0x000000018358D270-0x000000018358D350 0x000000018358CEA0-0x000000018358CF70
	public float radius { /* [XID] */ /* 0x00000001897374C0-0x00000001897374E0 */ get => default; /* [XID] */ /* 0x000000018973EF60-0x000000018973EF80 */ private set {} } // 0x000000018358D350-0x000000018358D430 0x000000018358D940-0x000000018358DA20

	// Constructors
	public ConfigSpatialSphereRoomTrigger() {} // 0x000000018358DAC0-0x000000018358DB20

	// Methods
	// [XID] // 0x00000001897461A0-0x00000001897461C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018358D6D0-0x000000018358D800
	// [XID] // 0x000000018974DD50-0x000000018974DD70
	public void InitEmpty() {} // 0x000000018358CDA0-0x000000018358CEA0
	[BlackList] // 0x00000001897553D0-0x0000000189755410
	// [XID] // 0x00000001897553D0-0x0000000189755410
	public bool FromJson(JSONNode node) => default; // 0x000000018358CA20-0x000000018358CDA0
	// [XID] // 0x0000000189B456C0-0x0000000189B456E0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018358C000-0x000000018358C320
	// [XID] // 0x0000000189A62960-0x0000000189A62980
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB73D */, bool useObjectPool = false /* Metadata: 0x00AFB741 */) => default; // 0x000000018358CF70-0x000000018358D270
	// [XID] // 0x000000018976E3A0-0x000000018976E3C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB742 */, bool useObjectPool = false /* Metadata: 0x00AFB746 */) => default; // 0x000000018358C770-0x000000018358CA20
	[BlackList] // 0x0000000189775CA0-0x0000000189775CE0
	// [XID] // 0x0000000189775CA0-0x0000000189775CE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018358C320-0x000000018358C5F0
	// [XID] // 0x00000001897803A0-0x00000001897803C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018358D430-0x000000018358D6D0
	[BlackList] // 0x0000000189787B20-0x0000000189787B60
	// [XID] // 0x0000000189787B20-0x0000000189787B60
	public virtual void AutoAllocTypeFields() {} // 0x000000018358C5F0-0x000000018358C690
	[BlackList] // 0x0000000189792180-0x00000001897921C0
	// [XID] // 0x0000000189792180-0x00000001897921C0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018358C690-0x000000018358C770
	[BlackList] // 0x000000018979D4D0-0x000000018979D510
	// [XID] // 0x000000018979D4D0-0x000000018979D510
	public virtual void ReturnToObjectPool() {} // 0x000000018358DA20-0x000000018358DAC0
	[BlackList] // 0x00000001897A76A0-0x00000001897A76E0
	// [XID] // 0x00000001897A76A0-0x00000001897A76E0
	public virtual void OnPoolAllocated() {} // 0x000000018358D8A0-0x000000018358D940
	[BlackList] // 0x00000001897B1F50-0x00000001897B1F90
	// [XID] // 0x00000001897B1F50-0x00000001897B1F90
	public virtual void OnBeforePoolRecycled() {} // 0x000000018358D800-0x000000018358D8A0
}

