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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class FleurFairTipsExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15103
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _icon; // 0x18
	protected uint _titleTextMapHash; // 0x20
	protected uint _descTextMapHash; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897CE340-0x00000001897CE360 */ get => default; /* [XID] */ /* 0x00000001897D58D0-0x00000001897D58F0 */ protected set {} } // 0x0000000181DA8E10-0x0000000181DA8EE0 0x0000000181DA8470-0x0000000181DA8550
	public string icon { /* [XID] */ /* 0x00000001897DCFF0-0x00000001897DD010 */ get => default; /* [XID] */ /* 0x00000001897E48D0-0x00000001897E48F0 */ protected set {} } // 0x0000000181DA7860-0x0000000181DA7900 0x0000000181DA8C20-0x0000000181DA8CD0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x00000001897EC520-0x00000001897EC540 */ get => default; /* [XID] */ /* 0x00000001897F3E50-0x00000001897F3E70 */ protected set {} } // 0x0000000181DA7A80-0x0000000181DA7B20 0x0000000181DA7BD0-0x0000000181DA7C80
	public string title { /* [XID] */ /* 0x00000001897FB7B0-0x00000001897FB7D0 */ get => default; } // 0x0000000181DA8AA0-0x0000000181DA8C20 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189802C00-0x0000000189802C20 */ get => default; /* [XID] */ /* 0x000000018980A210-0x000000018980A230 */ protected set {} } // 0x0000000181DA8A00-0x0000000181DA8AA0 0x0000000181DA7B20-0x0000000181DA7BD0
	public string desc { /* [XID] */ /* 0x0000000189811920-0x0000000189811940 */ get => default; } // 0x0000000181DA82F0-0x0000000181DA8470 

	// Constructors
	public FleurFairTipsExcelConfig() {} // 0x0000000181DA8F80-0x0000000181DA8FE0

	// Methods
	// [IDTag] // 0x0000000189819570-0x00000001898195B0
	// [XID] // 0x0000000189819570-0x00000001898195B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181DA7C80-0x0000000181DA7FD0
	// [IDTag] // 0x0000000189823670-0x00000001898236B0
	// [XID] // 0x0000000189823670-0x00000001898236B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181DA7FD0-0x0000000181DA82F0
	// [XID] // 0x000000018982DF20-0x000000018982DF40
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF00E4 */, bool useObjectPool = false /* Metadata: 0x00AF00E8 */) => default; // 0x0000000181DA8550-0x0000000181DA8A00
	[BlackList] // 0x0000000189835530-0x0000000189835570
	// [XID] // 0x0000000189835530-0x0000000189835570
	public virtual void AutoAllocTypeFields() {} // 0x0000000181DA7900-0x0000000181DA79A0
	[BlackList] // 0x000000018983FB70-0x000000018983FBB0
	// [XID] // 0x000000018983FB70-0x000000018983FBB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181DA79A0-0x0000000181DA7A80
	[BlackList] // 0x0000000189849FD0-0x000000018984A010
	// [XID] // 0x0000000189849FD0-0x000000018984A010
	public virtual void ReturnToObjectPool() {} // 0x0000000181DA8EE0-0x0000000181DA8F80
	[BlackList] // 0x0000000189854140-0x0000000189854180
	// [XID] // 0x0000000189854140-0x0000000189854180
	public virtual void OnPoolAllocated() {} // 0x0000000181DA8D70-0x0000000181DA8E10
	[BlackList] // 0x000000018985E270-0x000000018985E2B0
	// [XID] // 0x000000018985E270-0x000000018985E2B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181DA8CD0-0x0000000181DA8D70
}

