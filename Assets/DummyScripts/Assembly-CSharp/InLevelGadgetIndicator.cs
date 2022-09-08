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

public sealed class InLevelGadgetIndicator : BaseContextComponent // TypeDefIndex: 29659
{
	// Fields
	private static string GADGET_PREFAB_PATH; // 0x00
	public static string DEFAULT_CION; // 0x08
	private GameObject _gadgetIndicatorPrefab; // 0x30
	private Transform _indicatorGroupFollow; // 0x38
	private float containerWidth; // 0x40
	private float containerHeight; // 0x44
	private CameraEntity _mainCamera; // 0x48
	private Camera _uiCamera; // 0x50
	private Dictionary<uint, GadgetIndicatorInfo> _indicatorDic; // 0x58
	private Dictionary<uint, GameObject> _objectDic; // 0x60
	private float _ra; // 0x68
	private float _rb; // 0x6C
	private SpriteLoadProxy _iconProxy; // 0x70
	private List<uint> _toBeRemovedTarget; // 0x78
	private static Stack<GameObject> _unuseIndicatorStack; // 0x10

	// Nested types
	public class GadgetIndicatorInfo // TypeDefIndex: 29660
	{
		// Fields
		public string icon; // 0x10
		public IndicatorDistanceInfoType disType; // 0x18
		public Vector3 position; // 0x1C
		public Vector3 localOffSet; // 0x28
		public bool isFollowMove; // 0x34
		public bool isEnabled; // 0x35

		// Constructors
		public GadgetIndicatorInfo() {} // 0x0000000182A9A250-0x0000000182A9A2B0
	}

	// Constructors
	public InLevelGadgetIndicator() {} // 0x0000000182A974A0-0x0000000182A97560
	static InLevelGadgetIndicator() {} // 0x0000000182A97410-0x0000000182A974A0

	// Methods
	// [XID] // 0x00000001896D91C0-0x00000001896D91E0
	private void UpdateResolution() {} // 0x0000000182A954B0-0x0000000182A956C0
	// [XID] // 0x00000001896E0990-0x00000001896E09B0
	private void SetEllipseScale(MonoArrowPointContainer arrowPointContainer) {} // 0x0000000182A956C0-0x0000000182A95880
	// [XID] // 0x00000001896E7C40-0x00000001896E7C60
	public override void Init(GameObject view) {} // 0x0000000182A95B00-0x0000000182A95F80
	// [XID] // 0x00000001896EF330-0x00000001896EF350
	public override void Destroy() {} // 0x0000000182A95090-0x0000000182A954B0
	// [XID] // 0x00000001896F6CC0-0x00000001896F6CE0
	public override void UpdateView() {} // 0x0000000182A965D0-0x0000000182A97410
	// [XID] // 0x00000001896FE630-0x00000001896FE650
	private void ReInitIndicatorObj(GameObject ins, GadgetIndicatorInfo info) {} // 0x0000000182A95880-0x0000000182A95B00
	// [XID] // 0x0000000189705740-0x0000000189705760
	public void AddIndicator(uint entityRuntimeID, Vector3 position, IndicatorDistanceInfoType disType, string icon, float yOffSet, bool isFollowMove) {} // 0x0000000182A94E70-0x0000000182A95090
	// [XID] // 0x000000018970D280-0x000000018970D2A0
	public void SetIndicatorCountDown(uint entityRuntimeID, uint countDown) {} // 0x0000000182A96310-0x0000000182A96430
	// [XID] // 0x0000000189714720-0x0000000189714740
	public void RemoveIndicator(uint entityRuntimeID) {} // 0x0000000182A96430-0x0000000182A965D0
	// [XID] // 0x000000018971C130-0x000000018971C150
	private bool PointInEllipse(Vector2 point) => default; // 0x0000000182A96210-0x0000000182A96310
	// [XID] // 0x0000000189723580-0x00000001897235A0
	private GameObject GetUnuseIndicator() => default; // 0x0000000182A95FE0-0x0000000182A961B0
	// [XID] // 0x000000018972AD00-0x000000018972AD20
	private void PushUnuseIndicator(GameObject indicator) {} // 0x0000000182A94CF0-0x0000000182A94DF0
}

