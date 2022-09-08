/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MassiveElementReactionEvent // TypeDefIndex: 20583
{
	// Fields
	private static Queue<MassiveElementReactionEvent> _pool; // 0x00
	public EntityType entityType; // 0x10
	public MassiveEntityProxy proxy; // 0x18
	public ElementReactionSourceType reactionSourceType; // 0x20
	public ElementType sourceElementType; // 0x24
	public uint sourceElementCasterID; // 0x28
	public ElementType reactorElementType; // 0x2C
	public float durability; // 0x30
	public ElementReactionType elementReactionType; // 0x34

	// Constructors
	public MassiveElementReactionEvent() {} // 0x0000000182B7E640-0x0000000182B7E6A0
	static MassiveElementReactionEvent() {} // 0x0000000182B7E5B0-0x0000000182B7E640

	// Methods
	// [XID] // 0x00000001896E9A80-0x00000001896E9AA0
	private static MassiveElementReactionEvent Allocate() => default; // 0x0000000182B7E370-0x0000000182B7E4D0
	// [XID] // 0x00000001896F0C80-0x00000001896F0CA0
	private static void Deallocate(ref MassiveElementReactionEvent evt) {} // 0x0000000182B7E1C0-0x0000000182B7E2B0
	// [XID] // 0x00000001896F84C0-0x00000001896F84E0
	public static MassiveElementReactionEvent Create() => default; // 0x0000000182B7E2B0-0x0000000182B7E370
	// [XID] // 0x00000001896FFE40-0x00000001896FFE60
	public static void Release(ref MassiveElementReactionEvent evt) {} // 0x0000000182B7E4D0-0x0000000182B7E5B0
	// [XID] // 0x0000000189707560-0x0000000189707580
	public void Destroy() {} // 0x0000000182B7E120-0x0000000182B7E1C0
}

