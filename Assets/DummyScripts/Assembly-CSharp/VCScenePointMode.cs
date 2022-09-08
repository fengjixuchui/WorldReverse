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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCScenePointMode : VCBaseModel // TypeDefIndex: 11940
{
	// Fields
	private Coroutine _matResLoader; // 0x1E0
	private uint _matResHandle; // 0x1E8
	private List<Renderer> renderers; // 0x1F0
	private bool _1stActiveTrigger; // 0x1F8
	private bool _1stActiveStart; // 0x1F9

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189728CE0-0x0000000189728D00 */ get => default; } // 0x0000000182D1FCE0-0x0000000182D1FD80 

	// Constructors
	public VCScenePointMode() {} // 0x0000000182D1FC70-0x0000000182D1FCE0

	// Methods
	// [XID] // 0x0000000189B1E4C0-0x0000000189B1E4E0
	public override void OnEnable() {} // 0x0000000182D1FB40-0x0000000182D1FC70
	// [XID] // 0x0000000189730710-0x0000000189730730
	private void OnEnableImp(BaseEntity entity) {} // 0x0000000182D1DCB0-0x0000000182D1DE00
	// [XID] // 0x0000000189B2D0F0-0x0000000189B2D110
	public override void Destroy() {} // 0x0000000182D1E130-0x0000000182D1E1E0
	// [IDTag] // 0x0000000189B34630-0x0000000189B34670
	// [XID] // 0x0000000189B34630-0x0000000189B34670
	public void UpdateAnimator(bool init) {} // 0x0000000182D1F840-0x0000000182D1F9F0
	// [IDTag] // 0x0000000189B3F1D0-0x0000000189B3F210
	// [XID] // 0x0000000189B3F1D0-0x0000000189B3F210
	private void UpdateAnimatorImp(BaseEntity entity, bool init) {} // 0x0000000182D1D850-0x0000000182D1D9D0
	// [XID] // 0x0000000189B49C70-0x0000000189B49C90
	public void UpdateAnimatorForDungeonEntry(bool init) {} // 0x0000000182D1E840-0x0000000182D1E9F0
	// [XID] // 0x0000000189B51370-0x0000000189B51390
	private void UpdateAnimatorForDungeonEntryImp(BaseEntity entity, bool init) {} // 0x0000000182D1E550-0x0000000182D1E720
	// [IDTag] // 0x0000000189B58CE0-0x0000000189B58D20
	// [XID] // 0x0000000189B58CE0-0x0000000189B58D20
	public void UpdateAnimator(uint level, bool init) {} // 0x0000000182D1F670-0x0000000182D1F840
	// [IDTag] // 0x0000000189B63020-0x0000000189B63060
	// [XID] // 0x0000000189B63020-0x0000000189B63060
	public void UpdateAnimatorImp(BaseEntity entity, uint level, bool init) {} // 0x0000000182D1D9D0-0x0000000182D1DB60
	// [XID] // 0x00000001896C2700-0x00000001896C2720
	public void UpdateAnimatorInActive() {} // 0x0000000182D1E720-0x0000000182D1E840
	// [XID] // 0x0000000189B74D90-0x0000000189B74DB0
	private void UpdateAnimatorInActiveImp(BaseEntity entity) {} // 0x0000000182D1EFB0-0x0000000182D1F0E0
	// [XID] // 0x0000000189758890-0x00000001897588B0
	public void UpdateAnimatorInActiveForDungeonEntry(bool isGroupLimit, bool canNotExplore) {} // 0x0000000182D1F4A0-0x0000000182D1F670
	// [XID] // 0x0000000189B83E60-0x0000000189B83E80
	private void UpdateAnimatorInActiveForDungeonEntryImp(BaseEntity entity, bool isGroupLimit, bool canNotExplore) {} // 0x0000000182D1E1E0-0x0000000182D1E390
	// [XID] // 0x0000000189B8AE80-0x0000000189B8AEA0
	public void UpdateAnimatorToBeExploredForDungeonEntry(bool isGroupLimit) {} // 0x0000000182D1F280-0x0000000182D1F430
	// [XID] // 0x0000000189B92600-0x0000000189B92620
	private void UpdateAnimatorToBeExploredForDungeonEntryImp(BaseEntity entity, bool isGroupLimit) {} // 0x0000000182D1E390-0x0000000182D1E550
	// [XID] // 0x00000001898F0E60-0x00000001898F0E80
	public void UpdateAnimatorUnfreezeGroupLimitForDungeonEntry() {} // 0x0000000182D1DFB0-0x0000000182D1E0D0
	// [XID] // 0x0000000189925AA0-0x0000000189925AC0
	private void UpdateAnimatorUnfreezeGroupLimitForDungeonEntryImp(BaseEntity entity) {} // 0x0000000182D1F9F0-0x0000000182D1FB40
	// [XID] // 0x000000018985BF60-0x000000018985BF80
	public void UpdateMaterial(uint level) {} // 0x0000000182D1DE00-0x0000000182D1DFB0
	// [XID] // 0x0000000189871EF0-0x0000000189871F10
	public void UpdateMaterialImp(BaseEntity entity, uint level) {} // 0x0000000182D1EA70-0x0000000182D1EEB0
	[DebuggerHidden] // 0x0000000189BB72E0-0x0000000189BB7320
	// [XID] // 0x0000000189BB72E0-0x0000000189BB7320
	private IEnumerator LoadMaterialResource(string matPath, List<Renderer> renderers) => default; // 0x0000000182D1F140-0x0000000182D1F280
	// [XID] // 0x0000000189896C40-0x0000000189896C60
	private void ReleaseMaterialRes() {} // 0x0000000182D1DB60-0x0000000182D1DCB0
}

