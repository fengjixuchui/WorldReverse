/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BasePageContext : BaseContext // TypeDefIndex: 28439
{
	// Fields
	public List<BaseDialogContext> dialogContextList; // 0x168
	public List<BaseSubPageContext> subPageContextList; // 0x170
	protected bool _forceLodOff; // 0x178
	protected bool _autoClosePageOnBackEvent; // 0x179
	protected bool _disableMainCamera; // 0x17A
	protected bool _pauseLevelTime; // 0x17B
	protected bool _asyncLoadRes; // 0x17C
	private Coroutine _cameraCoroutine; // 0x180
	private bool _joyFocusOnParentPage; // 0x188

	// Properties
	public bool asyncLoadRes { /* [XID] */ /* 0x00000001895F7E10-0x00000001895F7E30 */ get => default; } // 0x00000001841C3FA0-0x00000001841C4050 
	public int dialogCount { /* [XID] */ /* 0x00000001896AB880-0x00000001896AB8A0 */ get => default; } // 0x00000001841C5430-0x00000001841C54F0 
	public int subPageCount { /* [XID] */ /* 0x00000001896C8B70-0x00000001896C8B90 */ get => default; } // 0x00000001841C2890-0x00000001841C2950 
	public bool JoyFocusOnParentPage { /* [XID] */ /* 0x00000001896E6730-0x00000001896E6750 */ get => default; /* [XID] */ /* 0x00000001896EDC60-0x00000001896EDC80 */ set {} } // 0x00000001841C48C0-0x00000001841C4970 0x00000001841C3640-0x00000001841C3710

	// Constructors
	protected BasePageContext() {} // 0x00000001841C6310-0x00000001841C6420

	// Methods
	// [XID] // 0x00000001895FF1F0-0x00000001895FF210
	public override void Init() {} // 0x00000001841C4050-0x00000001841C4170
	// [XID] // 0x0000000189606A90-0x0000000189606AB0
	protected override void OnLoadedView(GameObject instantiatedView) {} // 0x00000001841C5180-0x00000001841C5430
	// [XID] // 0x000000018960E3F0-0x000000018960E410
	protected override void FadeOut() {} // 0x00000001841C3710-0x00000001841C37D0
	// [XID] // 0x0000000189615A00-0x0000000189615A20
	protected virtual void EnableMainCamera(bool enable) {} // 0x00000001841C38B0-0x00000001841C3BC0
	// [XID] // 0x000000018961D1E0-0x000000018961D200
	protected override void PostSetupView() {} // 0x00000001841C5A40-0x00000001841C5B70
	// [XID] // 0x0000000189624710-0x0000000189624730
	protected override void PostReleaseView() {} // 0x00000001841C5840-0x00000001841C5A40
	// [XID] // 0x000000018962BE70-0x000000018962BE90
	public override void SetActive(bool enabled) {} // 0x00000001841C5B70-0x00000001841C5FA0
	// [XID] // 0x00000001896339D0-0x00000001896339F0
	private void PauseLevelTime(bool enabled) {} // 0x00000001841C37D0-0x00000001841C38B0
	// [XID] // 0x000000018963B2F0-0x000000018963B310
	public override void SetUIResolutionChanged() {} // 0x00000001841C5FA0-0x00000001841C6220
	// [XID] // 0x0000000189642A20-0x0000000189642A40
	protected override void Unregister() {} // 0x00000001841C6220-0x00000001841C6310
	// [XID] // 0x000000018964A150-0x000000018964A170
	public override void Destroy() {} // 0x00000001841C2FF0-0x00000001841C3240
	// [XID] // 0x0000000189651810-0x0000000189651830
	public override void DestroyForce() {} // 0x00000001841C2DF0-0x00000001841C2FF0
	// [XID] // 0x0000000189659010-0x0000000189659030
	public BaseDialogContext GetDialogByName(string name) => default; // 0x00000001841C4730-0x00000001841C48C0
	public T GetDialog<T>()
		where T : BaseDialogContext => default;
	// [XID] // 0x0000000189660700-0x0000000189660720
	public BaseDialogContext GetActiveDialog() => default; // 0x00000001841C4970-0x00000001841C4AB0
	// [XID] // 0x0000000189668080-0x00000001896680A0
	public BaseSubPageContext GetSubPageByName(string name) => default; // 0x00000001841C4D00-0x00000001841C4E90
	public T GetSubPage<T>()
		where T : BaseSubPageContext => default;
	// [XID] // 0x000000018966FB00-0x000000018966FB20
	public BaseSubPageContext GetActiveSubPage() => default; // 0x00000001841C5570-0x00000001841C56B0
	// [XID] // 0x0000000189677440-0x0000000189677460
	public void OnLandedFromBack() {} // 0x00000001841C3BC0-0x00000001841C3DA0
	// [XID] // 0x000000018967E990-0x000000018967E9B0
	public override void OnDisconnect() {} // 0x00000001841C4FE0-0x00000001841C5180
	// [XID] // 0x00000001899435C0-0x00000001899435E0
	public virtual void ClosePage() {} // 0x00000001841C2950-0x00000001841C2A80
	// [XID] // 0x000000018968E030-0x000000018968E050
	protected void DoClosePage() {} // 0x00000001841C44C0-0x00000001841C4730
	// [XID] // 0x0000000189695980-0x00000001896959A0
	public void DestroyForceAllDialog() {} // 0x00000001841C2740-0x00000001841C2890
	// [XID] // 0x000000018969D030-0x000000018969D050
	public void AddDialog(BaseDialogContext dialog) {} // 0x00000001841C2A80-0x00000001841C2B50
	// [XID] // 0x00000001896A42C0-0x00000001896A42E0
	public void RemoveDialog(BaseDialogContext dialog) {} // 0x00000001841C5710-0x00000001841C57E0
	// [XID] // 0x00000001896B2AB0-0x00000001896B2AD0
	public void AddSubPage(BaseSubPageContext subPage) {} // 0x00000001841C2B50-0x00000001841C2C20
	// [XID] // 0x00000001896BA280-0x00000001896BA2A0
	public void RemoveSubPage(BaseSubPageContext subPage) {} // 0x00000001841C4BB0-0x00000001841C4C80
	// [XID] // 0x00000001896C14B0-0x00000001896C14D0
	public void CloseAllSubPage() {} // 0x00000001841C4AB0-0x00000001841C4BB0
	// [XID] // 0x00000001896D05A0-0x00000001896D05C0
	public override void ClearInputState() {} // 0x00000001841C2C20-0x00000001841C2DF0
	// [XID] // 0x00000001896D7A80-0x00000001896D7AA0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001841C3E90-0x00000001841C3FA0
	// [XID] // 0x00000001896DF340-0x00000001896DF360
	public virtual bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001841C3DA0-0x00000001841C3E90
	// [XID] // 0x00000001896F5490-0x00000001896F54B0
	public virtual void OnParentFocusChangeed(bool focusOnParent) {} // 0x00000001841C4170-0x00000001841C4320
	// [XID] // 0x00000001896FCC90-0x00000001896FCCB0
	protected bool UsingJoypadLayout() => default; // 0x00000001841C4EF0-0x00000001841C4FE0
	// [XID] // 0x0000000189890DA0-0x0000000189890DC0
	protected void SetCursorVisible(bool visible) {} // 0x00000001841C3360-0x00000001841C3530
}

