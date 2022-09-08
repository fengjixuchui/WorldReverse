/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnimatorEventEmoSync : AnimatorEvent // TypeDefIndex: 19313
{
	// Fields
	public EmoSyncEventType type; // 0x20
	// [InspectorShowIf] // 0x00000001897627E0-0x0000000189762810
	public uint dialogID; // 0x24
	// [InspectorShowIf] // 0x000000018976B630-0x000000018976B660
	public string emoSyncAssetPath; // 0x28
	private bool _show_DIALOG_ID; // 0x30
	private bool _show_ASSET_PATH; // 0x31

	// Properties
	private bool show_DIALOG_ID { /* [XID] */ /* 0x0000000189774250-0x0000000189774270 */ get => default; } // 0x000000018554AE20-0x000000018554AEC0 
	private bool show_ASSET_PATH { /* [XID] */ /* 0x000000018977BA60-0x000000018977BA80 */ get => default; } // 0x000000018554AB20-0x000000018554ABC0 

	// Nested types
	public enum EmoSyncEventType // TypeDefIndex: 19314
	{
		DIALOG = 0,
		EMO_SYNC_ONLY = 1
	}

	// Constructors
	public AnimatorEventEmoSync() {} // 0x000000018554B060-0x000000018554B0D0

	// Methods
	// [XID] // 0x0000000189783470-0x0000000189783490
	public override AnimatorEventEntry ConvertToEntry() => default; // 0x000000018554A870-0x000000018554AA70
	// [XID] // 0x000000018978AAE0-0x000000018978AB00
	public override void ParseFromEntry(AnimatorEventEntry entry) {} // 0x000000018554AEC0-0x000000018554B060
	// [XID] // 0x0000000189792140-0x0000000189792160
	public override void HandleAnimatorEvent(VCAnimatorEvent vcAnimatorEvent, AnimatorStateInfo? curStateInfo = default) {} // 0x000000018554ABC0-0x000000018554AE20
}

