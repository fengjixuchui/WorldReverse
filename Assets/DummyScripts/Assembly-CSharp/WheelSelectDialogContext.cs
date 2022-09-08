/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WheelSelectDialogContext : BaseDialogContext // TypeDefIndex: 29347
{
	// Fields
	private static object[] _skillInfo; // 0x00
	public ulong curSelectGuid; // 0x178
	public Vector3 showPos; // 0x180
	public int allItems; // 0x18C

	// Constructors
	public WheelSelectDialogContext() {} // Dummy constructor
	public WheelSelectDialogContext(Vector3 pos) {} // 0x000000018315D4F0-0x000000018315D5B0
	static WheelSelectDialogContext() {} // 0x000000018315D280-0x000000018315D4F0

	// Methods
	// [XID] // 0x000000018991A1A0-0x000000018991A1C0
	public static Color GetSkillIconColor(uint id) => default; // 0x000000018315C420-0x000000018315C590
	// [XID] // 0x00000001899219A0-0x00000001899219C0
	public override void SetupView() {} // 0x000000018315CD10-0x000000018315D280
	// [XID] // 0x00000001899290C0-0x00000001899290E0
	public static void SetupItem(GameObject selectItem, ulong guid, bool isOut = false /* Metadata: 0x00B0F61F */) {} // 0x000000018315C800-0x000000018315CD10
	// [XID] // 0x0000000189930610-0x0000000189930630
	public override void ClearView() {} // 0x000000018315C320-0x000000018315C420
	// [XID] // 0x0000000189937B60-0x0000000189937B80
	public void SelectItem(float angle) {} // 0x000000018315C650-0x000000018315C800
}

