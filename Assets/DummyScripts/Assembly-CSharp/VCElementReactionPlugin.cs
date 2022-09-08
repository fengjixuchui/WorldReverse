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

public sealed class VCElementReactionPlugin : VCBaseBillboardPlugin // TypeDefIndex: 12161
{
	// Fields
	private LCAbilityElement _lcAbility; // 0x88
	private MonoElementReaction _elementReactionUI; // 0x90
	private float _showUIDistance; // 0x98
	private bool _needRefreshElementIcons; // 0x9C
	private float _showForHittedLimit; // 0xA0
	private bool _showElemUI; // 0xA4
	private List<ElementStateExcelConfig> _elementUITypesCache; // 0xA8
	private List<ElementStateExcelConfig> _elementUITypes; // 0xB0
	private Dictionary<ElementType, float> _iconAppearAnimTime; // 0xB8
	private Dictionary<ElementType, float> _iconRemainTime; // 0xC0
	private SpriteLoadProxy _iconProxy; // 0xC8
	private List<string> _overrideNames; // 0xD0
	private Dictionary<string, Transform> _overrideTrans; // 0xD8
	private const string SHOW_REACTION_ANI_NAME = "Ani_ElementReaction_Eff_Legacy"; // Metadata: 0x00AEB58F
	private bool _currLoading; // 0xE0
	private Animation _currAnim; // 0xE8
	private float _reactionRemainTime; // 0xF0
	private const string REACTION_ELEMENET_PATH = "ART/UI/Menus/Widget/InLevel/Billboard/EffElemReaction/CommonReaction"; // Metadata: 0x00AEB5B1

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189774C80-0x0000000189774CA0 */ get => default; } // 0x0000000183D31140-0x0000000183D311E0 
	public bool ResReady { /* [XID] */ /* 0x000000018977C560-0x000000018977C580 */ get => default; } // 0x0000000183D30830-0x0000000183D30900 
	private bool _showForHitted { /* [XID] */ /* 0x0000000189784060-0x0000000189784080 */ get => default; } // 0x0000000183D30400-0x0000000183D304B0 
	public override bool isActive { /* [XID] */ /* 0x000000018978B7D0-0x000000018978B7F0 */ get => default; } // 0x0000000183D30900-0x0000000183D309B0 

	// Constructors
	public VCElementReactionPlugin() {} // 0x0000000183D31090-0x0000000183D31140

	// Methods
	// [XID] // 0x0000000189792BD0-0x0000000189792BF0
	public override void Init() {} // 0x0000000183D2F610-0x0000000183D2F730
	// [XID] // 0x000000018979A2A0-0x000000018979A2C0
	private void OnCreateElementReaction() {} // 0x0000000183D2DBD0-0x0000000183D2DD50
	// [XID] // 0x00000001897A2240-0x00000001897A2260
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183D30FD0-0x0000000183D31090
	// [XID] // 0x00000001897A9900-0x00000001897A9920
	public override void Destroy() {} // 0x0000000183D2DEB0-0x0000000183D2DFD0
	// [XID] // 0x00000001897B1180-0x00000001897B11A0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183D2E860-0x0000000183D2E930
	// [XID] // 0x00000001897B8D40-0x00000001897B8D60
	public override bool OnEvent(BaseEvent e) => default; // 0x0000000183D309B0-0x0000000183D30AC0
	// [XID] // 0x00000001897C0DF0-0x00000001897C0E10
	public override bool OnRemoteEvtBeingHit(BaseEvent e) => default; // 0x0000000183D30AC0-0x0000000183D30BB0
	// [XID] // 0x00000001897C8770-0x00000001897C8790
	public override void LateUpdateView(Vector3 cameraPosition, Vector3 billboardPosition) {} // 0x0000000183D2EA60-0x0000000183D2ED60
	// [XID] // 0x00000001897CFD80-0x00000001897CFDA0
	private void InitElementIcon() {} // 0x0000000183D2E4F0-0x0000000183D2E690
	// [XID] // 0x00000001897D75B0-0x00000001897D75D0
	private void ClearElementIcon() {} // 0x0000000183D30BB0-0x0000000183D30DA0
	// [XID] // 0x00000001897DEB00-0x00000001897DEB20
	private void RefreshElementIcons() {} // 0x0000000183D2F730-0x0000000183D2FDC0
	// [XID] // 0x00000001897E64F0-0x00000001897E6510
	private void UpdateElementIcon() {} // 0x0000000183D2DFD0-0x0000000183D2E4F0
	// [XID] // 0x00000001897EE060-0x00000001897EE080
	private bool HasIcon() => default; // 0x0000000183D2F220-0x0000000183D2F2E0
	// [XID] // 0x00000001897F57A0-0x00000001897F57C0
	public void AddElementOverride(string name) {} // 0x0000000183D2F2E0-0x0000000183D2F540
	// [XID] // 0x00000001897FCFC0-0x00000001897FCFE0
	public void RemoveElementOverride(string name) {} // 0x0000000183D304B0-0x0000000183D306D0
	// [XID] // 0x00000001898046C0-0x00000001898046E0
	private void UpdateElementOverride() {} // 0x0000000183D2DDD0-0x0000000183D2DEB0
	// [XID] // 0x000000018980BAF0-0x000000018980BB10
	private void ClearElementOverride() {} // 0x0000000183D2FE20-0x0000000183D30040
	// [XID] // 0x00000001898132A0-0x00000001898132C0
	private bool HasOverride() => default; // 0x0000000183D30250-0x0000000183D30310
	// [XID] // 0x000000018981AE30-0x000000018981AE50
	private Transform AllocElementOverride(string name) => default; // 0x0000000183D30DA0-0x0000000183D30FD0
	// [XID] // 0x0000000189822630-0x0000000189822650
	private void DeallocElementOverride(string name, Transform trans) {} // 0x0000000183D30040-0x0000000183D30250
	// [XID] // 0x0000000189829C30-0x0000000189829C50
	public void ShowElementReactionWithToken(ElementReactionType reaction, ElementType sourceElementType, ElementType reactorElementType) {} // 0x0000000183D2ED60-0x0000000183D2EFA0
	// [XID] // 0x0000000189831100-0x0000000189831120
	public void ShowElementReaction(ElementReactionType reaction, ElementType sourceElementType, ElementType reactorElementType) {} // 0x0000000183D2EFA0-0x0000000183D2F220
	// [XID] // 0x0000000189838900-0x0000000189838920
	private void UpdateElementReaction() {} // 0x0000000183D2E690-0x0000000183D2E860
	// [XID] // 0x000000018983FE20-0x000000018983FE40
	private void ClearElementReaction() {} // 0x0000000183D2E930-0x0000000183D2EA60
	// [XID] // 0x00000001898474E0-0x0000000189847500
	private bool HasReaction() => default; // 0x0000000183D2F540-0x0000000183D2F610
	// [XID] // 0x000000018984EBA0-0x000000018984EBC0
	private void DeallocElementReaction(ElementReactionType reaction, Animation anim) {} // 0x0000000183D306D0-0x0000000183D30830
}

