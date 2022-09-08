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

public sealed class ActivitySubPage_Homeworld : BaseSubPageContext // TypeDefIndex: 30274
{
	// Fields
	private uint _activityId; // 0x178
	private MonoActivityHomeworld _pageMono; // 0x180
	private ConditionButtonComponent _conditionBtn; // 0x188
	private RewardPreviewComponent _rewardPreview; // 0x190

	// Nested types
	public class HomeworldTemplate : ConditionButtonComponent.ITemplate // TypeDefIndex: 30275
	{
		// Fields
		public uint mainQuestId; // 0x10
		public MonoUIContainer gotoBtnContainer; // 0x18
		public GameObject unlockTip; // 0x20

		// Constructors
		public HomeworldTemplate() {} // Dummy constructor
		public HomeworldTemplate(uint mainQuestId, MonoUIContainer gotoBtnContainer, GameObject unlockTip) {} // 0x000000018303BAF0-0x000000018303BB70

		// Methods
		// [XID] // 0x00000001899648F0-0x0000000189964910
		public void BuildBeforeComplete(ConditionButtonComponent component) {} // 0x000000018303B280-0x000000018303B620
		// [XID] // 0x000000018996BF70-0x000000018996BF90
		public void BuildAfterComplete(ConditionButtonComponent component) {} // 0x000000018303B6E0-0x000000018303BAF0
		// [XID] // 0x0000000189973A60-0x0000000189973A80
		public void ApplyTo(ConditionButtonComponent component) {} // 0x000000018303B620-0x000000018303B6E0
	}

	// Constructors
	public ActivitySubPage_Homeworld() {} // Dummy constructor
	public ActivitySubPage_Homeworld(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000183056870-0x0000000183056950

	// Methods
	// [XID] // 0x000000018990AA80-0x000000018990AAA0
	public override void SetupView() {} // 0x0000000183056400-0x0000000183056870
	// [XID] // 0x0000000189912730-0x0000000189912750
	public override void ClearView() {} // 0x0000000183055AC0-0x0000000183055B70
	// [XID] // 0x000000018991A000-0x000000018991A020
	protected override void BindViewCallbacks() {} // 0x0000000183055800-0x0000000183055AC0
	// [XID] // 0x0000000189921840-0x0000000189921860
	protected override void BindRedPoints() {} // 0x00000001830556C0-0x0000000183055800
	// [XID] // 0x0000000189928F60-0x0000000189928F80
	private void OnBtnGotoQuestClick() {} // 0x00000001830562B0-0x0000000183056400
	// [XID] // 0x00000001899304F0-0x0000000189930510
	private void OnBtnExitClick() {} // 0x0000000183056110-0x00000001830561B0
	// [XID] // 0x00000001899379C0-0x00000001899379E0
	private void OnBtnBackClick() {} // 0x0000000183055B70-0x0000000183055C10
	// [XID] // 0x000000018993F490-0x000000018993F4B0
	private void OnBtnOKClick() {} // 0x00000001830555C0-0x0000000183055660
	// [XID] // 0x0000000189946A60-0x0000000189946A80
	private void OnBtnItemDetailClick() {} // 0x0000000183055510-0x00000001830555C0
	// [XID] // 0x000000018994E120-0x000000018994E140
	private void OnBtnAreaClick() {} // 0x00000001830561B0-0x0000000183056250
	// [XID] // 0x0000000189955720-0x0000000189955740
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183055D00-0x0000000183055E70
	// [XID] // 0x000000018995D240-0x000000018995D260
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000183055ED0-0x0000000183056110
}

