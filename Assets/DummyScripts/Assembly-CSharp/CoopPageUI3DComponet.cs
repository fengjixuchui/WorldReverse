/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopPageUI3DComponet : UI3DBaseComponent // TypeDefIndex: 30213
{
	// Fields
	private MonoCoopPageUI3D _ui3Dmono; // 0x60
	private Dictionary<uint, CoopRootPoint> _pos2Point; // 0x68
	private List<CoopRootPoint> _coopPoints; // 0x70
	private uint _chapterId; // 0x78
	private CoopChapterExcelConfig _config; // 0x80
	private MonoCoopPoint3D _lastSelectedPoint; // 0x88
	private RectTransform _canvas3D; // 0x90
	private bool _easyTouchUICompatibily; // 0x98
	private float currAnimTime; // 0x9C
	private Vector2 startPos; // 0xA0

	// Properties
	public uint chapterId { /* [XID] */ /* 0x000000018997DCD0-0x000000018997DCF0 */ set {} } // 0x0000000183D47BE0-0x0000000183D47C90
	public List<CoopRootPoint> coopActivePoints { /* [XID] */ /* 0x0000000189A0F6E0-0x0000000189A0F700 */ get => default; } // 0x0000000183D49700-0x0000000183D49AC0 

	// Constructors
	public CoopPageUI3DComponet() {} // 0x0000000183D4AE20-0x0000000183D4AEE0

	// Methods
	// [XID] // 0x0000000189985680-0x00000001899856A0
	protected override void InitUI3D() {} // 0x0000000183D47A80-0x0000000183D47B20
	// [XID] // 0x000000018998D450-0x000000018998D470
	protected override void InitMonoUI3D() {} // 0x0000000183D47B20-0x0000000183D47BE0
	// [XID] // 0x0000000189994ED0-0x0000000189994EF0
	private void InitCanvasRatio() {} // 0x0000000183D47D80-0x0000000183D47F10
	// [XID] // 0x000000018999C7B0-0x000000018999C7D0
	private void SetCanvasShowRatio(float xRatio = 1f /* Metadata: 0x00B108C6 */, float yRatio = 1f /* Metadata: 0x00B108CA */) {} // 0x0000000183D47C90-0x0000000183D47D80
	// [XID] // 0x00000001899A4260-0x00000001899A4280
	protected override void SetupUI3DView() {} // 0x0000000183D49C20-0x0000000183D4A070
	// [XID] // 0x00000001899ABC00-0x00000001899ABC20
	protected override void ClearUI3DView() {} // 0x0000000183D486F0-0x0000000183D48820
	// [XID] // 0x00000001899B3550-0x00000001899B3570
	public void RefreshPointState(CoopPoint info, Action<CoopPoint> clickCallback) {} // 0x0000000183D48E20-0x0000000183D490D0
	// [XID] // 0x00000001899BA930-0x00000001899BA950
	private void SetPointView(CoopPoint info, CoopPointExcelConfig config, CoopRootPoint rootPoint) {} // 0x0000000183D4A5B0-0x0000000183D4AC00
	// [XID] // 0x00000001899C2230-0x00000001899C2250
	private void CheckActivePostPoint(uint postPoint) {} // 0x0000000183D4AC60-0x0000000183D4ADC0
	// [XID] // 0x00000001899C9960-0x00000001899C9980
	public void ResetPointShowState() {} // 0x0000000183D49130-0x0000000183D49420
	// [XID] // 0x00000001899D1190-0x00000001899D11B0
	public void RefreshPointShowSate() {} // 0x0000000183D4A070-0x0000000183D4A400
	// [XID] // 0x00000001899D8680-0x00000001899D86A0
	public void SetPointOngoingView(uint posID) {} // 0x0000000183D48230-0x0000000183D486F0
	// [XID] // 0x00000001899DFD30-0x00000001899DFD50
	public MonoUIContainer LocateToPosId(uint posId) => default; // 0x0000000183D47F10-0x0000000183D48230
	// [XID] // 0x00000001899E7740-0x00000001899E7760
	public void CameraMoveToPos(float posX, float posY) {} // 0x0000000183D49AC0-0x0000000183D49C20
	// [XID] // 0x00000001899EECF0-0x00000001899EED10
	private Vector2 GetPosRatioOnCanvas(float posX, float posY) => default; // 0x0000000183D49420-0x0000000183D49700
	// [XID] // 0x00000001899F65B0-0x00000001899F65D0
	public Vector2 GetCameraLocalPosition() => default; // 0x0000000183D489E0-0x0000000183D48B10
	// [XID] // 0x00000001899FDAF0-0x00000001899FDB10
	public void CameraMoveToPosSlow(Vector2 targetPos, float moveTime, Action moveCallback) {} // 0x0000000183D48820-0x0000000183D489E0
	[DebuggerHidden] // 0x0000000189A05510-0x0000000189A05550
	// [XID] // 0x0000000189A05510-0x0000000189A05550
	private IEnumerator SetCameraMove(Vector2 targetPos, float moveTime, Action moveCallback) => default; // 0x0000000183D4A400-0x0000000183D4A550
	// [XID] // 0x0000000189A16D20-0x0000000189A16D40
	public void HideActivePoints(bool hide) {} // 0x0000000183D48B10-0x0000000183D48E20
}

