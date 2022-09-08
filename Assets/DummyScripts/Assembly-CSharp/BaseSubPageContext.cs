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

public class BaseSubPageContext : BaseContext // TypeDefIndex: 28441
{
	// Fields
	private Transform _rootObjectTrans; // 0x168

	// Properties
	public BasePageContext pageContext { /* [XID] */ /* 0x00000001897505F0-0x0000000189750630 */ get; /* [XID] */ /* 0x000000018975A7B0-0x000000018975A7F0 */ private set; } // 0x0000000181EF6780-0x0000000181EF67E0 0x0000000181EF6950-0x0000000181EF69C0

	// Constructors
	public BaseSubPageContext() {} // Dummy constructor
	protected BaseSubPageContext(BasePageContext _parent, Transform _mountTrans) {} // 0x0000000181EF7230-0x0000000181EF7310

	// Methods
	// [XID] // 0x0000000189764FD0-0x0000000189764FF0
	protected override void OnLoadedView(GameObject instantiatedView) {} // 0x0000000181EF6C20-0x0000000181EF6DA0
	// [XID] // 0x000000018976CA10-0x000000018976CA30
	protected override void PostSetupView() {} // 0x0000000181EF6EE0-0x0000000181EF7040
	// [XID] // 0x0000000189773ED0-0x0000000189773EF0
	public void SetPageContext(BasePageContext context) {} // 0x0000000181EF6A40-0x0000000181EF6BC0
	// [XID] // 0x000000018977B580-0x000000018977B5A0
	public override void Destroy() {} // 0x0000000181EF6240-0x0000000181EF63D0
	// [XID] // 0x00000001897830C0-0x00000001897830E0
	public override void DestroyForce() {} // 0x0000000181EF60B0-0x0000000181EF6240
	// [XID] // 0x000000018978A5B0-0x000000018978A5D0
	public void CloseSubPage() {} // 0x0000000181EF68A0-0x0000000181EF6950
	// [XID] // 0x0000000189791D30-0x0000000189791D50
	protected override void ReleaseView() {} // 0x0000000181EF7040-0x0000000181EF7170
	// [XID] // 0x00000001897993F0-0x0000000189799410
	public override void SetActive(bool enabled) {} // 0x0000000181EF7170-0x0000000181EF7230
	// [XID] // 0x00000001897A1310-0x00000001897A1330
	protected override void OnPostSetActive() {} // 0x0000000181EF6DA0-0x0000000181EF6E40
	// [XID] // 0x00000001897A88E0-0x00000001897A8900
	protected override void PostClose() {} // 0x0000000181EF6E40-0x0000000181EF6EE0
	// [XID] // 0x00000001897B03C0-0x00000001897B03E0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181EF6540-0x0000000181EF66D0
	// [XID] // 0x00000001897B8030-0x00000001897B8050
	public virtual void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000181EF66D0-0x0000000181EF6780
}

