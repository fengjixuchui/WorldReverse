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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCBaseInter : LCBaseIntee // TypeDefIndex: 11714
{
	// Fields
	public const float ANGLE_PARAM = 0.05f; // Metadata: 0x00AEA747
	public const float DIST_PARAM = 1f; // Metadata: 0x00AEA74B
	private const float PREPERFORM_EXIST_DIST = 9f; // Metadata: 0x00AEA74F
	private const float PREPERFORM_EXIST_DIST_SQR = 81f; // Metadata: 0x00AEA753
	private LCTrigger _attentionTrigger; // 0x218
	private float _lastHeadDelat; // 0x220
	private List<LCBaseIntee> _candidateInteeList; // 0x228
	private List<LCBaseIntee> _prePerformInteeList; // 0x230
	private List<LCBaseIntee> _freeInteeList; // 0x238
	private List<LCBaseIntee> _selectedFreeInteeList; // 0x240
	private List<LCBaseIntee> _currInteeList; // 0x248

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898A27F0-0x00000001898A2810 */ get => default; } // 0x00000001842728B0-0x0000000184272950 

	// Constructors
	public LCBaseInter() {} // 0x0000000184272770-0x00000001842728B0

	// Methods
	// [XID] // 0x00000001896FACD0-0x00000001896FACF0
	public override void PreInit() {} // 0x00000001842725B0-0x0000000184272650
	// [XID] // 0x00000001898B17D0-0x00000001898B17F0
	private void InitAttentionTrigger() {} // 0x00000001842701C0-0x0000000184270510
	// [XID] // 0x00000001896BF7B0-0x00000001896BF7D0
	public void ForceOnAttentionOnFieldEnter(BaseEntity entity) {} // 0x0000000184272010-0x00000001842720D0
	// [XID] // 0x00000001898C06E0-0x00000001898C0700
	private void OnAttentionOnFieldEnter(BaseEntity entity) {} // 0x0000000184270100-0x00000001842701C0
	// [XID] // 0x0000000189743D80-0x0000000189743DA0
	public void ForceLostAttentionOnFieldExit(BaseEntity entity) {} // 0x00000001842720D0-0x0000000184272190
	// [XID] // 0x00000001896B8670-0x00000001896B8690
	private void OnLostAttentionOnFieldExit(BaseEntity entity) {} // 0x000000018426DB70-0x000000018426DC30
	// [XID] // 0x000000018966BF20-0x000000018966BF40
	public void HandleAttenstionOnFieldEnter(BaseEntity entity, bool force = false /* Metadata: 0x00AEA745 */) {} // 0x00000001842711F0-0x0000000184271350
	// [XID] // 0x00000001898DEDB0-0x00000001898DEDD0
	public void HandleLostAttentionOnFieldExit(BaseEntity entity, bool force = false /* Metadata: 0x00AEA746 */) {} // 0x0000000184271E50-0x0000000184272010
	// [XID] // 0x0000000189AADA00-0x0000000189AADA20
	private bool CheckCandidate(LCBaseIntee intee, InteractionManager interMgr) => default; // 0x000000018426E530-0x000000018426E800
	// [XID] // 0x00000001898EDC90-0x00000001898EDCB0
	private void CheckPreTalkPerform(float dist, bool heightValid, LCBaseIntee intee, InteractionManager interMgr) {} // 0x0000000184270610-0x0000000184270760
	// [XID] // 0x00000001898F5650-0x00000001898F5670
	private bool CheckAttentionTrigger(float dist, bool heightValid, LCBaseIntee intee, InteractionManager interMgr) => default; // 0x0000000184270C50-0x0000000184270E30
	// [XID] // 0x00000001898FCD60-0x00000001898FCD80
	private void CheckFreeInteractionTrigger(float dist, bool heightValid, LCBaseIntee intee, InteractionManager interMgr) {} // 0x0000000184272240-0x00000001842723B0
	// [XID] // 0x0000000189904700-0x0000000189904720
	private bool CheckHeadCtrlEnable(float dist, LCBaseIntee intee) => default; // 0x0000000184271430-0x0000000184271850
	// [XID] // 0x000000018990BEC0-0x000000018990BEE0
	private void CheckHeadCtrlTrigger(float dist, LCBaseIntee intee, InteractionManager interMgr) {} // 0x0000000184270760-0x0000000184270920
	// [XID] // 0x00000001899138A0-0x00000001899138C0
	private void CheckCandidateExit(LCBaseIntee intee, InteractionManager interMgr) {} // 0x000000018426F240-0x000000018426F330
	// [XID] // 0x000000018991B200-0x000000018991B220
	private void CheckAttentionTriggerExit(LCBaseIntee intee, InteractionManager interMgr) {} // 0x0000000184272490-0x00000001842725B0
	// [XID] // 0x0000000189A627E0-0x0000000189A62800
	private void CheckFreeInteractionTriggerExit(LCBaseIntee intee, InteractionManager interMgr) {} // 0x000000018426DF80-0x000000018426E070
	// [XID] // 0x0000000189929F00-0x0000000189929F20
	private void CheckPrePerformTriggerExit(LCBaseIntee intee, InteractionManager interMgr) {} // 0x000000018426F800-0x000000018426F920
	// [XID] // 0x0000000189931650-0x0000000189931670
	private void CheckHeadCtrlTriggerExit(LCBaseIntee intee, InteractionManager interMgr) {} // 0x0000000184271850-0x0000000184271960
	// [XID] // 0x0000000189649AE0-0x0000000189649B00
	public void ForceCheckHeadCtrl() {} // 0x000000018426EF90-0x000000018426F240
	// [XID] // 0x00000001896D42C0-0x00000001896D42E0
	public bool IsInValidState() => default; // 0x0000000184271350-0x0000000184271430
	// [XID] // 0x0000000189947BB0-0x0000000189947BD0
	private bool HasInteeInList(LCBaseIntee intee, List<LCBaseIntee> inteeList) => default; // 0x000000018426ED80-0x000000018426EEB0
	// [XID] // 0x000000018994F290-0x000000018994F2B0
	private bool RemoveInteeFromList(LCBaseIntee intee, List<LCBaseIntee> inteeList) => default; // 0x000000018426FEE0-0x0000000184270020
	// [XID] // 0x00000001896E4A10-0x00000001896E4A30
	public List<LCBaseIntee> GetCandidateInteeList() => default; // 0x0000000184271C90-0x0000000184271D40
	// [XID] // 0x0000000189A8FF10-0x0000000189A8FF30
	public bool IsCandidateIntee(LCBaseIntee intee) => default; // 0x000000018426F9E0-0x000000018426FAA0
	// [XID] // 0x0000000189965BC0-0x0000000189965BE0
	public void AddToCandidateInte(LCBaseIntee intee) {} // 0x0000000184270020-0x0000000184270100
	// [XID] // 0x000000018973C900-0x000000018973C920
	public bool RemoveCandidateIntee(LCBaseIntee intee) => default; // 0x000000018426E350-0x000000018426E410
	// [XID] // 0x00000001896EBF70-0x00000001896EBF90
	public List<LCBaseIntee> GetPrePerformInteeList() => default; // 0x000000018426E880-0x000000018426E930
	// [XID] // 0x000000018997C000-0x000000018997C020
	private bool IsPrePerformIntee(LCBaseIntee intee) => default; // 0x000000018426F920-0x000000018426F9E0
	// [XID] // 0x0000000189983C50-0x0000000189983C70
	public void AddToPrePerformInteeList(LCBaseIntee intee) {} // 0x000000018426FE00-0x000000018426FEE0
	// [XID] // 0x000000018998B560-0x000000018998B580
	public bool RemovePrePerformIntee(LCBaseIntee intee) => default; // 0x000000018426D8F0-0x000000018426D9B0
	// [XID] // 0x00000001896F3660-0x00000001896F3680
	public List<LCBaseIntee> GetFreeInteeList() => default; // 0x000000018426FAA0-0x000000018426FB50
	// [XID] // 0x0000000189B618E0-0x0000000189B61900
	private bool IsFreeIntee(LCBaseIntee intee) => default; // 0x000000018426E930-0x000000018426E9F0
	// [XID] // 0x00000001899A23B0-0x00000001899A23D0
	public void AddToFreeInteeList(LCBaseIntee intee) {} // 0x000000018426DA90-0x000000018426DB70
	// [XID] // 0x00000001895FBC40-0x00000001895FBC60
	public bool RemoveFreeIntee(LCBaseIntee intee) => default; // 0x000000018426FC10-0x000000018426FCD0
	// [XID] // 0x00000001899B15A0-0x00000001899B15C0
	public List<LCBaseIntee> GetSelectedFreeInteeList(float angle) => default; // 0x000000018426F330-0x000000018426F6E0
	// [XID] // 0x00000001899B8A20-0x00000001899B8A40
	public List<LCBaseIntee> GetInteeList() => default; // 0x0000000184272190-0x0000000184272240
	// [XID] // 0x00000001899C0310-0x00000001899C0330
	private bool HasIntee(LCBaseIntee intee) => default; // 0x000000018426E070-0x000000018426E130
	// [XID] // 0x00000001899C7BB0-0x00000001899C7BD0
	public void AddToInteeList(LCBaseIntee intee) {} // 0x00000001842723B0-0x0000000184272490
	// [XID] // 0x00000001895F4500-0x00000001895F4520
	public bool RemoveIntee(LCBaseIntee intee) => default; // 0x000000018426DC30-0x000000018426DCF0
	// [XID] // 0x00000001899D6830-0x00000001899D6850
	public void RefreshOnlyInteeHeadCtrl() {} // 0x0000000184270990-0x0000000184270C50
	// [XID] // 0x00000001899DDED0-0x00000001899DDEF0
	public void RefreshAllInteeTalk() {} // 0x000000018426EA70-0x000000018426ED80
	// [XID] // 0x00000001899E5C70-0x00000001899E5C90
	private bool CheckPrePerformValid(LCBaseIntee intee) => default; // 0x000000018426E130-0x000000018426E350
	// [XID] // 0x0000000189718A60-0x0000000189718A80
	public void LostInteeAttentionAt(int index) {} // 0x0000000184271D40-0x0000000184271E50
	// [XID] // 0x00000001899F4AC0-0x00000001899F4AE0
	public void LostAllInteeAttention() {} // 0x000000018426D9B0-0x000000018426DA90
	// [XID] // 0x00000001899FC0A0-0x00000001899FC0C0
	public void ClearIntee() {} // 0x000000018426DE70-0x000000018426DF80
	// [XID] // 0x00000001896DBB40-0x00000001896DBB60
	public void OnSwitchInter(LCBaseInter fromInter) {} // 0x0000000184271960-0x0000000184271C90
	// [XID] // 0x0000000189A0AB30-0x0000000189A0AB50
	public LCBaseIntee GetCurrSelected() => default; // 0x0000000184270E30-0x00000001842711F0
	// [XID] // 0x00000001898047E0-0x0000000189804800
	public override void Init() {} // 0x000000018426F6E0-0x000000018426F800
	// [XID] // 0x0000000189A197B0-0x0000000189A197D0
	protected override void Tick(float inDeltaTime) {} // 0x0000000184272650-0x0000000184272770
	// [XID] // 0x00000001898226D0-0x00000001898226F0
	public override void Destroy() {} // 0x000000018426E410-0x000000018426E530
	// [XID] // 0x0000000189A28100-0x0000000189A28120
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x000000018426EEB0-0x000000018426EF90
	// [XID] // 0x0000000189A2F870-0x0000000189A2F890
	protected override bool ListenEvent(BaseEvent e) => default; // 0x0000000184270510-0x0000000184270610
	// [XID] // 0x0000000189A372A0-0x0000000189A372C0
	private bool OnEvtAvatarChanged(EvtAvatarChanged evt) => default; // 0x000000018426DCF0-0x000000018426DE70
	// [XID] // 0x00000001895FBC20-0x00000001895FBC40
	public bool CheckInteractionState() => default; // 0x000000018426FCD0-0x000000018426FE00
}

