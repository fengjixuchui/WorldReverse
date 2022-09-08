/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCFlyAttachment : VCBaseAttachment // TypeDefIndex: 11864
{
	// Fields
	public const string PARAM_FLY_ATTACH_STATE = "State"; // Metadata: 0x00AEAD4E
	public const int PARAM_FLY_ATTACH_STATE_VALUE_START = 1; // Metadata: 0x00AEAD57
	public const int PARAM_FLY_ATTACH_STATE_VALUE_END = 2; // Metadata: 0x00AEAD5B
	private VCAnimatorEvent _vcAnimatorEvent; // 0x130
	private MonoFlyAttachmentHelper _flyAttachHelper; // 0x138
	private MonoFlyAttachmentHelper _accFlyAttachHelper; // 0x140
	private VCHumanoidMove _vcMove; // 0x148
	private bool _isNormalFlying; // 0x150
	private bool _isTailEnabled; // 0x151
	private bool _isAccTailEnabled; // 0x152
	private const float ENABLE_TIME = 0f; // Metadata: 0x00AEAD5F
	private const float DISABLE_TIME = 0.1f; // Metadata: 0x00AEAD63
	private const float FLY_SPEED_FAST_TH = 0.7f; // Metadata: 0x00AEAD67
	private bool _enableAllTheTrail; // 0x153
	private ConfigFlycloakFashion _currentConfigCloak; // 0x158
	private ConfigFlycloakFashionScale _currentCloakScales; // 0x160
	private ConfigFlycloakFashionEffect _currentCloakEffects; // 0x168
	private uint _currentCloakID; // 0x170
	public bool isManekinFlycloak; // 0x174

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898A2770-0x00000001898A2790 */ get => default; } // 0x0000000182EA4BA0-0x0000000182EA4C40 
	public bool enableAllTheTrail { /* [XID] */ /* 0x00000001898A9CE0-0x00000001898A9D00 */ get => default; /* [XID] */ /* 0x00000001898B1790-0x00000001898B17B0 */ set {} } // 0x0000000182EA35A0-0x0000000182EA3650 0x0000000182EA4770-0x0000000182EA4840
	public override string viewPath { /* [XID] */ /* 0x00000001898E6370-0x00000001898E6390 */ get => default; } // 0x0000000182EA2910-0x0000000182EA2B20 
	public override bool IsAniamtorValid { /* [XID] */ /* 0x00000001898EC490-0x00000001898EC4B0 */ get => default; } // 0x0000000182EA4340-0x0000000182EA43F0 

	// Constructors
	public VCFlyAttachment() {} // 0x0000000182EA4AF0-0x0000000182EA4BA0

	// Methods
	// [XID] // 0x00000001898B90E0-0x00000001898B9100
	public void RemoveFlycloak() {} // 0x0000000182EA2270-0x0000000182EA2360
	// [XID] // 0x00000001898575A0-0x00000001898575C0
	public void ChangeFlycloak(uint flycloakId) {} // 0x0000000182EA2050-0x0000000182EA2270
	// [XID] // 0x00000001898C7E60-0x00000001898C7E80
	public bool ChangeManekinFlycloak(uint flycloakId) => default; // 0x0000000182EA4840-0x0000000182EA4A30
	// [XID] // 0x00000001898CF680-0x00000001898CF6A0
	public void ShowManekinFlycloak() {} // 0x0000000182EA3000-0x0000000182EA3180
	// [XID] // 0x00000001898D6EB0-0x00000001898D6ED0
	public void HideManekinFlycloak() {} // 0x0000000182EA3650-0x0000000182EA3760
	// [XID] // 0x000000018985E740-0x000000018985E760
	private void UpdateViewPath(uint flycloakId) {} // 0x0000000182EA2C10-0x0000000182EA2E20
	// [XID] // 0x000000018990A610-0x000000018990A630
	public override void Init() {} // 0x0000000182EA3760-0x0000000182EA39A0
	// [XID] // 0x00000001898FCD00-0x00000001898FCD20
	public void InitView() {} // 0x0000000182EA2460-0x0000000182EA2910
	// [XID] // 0x00000001899046A0-0x00000001899046C0
	protected override void Tick(float inDeltaTime) {} // 0x0000000182EA4A30-0x0000000182EA4AF0
	// [XID] // 0x000000018990BE60-0x000000018990BE80
	private void TickTail(float deltaTime) {} // 0x0000000182EA39A0-0x0000000182EA3B00
	// [XID] // 0x0000000189913820-0x0000000189913840
	private bool CheckFlySpeed() => default; // 0x0000000182EA4600-0x0000000182EA4770
	// [XID] // 0x00000001899B3030-0x00000001899B3050
	private void UpdateWind(float flySpd) {} // 0x0000000182EA3F50-0x0000000182EA4070
	// [XID] // 0x0000000189B15650-0x0000000189B15670
	private void EnableTail() {} // 0x0000000182EA3180-0x0000000182EA3280
	// [XID] // 0x00000001897976B0-0x00000001897976D0
	private void EnableAccTail() {} // 0x0000000182EA2F00-0x0000000182EA3000
	// [XID] // 0x0000000189931610-0x0000000189931630
	private void DisableTail(bool force = false /* Metadata: 0x00AEAD4C */) {} // 0x0000000182EA1BF0-0x0000000182EA1D30
	// [XID] // 0x0000000189938D60-0x0000000189938D80
	private void DisableAccTail(bool force = false /* Metadata: 0x00AEAD4D */) {} // 0x0000000182EA4450-0x0000000182EA4590
	// [XID] // 0x0000000189940510-0x0000000189940530
	protected override void AddAttachmentPlugins() {} // 0x0000000182EA4070-0x0000000182EA41A0
	// [XID] // 0x0000000189947B90-0x0000000189947BB0
	public void ForceDisable() {} // 0x0000000182EA41A0-0x0000000182EA42D0
	// [XID] // 0x000000018994F250-0x000000018994F270
	private void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x0000000182EA3B00-0x0000000182EA3EF0
	// [XID] // 0x00000001898A1030-0x00000001898A1050
	private void PlayFlyStartEff() {} // 0x0000000182EA1D30-0x0000000182EA2050
	// [XID] // 0x000000018995E250-0x000000018995E270
	private void PlayFlyEndEff() {} // 0x0000000182EA3280-0x0000000182EA35A0
	// [XID] // 0x0000000189AF7F70-0x0000000189AF7F90
	public override void Destroy() {} // 0x0000000182EA2360-0x0000000182EA2460
	// [XID] // 0x00000001899C91A0-0x00000001899C91C0
	public void SetIsManekin(bool isManekin) {} // 0x0000000182EA2E20-0x0000000182EA2F00
}

