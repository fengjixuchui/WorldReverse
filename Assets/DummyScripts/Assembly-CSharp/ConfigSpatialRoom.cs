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
public class ConfigSpatialRoom : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19011
{
	// Fields
	private string _name; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _reverbAuxBus; // 0x18
	private SimpleSafeFloat reverbLevelRawNum; // 0x20
	private SimpleSafeFloat wallOcclusionRawNum; // 0x24
	private SimpleSafeFloat auxSendLevelToSelfRawNum; // 0x28
	private bool _keepRegister; // 0x2C
	private SimpleSafeInt32 priorityRawNum; // 0x30
	private bool _isMajorRoom; // 0x34
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigSpatialBoxRoomTrigger[] _boxRoomTriggers; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigSpatialSphereRoomTrigger[] _sphereRoomTriggers; // 0x40

	// Properties
	public string name { /* [XID] */ /* 0x00000001897DB310-0x00000001897DB330 */ get => default; /* [XID] */ /* 0x00000001897E2A60-0x00000001897E2A80 */ private set {} } // 0x0000000181A166F0-0x0000000181A16790 0x0000000181A15410-0x0000000181A154C0
	public ConfigWwiseString reverbAuxBus { /* [XID] */ /* 0x00000001897EA220-0x00000001897EA240 */ get => default; /* [XID] */ /* 0x00000001897F1ED0-0x00000001897F1EF0 */ private set {} } // 0x0000000181A14C60-0x0000000181A14D00 0x0000000181A149F0-0x0000000181A14AA0
	public float reverbLevel { /* [XID] */ /* 0x00000001897F9780-0x00000001897F97A0 */ get => default; /* [XID] */ /* 0x0000000189800CA0-0x0000000189800CC0 */ private set {} } // 0x0000000181A13F90-0x0000000181A14070 0x0000000181A14AA0-0x0000000181A14B80
	public float wallOcclusion { /* [XID] */ /* 0x0000000189628B60-0x0000000189628B80 */ get => default; /* [XID] */ /* 0x000000018980FBB0-0x000000018980FBD0 */ private set {} } // 0x0000000181A151D0-0x0000000181A152B0 0x0000000181A15950-0x0000000181A15A30
	public float auxSendLevelToSelf { /* [XID] */ /* 0x0000000189817240-0x0000000189817260 */ get => default; /* [XID] */ /* 0x000000018981EB60-0x000000018981EB80 */ private set {} } // 0x0000000181A13C30-0x0000000181A13D10 0x0000000181A162E0-0x0000000181A163C0
	public bool keepRegister { /* [XID] */ /* 0x0000000189826030-0x0000000189826050 */ get => default; /* [XID] */ /* 0x000000018982D680-0x000000018982D6A0 */ private set {} } // 0x0000000181A15080-0x0000000181A15120 0x0000000181A15120-0x0000000181A151D0
	public int priority { /* [XID] */ /* 0x00000001899BA540-0x00000001899BA560 */ get => default; /* [XID] */ /* 0x000000018983C5D0-0x000000018983C5F0 */ private set {} } // 0x0000000181A15A30-0x0000000181A15B00 0x0000000181A14B80-0x0000000181A14C60
	public bool isMajorRoom { /* [XID] */ /* 0x0000000189664A70-0x0000000189664A90 */ get => default; /* [XID] */ /* 0x000000018984B0D0-0x000000018984B0F0 */ private set {} } // 0x0000000181A14070-0x0000000181A14110 0x0000000181A152B0-0x0000000181A15360
	public ConfigSpatialBoxRoomTrigger[] boxRoomTriggers { /* [XID] */ /* 0x000000018965D3E0-0x000000018965D400 */ get => default; /* [XID] */ /* 0x0000000189859C70-0x0000000189859C90 */ private set {} } // 0x0000000181A15B00-0x0000000181A15BA0 0x0000000181A15360-0x0000000181A15410
	public ConfigSpatialSphereRoomTrigger[] sphereRoomTriggers { /* [XID] */ /* 0x0000000189986C00-0x0000000189986C20 */ get => default; /* [XID] */ /* 0x00000001898685D0-0x00000001898685F0 */ private set {} } // 0x0000000181A14950-0x0000000181A149F0 0x0000000181A14110-0x0000000181A141C0

	// Constructors
	public ConfigSpatialRoom() {} // 0x0000000181A16830-0x0000000181A168E0

	// Methods
	// [XID] // 0x000000018986F9E0-0x000000018986FA00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A163C0-0x0000000181A165B0
	// [XID] // 0x00000001898770D0-0x00000001898770F0
	public void InitEmpty() {} // 0x0000000181A154C0-0x0000000181A15650
	[BlackList] // 0x000000018987EAC0-0x000000018987EB00
	// [XID] // 0x000000018987EAC0-0x000000018987EB00
	public bool FromJson(JSONNode node) => default; // 0x0000000181A14D00-0x0000000181A15080
	// [XID] // 0x0000000189888D40-0x0000000189888D60
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181A12F10-0x0000000181A13960
	// [XID] // 0x0000000189A88680-0x0000000189A886A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB747 */, bool useObjectPool = false /* Metadata: 0x00AFB74B */) => default; // 0x0000000181A15650-0x0000000181A15950
	// [XID] // 0x0000000189897620-0x0000000189897640
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB74C */, bool useObjectPool = false /* Metadata: 0x00AFB750 */) => default; // 0x0000000181A141C0-0x0000000181A14950
	[BlackList] // 0x000000018989EBC0-0x000000018989EC00
	// [XID] // 0x000000018989EBC0-0x000000018989EC00
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181A13960-0x0000000181A13C30
	// [XID] // 0x00000001898A9490-0x00000001898A94B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A15BA0-0x0000000181A162E0
	[BlackList] // 0x00000001898B0CE0-0x00000001898B0D20
	// [XID] // 0x00000001898B0CE0-0x00000001898B0D20
	public virtual void AutoAllocTypeFields() {} // 0x0000000181A13D10-0x0000000181A13DB0
	[BlackList] // 0x00000001898BB6D0-0x00000001898BB710
	// [XID] // 0x00000001898BB6D0-0x00000001898BB710
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181A13DB0-0x0000000181A13F90
	[BlackList] // 0x00000001898C5A90-0x00000001898C5AD0
	// [XID] // 0x00000001898C5A90-0x00000001898C5AD0
	public virtual void ReturnToObjectPool() {} // 0x0000000181A16790-0x0000000181A16830
	[BlackList] // 0x00000001898D0560-0x00000001898D05A0
	// [XID] // 0x00000001898D0560-0x00000001898D05A0
	public virtual void OnPoolAllocated() {} // 0x0000000181A16650-0x0000000181A166F0
	[BlackList] // 0x00000001898DAAC0-0x00000001898DAB00
	// [XID] // 0x00000001898DAAC0-0x00000001898DAB00
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181A165B0-0x0000000181A16650
}

