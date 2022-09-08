/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoEmotion;
using RootMotion.FinalIK;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class MonoVisualEntityTool : MonoBehaviour // TypeDefIndex: 31766
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public NamedTransform[] transforms; // 0x18
		private Dictionary<int, TransformDefaults> _transformsDefault; // 0x20
		private Dictionary<string, Transform> _dynamicTransformDict; // 0x28
		private Dictionary<string, Transform> _dynamicTransformWorldDict; // 0x30
		private Dictionary<Transform, bool> _dynamicTransformWorldDisableConfig; // 0x38
		private Renderer[] _renderers; // 0x40
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public RendererInfo[] rendererInfos; // 0x48
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		private List<Collider> headBoxes; // 0x50
		public NamedCollider[] hitBoxes; // 0x58
		private Dictionary<int, NamedColliderDefaults> _hitBoxesDefault; // 0x60
		[NonSerialized]
		public bool complexHitBox; // 0x68
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public NamedTransform[] pushColliders; // 0x70
		private Dictionary<int, CollidersDefaults> _pushCollidersDefault; // 0x78
		public Collider[] connectTriggers; // 0x80
		public Collider[] ScenePropColliders; // 0x88
		public Collider[] detectTriggers; // 0x90
		public Bounds[] ScenePropColliderBounds; // 0x98
		public float shoesOffset; // 0xA0
		public int footIKMode; // 0xA4
		public float climbFootOffset; // 0xA8
		public float characterPushCollisionRadius; // 0xAC
		public float entityHeight; // 0xB0
		public float entityNearByRange; // 0xB4
		public NamedTransform entityHeightAttachPoint; // 0xB8
		public bool entityHeightEnable; // 0xC0
		public bool isVolatileGameObject; // 0xC1
		public bool ignoreLODPattern; // 0xC2
		public float effectFallOffBegin; // 0xC4
		public float effectFallOffEnd; // 0xC8
		public List<MonoLightActiveBase> lightActiveCallbackList; // 0xD0
		// [Tooltip] // 0x000000018992EC30-0x000000018992EC60
		public List<IK> finalIKList; // 0xD8
		private static Transform _worldAttachPointRoot; // 0x00
		private EmoSync _emoSync; // 0xE0
		private EyeCtrl _eyeCtrl; // 0xE8
		private EyeKey _eyeKey; // 0xF0
		private Action<BaseEntity, int, int> _onTickLodChanged; // 0xF8
		public AfterImageFollowInfo[] _afterImages; // 0x108
		public AnimationClip IKClip; // 0x110
		private float _viewSize; // 0x118
		private float _rootNodeHeight; // 0x11C
		private bool _isMonoRefInited; // 0x120
	
		// Properties
		public Renderer[] renderers { /* [XID] */ /* 0x00000001899511E0-0x0000000189951200 */ get => default; } // 0x00000001824A5390-0x00000001824A5540 
		public EmoSync emoSync { /* [XID] */ /* 0x0000000189BC5150-0x0000000189BC5170 */ get => default; } // 0x00000001824A5180-0x00000001824A5230 
		public EyeCtrl eyeCtrl { /* [XID] */ /* 0x000000018996EAD0-0x000000018996EAF0 */ get => default; } // 0x00000001824A5230-0x00000001824A52E0 
		public EyeKey eyeKey { /* [XID] */ /* 0x00000001899766F0-0x0000000189976710 */ get => default; } // 0x00000001824A52E0-0x00000001824A5390 
		public Renderer cachedMainRenderer { /* [XID] */ /* 0x000000018997DAB0-0x000000018997DAF0 */ get; /* [XID] */ /* 0x0000000189988A80-0x0000000189988AC0 */ private set; } // 0x00000001824A5120-0x00000001824A5180 0x00000001824A0E20-0x00000001824A0E90
		public float viewSize { /* [XID] */ /* 0x000000018999AFB0-0x000000018999AFD0 */ get => default; } // 0x00000001824A55F0-0x00000001824A56A0 
		public float rootNodeHeight { /* [XID] */ /* 0x00000001899A27C0-0x00000001899A27E0 */ get => default; } // 0x00000001824A5540-0x00000001824A55F0 
	
		// Nested types
		[Serializable]
		public struct AfterImageFollowInfo // TypeDefIndex: 31767
		{
			// Fields
			public GameObject afterImageObj; // 0x00
			[NonSerialized]
			[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
			public MonoEffectAfterImage afterImage; // 0x08
			public Animator followAnimator; // 0x10
			public Transform targetRoot; // 0x18
		}
	
		// Constructors
		public MonoVisualEntityTool() {} // 0x00000001824A4FE0-0x00000001824A5120
	
		// Methods
		// [XID] // 0x0000000189941DD0-0x0000000189941DF0
		public bool HasHeadBox(Collider collider) => default; // 0x00000001824A2BC0-0x00000001824A2C90
		// [XID] // 0x0000000189861990-0x00000001898619B0
		public static void SetParentToWorldAttachPointRoot(Transform trans) {} // 0x00000001824A42C0-0x00000001824A43B0
		// [XID] // 0x0000000189958850-0x0000000189958870
		public bool EnableRenderers(bool value) => default; // 0x00000001824A15A0-0x00000001824A1710
		// [XID] // 0x000000018995FF10-0x000000018995FF30
		public bool EnalbeBoxes(bool value) => default; // 0x00000001824A1710-0x00000001824A1890
		// [XID] // 0x0000000189B2BC40-0x0000000189B2BC60
		public void EnableAutoEmotion(bool value) {} // 0x00000001824A13E0-0x00000001824A15A0
		// [XID] // 0x00000001899AA130-0x00000001899AA150
		public void Start() {} // 0x00000001824A4920-0x00000001824A4DF0
		// [XID] // 0x00000001899B1AE0-0x00000001899B1B00
		public void ReInit() {} // 0x00000001824A3E00-0x00000001824A3EF0
		// [XID] // 0x00000001899B8E40-0x00000001899B8E60
		private void CacheDefaultsOnStart() {} // 0x00000001824A1170-0x00000001824A1210
		// [XID] // 0x00000001899C06C0-0x00000001899C06E0
		private void TryCaheTransformDefault(int index) {} // 0x00000001824A00F0-0x00000001824A02C0
		// [XID] // 0x0000000189823D00-0x0000000189823D20
		private void ApplyTransformDefaults() {} // 0x00000001824A2D60-0x00000001824A3130
		// [XID] // 0x00000001899CF8C0-0x00000001899CF8E0
		private void TryCachePushColliderDefault(int index, Collider[] colliders) {} // 0x00000001824A0FF0-0x00000001824A1170
		// [XID] // 0x00000001897F71C0-0x00000001897F71E0
		private void ApplyPushColliderDefaults() {} // 0x00000001824A02C0-0x00000001824A08C0
		// [XID] // 0x00000001899DE2C0-0x00000001899DE2E0
		private void TryCacheHitBoxDefault(int index, NamedCollider nameCollider) {} // 0x000000018249FB70-0x000000018249FCC0
		// [XID] // 0x0000000189B63330-0x0000000189B63350
		private void ApplyHitBoxDefaults() {} // 0x00000001824A08C0-0x00000001824A0C90
		// [XID] // 0x00000001899ED3F0-0x00000001899ED410
		private void ClearAllDynamicTrans() {} // 0x000000018249FCC0-0x00000001824A00F0
		// [XID] // 0x00000001899F4EC0-0x00000001899F4EE0
		public bool HasRenderer() => default; // 0x00000001824A2C90-0x00000001824A2D60
		// [XID] // 0x00000001899FC490-0x00000001899FC4B0
		public bool IsRendering() => default; // 0x00000001824A3650-0x00000001824A37C0
		// [XID] // 0x0000000189A03A60-0x0000000189A03A80
		private void ConditionalCacheMainRenderer() {} // 0x00000001824A37C0-0x00000001824A3990
		// [XID] // 0x0000000189A0AF50-0x0000000189A0AF70
		private Renderer CacheLargestRenderer() => default; // 0x00000001824A3BE0-0x00000001824A3E00
		// [XID] // 0x0000000189A128E0-0x0000000189A12900
		public void InitMonoRef() {} // 0x00000001824A3220-0x00000001824A3310
		// [XID] // 0x0000000189A19B30-0x0000000189A19B50
		public void RegisterMonoTickLod(BaseEntity entity) {} // 0x00000001824A3EF0-0x00000001824A40F0
		// [XID] // 0x0000000189A21110-0x0000000189A21130
		public void UnRegisterMonoTickLod(BaseEntity entity) {} // 0x00000001824A4DF0-0x00000001824A4FE0
		// [XID] // 0x0000000189A286A0-0x0000000189A286C0
		private void OnTickLodChanged(BaseEntity entity, int oldLOD, int newLOD) {} // 0x00000001824A28E0-0x00000001824A2BC0
		// [XID] // 0x0000000189A2FCF0-0x0000000189A2FD10
		public void InitByConfig(ConfigEntity jsonConfig) {} // 0x00000001824A3130-0x00000001824A3220
		private void InitDic<T>(T[] arrays, out Dictionary<string, T> dic)
			where T : UnityEngine.Object {
			dic = default;
		}
		private T GetMemberByName<T>(string sName, Dictionary<string, T> dic)
			where T : UnityEngine.Object => default;
		// [XID] // 0x0000000189B49EA0-0x0000000189B49EC0
		public Transform GetTransformByName(string name) => default; // 0x00000001824A2750-0x00000001824A28E0
		// [XID] // 0x0000000189A3EDC0-0x0000000189A3EDE0
		public void MaunalUpdateFinalIK() {} // 0x00000001824A3990-0x00000001824A3AC0
		// [XID] // 0x0000000189A464D0-0x0000000189A464F0
		public Transform GetDynamicTransform(string name) => default; // 0x00000001824A1DF0-0x00000001824A1F00
		// [XID] // 0x0000000189A4DC80-0x0000000189A4DCA0
		public void SetDynamicTransformPos(string name, Vector3 pos) {} // 0x00000001824A40F0-0x00000001824A42C0
		// [XID] // 0x0000000189A554F0-0x0000000189A55510
		public void SetWorldDynamicTransformPos(string name, Vector3 pos, bool disableWhenEntityDisable) {} // 0x00000001824A4740-0x00000001824A4920
		// [XID] // 0x0000000189A5CD90-0x0000000189A5CDB0
		public void SetWorldDynamicTransformActive(bool active, bool lightActive) {} // 0x00000001824A44D0-0x00000001824A4740
		// [XID] // 0x0000000189A645E0-0x0000000189A64600
		private void OnDestroy() {} // 0x00000001824A3AC0-0x00000001824A3BE0
		// [XID] // 0x0000000189A6BEC0-0x0000000189A6BEE0
		public void DestroyWorldDynamicTransform() {} // 0x00000001824A1210-0x00000001824A13E0
		// [XID] // 0x0000000189A73580-0x0000000189A735A0
		public Renderer GetRendereByName(string name) => default; // 0x00000001824A25D0-0x00000001824A2750
		// [XID] // 0x0000000189A7B160-0x0000000189A7B180
		public Collider[] GetPushColliderByName(string name) => default; // 0x00000001824A2420-0x00000001824A25D0
		// [XID] // 0x000000018975EE70-0x000000018975EE90
		public NamedCollider GetHitBoxByName(string name) => default; // 0x00000001824A22A0-0x00000001824A2420
		// [XID] // 0x0000000189A8A270-0x0000000189A8A290
		public NamedCollider GetHitBoxByIndex(uint index) => default; // 0x00000001824A2170-0x00000001824A22A0
		// [XID] // 0x00000001895EE670-0x00000001895EE690
		public NamedCollider GetHitBoxByCollder(Collider hitCollider, bool ignoreHead = true /* Metadata: 0x00B13542 */, bool checkActive = false /* Metadata: 0x00B13543 */) => default; // 0x00000001824A1F00-0x00000001824A2170
		// [XID] // 0x0000000189A99490-0x0000000189A994B0
		public bool IsAnyRenderersVisible() => default; // 0x00000001824A3430-0x00000001824A3650
		// [XID] // 0x0000000189AA0590-0x0000000189AA05B0
		public bool IsAllRenderersVisible() => default; // 0x00000001824A3310-0x00000001824A3430
		// [XID] // 0x0000000189AA7BB0-0x0000000189AA7BD0
		public void SetRenderersVisible(bool b) {} // 0x00000001824A43B0-0x00000001824A44D0
		// [XID] // 0x0000000189AAF640-0x0000000189AAF660
		public Bounds? GetBounds() => default; // 0x00000001824A1A20-0x00000001824A1DF0
		// [XID] // 0x0000000189AB6E70-0x0000000189AB6E90
		private void InitRootNodeHeight() {} // 0x00000001824A0E90-0x00000001824A0FF0
		// [XID] // 0x0000000189ABE870-0x0000000189ABE890
		private void OnRegisterGameObjectLightweightActivate() {} // 0x00000001824A0C90-0x00000001824A0E20
		// [XID] // 0x0000000189AC6440-0x0000000189AC6460
		private void OnRegisterGameObjectLightweightDeactivate() {} // 0x00000001824A1890-0x00000001824A1A20
	}
}
