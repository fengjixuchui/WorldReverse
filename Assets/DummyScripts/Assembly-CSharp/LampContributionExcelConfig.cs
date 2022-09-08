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
public class LampContributionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15174
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 contributionRawNum; // 0x14
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189BB85A0-0x0000000189BB85C0 */ get => default; /* [XID] */ /* 0x0000000189BBFF30-0x0000000189BBFF50 */ protected set {} } // 0x000000018399E750-0x000000018399E820 0x000000018399E050-0x000000018399E130
	public uint contribution { /* [XID] */ /* 0x0000000189BC79C0-0x0000000189BC79E0 */ get => default; /* [XID] */ /* 0x0000000189BCF4F0-0x0000000189BCF510 */ protected set {} } // 0x000000018399D920-0x000000018399D9F0 0x000000018399DF70-0x000000018399E050
	public uint rewardId { /* [XID] */ /* 0x0000000189BD6860-0x0000000189BD6880 */ get => default; /* [XID] */ /* 0x0000000189BDE5C0-0x0000000189BDE5E0 */ protected set {} } // 0x000000018399E540-0x000000018399E610 0x000000018399D6B0-0x000000018399D790

	// Constructors
	public LampContributionExcelConfig() {} // 0x000000018399E8C0-0x000000018399EA90

	// Methods
	// [IDTag] // 0x00000001895EB090-0x00000001895EB0D0
	// [XID] // 0x00000001895EB090-0x00000001895EB0D0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018399D9F0-0x000000018399DCD0
	// [IDTag] // 0x00000001895F5750-0x00000001895F5790
	// [XID] // 0x00000001895F5750-0x00000001895F5790
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018399DCD0-0x000000018399DF70
	// [XID] // 0x00000001895FFDD0-0x00000001895FFDF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02E5 */, bool useObjectPool = false /* Metadata: 0x00AF02E9 */) => default; // 0x000000018399E130-0x000000018399E540
	[BlackList] // 0x00000001896074C0-0x0000000189607500
	// [XID] // 0x00000001896074C0-0x0000000189607500
	public virtual void AutoAllocTypeFields() {} // 0x000000018399D790-0x000000018399D830
	[BlackList] // 0x0000000189611E60-0x0000000189611EA0
	// [XID] // 0x0000000189611E60-0x0000000189611EA0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018399D830-0x000000018399D920
	[BlackList] // 0x000000018961C6E0-0x000000018961C720
	// [XID] // 0x000000018961C6E0-0x000000018961C720
	public virtual void ReturnToObjectPool() {} // 0x000000018399E820-0x000000018399E8C0
	[BlackList] // 0x0000000189626AE0-0x0000000189626B20
	// [XID] // 0x0000000189626AE0-0x0000000189626B20
	public virtual void OnPoolAllocated() {} // 0x000000018399E6B0-0x000000018399E750
	[BlackList] // 0x0000000189631520-0x0000000189631560
	// [XID] // 0x0000000189631520-0x0000000189631560
	public virtual void OnBeforePoolRecycled() {} // 0x000000018399E610-0x000000018399E6B0
}

