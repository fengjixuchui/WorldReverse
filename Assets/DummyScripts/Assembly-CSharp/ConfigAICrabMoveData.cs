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
public class ConfigAICrabMoveData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17457
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x14
	private SimpleSafeFloat radiusMinRawNum; // 0x18
	private SimpleSafeFloat radiusMaxRawNum; // 0x1C
	private SimpleSafeFloat moveTimeMinRawNum; // 0x20
	private SimpleSafeFloat moveTimeMaxRawNum; // 0x24
	private SimpleSafeFloat restTimeMinRawNum; // 0x28
	private SimpleSafeFloat restTimeMaxRawNum; // 0x2C
	private SimpleSafeFloat detectFrontDistanceRawNum; // 0x30

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189785080-0x00000001897850A0 */ get => default; /* [XID] */ /* 0x000000018978C590-0x000000018978C5B0 */ private set {} } // 0x00000001854A7980-0x00000001854A7A50 0x00000001854A7DD0-0x00000001854A7EB0
	public float turnSpeedOverride { /* [XID] */ /* 0x0000000189793A80-0x0000000189793AA0 */ get => default; /* [XID] */ /* 0x000000018979BCF0-0x000000018979BD10 */ private set {} } // 0x00000001854A7C10-0x00000001854A7CF0 0x00000001854A8640-0x00000001854A8720
	public float radiusMin { /* [XID] */ /* 0x00000001897A31C0-0x00000001897A31E0 */ get => default; /* [XID] */ /* 0x00000001897AA7C0-0x00000001897AA7E0 */ private set {} } // 0x00000001854A7670-0x00000001854A7750 0x00000001854A7CF0-0x00000001854A7DD0
	public float radiusMax { /* [XID] */ /* 0x00000001897B2250-0x00000001897B2270 */ get => default; /* [XID] */ /* 0x00000001897B9C70-0x00000001897B9C90 */ private set {} } // 0x00000001854A8560-0x00000001854A8640 0x00000001854A92B0-0x00000001854A9390
	public float moveTimeMin { /* [XID] */ /* 0x00000001897C1DB0-0x00000001897C1DD0 */ get => default; /* [XID] */ /* 0x00000001897C96E0-0x00000001897C9700 */ private set {} } // 0x00000001854A7EB0-0x00000001854A7F90 0x00000001854A91D0-0x00000001854A92B0
	public float moveTimeMax { /* [XID] */ /* 0x00000001897D0C50-0x00000001897D0C70 */ get => default; /* [XID] */ /* 0x00000001897D8AB0-0x00000001897D8AD0 */ private set {} } // 0x00000001854A9AB0-0x00000001854A9B90 0x00000001854A8B80-0x00000001854A8C60
	public float restTimeMin { /* [XID] */ /* 0x00000001897DFCF0-0x00000001897DFD10 */ get => default; /* [XID] */ /* 0x00000001897E7250-0x00000001897E7270 */ private set {} } // 0x00000001854A9B90-0x00000001854A9C70 0x00000001854A8C60-0x00000001854A8D40
	public float restTimeMax { /* [XID] */ /* 0x00000001897EEF90-0x00000001897EEFB0 */ get => default; /* [XID] */ /* 0x00000001897F6660-0x00000001897F6680 */ private set {} } // 0x00000001854A7B30-0x00000001854A7C10 0x00000001854A8AA0-0x00000001854A8B80
	public float detectFrontDistance { /* [XID] */ /* 0x00000001897FDD40-0x00000001897FDD60 */ get => default; /* [XID] */ /* 0x00000001898054F0-0x0000000189805510 */ private set {} } // 0x00000001854A7A50-0x00000001854A7B30 0x00000001854A9390-0x00000001854A9470

	// Constructors
	public ConfigAICrabMoveData() {} // 0x00000001854AA010-0x00000001854AA170

	// Methods
	// [XID] // 0x000000018980CAB0-0x000000018980CAD0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001854A9C70-0x00000001854A9E30
	// [XID] // 0x00000001898142D0-0x00000001898142F0
	public void InitEmpty() {} // 0x00000001854A8D40-0x00000001854A8ED0
	[BlackList] // 0x000000018981BE00-0x000000018981BE40
	// [XID] // 0x000000018981BE00-0x000000018981BE40
	public bool FromJson(JSONNode node) => default; // 0x00000001854A8720-0x00000001854A8AA0
	// [XID] // 0x0000000189826370-0x0000000189826390
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001854A69D0-0x00000001854A73A0
	// [XID] // 0x000000018982D9A0-0x000000018982D9C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F47 */, bool useObjectPool = false /* Metadata: 0x00AF6F4B */) => default; // 0x00000001854A8ED0-0x00000001854A91D0
	// [XID] // 0x0000000189835150-0x0000000189835170
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F4C */, bool useObjectPool = false /* Metadata: 0x00AF6F50 */) => default; // 0x00000001854A7F90-0x00000001854A8560
	[BlackList] // 0x000000018983C850-0x000000018983C890
	// [XID] // 0x000000018983C850-0x000000018983C890
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001854A73A0-0x00000001854A7670
	// [XID] // 0x0000000189846E10-0x0000000189846E30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001854A9470-0x00000001854A9AB0
	[BlackList] // 0x000000018984E3A0-0x000000018984E3E0
	// [XID] // 0x000000018984E3A0-0x000000018984E3E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001854A7750-0x00000001854A77F0
	[BlackList] // 0x0000000189858700-0x0000000189858740
	// [XID] // 0x0000000189858700-0x0000000189858740
	public virtual void AutoRecycleTypeFields() {} // 0x00000001854A77F0-0x00000001854A7980
	[BlackList] // 0x0000000189862BD0-0x0000000189862C10
	// [XID] // 0x0000000189862BD0-0x0000000189862C10
	public virtual void ReturnToObjectPool() {} // 0x00000001854A9F70-0x00000001854AA010
	[BlackList] // 0x000000018986CCB0-0x000000018986CCF0
	// [XID] // 0x000000018986CCB0-0x000000018986CCF0
	public virtual void OnPoolAllocated() {} // 0x00000001854A9ED0-0x00000001854A9F70
	[BlackList] // 0x00000001898773F0-0x0000000189877430
	// [XID] // 0x00000001898773F0-0x0000000189877430
	public virtual void OnBeforePoolRecycled() {} // 0x00000001854A9E30-0x00000001854A9ED0
}

