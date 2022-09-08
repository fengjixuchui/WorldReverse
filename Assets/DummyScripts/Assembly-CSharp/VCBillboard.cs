/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCBillboard : VCBase // TypeDefIndex: 11829
{
	// Fields
	public const bool USE_BATCH_TRANSFORM = true; // Metadata: 0x00AEACB8
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private MonoBillboard _billboard; // 0x108
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private ConfigBillboard _jsonConfig; // 0x110
	private bool _hideFromAbility; // 0x118
	private CameraEntity _cameraEntity; // 0x120
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private Transform _attachTrans; // 0x128
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private Vector3 _offset; // 0x130
	private VCCombatBillboardPlugin _combatBillboardPlugin; // 0x140
	private VCElementReactionPlugin _elementReactionPlugin; // 0x148
	private const int SHOW_ELEMENT_COUNT = 4; // Metadata: 0x00AEACB9
	private List<VCBaseBillboardPlugin> _billboardPlugins; // 0x150
	private float _deadline; // 0x158
	private const float CACHE_DURATION = 5f; // Metadata: 0x00AEACBD
	private const float BILLBOARD_UPDATE_TRRESHOLD_NEAR = 0.003f; // Metadata: 0x00AEACC1
	private const float BILLBOARD_UPDATE_TRRESHOLD_MID = 0.02f; // Metadata: 0x00AEACC5
	private const float CHARACTOR_BILLBOARD_OFFSET = 0.15f; // Metadata: 0x00AEACC9
	private const float BILLBOARD_DEPTH_OFFSET = 0.15f; // Metadata: 0x00AEACCD
	private bool _showProgressBar; // 0x168
	private UnityAction _onBillboardLoaded; // 0x170
	private AsyncJob _job; // 0x178
	private bool bUseBatch; // 0x188
	private HashList<Action<VCElementReactionPlugin>> callBackReaction; // 0x190
	private HashList<Action<VCCombatBillboardPlugin>> callBackCombat; // 0x198
	private bool _needFlushTrans; // 0x1A0
	public float pluginScale; // 0x1A4
	public Vector3 pluginVector; // 0x1A8
	public float distanceToCamera; // 0x1B4
	private static readonly float BILLBOARD_DEFAULT_SCALE; // 0x00
	public bool needTickRotation; // 0x1B8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189889830-0x0000000189889850 */ get => default; } // 0x0000000183340190-0x0000000183340230 
	public Transform AttachTrans { /* [XID] */ /* 0x0000000189890D60-0x0000000189890D80 */ get => default; } // 0x000000018333BA60-0x000000018333BB10 
	public VCCombatBillboardPlugin combatBillboardPlugin { /* [XID] */ /* 0x0000000189702320-0x0000000189702340 */ get => default; } // 0x000000018333BB90-0x000000018333BC40 
	public VCElementReactionPlugin elementReactionPlugin { /* [XID] */ /* 0x0000000189898340-0x0000000189898360 */ get => default; } // 0x000000018333DC10-0x000000018333DCC0 
	public MonoBillboard billboard { /* [XID] */ /* 0x000000018990A490-0x000000018990A4B0 */ get => default; } // 0x000000018333AFC0-0x000000018333B070 
	public ConfigBillboard jsonConfig { /* [XID] */ /* 0x000000018989F560-0x000000018989F580 */ get => default; /* [XID] */ /* 0x00000001899199A0-0x00000001899199C0 */ set {} } // 0x000000018333BC40-0x000000018333BCF0 0x000000018333C7A0-0x000000018333C850
	public string iconName { /* [XID] */ /* 0x0000000189920E70-0x0000000189920EB0 */ get; /* [XID] */ /* 0x000000018992B860-0x000000018992B8A0 */ private set; } // 0x000000018333E0E0-0x000000018333E140 0x000000018333F220-0x000000018333F290
	private bool anyValidPlugin { /* [XID] */ /* 0x00000001899BD2A0-0x00000001899BD2C0 */ get => default; } // 0x000000018333A970-0x000000018333AB30 
	private bool anyActivePlugin { /* [XID] */ /* 0x00000001899C4C90-0x00000001899C4CB0 */ get => default; } // 0x000000018333EB40-0x000000018333EC90 
	public bool hideFromAbility { /* [XID] */ /* 0x0000000189A61050-0x0000000189A61070 */ set {} } // 0x000000018333B200-0x000000018333B2B0
	public bool hideFromManager { /* [XID] */ /* 0x0000000189A68EB0-0x0000000189A68ED0 */ get => default; } // 0x000000018333B830-0x000000018333B910 

	// Constructors
	public VCBillboard() {} // 0x0000000183340000-0x0000000183340190
	static VCBillboard() {} // 0x000000018333FFA0-0x0000000183340000

	// Methods
	// [XID] // 0x0000000189935B20-0x0000000189935B40
	public override void PreInit() {} // 0x000000018333F860-0x000000018333FAD0
	// [XID] // 0x00000001898BD6A0-0x00000001898BD6C0
	public override void Init() {} // 0x000000018333C990-0x000000018333CCA0
	// [XID] // 0x00000001898F2680-0x00000001898F26A0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018333FAD0-0x000000018333FB90
	// [XID] // 0x0000000189A5CAC0-0x0000000189A5CAE0
	private void RegisterInBillboardManager() {} // 0x000000018333A4A0-0x000000018333A580
	// [XID] // 0x00000001898F9DC0-0x00000001898F9DE0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x000000018333B070-0x000000018333B190
	// [XID] // 0x000000018995B0F0-0x000000018995B110
	public void AddGeneralMark(string iconName) {} // 0x000000018333A580-0x000000018333A750
	// [XID] // 0x00000001899A3C20-0x00000001899A3C40
	public void AddMixinGeneralMark(string iconName, float? showDistance = default) {} // 0x000000018333BFE0-0x000000018333C190
	// [XID] // 0x000000018996A0F0-0x000000018996A110
	public void ClearMixinGeneralMark() {} // 0x000000018333D210-0x000000018333D340
	// [XID] // 0x0000000189AB6CB0-0x0000000189AB6CD0
	private void ResetIconName() {} // 0x000000018333C580-0x000000018333C7A0
	// [XID] // 0x0000000189AAF460-0x0000000189AAF480
	public void ClearGeneralMark() {} // 0x000000018333EC90-0x000000018333EE20
	// [XID] // 0x00000001898E3260-0x00000001898E3280
	private void OnBillboardRequired() {} // 0x000000018333EE20-0x000000018333F0B0
	// [XID] // 0x00000001899881D0-0x00000001899881F0
	public void ShowProgressBar(bool show) {} // 0x000000018333D3B0-0x000000018333D480
	// [XID] // 0x000000018998FC60-0x000000018998FC80
	private void InitProgressPlugin() {} // 0x000000018333E7B0-0x000000018333E990
	// [XID] // 0x00000001899975D0-0x00000001899975F0
	public void InitDefaultMarks(bool forceInit) {} // 0x000000018333AB30-0x000000018333AFC0
	// [XID] // 0x0000000189B3C110-0x0000000189B3C130
	public void SetTitle(string title) {} // 0x000000018333F290-0x000000018333F3E0
	// [XID] // 0x00000001899A6AB0-0x00000001899A6AD0
	public void ResetAllCombat() {} // 0x000000018333DCC0-0x000000018333DD80
	// [XID] // 0x00000001899AE3B0-0x00000001899AE3D0
	public void ResetMarkName() {} // 0x000000018333B2B0-0x000000018333B500
	// [XID] // 0x00000001899B5A00-0x00000001899B5A20
	public void ResetMarkTitle() {} // 0x000000018333DB00-0x000000018333DC10
	// [XID] // 0x00000001899F8F10-0x00000001899F8F30
	public override void Destroy() {} // 0x000000018333B560-0x000000018333B670
	// [XID] // 0x00000001899D3A20-0x00000001899D3A40
	public override void Retarget() {} // 0x000000018333FB90-0x000000018333FC80
	// [XID] // 0x00000001899DAFC0-0x00000001899DAFE0
	public void UnregisterBillboardCallBack(UnityAction callback) {} // 0x000000018333B970-0x000000018333BA60
	// [XID] // 0x0000000189A20FA0-0x0000000189A20FC0
	public void RequestBillboardAsync(UnityAction callback) {} // 0x000000018333BCF0-0x000000018333BF10
	// [XID] // 0x00000001899E9D50-0x00000001899E9D70
	private void OnBillboardLoaded(MonoBillboard billboard) {} // 0x000000018333C190-0x000000018333C520
	// [XID] // 0x00000001899F1530-0x00000001899F1550
	private void CallLoadedCallback() {} // 0x000000018333A8B0-0x000000018333A970
	// [XID] // 0x00000001899F8D90-0x00000001899F8DB0
	private void ReleaseBillboard() {} // 0x000000018333B670-0x000000018333B830
	// [XID] // 0x000000018968F2E0-0x000000018968F300
	public void SetReactionRegister(Action<VCElementReactionPlugin> callback, bool register = true /* Metadata: 0x00AEACB6 */) {} // 0x000000018333D010-0x000000018333D150
	// [XID] // 0x0000000189A07A80-0x0000000189A07AA0
	public void SetCombatRegister(Action<VCCombatBillboardPlugin> callback, bool register = true /* Metadata: 0x00AEACB7 */) {} // 0x000000018333F710-0x000000018333F860
	// [XID] // 0x0000000189A0F120-0x0000000189A0F140
	protected override void Tick(float inDeltaTime) {} // 0x000000018333FC80-0x000000018333FFA0
	// [XID] // 0x0000000189A70240-0x0000000189A70260
	public override bool IsActive() => default; // 0x000000018333CCA0-0x000000018333CD80
	// [XID] // 0x0000000189A77AE0-0x0000000189A77B00
	private void UpdateBillboardCameraInfo(Vector3 cameraPosition, Vector3 billboardPosition) {} // 0x000000018333F3E0-0x000000018333F710
	// [XID] // 0x00000001899018A0-0x00000001899018C0
	public bool NeedHideBillboard() => default; // 0x000000018333E140-0x000000018333E220
	// [XID] // 0x0000000189A2C8E0-0x0000000189A2C900
	private void HideBillboard() {} // 0x000000018333BF10-0x000000018333BFE0
	// [XID] // 0x0000000189A33F60-0x0000000189A33F80
	public void UpdateTransform(Transform cameraTrans) {} // 0x000000018333D480-0x000000018333DB00
	// [XID] // 0x0000000189B0FBF0-0x0000000189B0FC10
	public override void OnDisable() {} // 0x000000018333F0B0-0x000000018333F180
	// [XID] // 0x0000000189A0F260-0x0000000189A0F280
	public override void OnEnable() {} // 0x000000018333F180-0x000000018333F220
	// [XID] // 0x0000000189A4A6F0-0x0000000189A4A710
	private void CheckSetActive() {} // 0x000000018333A7C0-0x000000018333A8B0
	// [XID] // 0x0000000189B16DA0-0x0000000189B16DC0
	public void OnBillboardPluginAdded(VCBaseBillboardPlugin plugin) {} // 0x000000018333C8C0-0x000000018333C990
	// [XID] // 0x0000000189A16880-0x0000000189A168A0
	public void OnBillboardPluginDestroyed(VCBaseBillboardPlugin plugin) {} // 0x000000018333DDF0-0x000000018333DEC0
	// [XID] // 0x0000000189A70160-0x0000000189A70180
	private Vector3 LocateBillboard(Transform cameraTrans) => default; // 0x000000018333E220-0x000000018333E7B0
	// [XID] // 0x0000000189A77980-0x0000000189A779A0
	private void AdaptPosition() {} // 0x000000018333CD80-0x000000018333D010
	// [XID] // 0x0000000189A7F040-0x0000000189A7F060
	public void OnEnterElementView() {} // 0x000000018333DEC0-0x000000018333E070
	// [XID] // 0x0000000189B5A3E0-0x0000000189B5A400
	public void OnExitElementView() {} // 0x000000018333E990-0x000000018333EB40
}

