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

public sealed class ConditionButtonComponent : BaseContextComponent // TypeDefIndex: 29460
{
	// Fields
	public List<ContextConditionActionGroup> clickGroups; // 0x30
	public List<ContextConditionActionGroup> updateGroups; // 0x38

	// Nested types
	public interface ITemplate // TypeDefIndex: 29461
	{
		// Methods
		void ApplyTo(ConditionButtonComponent contextComponent);
	}

	public class MonsterBannerDefaultTemplate : ITemplate // TypeDefIndex: 29462
	{
		// Fields
		public uint activityId; // 0x10
		public uint mainQuestId; // 0x14
		public uint questId; // 0x18
		public uint monsterId; // 0x1C
		public MarkIconType questMarkType; // 0x20
		public string strGotoChallenge; // 0x28
		public string strGotoInvestigate; // 0x30
		public MonoUIContainer btnContainer; // 0x38
		public GameObject disableTip; // 0x40

		// Constructors
		public MonsterBannerDefaultTemplate() {} // Dummy constructor
		public MonsterBannerDefaultTemplate(uint activityId, uint mainQuestId, uint questId, uint monsterId, MarkIconType questMarkType, string strGotoChallenge, string strGotoInvestigate, MonoUIContainer btnContainer, GameObject disableTip) {} // 0x000000018294B9A0-0x000000018294BA70

		// Methods
		// [XID] // 0x0000000189A3D820-0x0000000189A3D840
		public void BuildCannotAccpetQuest(ConditionButtonComponent contextComponent) {} // 0x000000018294B520-0x000000018294B8C0
		// [XID] // 0x0000000189A44FA0-0x0000000189A44FC0
		public void BuildBeforeQuestAccepted(ConditionButtonComponent contextComponent) {} // 0x000000018294A490-0x000000018294AA60
		// [XID] // 0x0000000189A4C6E0-0x0000000189A4C700
		public void BuildAfterQuestAccepted(ConditionButtonComponent contextComponent) {} // 0x000000018294AA60-0x000000018294B000
		// [XID] // 0x0000000189A53EC0-0x0000000189A53EE0
		public void BuildAfterQuestFinished(ConditionButtonComponent contextComponent) {} // 0x000000018294B000-0x000000018294B520
		// [XID] // 0x0000000189A5B8F0-0x0000000189A5B910
		public void ApplyTo(ConditionButtonComponent contextComponent) {} // 0x000000018294B8C0-0x000000018294B9A0
	}

	// Constructors
	public ConditionButtonComponent() {} // 0x000000018294E5E0-0x000000018294E690

	// Methods
	// [XID] // 0x0000000189A270D0-0x0000000189A270F0
	public override void Init(GameObject view) {} // 0x000000018294E4F0-0x000000018294E5E0
	// [XID] // 0x0000000189A2E8D0-0x0000000189A2E8F0
	public void Click() {} // 0x000000018294E330-0x000000018294E4F0
	// [XID] // 0x0000000189A36220-0x0000000189A36240
	public void Update() {} // 0x000000018294E170-0x000000018294E330
}

