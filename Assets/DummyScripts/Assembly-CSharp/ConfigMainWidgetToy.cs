/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigMainWidgetToy : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19231
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeUInt32, ConfigWidgetGadget> _gadgetConfigMap; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeUInt32, ConfigWidgetCdGroup> _cdGroupConfigMap; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeUInt32, ConfigBaseWidgetToy> _widgetConfigMap; // 0x20

	// Properties
	public Dictionary<SimpleSafeUInt32, ConfigWidgetGadget> gadgetConfigMap { /* [XID] */ /* 0x0000000189A2A620-0x0000000189A2A640 */ get => default; /* [XID] */ /* 0x0000000189A31BA0-0x0000000189A31BC0 */ private set {} } // 0x00000001822CB730-0x00000001822CB7D0 0x00000001822CBF60-0x00000001822CC010
	public Dictionary<SimpleSafeUInt32, ConfigWidgetCdGroup> cdGroupConfigMap { /* [XID] */ /* 0x0000000189A39610-0x0000000189A39630 */ get => default; /* [XID] */ /* 0x0000000189A40D70-0x0000000189A40D90 */ private set {} } // 0x00000001822CC0C0-0x00000001822CC160 0x00000001822CB7D0-0x00000001822CB880
	public Dictionary<SimpleSafeUInt32, ConfigBaseWidgetToy> widgetConfigMap { /* [XID] */ /* 0x0000000189A48410-0x0000000189A48430 */ get => default; /* [XID] */ /* 0x0000000189A4FD20-0x0000000189A4FD40 */ private set {} } // 0x00000001822CC560-0x00000001822CC600 0x00000001822CC010-0x00000001822CC0C0

	// Constructors
	public ConfigMainWidgetToy() {} // 0x00000001822CCC60-0x00000001822CCCC0

	// Methods
	// [XID] // 0x0000000189A57210-0x0000000189A57230
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822CC960-0x00000001822CCA80
	// [XID] // 0x0000000189A5ED70-0x0000000189A5ED90
	public void InitEmpty() {} // 0x00000001822CC160-0x00000001822CC260
	[BlackList] // 0x0000000189A66600-0x0000000189A66640
	// [XID] // 0x0000000189A66600-0x0000000189A66640
	public bool FromJson(JSONNode node) => default; // 0x00000001822CBBE0-0x00000001822CBF60
	// [XID] // 0x0000000189A70DA0-0x0000000189A70DC0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001822CAF10-0x00000001822CB2C0
	// [XID] // 0x0000000189A787E0-0x0000000189A78800
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC615 */, bool useObjectPool = false /* Metadata: 0x00AFC619 */) => default; // 0x00000001822CC260-0x00000001822CC560
	// [XID] // 0x0000000189A7FC40-0x0000000189A7FC60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC61A */, bool useObjectPool = false /* Metadata: 0x00AFC61E */) => default; // 0x00000001822CB880-0x00000001822CBBE0
	[BlackList] // 0x0000000189A87A20-0x0000000189A87A60
	// [XID] // 0x0000000189A87A20-0x0000000189A87A60
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001822CB2C0-0x00000001822CB590
	// [XID] // 0x0000000189A92270-0x0000000189A92290
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001822CC600-0x00000001822CC960
	[BlackList] // 0x0000000189A99BC0-0x0000000189A99C00
	// [XID] // 0x0000000189A99BC0-0x0000000189A99C00
	public virtual void AutoAllocTypeFields() {} // 0x00000001822CB590-0x00000001822CB630
	[BlackList] // 0x0000000189AA3F20-0x0000000189AA3F60
	// [XID] // 0x0000000189AA3F20-0x0000000189AA3F60
	public virtual void AutoRecycleTypeFields() {} // 0x00000001822CB630-0x00000001822CB730
	[BlackList] // 0x0000000189AAE5E0-0x0000000189AAE620
	// [XID] // 0x0000000189AAE5E0-0x0000000189AAE620
	public virtual void ReturnToObjectPool() {} // 0x00000001822CCBC0-0x00000001822CCC60
	[BlackList] // 0x0000000189AB8C60-0x0000000189AB8CA0
	// [XID] // 0x0000000189AB8C60-0x0000000189AB8CA0
	public virtual void OnPoolAllocated() {} // 0x00000001822CCB20-0x00000001822CCBC0
	[BlackList] // 0x0000000189AC3D60-0x0000000189AC3DA0
	// [XID] // 0x0000000189AC3D60-0x0000000189AC3DA0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001822CCA80-0x00000001822CCB20
}

