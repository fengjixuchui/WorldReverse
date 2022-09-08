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

public sealed class VCAvatarPerform : VCBasePerform // TypeDefIndex: 11800
{
	// Fields
	private LCAIManager _levelAI; // 0x168
	private Animator _animator; // 0x170
	private VCAvatarFocus _vcAvatarFocus; // 0x178
	private VCBaseInputController _vcInputController; // 0x180
	private VCAvatarCombat _vcCombat; // 0x188
	private VCBaseModel _vcBaseModel; // 0x190
	private bool _beingHitted; // 0x198
	private bool _hasConfigStandbyPerform; // 0x199
	private float _configStandbyPerformMinTime; // 0x19C
	private float _configStandbyPerformMaxTime; // 0x1A0
	private SimpleSafeInt32[] _configStandbyPerformIDs; // 0x1A8
	private int _lastTriggerStandbyPerformIDIndex; // 0x1B0
	private float _triggerStandbyPerformTimeThreshold; // 0x1B4
	private float _keepStandbyTime; // 0x1B8
	private const string SIT_DOWN_UI_TEXT_ID = "UI_AVATAR_SITDOWN"; // Metadata: 0x00AEABD6
	private uint _sitDownUIRuntimeID; // 0x1BC
	private bool _isShowingSitDownUI; // 0x1C0
	private bool _triggeredSitDownUI; // 0x1C1
	private int _curIterateChairIndex; // 0x1C4
	private IChair _curIterateSittableChair; // 0x1C8
	private SceneChairConfig.SitDownData _curIterateSittableSitData; // 0x1D0
	public Action onSitDownToChair; // 0x1E0
	public Action onStandUpFromChair; // 0x1E8
	private int _lastAnimTag; // 0x1F0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018970FB90-0x000000018970FBB0 */ get => default; } // 0x00000001817D36B0-0x00000001817D3750 
	public int currentAnimTagHash { /* [XID] */ /* 0x0000000189770910-0x0000000189770930 */ get => default; } // 0x00000001817D0D50-0x00000001817D0F20 

	// Constructors
	public VCAvatarPerform() {} // 0x00000001817D35F0-0x00000001817D36B0

	// Methods
	// [XID] // 0x00000001899A9C40-0x00000001899A9C60
	public override void Init() {} // 0x00000001817D1D70-0x00000001817D22A0
	// [XID] // 0x00000001898001A0-0x00000001898001C0
	protected override void Tick(float inDeltaTime) {} // 0x00000001817D3320-0x00000001817D35F0
	// [XID] // 0x00000001899D6990-0x00000001899D69B0
	public override void OnEnable() {} // 0x00000001817D2FA0-0x00000001817D3050
	// [XID] // 0x000000018975D1A0-0x000000018975D1C0
	public override void OnDisable() {} // 0x00000001817D2EF0-0x00000001817D2FA0
	// [XID] // 0x000000018973C780-0x000000018973C7A0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001817D1010-0x00000001817D10F0
	// [XID] // 0x0000000189743C80-0x0000000189743CA0
	protected override bool OnEvent(BaseEvent e) => default; // 0x00000001817D3050-0x00000001817D3130
	// [XID] // 0x00000001897A55D0-0x00000001897A55F0
	private void ResetPerformData() {} // 0x00000001817D22A0-0x00000001817D2340
	// [XID] // 0x00000001895FBC00-0x00000001895FBC20
	private void CheckStandbyPerform(float inDeltaTime, int animTag) {} // 0x00000001817D1470-0x00000001817D17A0
	// [XID] // 0x000000018965BAD0-0x000000018965BAF0
	private void DoStandbyPerform() {} // 0x00000001817D05B0-0x00000001817D0730
	// [XID] // 0x0000000189720160-0x0000000189720180
	private void InterruptStandbyPerform() {} // 0x00000001817D0850-0x00000001817D0910
	// [XID] // 0x00000001897690B0-0x00000001897690D0
	private void ResetStandbyPerform() {} // 0x00000001817D07B0-0x00000001817D0850
	// [XID] // 0x00000001897707B0-0x00000001897707D0
	private void CheckSitPerform(int animTag) {} // 0x00000001817D10F0-0x00000001817D1470
	// [XID] // 0x0000000189777FB0-0x0000000189777FD0
	private void CheckSitUp(bool canPlaySitUp) {} // 0x00000001817D2770-0x00000001817D2970
	// [XID] // 0x000000018977F4C0-0x000000018977F4E0
	public override void NotifySitEnd() {} // 0x00000001817D2340-0x00000001817D2400
	// [XID] // 0x000000018979E050-0x000000018979E070
	public override void NotifySitStart() {} // 0x00000001817D2BF0-0x00000001817D2D40
	// [XID] // 0x000000018978E560-0x000000018978E580
	public void NotifyRemoteAvatarSitStart() {} // 0x00000001817D3130-0x00000001817D3270
	// [XID] // 0x0000000189A28200-0x0000000189A28220
	protected override void CommonStandFromChair(SceneChairConfig.SitDirection sitDirection) {} // 0x00000001817D0F20-0x00000001817D1010
	// [XID] // 0x0000000189619C50-0x0000000189619C70
	private float GetStandAngle(Vector3 entityForward, float joystickAngle) => default; // 0x00000001817D0A50-0x00000001817D0D50
	// [XID] // 0x00000001899E5D40-0x00000001899E5D60
	private void CheckSitDown(bool canPlaySitDown) {} // 0x00000001817D1940-0x00000001817D1CD0
	// [XID] // 0x00000001897F8A80-0x00000001897F8AA0
	private void ShowSitDownUI() {} // 0x00000001817D24F0-0x00000001817D2710
	// [XID] // 0x00000001897B4840-0x00000001897B4860
	private void OnGeneralInteeCB(uint entityRuntimeID) {} // 0x00000001817D3270-0x00000001817D3320
	// [XID] // 0x00000001899ECE60-0x00000001899ECE80
	private void HideSitDownUI() {} // 0x00000001817D17A0-0x00000001817D1940
	// [XID] // 0x00000001899CF530-0x00000001899CF550
	private void CheckSitCallback(int animTag) {} // 0x00000001817D2D40-0x00000001817D2EF0
	// [XID] // 0x0000000189A20EB0-0x0000000189A20ED0
	public override void SetupVCMove(bool enableCollision) {} // 0x00000001817D0220-0x00000001817D0300
	// [XID] // 0x00000001897D2C60-0x00000001897D2C80
	public override void SetupRigidbody(bool enable) {} // 0x00000001817D2A60-0x00000001817D2B90
	// [XID] // 0x00000001897DA9C0-0x00000001897DA9E0
	public override void DoPerform(int performID, float performParam, bool fixedPerformTrans) {} // 0x00000001817D0300-0x00000001817D05B0
	// [XID] // 0x00000001897E1DA0-0x00000001897E1DC0
	public override void CancelPerform() {} // 0x00000001817D0060-0x00000001817D0160
}

