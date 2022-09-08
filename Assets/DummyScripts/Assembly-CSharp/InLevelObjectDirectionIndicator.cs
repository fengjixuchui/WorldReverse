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

public sealed class InLevelObjectDirectionIndicator : BaseContextComponent // TypeDefIndex: 29675
{
	// Fields
	private Transform _indicatorGroup; // 0x30
	private Transform _indicatorGroupFollow; // 0x38
	private BaseEntity _localActiveAvatar; // 0x40
	private CameraEntity _mainCamera; // 0x48
	private const string INDICATOR_COMBATENEMY_PATH = "ART/UI/Menus/Widget/InLevel/ArrowPoint"; // Metadata: 0x00B0FBB9
	private const string INDICATOR_COMBATENEMY_SNEAK_PATH = "ART/UI/Menus/Widget/InLevel/ArrowPoint_Recon"; // Metadata: 0x00B0FBE3
	private const string INDICATOR_COMBATENEMY_SNEAK_FOLLOW_PATH = "ART/UI/Menus/Widget/InLevel/ArrowPoint_Follow"; // Metadata: 0x00B0FC13
	private const int INDICATOR_COMBATENEMY_MAXCOUNT = 3; // Metadata: 0x00B0FC44
	private uint _resHandlerCombatEnemyIndicator; // 0x50
	private float _combatEnemyInViewUpdateNextFrame; // 0x54
	private IndicatorObject[] _combatEnemyIndicatorPool; // 0x58
	private List<BaseEntityHandle> _combatEnemies; // 0x60
	private LCAIManager _aiManager; // 0x68
	private readonly AIMath.EntityDistanceComparer _localActiveAvatarDistanceComparer; // 0x70
	private float _nextUpdateCombatEnemiesFrame; // 0x78
	private List<GameObject> _sneakIndicatorList; // 0x80
	private List<GameObject> _sneakIndicatorFollowList; // 0x88
	private Dictionary<int, RefGameObject> _sneakIndicatorInMosterDic; // 0x90
	private GameObject _sneakIndicatorPrefab; // 0x98
	private GameObject _sneakIndicatorFollowPrefab; // 0xA0
	private Dictionary<BaseEntity, float> _candidateEnemiesDic; // 0xA8
	public float sneakSensingRange; // 0xB0
	private bool _useIndicator; // 0xB4
	private bool _inSneakState; // 0xB5

	// Nested types
	private class IndicatorObject // TypeDefIndex: 29676
	{
		// Fields
		public GameObject uiObject; // 0x10
		public BaseEntityHandle refEntityHandle; // 0x18
		private bool _display; // 0x28

		// Constructors
		public IndicatorObject() {} // Dummy constructor
		public IndicatorObject(GameObject gameObj) {} // 0x0000000184753590-0x0000000184753620

		// Methods
		// [XID] // 0x000000018996C0B0-0x000000018996C0D0
		public void Take(BaseEntity entity) {} // 0x0000000184752DC0-0x0000000184752EA0
		// [XID] // 0x0000000189973B40-0x0000000189973B60
		public void Release() {} // 0x00000001847534D0-0x0000000184753590
		// [IDTag] // 0x000000018997B190-0x000000018997B1D0
		// [XID] // 0x000000018997B190-0x000000018997B1D0
		public void UpdateRotation(Vector3 projectedPos) {} // 0x0000000184753190-0x0000000184753400
		// [IDTag] // 0x00000001899857D0-0x0000000189985810
		// [XID] // 0x00000001899857D0-0x0000000189985810
		public void UpdateRotation(CameraEntity mainCamera) {} // 0x0000000184752EA0-0x0000000184753190
		// [XID] // 0x0000000189990500-0x0000000189990520
		private void UpdateDisplay(bool shouldDisplay) {} // 0x0000000184753400-0x00000001847534D0
	}

	private struct RefGameObject // TypeDefIndex: 29677
	{
		// Fields
		public GameObject go; // 0x00
		public uint refCount; // 0x08
	}

	// Constructors
	public InLevelObjectDirectionIndicator() {} // 0x0000000184743F80-0x0000000184744280

	// Methods
	// [XID] // 0x0000000189912830-0x0000000189912850
	public override void Init(GameObject indicatorGroup) {} // 0x0000000184742160-0x0000000184742460
	// [XID] // 0x000000018991A100-0x000000018991A120
	public override void Destroy() {} // 0x0000000184741E70-0x0000000184741F40
	// [XID] // 0x0000000189921900-0x0000000189921920
	public override void UpdateView() {} // 0x0000000184743E60-0x0000000184743F80
	// [XID] // 0x0000000189929020-0x0000000189929040
	private void UpdateIndicator() {} // 0x0000000184743A20-0x0000000184743E60
	// [XID] // 0x0000000189930570-0x0000000189930590
	private void UpdateCombatEnemies() {} // 0x0000000184741F40-0x0000000184742160
	// [XID] // 0x0000000189937AC0-0x0000000189937AE0
	public void InitSneakIndicator(Transform followTrans) {} // 0x0000000184741AD0-0x0000000184741E70
	// [XID] // 0x000000018993F590-0x000000018993F5B0
	public void QuitSneakIndicator() {} // 0x0000000184741A20-0x0000000184741AD0
	// [XID] // 0x0000000189946B60-0x0000000189946B80
	private void StopDirectionIndicator() {} // 0x0000000184742600-0x0000000184742710
	// [XID] // 0x000000018994E220-0x000000018994E240
	private void StartDirectionIndicator() {} // 0x0000000184742710-0x00000001847427B0
	// [XID] // 0x0000000189955800-0x0000000189955820
	private void DestroySneakIndicator() {} // 0x0000000184741730-0x0000000184741A20
	// [XID] // 0x000000018995D320-0x000000018995D340
	public void UpdateSneakIndicator() {} // 0x00000001847427B0-0x0000000184743A20
	// [XID] // 0x00000001899649D0-0x00000001899649F0
	private void UpdateCandidateEnemies(LCAIManager aiManager) {} // 0x0000000184742520-0x0000000184742600
}

