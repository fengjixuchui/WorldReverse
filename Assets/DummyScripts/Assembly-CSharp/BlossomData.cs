/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BlossomData : ISimplePoolObject // TypeDefIndex: 21414
{
	// Fields
	public uint refreshID; // 0x10
	public uint groupID; // 0x14
	public uint resin; // 0x18
	public Vector3 position; // 0x1C
	public uint rewardPreviewID; // 0x28
	public BlossomShowType showType; // 0x2C
	public BlossomScheduleState state; // 0x30
	public uint cityID; // 0x34
	public uint level; // 0x38
	public uint curMarkId; // 0x3C

	// Constructors
	public BlossomData() {} // 0x00000001836FD470-0x00000001836FD4D0

	// Methods
	// [XID] // 0x000000018988D0A0-0x000000018988D0C0
	public bool IsCanShowMark() => default; // 0x00000001836FD150-0x00000001836FD200
	// [XID] // 0x0000000189894710-0x0000000189894730
	public void Init(BlossomBriefInfo serverData, BlossomRefreshExcelConfig refreshCfg) {} // 0x00000001836FD200-0x00000001836FD3C0
	// [XID] // 0x000000018989BD20-0x000000018989BD40
	public void ResetObject() {} // 0x00000001836FD3C0-0x00000001836FD470
}

