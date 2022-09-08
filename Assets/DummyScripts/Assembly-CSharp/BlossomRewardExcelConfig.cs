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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BlossomRewardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15267
{
	// Fields
	protected SimpleSafeUInt32 drop_idRawNum; // 0x10
	protected SimpleSafeUInt32 preview_rewardRawNum; // 0x14

	// Properties
	public uint drop_id { /* [XID] */ /* 0x0000000189AB2000-0x0000000189AB2020 */ get => default; /* [XID] */ /* 0x0000000189AB9250-0x0000000189AB9270 */ protected set {} } // 0x00000001819269B0-0x0000000181926A80 0x00000001819271B0-0x0000000181927290
	public uint preview_reward { /* [XID] */ /* 0x0000000189AC0E30-0x0000000189AC0E50 */ get => default; /* [XID] */ /* 0x0000000189AC8870-0x0000000189AC8890 */ protected set {} } // 0x00000001819270E0-0x00000001819271B0 0x0000000181926A80-0x0000000181926B60

	// Constructors
	public BlossomRewardExcelConfig() {} // 0x0000000181927470-0x00000001819274D0

	// Methods
	// [XID] // 0x0000000189ACFF90-0x0000000189ACFFB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181926B60-0x0000000181926D80
	// [XID] // 0x0000000189AD7E00-0x0000000189AD7E20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF05C3 */, bool useObjectPool = false /* Metadata: 0x00AF05C7 */) => default; // 0x0000000181926D80-0x00000001819270E0
	[BlackList] // 0x0000000189ADF930-0x0000000189ADF970
	// [XID] // 0x0000000189ADF930-0x0000000189ADF970
	public virtual void AutoAllocTypeFields() {} // 0x0000000181926830-0x00000001819268D0
	[BlackList] // 0x0000000189AE9DF0-0x0000000189AE9E30
	// [XID] // 0x0000000189AE9DF0-0x0000000189AE9E30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001819268D0-0x00000001819269B0
	[BlackList] // 0x0000000189AF4790-0x0000000189AF47D0
	// [XID] // 0x0000000189AF4790-0x0000000189AF47D0
	public virtual void ReturnToObjectPool() {} // 0x00000001819273D0-0x0000000181927470
	[BlackList] // 0x0000000189AFEF30-0x0000000189AFEF70
	// [XID] // 0x0000000189AFEF30-0x0000000189AFEF70
	public virtual void OnPoolAllocated() {} // 0x0000000181927330-0x00000001819273D0
	[BlackList] // 0x0000000189B09570-0x0000000189B095B0
	// [XID] // 0x0000000189B09570-0x0000000189B095B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181927290-0x0000000181927330
}

