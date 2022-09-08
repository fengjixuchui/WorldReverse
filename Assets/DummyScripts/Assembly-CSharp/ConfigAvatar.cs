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
public class ConfigAvatar : ConfigCharacter, IAutoAllocRecycle // TypeDefIndex: 18024
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarShoot _shootConfig; // 0x98
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarAudio _audio; // 0xA0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarControllerAssembly _controllerAssembly; // 0xA8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMoveStateEffect _moveStateEffect; // 0xB0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarPerform _perform; // 0xB8

	// Properties
	public ConfigAvatarShoot shootConfig { /* [XID] */ /* 0x00000001897F0840-0x00000001897F0860 */ get => default; /* [XID] */ /* 0x00000001897F7FC0-0x00000001897F7FE0 */ private set {} } // 0x0000000183B9B1A0-0x0000000183B9B250 0x0000000183B9CEE0-0x0000000183B9CF90
	public ConfigAvatarAudio audio { /* [XID] */ /* 0x00000001897FF690-0x00000001897FF6B0 */ get => default; /* [XID] */ /* 0x0000000189806E50-0x0000000189806E70 */ private set {} } // 0x0000000183B9C540-0x0000000183B9C5F0 0x0000000183B9BF00-0x0000000183B9BFB0
	public ConfigAvatarControllerAssembly controllerAssembly { /* [XID] */ /* 0x000000018980E4D0-0x000000018980E4F0 */ get => default; /* [XID] */ /* 0x0000000189815BB0-0x0000000189815BD0 */ private set {} } // 0x0000000183B9C5F0-0x0000000183B9C6A0 0x0000000183B9BFB0-0x0000000183B9C060
	public ConfigMoveStateEffect moveStateEffect { /* [XID] */ /* 0x000000018981D650-0x000000018981D670 */ get => default; /* [XID] */ /* 0x0000000189824B40-0x0000000189824B60 */ private set {} } // 0x0000000183B9C3A0-0x0000000183B9C450 0x0000000183B9C0D0-0x0000000183B9C180
	public ConfigAvatarPerform perform { /* [XID] */ /* 0x00000001897A8230-0x00000001897A8250 */ get => default; /* [XID] */ /* 0x00000001898339C0-0x00000001898339E0 */ private set {} } // 0x0000000183B9A0E0-0x0000000183B9A190 0x0000000183B9D600-0x0000000183B9D6B0

	// Constructors
	public ConfigAvatar() {} // 0x0000000183B9D750-0x0000000183B9D7B0

	// Methods
	// [XID] // 0x000000018983AF40-0x000000018983AF60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B9D460-0x0000000183B9D600
	// [XID] // 0x0000000189842620-0x0000000189842640
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183B9CD90-0x0000000183B9CEE0
	// [XID] // 0x00000001898499F0-0x0000000189849A10
	public override ConfigEntity Clone(bool useObjectPool = false /* Metadata: 0x00AF8703 */) => default; // 0x0000000183B9C9A0-0x0000000183B9CA80
	// [XID] // 0x0000000189851150-0x0000000189851170
	public override int GetHashNum() => default; // 0x0000000183B9AFF0-0x0000000183B9B0C0
	// [XID] // 0x0000000189858640-0x0000000189858660
	public override void InitEmpty() {} // 0x0000000183B9C180-0x0000000183B9C2C0
	[BlackList] // 0x000000018985F6D0-0x000000018985F710
	// [XID] // 0x000000018985F6D0-0x000000018985F710
	public override bool FromJson(JSONNode node) => default; // 0x0000000183B9B960-0x0000000183B9BCE0
	// [XID] // 0x0000000189869FA0-0x0000000189869FC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183B9A210-0x0000000183B9A840
	[BlackList] // 0x00000001898712F0-0x0000000189871330
	// [XID] // 0x00000001898712F0-0x0000000189871330
	public static new ConfigAvatar ParseFromJson(JSONNode node) => default; // 0x0000000183B9CAE0-0x0000000183B9CD30
	// [XID] // 0x000000018987BBC0-0x000000018987BBE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8704 */, bool useObjectPool = false /* Metadata: 0x00AF8708 */) => default; // 0x0000000183B9C6A0-0x0000000183B9C9A0
	// [XID] // 0x0000000189882D50-0x0000000189882D70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8709 */, bool useObjectPool = false /* Metadata: 0x00AF870D */) => default; // 0x0000000183B9B250-0x0000000183B9B860
	// [XID] // 0x000000018988A4F0-0x000000018988A510
	public static new ConfigAvatar ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF870E */, bool useObjectPool = false /* Metadata: 0x00AF8712 */) => default; // 0x0000000183B9BCE0-0x0000000183B9BF00
	[BlackList] // 0x00000001898919A0-0x00000001898919E0
	// [XID] // 0x00000001898919A0-0x00000001898919E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B9A840-0x0000000183B9AB10
	// [XID] // 0x000000018989BFA0-0x000000018989BFC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B9CF90-0x0000000183B9D460
	[BlackList] // 0x00000001898A3660-0x00000001898A36A0
	// [XID] // 0x00000001898A3660-0x00000001898A36A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183B9C450-0x0000000183B9C540
	[BlackList] // 0x00000001898ADED0-0x00000001898ADF10
	// [XID] // 0x00000001898ADED0-0x00000001898ADF10
	public override void AutoAllocTypeFields() {} // 0x0000000183B9AB10-0x0000000183B9ABB0
	[BlackList] // 0x00000001898B8540-0x00000001898B8580
	// [XID] // 0x00000001898B8540-0x00000001898B8580
	public override void AutoRecycleTypeFields() {} // 0x0000000183B9ABB0-0x0000000183B9AED0
	[BlackList] // 0x00000001898C2AC0-0x00000001898C2B00
	// [XID] // 0x00000001898C2AC0-0x00000001898C2B00
	public override void ReturnToObjectPool() {} // 0x0000000183B9D6B0-0x0000000183B9D750
}

