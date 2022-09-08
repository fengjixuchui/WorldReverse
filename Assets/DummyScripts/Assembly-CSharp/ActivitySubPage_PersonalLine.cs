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

public sealed class ActivitySubPage_PersonalLine : BaseSubPageContext // TypeDefIndex: 29412
{
	// Fields
	private ActivityInfo activityInfo; // 0x178
	private MonoActivityPersonalLine _pageMono; // 0x180
	private uint _activityID; // 0x188
	private PersonalLineActivityExcelConfig activityConfig; // 0x190
	private ConditionButtonComponent _gotoBtn; // 0x198

	// Nested types
	public class PersonalLineTemplate : ConditionButtonComponent.ITemplate // TypeDefIndex: 29413
	{
		// Fields
		public uint chapterId; // 0x10
		public MonoUIContainer btnContainer; // 0x18
		public GameObject finishedTip; // 0x20

		// Constructors
		public PersonalLineTemplate() {} // Dummy constructor
		public PersonalLineTemplate(uint chapterId, MonoUIContainer btnContainer, GameObject finishedTip) {} // 0x0000000183E7DF80-0x0000000183E7E210

		// Methods
		// [XID] // 0x000000018989E5C0-0x000000018989E5E0
		public void BuildBeforeAcceptQuest(ConditionButtonComponent contextComponent) {} // 0x0000000183E7DAE0-0x0000000183E7DF80
		// [XID] // 0x00000001898A60C0-0x00000001898A60E0
		public void BuildAfterQuestAccepted(ConditionButtonComponent contextComponent) {} // 0x0000000183E7D390-0x0000000183E7D770
		// [XID] // 0x00000001898AD6F0-0x00000001898AD710
		public void BuildAfterQuestFinished(ConditionButtonComponent contextComponent) {} // 0x0000000183E7D770-0x0000000183E7DA10
		// [XID] // 0x00000001898B4C10-0x00000001898B4C30
		public void ApplyTo(ConditionButtonComponent contextComponent) {} // 0x0000000183E7DA10-0x0000000183E7DAE0
	}

	// Constructors
	public ActivitySubPage_PersonalLine() {} // Dummy constructor
	public ActivitySubPage_PersonalLine(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000183E78160-0x0000000183E78290

	// Methods
	// [XID] // 0x000000018985C420-0x000000018985C440
	public override void SetupView() {} // 0x0000000183E77E20-0x0000000183E78160
	// [XID] // 0x0000000189863D80-0x0000000189863DA0
	protected override void BindViewCallbacks() {} // 0x0000000183E76FE0-0x0000000183E77170
	// [XID] // 0x000000018986B0B0-0x000000018986B0D0
	private void OnClickGoto() {} // 0x0000000183E778E0-0x0000000183E77A40
	// [XID] // 0x0000000189872480-0x00000001898724A0
	private void OnClickDesc() {} // 0x0000000183E76ED0-0x0000000183E76FE0
	// [XID] // 0x000000018987A0F0-0x000000018987A110
	private void Refresh() {} // 0x0000000183E76AB0-0x0000000183E76E50
	// [XID] // 0x0000000189881270-0x0000000189881290
	private void RefreshKeyCount() {} // 0x0000000183E77200-0x0000000183E77400
	// [XID] // 0x0000000189888840-0x0000000189888860
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183E77D40-0x0000000183E77E20
	// [XID] // 0x000000018988FBC0-0x000000018988FBE0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183E77460-0x0000000183E778E0
	// [XID] // 0x0000000189897080-0x00000001898970A0
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000183E77A40-0x0000000183E77C50
}

