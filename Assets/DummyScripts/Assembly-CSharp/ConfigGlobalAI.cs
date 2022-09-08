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
public class ConfigGlobalAI : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18098
{
	// Fields
	private SimpleSafeFloat avatarMeleeSlotRadiusRawNum; // 0x10
	private SimpleSafeFloat avoidanceRadiusRawNum; // 0x14
	private SimpleSafeFloat avoidanceForceRawNum; // 0x18
	private SimpleSafeFloat lod0RawNum; // 0x1C
	private SimpleSafeFloat lod1RawNum; // 0x20
	private SimpleSafeFloat lod2RawNum; // 0x24
	private SimpleSafeUInt32[] _sensingIgnoreCampIDs; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigPublicAISkillCD> _publicCDs; // 0x30
	private Dictionary<ConfigWeatherType, NeuronName[]> _defaultWeatherNeuronMapping; // 0x38
	private bool _useServerPathfinding; // 0x40

	// Properties
	public float avatarMeleeSlotRadius { /* [XID] */ /* 0x000000018974C760-0x000000018974C780 */ get => default; /* [XID] */ /* 0x0000000189753A00-0x0000000189753A20 */ private set {} } // 0x00000001846C2600-0x00000001846C26E0 0x00000001846C50D0-0x00000001846C51B0
	public float avoidanceRadius { /* [XID] */ /* 0x000000018975B000-0x000000018975B020 */ get => default; /* [XID] */ /* 0x0000000189762950-0x0000000189762970 */ private set {} } // 0x00000001846C4CF0-0x00000001846C4DD0 0x00000001846C5B00-0x00000001846C5BE0
	public float avoidanceForce { /* [XID] */ /* 0x0000000189769F70-0x0000000189769F90 */ get => default; /* [XID] */ /* 0x0000000189771770-0x0000000189771790 */ private set {} } // 0x00000001846C3280-0x00000001846C3360 0x00000001846C44B0-0x00000001846C4590
	public float lod0 { /* [XID] */ /* 0x0000000189778EE0-0x0000000189778F00 */ get => default; /* [XID] */ /* 0x00000001897805E0-0x0000000189780600 */ private set {} } // 0x00000001846C4A90-0x00000001846C4B70 0x00000001846C4270-0x00000001846C4350
	public float lod1 { /* [XID] */ /* 0x0000000189787DC0-0x0000000189787DE0 */ get => default; /* [XID] */ /* 0x000000018978F340-0x000000018978F360 */ private set {} } // 0x00000001846C4910-0x00000001846C49F0 0x00000001846C3830-0x00000001846C3910
	public float lod2 { /* [XID] */ /* 0x00000001898BC350-0x00000001898BC370 */ get => default; /* [XID] */ /* 0x000000018979EC70-0x000000018979EC90 */ private set {} } // 0x00000001846C5260-0x00000001846C5340 0x00000001846C3910-0x00000001846C39F0
	public SimpleSafeUInt32[] sensingIgnoreCampIDs { /* [XID] */ /* 0x000000018968D650-0x000000018968D670 */ get => default; /* [XID] */ /* 0x00000001897AD710-0x00000001897AD730 */ private set {} } // 0x00000001846C5340-0x00000001846C53E0 0x00000001846C51B0-0x00000001846C5260
	public Dictionary<string, ConfigPublicAISkillCD> publicCDs { /* [XID] */ /* 0x00000001897B5870-0x00000001897B5890 */ get => default; /* [XID] */ /* 0x00000001897BD5A0-0x00000001897BD5C0 */ private set {} } // 0x00000001846C49F0-0x00000001846C4A90 0x00000001846C5BE0-0x00000001846C5C90
	public Dictionary<ConfigWeatherType, NeuronName[]> defaultWeatherNeuronMapping { /* [XID] */ /* 0x00000001897C49A0-0x00000001897C49C0 */ get => default; /* [XID] */ /* 0x00000001897CC1B0-0x00000001897CC1D0 */ private set {} } // 0x00000001846C26E0-0x00000001846C2780 0x00000001846C4350-0x00000001846C4400
	public bool useServerPathfinding { /* [XID] */ /* 0x00000001897D3B00-0x00000001897D3B20 */ get => default; /* [XID] */ /* 0x00000001897DB570-0x00000001897DB590 */ private set {} } // 0x00000001846C39F0-0x00000001846C3A90 0x00000001846C4400-0x00000001846C44B0

	// Constructors
	public ConfigGlobalAI() {} // 0x00000001846C6050-0x00000001846C60C0

	// Methods
	// [XID] // 0x00000001897E2C60-0x00000001897E2C80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001846C5C90-0x00000001846C5E70
	// [XID] // 0x00000001897EA440-0x00000001897EA460
	public void InitEmpty() {} // 0x00000001846C4B70-0x00000001846C4CF0
	[BlackList] // 0x00000001897F21D0-0x00000001897F2210
	// [XID] // 0x00000001897F21D0-0x00000001897F2210
	public bool FromJson(JSONNode node) => default; // 0x00000001846C4590-0x00000001846C4910
	// [XID] // 0x00000001897FCA00-0x00000001897FCA20
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001846C2780-0x00000001846C3280
	// [XID] // 0x0000000189803F30-0x0000000189803F50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AEB */, bool useObjectPool = false /* Metadata: 0x00AF8AEF */) => default; // 0x00000001846C4DD0-0x00000001846C50D0
	// [XID] // 0x000000018980B300-0x000000018980B320
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AF0 */, bool useObjectPool = false /* Metadata: 0x00AF8AF4 */) => default; // 0x00000001846C3A90-0x00000001846C4270
	[BlackList] // 0x0000000189812A40-0x0000000189812A80
	// [XID] // 0x0000000189812A40-0x0000000189812A80
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001846C3360-0x00000001846C3630
	// [XID] // 0x000000018981D5F0-0x000000018981D610
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001846C53E0-0x00000001846C5B00
	[BlackList] // 0x0000000189824AC0-0x0000000189824B00
	// [XID] // 0x0000000189824AC0-0x0000000189824B00
	public virtual void AutoAllocTypeFields() {} // 0x00000001846C3630-0x00000001846C36D0
	[BlackList] // 0x000000018982F040-0x000000018982F080
	// [XID] // 0x000000018982F040-0x000000018982F080
	public virtual void AutoRecycleTypeFields() {} // 0x00000001846C36D0-0x00000001846C3830
	[BlackList] // 0x0000000189839740-0x0000000189839780
	// [XID] // 0x0000000189839740-0x0000000189839780
	public virtual void ReturnToObjectPool() {} // 0x00000001846C5FB0-0x00000001846C6050
	[BlackList] // 0x0000000189843DE0-0x0000000189843E20
	// [XID] // 0x0000000189843DE0-0x0000000189843E20
	public virtual void OnPoolAllocated() {} // 0x00000001846C5F10-0x00000001846C5FB0
	[BlackList] // 0x000000018984E280-0x000000018984E2C0
	// [XID] // 0x000000018984E280-0x000000018984E2C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001846C5E70-0x00000001846C5F10
}

