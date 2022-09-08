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

public class InLevelTargetIndicator : BaseContextComponent // TypeDefIndex: 29685
{
	// Fields
	private static string TARGET_PREFAB_PATH; // 0x00
	private static string QUEST_MARK_PREFAB_PATH; // 0x08
	private static string GADGET_PREFAB_PATH; // 0x10
	private GameObject _targetIndicatorPrefab; // 0x30
	private GameObject _questMarkIndicatorPrefab; // 0x38
	private GameObject _gadgetIndicatorPrefab; // 0x40
	private Transform _indicatorGroupFollow; // 0x48
	private float containerWidth; // 0x50
	private float containerHeight; // 0x54
	private BaseEntity _localActiveAvatar; // 0x58
	private uint _localActiveAvatarID; // 0x60
	private CameraEntity _mainCamera; // 0x68
	private Camera _uiCamera; // 0x70
	protected Dictionary<IndicatorKey, TargetIndicatorInfo> _targetPointDic; // 0x78
	protected Dictionary<IndicatorKey, GameObject> _targetIndicatorDic; // 0x80
	private float _questShowDistance; // 0x88
	private float _ra; // 0x8C
	private float _rb; // 0x90
	private Vector3 _uiPos; // 0x94
	protected Dictionary<uint, TrackingGroup> _markIdDic; // 0xA0
	protected Dictionary<uint, TrackingGroup> _navigationMarkIdDic; // 0xA8
	private SpriteLoadProxy _iconProxy; // 0xB0
	private static List<IndicatorKey> _toBeRemovedTarget; // 0x18
	private static Dictionary<uint, Stack<GameObject>> _unuseIndicatorDic; // 0x20

	// Constructors
	public InLevelTargetIndicator() {} // 0x0000000181EC3500-0x0000000181EC3620
	static InLevelTargetIndicator() {} // 0x0000000181EC3410-0x0000000181EC3500

	// Methods
	// [XID] // 0x0000000189A50F40-0x0000000189A50F60
	private void UpdateResolution() {} // 0x0000000181EC0D40-0x0000000181EC0F50
	// [XID] // 0x0000000189A584C0-0x0000000189A584E0
	private void SetEllipseScale(MonoArrowPointContainer arrowPointContainer) {} // 0x0000000181EC1310-0x0000000181EC14C0
	// [XID] // 0x0000000189A5FF60-0x0000000189A5FF80
	public override void Init(GameObject view) {} // 0x0000000181EC15D0-0x0000000181EC1CC0
	// [XID] // 0x0000000189A67BC0-0x0000000189A67BE0
	public override void Destroy() {} // 0x0000000181EC0790-0x0000000181EC0D40
	// [XID] // 0x0000000189A6EFF0-0x0000000189A6F010
	public override void UpdateView() {} // 0x0000000181EC2370-0x0000000181EC3410
	// [XID] // 0x0000000189A76810-0x0000000189A76830
	private void ChangeColorOrIcon(GameObject ins, IndicatorKey key, TargetIndicatorType type) {} // 0x0000000181EC0F50-0x0000000181EC1310
	// [XID] // 0x0000000189A7E0E0-0x0000000189A7E100
	private void RefreshLocalAvatar() {} // 0x0000000181EC2270-0x0000000181EC2370
	// [XID] // 0x0000000189A85A80-0x0000000189A85AA0
	public void AddTargetPoint(IndicatorKey targetId, Vector3 position, Vector3 logicPosition, TargetIndicatorType type = TargetIndicatorType.DEFAULT /* Metadata: 0x00B0FC7A */, bool _pending = false /* Metadata: 0x00B0FC7E */, bool isPaimonNavi = false /* Metadata: 0x00B0FC7F */, bool needRefreshAnime = false /* Metadata: 0x00B0FC80 */, float radius = -1f /* Metadata: 0x00B0FC81 */) {} // 0x0000000181EC05C0-0x0000000181EC0790
	// [XID] // 0x0000000189A8D340-0x0000000189A8D360
	private bool CheckTargetAutoRemove(IndicatorKey targetId, ref TargetIndicatorInfo info, float currDistance) => default; // 0x0000000181EC14C0-0x0000000181EC15D0
	// [XID] // 0x0000000189A94860-0x0000000189A94880
	public void RemoveTargetPoint(IndicatorKey targetId) {} // 0x0000000181EC20B0-0x0000000181EC2270
	// [XID] // 0x0000000189A9C1C0-0x0000000189A9C1E0
	private bool PointInEllipse(Vector2 point) => default; // 0x0000000181EC1FB0-0x0000000181EC20B0
	// [XID] // 0x0000000189AA3890-0x0000000189AA38B0
	private GameObject GetUnuseIndicator(TargetIndicatorType type = TargetIndicatorType.DEFAULT /* Metadata: 0x00B0FC85 */) => default; // 0x0000000181EC1D20-0x0000000181EC1F50
	// [XID] // 0x0000000189AAAF30-0x0000000189AAAF50
	private void PushUnuseIndicator(TargetIndicatorType type, GameObject indicator) {} // 0x0000000181EC0330-0x0000000181EC0540
}

