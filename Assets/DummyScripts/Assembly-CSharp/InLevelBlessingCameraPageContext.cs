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

public sealed class InLevelBlessingCameraPageContext : BasePageContext // TypeDefIndex: 29783
{
	// Fields
	private MonoInLevelBlessingCameraPage _pageMono; // 0x190
	private bool _isFixedCamera; // 0x198
	private VCStackCamera _vcStackCamera; // 0x1A0
	private bool _canScan; // 0x1A8
	private float _cameraRotateRatio; // 0x1AC
	private uint _maxScanNumToday; // 0x1B0
	private List<BlessingScanExcelConfig> _scanEntityList; // 0x1B8
	private List<uint> _albumList; // 0x1C0
	private bool _isAlbumOpened; // 0x1C8
	private float _lastScanTime; // 0x1CC
	private float _scanInterval; // 0x1D0
	private ScanStage _scanStage; // 0x1D4
	private uint _scanEntityId; // 0x1D8
	private float _scanStartTime; // 0x1DC
	private float _idleStartTime; // 0x1E0
	private float _fadeInStartTime; // 0x1E4
	private const string POST_EFFECT_STRONG = "PostEffect_Scene_Glitch_Strong"; // Metadata: 0x00B0FEE2
	private HashSet<uint> _scanFailEntityIdSet; // 0x1E8
	private static readonly uint _scanSuccessAudio; // 0x00

	// Properties
	public static uint debugScanTypeId { /* [XID] */ /* 0x000000018978BDC0-0x000000018978BE00 */ get; set; } // 0x0000000181D69FC0-0x0000000181D6A050 0x0000000181D6B8F0-0x0000000181D6B980

	// Nested types
	private enum ScanStage // TypeDefIndex: 29784
	{
		Idle = 0,
		Find = 1,
		Focus = 2,
		Finish = 3
	}

	// Constructors
	public InLevelBlessingCameraPageContext() {} // Dummy constructor
	public InLevelBlessingCameraPageContext(bool isFixedCamera) {} // 0x0000000181D6CA10-0x0000000181D6CB70
	static InLevelBlessingCameraPageContext() {} // 0x0000000181D6C980-0x0000000181D6CA10

	// Methods
	// [XID] // 0x000000018977CE10-0x000000018977CE30
	public static bool CheckCanEnterPage() => default; // 0x0000000181D69A70-0x0000000181D69C30
	// [XID] // 0x0000000189784850-0x0000000189784870
	public static bool CheckActivityOpen() => default; // 0x0000000181D6BC30-0x0000000181D6BD80
	// [XID] // 0x000000018979E530-0x000000018979E550
	public override void SetupView() {} // 0x0000000181D6C390-0x0000000181D6C710
	// [XID] // 0x00000001897A5CD0-0x00000001897A5CF0
	public override void ClearView() {} // 0x0000000181D69410-0x0000000181D694D0
	// [XID] // 0x00000001897AD240-0x00000001897AD260
	public override void UpdateView() {} // 0x0000000181D6C710-0x0000000181D6C980
	// [XID] // 0x00000001897B52B0-0x00000001897B52D0
	public override void ClosePage() {} // 0x0000000181D68270-0x0000000181D68330
	// [XID] // 0x00000001897BCF20-0x00000001897BCF40
	protected override void BindViewCallbacks() {} // 0x0000000181D68BC0-0x0000000181D68D70
	// [XID] // 0x00000001897C4260-0x00000001897C4280
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181D6C150-0x0000000181D6C390
	// [XID] // 0x00000001897CBAE0-0x00000001897CBB00
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181D6A910-0x0000000181D6ADE0
	// [XID] // 0x00000001897D33F0-0x00000001897D3410
	private void SetupUI(bool isFixedCamera) {} // 0x0000000181D6AEA0-0x0000000181D6B0F0
	// [XID] // 0x00000001897DAE70-0x00000001897DAE90
	private void HideAvatar(bool hide) {} // 0x0000000181D6BF60-0x0000000181D6C0C0
	// [XID] // 0x00000001897E2580-0x00000001897E25A0
	private void CheckAvatarBeingHit(AttackResult attackResult, BaseEntity entity) {} // 0x0000000181D69DE0-0x0000000181D69F30
	// [XID] // 0x00000001897E9D30-0x00000001897E9D50
	private void InitBlessingData() {} // 0x0000000181D6B980-0x0000000181D6BBD0
	// [XID] // 0x00000001897F1990-0x00000001897F19B0
	private void RefreshScanNumToday(uint curScanNumToday) {} // 0x0000000181D69C30-0x0000000181D69DE0
	// [XID] // 0x00000001897F9100-0x00000001897F9120
	private void OnOpenAlbum() {} // 0x0000000181D68D70-0x0000000181D68F30
	// [XID] // 0x0000000189800710-0x0000000189800730
	private void OnCloseAlbum() {} // 0x0000000181D698B0-0x0000000181D69A70
	// [XID] // 0x0000000189807DB0-0x0000000189807DD0
	private void RefreshAlbum() {} // 0x0000000181D6B0F0-0x0000000181D6B3F0
	// [XID] // 0x000000018980F690-0x000000018980F6B0
	private void RefreshPhoto(Transform trans, int index) {} // 0x0000000181D69210-0x0000000181D69410
	// [XID] // 0x0000000189816D40-0x0000000189816D60
	private void ScanEntities() {} // 0x0000000181D694D0-0x0000000181D698B0
	// [XID] // 0x000000018981E590-0x000000018981E5B0
	private void ResetScanInfo() {} // 0x0000000181D6B3F0-0x0000000181D6B610
	// [XID] // 0x0000000189825A30-0x0000000189825A50
	private void OnScanEntitySuccess(uint photoId, uint curScanNumToday) {} // 0x0000000181D68F30-0x0000000181D69210
	// [XID] // 0x000000018982D1E0-0x000000018982D200
	private void OnScanEntityFail() {} // 0x0000000181D6B610-0x0000000181D6B6E0
	// [XID] // 0x0000000189834940-0x0000000189834960
	private BaseEntity ScanEntitiesByConfig(out Vector3 posOnScreen) {
		posOnScreen = default;
		return default;
	} // 0x0000000181D68330-0x0000000181D68BC0
	// [XID] // 0x000000018983BFD0-0x000000018983BFF0
	private bool CanScanEntity(uint configID, out BlessingScanExcelConfig scanConfig) {
		scanConfig = default;
		return default;
	} // 0x0000000181D6B6E0-0x0000000181D6B8F0
	// [XID] // 0x0000000189843600-0x0000000189843620
	private Vector3 GetEntityCenterPosition(BaseEntity entity, BlessingScanExcelConfig scanConfig) => default; // 0x0000000181D6A050-0x0000000181D6A850
	// [XID] // 0x000000018984AB00-0x000000018984AB20
	private bool CanSeeEntity(Vector3 cameraPos, Vector3 entityPos, BaseEntity entity) => default; // 0x0000000181D67BC0-0x0000000181D68270
	// [XID] // 0x0000000189851EA0-0x0000000189851EC0
	private void IndicateTarget(bool show, Vector3 posOnScreen) {} // 0x0000000181D6BD80-0x0000000181D6BF60
}

