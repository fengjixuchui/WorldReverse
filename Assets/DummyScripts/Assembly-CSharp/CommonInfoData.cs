/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CommonInfoData : ISimplePoolObject, ITickableObject<uint> // TypeDefIndex: 21391
{
	// Fields
	protected uint _key; // 0x10

	// Properties
	public virtual InfoType infoType { /* [XID] */ /* 0x0000000189AF13D0-0x0000000189AF13F0 */ get => default; } // 0x0000000180DE3AD0-0x0000000180DE3B70 
	public uint key { /* [XID] */ /* 0x0000000189AF89B0-0x0000000189AF89D0 */ get => default; } // 0x0000000180DE3A30-0x0000000180DE3AD0 
	public int index { get; set; } // 0x0000000180DE3CE0-0x0000000180DE3D40 0x0000000180DE3D40-0x0000000180DE3DA0

	// Nested types
	public enum InfoType // TypeDefIndex: 21392
	{
		INVALID = -1,
		BTN_TRANS = 0,
		COUNT = 1
	}

	// Constructors
	public CommonInfoData() {} // 0x0000000180DE3E40-0x0000000180DE3F60

	// Methods
	// [XID] // 0x0000000189B0EC90-0x0000000189B0ECB0
	public virtual void Init(uint pkey, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] list) {} // 0x0000000180DE3B70-0x0000000180DE3C30
	// [XID] // 0x0000000189B1D6B0-0x0000000189B1D6D0
	public virtual void ResetObject() {} // 0x0000000180DE3DA0-0x0000000180DE3E40
	// [XID] // 0x0000000189B250C0-0x0000000189B250E0
	public virtual void Tick(float deltaTime) {} // 0x0000000180DE3C30-0x0000000180DE3CE0
}

