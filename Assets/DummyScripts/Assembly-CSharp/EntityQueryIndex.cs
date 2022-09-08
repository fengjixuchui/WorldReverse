/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityQueryIndex // TypeDefIndex: 20808
{
	// Fields
	private int[] _entityQueryIndex; // 0x10
	private int[] _entityQueryDicIndex; // 0x18

	// Constructors
	public EntityQueryIndex() {} // 0x0000000181E90F40-0x0000000181E90FF0

	// Methods
	// [XID] // 0x0000000189BD78D0-0x0000000189BD78F0
	public static EntityQueryIndex Create() => default; // 0x0000000181E90C20-0x0000000181E90CE0
	// [XID] // 0x0000000189AAC2B0-0x0000000189AAC2D0
	public static void Release(ref EntityQueryIndex index) {} // 0x0000000181E90CE0-0x0000000181E90DA0
	// [XID] // 0x00000001896079A0-0x00000001896079C0
	internal void Init() {} // 0x0000000181E90B10-0x0000000181E90C20
	// [IDTag] // 0x00000001895F33D0-0x00000001895F3410
	// [XID] // 0x00000001895F33D0-0x00000001895F3410
	internal int GetIndex(EntityQueryType queryType) => default; // 0x0000000181E90E70-0x0000000181E90F40
	// [IDTag] // 0x00000001895FDB00-0x00000001895FDB40
	// [XID] // 0x00000001895FDB00-0x00000001895FDB40
	internal int GetIndex(EntityQueryDicType queryDicType) => default; // 0x0000000181E90DA0-0x0000000181E90E70
	// [IDTag] // 0x0000000189608770-0x00000001896087B0
	// [XID] // 0x0000000189608770-0x00000001896087B0
	internal void SetIndex(EntityQueryType queryType, int index) {} // 0x0000000181E90A20-0x0000000181E90B10
	// [IDTag] // 0x0000000189612CA0-0x0000000189612CE0
	// [XID] // 0x0000000189612CA0-0x0000000189612CE0
	internal void SetIndex(EntityQueryDicType queryDicType, int index) {} // 0x0000000181E90930-0x0000000181E90A20
}

