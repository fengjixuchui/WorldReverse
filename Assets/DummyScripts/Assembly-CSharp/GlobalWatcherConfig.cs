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
public class GlobalWatcherConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 16262
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected WatcherPredicateConfig[] _predicateConfigs; // 0x28

	// Properties
	public WatcherPredicateConfig[] predicateConfigs { /* [XID] */ /* 0x0000000189968440-0x0000000189968460 */ get => default; /* [XID] */ /* 0x000000018996F8E0-0x000000018996F900 */ protected set {} } // 0x000000018426B2E0-0x000000018426B380 0x000000018426B470-0x000000018426B520

	// Constructors
	public GlobalWatcherConfig() {} // 0x000000018426BB80-0x000000018426BBE0

	// Methods
	// [IDTag] // 0x0000000189977660-0x00000001899776A0
	// [XID] // 0x0000000189977660-0x00000001899776A0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018426AA00-0x000000018426AEC0
	// [IDTag] // 0x0000000189981F80-0x0000000189981FC0
	// [XID] // 0x0000000189981F80-0x0000000189981FC0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018426AEC0-0x000000018426B2E0
	// [XID] // 0x000000018998C670-0x000000018998C690
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF35DE */, bool useObjectPool = false /* Metadata: 0x00AF35E2 */) => default; // 0x000000018426B520-0x000000018426BA80
	[BlackList] // 0x0000000189994370-0x00000001899943B0
	// [XID] // 0x0000000189994370-0x00000001899943B0
	public override void AutoAllocTypeFields() {} // 0x000000018426A7B0-0x000000018426A850
	[BlackList] // 0x000000018999ED30-0x000000018999ED70
	// [XID] // 0x000000018999ED30-0x000000018999ED70
	public override void AutoRecycleTypeFields() {} // 0x000000018426A850-0x000000018426A900
	[BlackList] // 0x00000001899A9580-0x00000001899A95C0
	// [XID] // 0x00000001899A9580-0x00000001899A95C0
	public override void ReturnToObjectPool() {} // 0x000000018426BAE0-0x000000018426BB80
}

