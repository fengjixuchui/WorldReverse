/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityUISpawnTokenCache : BaseActionTokenCache // TypeDefIndex: 32035
{
	// Fields
	private VCElementReactionPlugin _plugin; // 0x38
	private ElementReactionType _reaction; // 0x40
	private ElementType _sourceElementType; // 0x44
	private ElementType _reactorElementType; // 0x48

	// Constructors
	public EntityUISpawnTokenCache() {} // 0x0000000183CDBDB0-0x0000000183CDBE10

	// Methods
	// [XID] // 0x0000000189B301D0-0x0000000189B301F0
	public static EntityUISpawnTokenCache CreateUISpawnTokenCache(VCElementReactionPlugin plugin, ElementReactionType reaction, ElementType sourceElementType, ElementType reactorElementType, EntityInternalBaseConfig actionConfig, BaseEntity targetEntity) => default; // 0x0000000183CDB750-0x0000000183CDB8A0
	// [XID] // 0x0000000189ADB6E0-0x0000000189ADB700
	public static void Release(EntityUISpawnTokenCache cache) {} // 0x0000000183CDBC10-0x0000000183CDBCE0
	// [XID] // 0x0000000189B46CC0-0x0000000189B46CE0
	public void Init(VCElementReactionPlugin plugin, ElementReactionType reaction, ElementType sourceElementType, ElementType reactorElementType, EntityInternalBaseConfig actionConfig, BaseEntity targetEntity) {} // 0x0000000183CDB9E0-0x0000000183CDBB00
	// [XID] // 0x0000000189AEA930-0x0000000189AEA950
	public override bool HandleTokenCache() => default; // 0x0000000183CDB8A0-0x0000000183CDB9E0
	// [XID] // 0x0000000189AF2220-0x0000000189AF2240
	public override void Clear() {} // 0x0000000183CDBB00-0x0000000183CDBBB0
	// [XID] // 0x0000000189AF9B40-0x0000000189AF9B60
	public override void Destroy() {} // 0x0000000183CDB6B0-0x0000000183CDB750
}

