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
public class SGVConfig : IAutoAllocRecycle // TypeDefIndex: 15411
{
	// Fields
	protected string _key; // 0x10
	protected SimpleSafeFloat valueRawNum; // 0x18

	// Properties
	public string key { /* [XID] */ /* 0x00000001897C0A80-0x00000001897C0AA0 */ get => default; /* [XID] */ /* 0x00000001897C8410-0x00000001897C8430 */ protected set {} } // 0x0000000181E27F00-0x0000000181E27FA0 0x0000000181E28700-0x0000000181E287B0
	public float value { /* [XID] */ /* 0x00000001897CF830-0x00000001897CF850 */ get => default; /* [XID] */ /* 0x00000001897D7160-0x00000001897D7180 */ protected set {} } // 0x0000000181E282B0-0x0000000181E28390 0x0000000181E281D0-0x0000000181E282B0

	// Constructors
	public SGVConfig() {} // 0x0000000181E28990-0x0000000181E289F0

	// Methods
	// [XID] // 0x00000001897DE6D0-0x00000001897DE6F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181E27FA0-0x0000000181E281D0
	// [XID] // 0x00000001897E6230-0x00000001897E6250
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1465 */, bool useObjectPool = false /* Metadata: 0x00AF1469 */) => default; // 0x0000000181E28390-0x0000000181E28700
	[BlackList] // 0x00000001897EDC50-0x00000001897EDC90
	// [XID] // 0x00000001897EDC50-0x00000001897EDC90
	public virtual void AutoAllocTypeFields() {} // 0x0000000181E27D80-0x0000000181E27E20
	[BlackList] // 0x00000001897F8520-0x00000001897F8560
	// [XID] // 0x00000001897F8520-0x00000001897F8560
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181E27E20-0x0000000181E27F00
	[BlackList] // 0x0000000189802B60-0x0000000189802BA0
	// [XID] // 0x0000000189802B60-0x0000000189802BA0
	public virtual void ReturnToObjectPool() {} // 0x0000000181E288F0-0x0000000181E28990
	[BlackList] // 0x000000018980CE70-0x000000018980CEB0
	// [XID] // 0x000000018980CE70-0x000000018980CEB0
	public virtual void OnPoolAllocated() {} // 0x0000000181E28850-0x0000000181E288F0
	[BlackList] // 0x00000001898178C0-0x0000000189817900
	// [XID] // 0x00000001898178C0-0x0000000189817900
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181E287B0-0x0000000181E28850
}

