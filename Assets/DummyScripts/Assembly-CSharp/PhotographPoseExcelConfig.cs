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
public class PhotographPoseExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15944
{
	// Fields
	protected SimpleSafeUInt32 character_idRawNum; // 0x10
	protected SimpleSafeUInt32[] _pose_id; // 0x18

	// Properties
	public uint character_id { /* [XID] */ /* 0x00000001897C4E80-0x00000001897C4EA0 */ get => default; /* [XID] */ /* 0x00000001897CC6D0-0x00000001897CC6F0 */ protected set {} } // 0x0000000182B5C860-0x0000000182B5C930 0x0000000182B5C780-0x0000000182B5C860
	public SimpleSafeUInt32[] pose_id { /* [XID] */ /* 0x00000001897D3F60-0x00000001897D3F80 */ get => default; /* [XID] */ /* 0x00000001897DB7D0-0x00000001897DB7F0 */ protected set {} } // 0x0000000182B5C2C0-0x0000000182B5C360 0x0000000182B5C6D0-0x0000000182B5C780

	// Constructors
	public PhotographPoseExcelConfig() {} // 0x0000000182B5CB10-0x0000000182B5CB70

	// Methods
	// [IDTag] // 0x00000001897E3000-0x00000001897E3040
	// [XID] // 0x00000001897E3000-0x00000001897E3040
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182B5BBF0-0x0000000182B5BF80
	// [IDTag] // 0x00000001897EDB30-0x00000001897EDB70
	// [XID] // 0x00000001897EDB30-0x00000001897EDB70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182B5BF80-0x0000000182B5C2C0
	// [XID] // 0x00000001897F8480-0x00000001897F84A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BD9 */, bool useObjectPool = false /* Metadata: 0x00AF2BDD */) => default; // 0x0000000182B5C360-0x0000000182B5C6D0
	[BlackList] // 0x00000001897FFB90-0x00000001897FFBD0
	// [XID] // 0x00000001897FFB90-0x00000001897FFBD0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B5BA70-0x0000000182B5BB10
	[BlackList] // 0x000000018980A070-0x000000018980A0B0
	// [XID] // 0x000000018980A070-0x000000018980A0B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B5BB10-0x0000000182B5BBF0
	[BlackList] // 0x0000000189814630-0x0000000189814670
	// [XID] // 0x0000000189814630-0x0000000189814670
	public virtual void ReturnToObjectPool() {} // 0x0000000182B5CA70-0x0000000182B5CB10
	[BlackList] // 0x000000018981F1E0-0x000000018981F220
	// [XID] // 0x000000018981F1E0-0x000000018981F220
	public virtual void OnPoolAllocated() {} // 0x0000000182B5C9D0-0x0000000182B5CA70
	[BlackList] // 0x0000000189829750-0x0000000189829790
	// [XID] // 0x0000000189829750-0x0000000189829790
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B5C930-0x0000000182B5C9D0
}

