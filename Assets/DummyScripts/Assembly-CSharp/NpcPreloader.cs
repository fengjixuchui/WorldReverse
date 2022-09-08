/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NpcPreloader : EntityPreloader // TypeDefIndex: 19880
{
	// Fields
	private static string[] RESERVED_NPC_TALK_ASYNC_PRELOADING_MARK; // 0x00
	private static string[] RESERVED_NPC_ANIME_ASYNC_PRELOADING_MARK; // 0x08
	private int _curLoadingAnimeCount; // 0x78

	// Constructors
	public NpcPreloader() {} // Dummy constructor
	public NpcPreloader(BaseEntity entity, ConfigPreloadType preloadType) {} // 0x00000001830B2300-0x00000001830B23B0
	static NpcPreloader() {} // 0x00000001830B2190-0x00000001830B2300

	// Methods
	// [XID] // 0x0000000189B179E0-0x0000000189B17A00
	protected override void AsyncPreloadOther() {} // 0x00000001830B1190-0x00000001830B1250
	// [XID] // 0x0000000189B1F380-0x0000000189B1F3A0
	protected override void ReleasePreloadOther() {} // 0x00000001830B1EB0-0x00000001830B1F70
	// [XID] // 0x0000000189B26B70-0x0000000189B26B90
	private void AsyncPreloadNpcTalk() {} // 0x00000001830B1330-0x00000001830B14C0
	// [XID] // 0x0000000189B2DD60-0x0000000189B2DD80
	private void OnAsyncPreloadNpcTalk() {} // 0x00000001830B0F60-0x00000001830B1060
	// [XID] // 0x0000000189B35190-0x0000000189B351B0
	private void ReleasePreloadNpcTalk() {} // 0x00000001830B1250-0x00000001830B1330
	// [XID] // 0x0000000189B3CAA0-0x0000000189B3CAC0
	private void AsyncPreloadNpcAnime() {} // 0x00000001830B1570-0x00000001830B1CB0
	// [XID] // 0x0000000189B447B0-0x0000000189B447D0
	private void OnAsyncPreloadNpcAnime(bool success) {} // 0x00000001830B1F70-0x00000001830B2090
	// [XID] // 0x0000000189B4C020-0x0000000189B4C040
	private void ReleasePreloadNpcAnime() {} // 0x00000001830B2090-0x00000001830B2130
	// [IDTag] // 0x0000000189B53560-0x0000000189B535A0
	// [XID] // 0x0000000189B53560-0x0000000189B535A0
	private void AsyncPreloadNPCAnimEventPattern() {} // 0x00000001830B1D60-0x00000001830B1EB0
	// [IDTag] // 0x0000000189B5DF20-0x0000000189B5DF60
	// [XID] // 0x0000000189B5DF20-0x0000000189B5DF60
	private void AsyncPreloadNPCAnimEventPattern(string pattern) {} // 0x00000001830B1CB0-0x00000001830B1D60
	// [XID] // 0x0000000189B686E0-0x0000000189B68700
	private void AsyncNPCAnimEventPatternPreloaded(string pattern) {} // 0x00000001830B14C0-0x00000001830B1570
	// [XID] // 0x0000000189B6FB00-0x0000000189B6FB20
	private void ReleasePreloadNPCAnimPattern() {} // 0x00000001830B1060-0x00000001830B1130
}

