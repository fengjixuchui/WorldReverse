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

public sealed class ActivitySubPage_MBEffigyIce : ActivitySubPage_MonsterBanner // TypeDefIndex: 29406
{
	// Nested types
	public class MBEffigyIceTemplate : ConditionButtonComponent.ITemplate // TypeDefIndex: 29407
	{
		// Fields
		public uint activityId; // 0x10
		public uint leadMainQuestId; // 0x14
		public uint mainQuestId; // 0x18
		public uint monsterId; // 0x1C
		public string strGotoChallenge; // 0x20
		public string strGotoInvestigate; // 0x28
		public MonoUIContainer btnContainer; // 0x30
		public GameObject unlockTip; // 0x38

		// Constructors
		public MBEffigyIceTemplate() {} // Dummy constructor
		public MBEffigyIceTemplate(uint activityId, uint leadMainQuestId, uint mainQuestId, uint monsterId, string strGotoChallenge, string strGotoInvestigate, MonoUIContainer btnContainer, GameObject unlockTip) {} // 0x00000001821680B0-0x0000000182168170

		// Methods
		// [XID] // 0x00000001897323F0-0x0000000189732410
		public void BuildBeforeAcceptQuest(ConditionButtonComponent contextComponent) {} // 0x0000000182167BB0-0x00000001821680B0
		// [XID] // 0x0000000189739B20-0x0000000189739B40
		public void BuildAfterQuestAccepted(ConditionButtonComponent contextComponent) {} // 0x0000000182167060-0x0000000182167560
		// [XID] // 0x0000000189741720-0x0000000189741740
		public void BuildAfterQuestFinished(ConditionButtonComponent contextComponent) {} // 0x0000000182167560-0x0000000182167AE0
		// [XID] // 0x0000000189749000-0x0000000189749020
		public void ApplyTo(ConditionButtonComponent contextComponent) {} // 0x0000000182167AE0-0x0000000182167BB0
	}

	// Constructors
	public ActivitySubPage_MBEffigyIce() {} // Dummy constructor
	public ActivitySubPage_MBEffigyIce(uint activityId, BasePageContext parent, Transform mountTrans) {} // 0x000000018215B8D0-0x000000018215B970

	// Methods
	// [XID] // 0x00000001897235A0-0x00000001897235C0
	protected override uint GetRewardPreviewId() => default; // 0x000000018215B500-0x000000018215B610
	// [XID] // 0x000000018972AD40-0x000000018972AD60
	protected override ConditionButtonComponent.ITemplate GetBtnTemplate() => default; // 0x000000018215B610-0x000000018215B860
}

