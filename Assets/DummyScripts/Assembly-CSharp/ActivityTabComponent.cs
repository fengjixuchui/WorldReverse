/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityTabComponent : BaseContextComponent // TypeDefIndex: 29436
{
	// Fields
	private MonoReusableList _tabContainer; // 0x30
	private Action<int> _clickCB; // 0x38
	private int _selectedTabIndex; // 0x40
	private int _tabCount; // 0x44

	// Constructors
	public ActivityTabComponent() {} // 0x000000018589C8E0-0x000000018589C950

	// Methods
	// [XID] // 0x0000000189921980-0x00000001899219A0
	public override void Init(GameObject view) {} // 0x000000018589C620-0x000000018589C6D0
	// [XID] // 0x00000001899290A0-0x00000001899290C0
	public void SetupTabInfo(MonoReusableList reusableList, int count, string tabPath, string[] tabIcons, Action<int> clickAction) {} // 0x000000018589C2F0-0x000000018589C620
	// [XID] // 0x00000001899305F0-0x0000000189930610
	public MonoImgTab GetTabAt(int index) => default; // 0x000000018589BD60-0x000000018589BEC0
	// [XID] // 0x0000000189937B40-0x0000000189937B60
	public override void OnEnable() {} // 0x000000018589C840-0x000000018589C8E0
	// [XID] // 0x000000018993F610-0x000000018993F630
	private void SetSelected() {} // 0x000000018589C150-0x000000018589C290
	// [XID] // 0x0000000189946C00-0x0000000189946C20
	private void OnClick(int index) {} // 0x000000018589C770-0x000000018589C840
	// [XID] // 0x000000018994E280-0x000000018994E2A0
	public void ToPrevTab() {} // 0x000000018589BFF0-0x000000018589C0A0
	// [XID] // 0x00000001899558A0-0x00000001899558C0
	public void ToNextTab() {} // 0x000000018589C0A0-0x000000018589C150
	// [XID] // 0x000000018995D380-0x000000018995D3A0
	public int GetSelectedIndex() => default; // 0x000000018589C6D0-0x000000018589C770
	// [XID] // 0x0000000189964A30-0x0000000189964A50
	public void SetClick(int index) {} // 0x000000018589BF40-0x000000018589BFF0
}

