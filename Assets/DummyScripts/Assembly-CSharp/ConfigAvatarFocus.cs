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
public class ConfigAvatarFocus : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17808
{
	// Fields
	private SimpleSafeFloat cameraHorMoveSpeedRawNum; // 0x10
	private SimpleSafeFloat cameraVerMoveSpeedRawNum; // 0x14
	private SimpleSafeFloat cameraHorStickyRatioRawNum; // 0x18
	private SimpleSafeFloat cameraVerStickyRatioRawNum; // 0x1C
	private SimpleSafeFloat autoFocusHorSpeedRawNum; // 0x20
	private SimpleSafeFloat autoFocusVerSpeedRawNum; // 0x24
	private SimpleSafeFloat autoFocusRangeCoefRawNum; // 0x28
	private SimpleSafeFloat gyroHorMoveSpeedRawNum; // 0x2C
	private SimpleSafeFloat gyroVerMoveSpeedRawNum; // 0x30

	// Properties
	public float cameraHorMoveSpeed { /* [XID] */ /* 0x0000000189AE9950-0x0000000189AE9970 */ get => default; /* [XID] */ /* 0x0000000189AF16F0-0x0000000189AF1710 */ private set {} } // 0x0000000184634200-0x00000001846342E0 0x0000000184635970-0x0000000184635A50
	public float cameraVerMoveSpeed { /* [XID] */ /* 0x000000018968F260-0x000000018968F280 */ get => default; /* [XID] */ /* 0x0000000189B002B0-0x0000000189B002D0 */ private set {} } // 0x0000000184636600-0x00000001846366E0 0x00000001846348B0-0x0000000184634990
	public float cameraHorStickyRatio { /* [XID] */ /* 0x0000000189AB6C30-0x0000000189AB6C50 */ get => default; /* [XID] */ /* 0x0000000189B0F150-0x0000000189B0F170 */ private set {} } // 0x0000000184635A50-0x0000000184635B30 0x00000001846356D0-0x00000001846357B0
	public float cameraVerStickyRatio { /* [XID] */ /* 0x0000000189AB99A0-0x0000000189AB99C0 */ get => default; /* [XID] */ /* 0x0000000189B1DBD0-0x0000000189B1DBF0 */ private set {} } // 0x0000000184634120-0x0000000184634200 0x00000001846357B0-0x0000000184635890
	public float autoFocusHorSpeed { /* [XID] */ /* 0x0000000189B25400-0x0000000189B25420 */ get => default; /* [XID] */ /* 0x0000000189B2C9F0-0x0000000189B2CA10 */ private set {} } // 0x0000000184636220-0x0000000184636300 0x00000001846355F0-0x00000001846356D0
	public float autoFocusVerSpeed { /* [XID] */ /* 0x0000000189B33DC0-0x0000000189B33DE0 */ get => default; /* [XID] */ /* 0x0000000189B3B6B0-0x0000000189B3B6D0 */ private set {} } // 0x0000000184634DF0-0x0000000184634ED0 0x0000000184634ED0-0x0000000184634FB0
	public float autoFocusRangeCoef { /* [XID] */ /* 0x0000000189B43090-0x0000000189B430B0 */ get => default; /* [XID] */ /* 0x0000000189B4A890-0x0000000189B4A8B0 */ private set {} } // 0x0000000184635890-0x0000000184635970 0x0000000184636140-0x0000000184636220
	public float gyroHorMoveSpeed { /* [XID] */ /* 0x0000000189B52020-0x0000000189B52040 */ get => default; /* [XID] */ /* 0x0000000189B59940-0x0000000189B59960 */ private set {} } // 0x0000000184634FB0-0x0000000184635090 0x0000000184634990-0x0000000184634A70
	public float gyroVerMoveSpeed { /* [XID] */ /* 0x0000000189983CF0-0x0000000189983D10 */ get => default; /* [XID] */ /* 0x0000000189B68900-0x0000000189B68920 */ private set {} } // 0x0000000184633170-0x0000000184633250 0x0000000184635090-0x0000000184635170

	// Constructors
	public ConfigAvatarFocus() {} // 0x0000000184636780-0x00000001846368C0

	// Methods
	// [XID] // 0x0000000189B6FE20-0x0000000189B6FE40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184636300-0x00000001846364C0
	// [XID] // 0x0000000189B77290-0x0000000189B772B0
	public void InitEmpty() {} // 0x0000000184635170-0x00000001846352F0
	[BlackList] // 0x0000000189B7E920-0x0000000189B7E960
	// [XID] // 0x0000000189B7E920-0x0000000189B7E960
	public bool FromJson(JSONNode node) => default; // 0x0000000184634A70-0x0000000184634DF0
	// [XID] // 0x0000000189B89270-0x0000000189B89290
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184633250-0x0000000184633C30
	// [XID] // 0x0000000189B90810-0x0000000189B90830
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7D6D */, bool useObjectPool = false /* Metadata: 0x00AF7D71 */) => default; // 0x00000001846352F0-0x00000001846355F0
	// [XID] // 0x0000000189B97CC0-0x0000000189B97CE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7D72 */, bool useObjectPool = false /* Metadata: 0x00AF7D76 */) => default; // 0x00000001846342E0-0x00000001846348B0
	[BlackList] // 0x0000000189B9F0B0-0x0000000189B9F0F0
	// [XID] // 0x0000000189B9F0B0-0x0000000189B9F0F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184633C30-0x0000000184633F00
	// [XID] // 0x0000000189BA9800-0x0000000189BA9820
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184635B30-0x0000000184636140
	[BlackList] // 0x0000000189BB0FF0-0x0000000189BB1030
	// [XID] // 0x0000000189BB0FF0-0x0000000189BB1030
	public virtual void AutoAllocTypeFields() {} // 0x0000000184633F00-0x0000000184633FA0
	[BlackList] // 0x0000000189BBB290-0x0000000189BBB2D0
	// [XID] // 0x0000000189BBB290-0x0000000189BBB2D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184633FA0-0x0000000184634120
	[BlackList] // 0x0000000189BC5DE0-0x0000000189BC5E20
	// [XID] // 0x0000000189BC5DE0-0x0000000189BC5E20
	public virtual void ReturnToObjectPool() {} // 0x00000001846366E0-0x0000000184636780
	[BlackList] // 0x0000000189BD06F0-0x0000000189BD0730
	// [XID] // 0x0000000189BD06F0-0x0000000189BD0730
	public virtual void OnPoolAllocated() {} // 0x0000000184636560-0x0000000184636600
	[BlackList] // 0x0000000189BDAF60-0x0000000189BDAFA0
	// [XID] // 0x0000000189BDAF60-0x0000000189BDAFA0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001846364C0-0x0000000184636560
}

