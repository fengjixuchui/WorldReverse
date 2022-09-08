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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BillboardManager : InLevelManager, IWorldShiftAgent // TypeDefIndex: 20750
{
	// Fields
	private const string BILLBOARD_PATH = "ART/UI/Menus/Widget/InLevel/Billboard/AvatarBoardCanvasV2"; // Metadata: 0x00AFE231
	public Transform RootTrans; // 0x10
	private Dictionary<uint, VCBillboard> _dicVCBillboards; // 0x18
	private FixedBoolStack _hideAllBillboards; // 0x20
	private Transform _cameraTrans; // 0x28
	private Quaternion _preCameraRotation; // 0x30
	private const float _angleUpdateThreshold = 15f; // Metadata: 0x00AFE26E
	public bool camAngleUpdate; // 0x40
	private List<uint> _idToRemove; // 0x48
	private LevelSceneElementViewPlugin _elementViewPlugin; // 0x50
	private bool _onElementView; // 0x58
	private Dictionary<string, GameObject> _elemReactionUIObjs; // 0x60
	private Dictionary<string, List<Transform>> _elemReactionUITrans; // 0x68

	// Properties
	public bool hideAllBillboards { /* [XID] */ /* 0x0000000189606C80-0x0000000189606CA0 */ get => default; } // 0x000000018192CD50-0x000000018192CE10 
	public Transform cameraTrans { /* [XID] */ /* 0x0000000189642CC0-0x0000000189642CE0 */ get => default; } // 0x000000018192BB20-0x000000018192BC70 
	private bool levelInElementView { /* [XID] */ /* 0x0000000189668440-0x0000000189668460 */ get => default; } // 0x000000018192B7D0-0x000000018192B910 

	// Nested types
	public enum BillboardHideType // TypeDefIndex: 20751
	{
		Default = 0,
		Photograph = 1,
		MPPlay = 2,
		Count = 3
	}

	// Constructors
	public BillboardManager() {} // 0x000000018192D0E0-0x000000018192D210

	// Methods
	// [XID] // 0x00000001895F8070-0x00000001895F8090
	public override void Init() {} // 0x000000018192C110-0x000000018192C230
	// [XID] // 0x00000001895FF470-0x00000001895FF490
	public override void Destroy() {} // 0x000000018192A9F0-0x000000018192AB50
	// [XID] // 0x00000001898EF730-0x00000001898EF750
	public void SetHideAllBillboards(BillboardHideType type, bool value) {} // 0x000000018192A510-0x000000018192A600
	// [XID] // 0x0000000189615C60-0x0000000189615C80
	public AsyncJob RequestBillboardAsync(VCBillboard vcBillboard, UnityAction<MonoBillboard> callback) => default; // 0x000000018192B5B0-0x000000018192B7D0
	// [XID] // 0x000000018961D4B0-0x000000018961D4D0
	public void RegisterVCBillboard(VCBillboard vcBillboard) {} // 0x000000018192AB50-0x000000018192AC20
	// [XID] // 0x00000001896249B0-0x00000001896249D0
	public void Abort() {} // 0x000000018192C840-0x000000018192C930
	// [XID] // 0x000000018962C150-0x000000018962C170
	public void ReleaseBillboardAsync(MonoBillboard billboard, uint entityID) {} // 0x000000018192B0F0-0x000000018192B2B0
	// [XID] // 0x0000000189633CB0-0x0000000189633CD0
	public void RemoveFromDic(uint entityID) {} // 0x000000018192C930-0x000000018192CA20
	// [XID] // 0x0000000189A610D0-0x0000000189A610F0
	public void RetargetRuntimeID(VCBillboard billboard, uint entityID) {} // 0x000000018192BC70-0x000000018192C110
	// [XID] // 0x000000018964A310-0x000000018964A330
	public override void LateTick() {} // 0x000000018192CA20-0x000000018192CB80
	// [XID] // 0x0000000189651A20-0x0000000189651A40
	private void TickBillboard(bool force) {} // 0x000000018192B2B0-0x000000018192B5B0
	// [XID] // 0x00000001896592F0-0x0000000189659310
	private void CleanseDicVCBillboard() {} // 0x000000018192C230-0x000000018192C580
	// [XID] // 0x00000001896609D0-0x00000001896609F0
	public void ResetAllMarksName() {} // 0x000000018192B910-0x000000018192BB20
	// [XID] // 0x000000018966FE90-0x000000018966FEB0
	private void OnEnterElementView() {} // 0x000000018192CB80-0x000000018192CD50
	// [XID] // 0x00000001896776C0-0x00000001896776E0
	private void OnExitElementView() {} // 0x000000018192CE10-0x000000018192CFE0
	// [XID] // 0x000000018967EC60-0x000000018967EC80
	public Transform AllocElementUI(string path, Transform parent) => default; // 0x000000018192AC20-0x000000018192B0F0
	// [XID] // 0x0000000189686550-0x0000000189686570
	public void DeallocElementUI(string path, Transform trans) {} // 0x000000018192C580-0x000000018192C840
	// [XID] // 0x000000018968E3B0-0x000000018968E3D0
	private void ClearElementUI() {} // 0x000000018192A600-0x000000018192A990
	// [XID] // 0x0000000189695C50-0x0000000189695C70
	public bool ShiftWorld(Vector3 offset, Vector3 oldOffset) => default; // 0x000000018192CFE0-0x000000018192D0E0
}

