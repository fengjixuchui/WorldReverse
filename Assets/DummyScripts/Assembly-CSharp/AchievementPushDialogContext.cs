/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AchievementPushDialogContext : BaseAutoCloseDialogContext // TypeDefIndex: 29483
{
	// Fields
	private const ulong LIMIT_STAY_TIME = 1500; // Metadata: 0x00B0F85D
	private MonoAchievementPushDialog _dialogMono; // 0x180
	private ulong _startTimeStamp; // 0x188
	public static Queue<AchievementPush> pushQueue; // 0x00
	public static bool isShowing; // 0x08

	// Nested types
	public class AchievementPush // TypeDefIndex: 29484
	{
		// Fields
		public string txtLabel; // 0x10
		public string txtTitle; // 0x18
		public string iconPath; // 0x20

		// Constructors
		public AchievementPush() {} // 0x0000000180FC89A0-0x0000000180FC8A10
	}

	// Constructors
	public AchievementPushDialogContext() {} // Dummy constructor
	public AchievementPushDialogContext(string txtLabel, string txtTitle, string iconPath, bool isNew = true /* Metadata: 0x00B0F85C */) {} // 0x0000000180FCA520-0x0000000180FCA7B0
	static AchievementPushDialogContext() {} // 0x0000000180FCA480-0x0000000180FCA520

	// Methods
	// [XID] // 0x00000001899C2330-0x00000001899C2350
	public override void SetupView() {} // 0x0000000180FCA060-0x0000000180FCA390
	// [XID] // 0x00000001899C9A20-0x00000001899C9A40
	public override void UpdateView() {} // 0x0000000180FCA390-0x0000000180FCA480
	// [XID] // 0x00000001899D12B0-0x00000001899D12D0
	public override void ClearView() {} // 0x0000000180FC9AF0-0x0000000180FC9C20
	// [XID] // 0x00000001899D8740-0x00000001899D8760
	private bool CanShow() => default; // 0x0000000180FC9CE0-0x0000000180FC9EF0
	[DebuggerHidden] // 0x00000001899DFE30-0x00000001899DFE70
	// [XID] // 0x00000001899DFE30-0x00000001899DFE70
	private IEnumerator CheckIfCanBeShowed() => default; // 0x0000000180FC9EF0-0x0000000180FCA000
}

