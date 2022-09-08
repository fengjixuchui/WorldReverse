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
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EffectManager : InLevelManager, IWorldShiftAgent // TypeDefIndex: 20719
{
	// Fields
	private EffectPool _effectPool; // 0x10
	private IndexedEffects _indexedEffects; // 0x18
	private const float PRELOAD_COMMON_EFFECT_MAX_TIME_PER_FRAME = 5f; // Metadata: 0x00AFE1D1
	private List<MonoEffectProxy> _proxyCacheForActiveEffects; // 0x20
	private Dictionary<uint, List<MonoEffectProxy>> _entityEffects; // 0x28
	private const int MonoEffectListDefaultCapacity = 10; // Metadata: 0x00AFE1D5
	private static Stack<List<MonoEffectProxy>> _cachedMonoEffectList; // 0x00
	private static List<uint> _preloadResHandled; // 0x08
	private static Dictionary<int, AsyncJob> _preloadResJob; // 0x10

	// Properties
	public EffectPool effectPool { /* [XID] */ /* 0x000000018995CC00-0x000000018995CC20 */ get => default; } // 0x000000018423F0D0-0x000000018423F170 

	// Nested types
	private class IndexedEffects // TypeDefIndex: 20720
	{
		// Fields
		private const int DEFAULT_INDEX_SIZE = 800; // Metadata: 0x00AFE1D9
		private HashSet<uint> _effectRuntimeIDs; // 0x10
		private Dictionary<int, MonoEffectProxy> _effectProxys; // 0x18
		private int _nextIndex; // 0x20
		private static string[] _alertUsernames; // 0x00
		private static bool _hasAlertBeyondSize; // 0x08

		// Constructors
		public IndexedEffects() {} // 0x0000000184238900-0x00000001842389C0
		static IndexedEffects() {} // 0x0000000184238810-0x0000000184238900

		// Methods
		// [XID] // 0x00000001899B4F20-0x00000001899B4F40
		public void Destroy() {} // 0x0000000184237B80-0x0000000184237C60
		// [XID] // 0x00000001899BC650-0x00000001899BC670
		public int AddEffect(MonoEffectProxy effectProxy) => default; // 0x0000000184238620-0x0000000184238810
		// [XID] // 0x00000001896302F0-0x0000000189630310
		public void RemoveEffect(int index, bool immediately) {} // 0x00000001842383C0-0x0000000184238620
		// [XID] // 0x00000001899CB790-0x00000001899CB7B0
		public MonoEffectProxy GetEffect(int index) => default; // 0x0000000184237C60-0x0000000184237D50
		// [XID] // 0x00000001899D2BD0-0x00000001899D2BF0
		public void SetEffectActive(int index, bool active, bool checkOwner) {} // 0x0000000184237D50-0x0000000184237EF0
		// [XID] // 0x00000001899F60F0-0x00000001899F6110
		public bool IsIndexedEffect(uint runtimeID) => default; // 0x00000001842382F0-0x00000001842383C0
		// [XID] // 0x00000001899E1D80-0x00000001899E1DA0
		public string Dump() => default; // 0x0000000184237EF0-0x00000001842382F0
	}

	// Constructors
	public EffectManager() {} // 0x0000000184241C50-0x0000000184241CE0
	static EffectManager() {} // 0x0000000184241B60-0x0000000184241C50

	// Methods
	// [XID] // 0x0000000189859BD0-0x0000000189859BF0
	public override void Init() {} // 0x000000018423FB60-0x000000018423FC50
	// [XID] // 0x0000000189860C90-0x0000000189860CB0
	public override void Tick() {} // 0x0000000184241A20-0x0000000184241B60
	// [XID] // 0x0000000189868440-0x0000000189868460
	public override void LateTick() {} // 0x0000000184240BF0-0x0000000184240D30
	// [XID] // 0x000000018986F8C0-0x000000018986F8E0
	public override void Destroy() {} // 0x000000018423E460-0x000000018423E530
	[DebuggerHidden] // 0x0000000189876EF0-0x0000000189876F30
	// [XID] // 0x0000000189876EF0-0x0000000189876F30
	public IEnumerator PreloadCommonEffect(Action<float> progressFunc) => default; // 0x000000018423D290-0x000000018423D3A0
	// [XID] // 0x00000001897F2CB0-0x00000001897F2CD0
	public void PreloadEntityEffects(BaseEntity entity, ConfigPreloadType preloadType, string[] effectNames) {} // 0x000000018423E980-0x000000018423EAC0
	// [XID] // 0x0000000189852D70-0x0000000189852D90
	public void PreloadEntityEffectsAsyncWithJob(BaseEntity entity, ConfigPreloadType preloadType, string[] effectNames, Action<string> preloadedCallback = null, List<AsyncJob> jobs = null) {} // 0x000000018423DDB0-0x000000018423DF60
	// [XID] // 0x000000018988FEE0-0x000000018988FF00
	public void ReleasePreloadedEntityEffects(BaseEntity entity, ConfigPreloadType preloadType, string[] effectNames) {} // 0x000000018423E2C0-0x000000018423E400
	// [IDTag] // 0x0000000189897440-0x0000000189897480
	// [XID] // 0x0000000189897440-0x0000000189897480
	public void GetEntityEffectsByOwner(uint entityID, List<MonoEffectProxy> result) {} // 0x000000018423EAC0-0x000000018423EC20
	// [IDTag] // 0x00000001898A1A40-0x00000001898A1A80
	// [XID] // 0x00000001898A1A40-0x00000001898A1A80
	private List<MonoEffectProxy> GetEntityEffectsByOwner(uint entityID) => default; // 0x000000018423EC20-0x000000018423ECE0
	// [XID] // 0x0000000189A56820-0x0000000189A56840
	public void SetEffectActive(uint entityID, bool active, bool includeIndexedEffects = false /* Metadata: 0x00AFE1C6 */) {} // 0x000000018423F340-0x000000018423F540
	// [XID] // 0x00000001898B3820-0x00000001898B3840
	public void SetEntityEffectVisible(uint entityID, bool active, bool includeIndexedEffects = false /* Metadata: 0x00AFE1C7 */) {} // 0x0000000184240500-0x0000000184240700
	// [XID] // 0x00000001898BB5F0-0x00000001898BB610
	public void SetEntityEffectStop(uint entityID) {} // 0x000000018423FC50-0x000000018423FE30
	// [XID] // 0x000000018997ADD0-0x000000018997ADF0
	public int CreateIndexedEntityEffect(BaseEntity owner, string effectName, Vector3? initPos = default, Quaternion? initRot = default, Vector3? initScale = default, bool async = false /* Metadata: 0x00AFE1C8 */) => default; // 0x0000000184240E20-0x0000000184241040
	// [XID] // 0x00000001898B7670-0x00000001898B7690
	public MonoEffectProxy CreateUnindexedEntityEffect(BaseEntity owner, string effectName, Vector3? initPos = default, Quaternion? initRot = default, Vector3? initScale = default, Vector3? targetPos = default, BaseEntity targetEntity = null, Transform targetTransform = null, Vector3? targetDir = default, bool indexed = false /* Metadata: 0x00AFE1C9 */, bool async = false /* Metadata: 0x00AFE1CA */) => default; // 0x0000000184241420-0x0000000184241670
	// [XID] // 0x00000001898D1A10-0x00000001898D1A30
	private void CreateUnindexedEntityEffectImplement(MonoEffectProxy effectProxy, BaseEntity owner, string effectName, Vector3? initPos = default, Quaternion? initRot = default, Vector3? initScale = default, Vector3? targetPos = default, BaseEntity targetEntity = null, Transform targetTransform = null, Vector3? targetDir = default, bool indexed = false /* Metadata: 0x00AFE1CB */, bool async = false /* Metadata: 0x00AFE1CC */) {} // 0x000000018423D3A0-0x000000018423DDB0
	// [XID] // 0x00000001898D9250-0x00000001898D9270
	private Vector3 GetInitPos(Vector3? initPos, BaseEntity owner) => default; // 0x000000018423F6C0-0x000000018423F860
	// [XID] // 0x00000001898E0EB0-0x00000001898E0ED0
	public void SetIndexedEntityEffectActive(int index, bool active, bool checkOwner = true /* Metadata: 0x00AFE1CD */) {} // 0x0000000184240D30-0x0000000184240E20
	// [XID] // 0x0000000189A4C1C0-0x0000000189A4C1E0
	public void SetIndexedEntityEffectDestroy(int index, bool immediately = false /* Metadata: 0x00AFE1CE */) {} // 0x0000000184241120-0x0000000184241200
	// [XID] // 0x00000001898F00A0-0x00000001898F00C0
	public MonoEffectProxy GetIndexedEntityEffect(int index) => default; // 0x000000018423E6A0-0x000000018423E760
	// [XID] // 0x00000001898F79D0-0x00000001898F79F0
	public void PreloadScenePropEffectAsync(string effectName) {} // 0x0000000184241040-0x0000000184241120
	// [XID] // 0x00000001898FF030-0x00000001898FF050
	public void ReleaseScenePropEffect(string effectName) {} // 0x000000018423DF60-0x000000018423E030
	// [XID] // 0x00000001899067B0-0x00000001899067D0
	public void PlayScenePropEffect(string effectName, Vector3 initPos, Quaternion initRot, Vector3 initScale) {} // 0x0000000184240700-0x0000000184240940
	[Preserve] // 0x000000018990E2D0-0x000000018990E310
	// [XID] // 0x000000018990E2D0-0x000000018990E310
	public override string Dump(string tag) => default; // 0x000000018423E530-0x000000018423E6A0
	[Preserve] // 0x0000000189918AD0-0x0000000189918B10
	// [XID] // 0x0000000189918AD0-0x0000000189918B10
	public void DumpCSV() {} // 0x000000018423F860-0x000000018423F900
	// [XID] // 0x0000000189923300-0x0000000189923320
	private void AttachProxyWithEffect(MonoEffect effect, MonoEffectProxy proxy) {} // 0x0000000184241670-0x0000000184241790
	// [XID] // 0x000000018992AAC0-0x000000018992AAE0
	public int CreateIndexedEmptyEffect(BaseEntity owner, string effectName, Vector3? initPos = default) => default; // 0x000000018423FE30-0x000000018423FF60
	// [XID] // 0x00000001895F43F0-0x00000001895F4410
	public MonoEffectProxy CreateUnindexedEmptyEffect(BaseEntity owner, string effectName, Vector3? initPos = default) => default; // 0x0000000184240940-0x0000000184240A50
	// [XID] // 0x00000001896123E0-0x0000000189612400
	public void FillIndexedEmptyEffect(int index, BaseEntity owner, Vector3? initPos = default, Quaternion? initRot = default, Vector3? initScale = default, Vector3? targetPos = default, BaseEntity targetEntity = null, Transform targetTransform = null, Vector3? targetDir = default, bool async = false /* Metadata: 0x00AFE1CF */) {} // 0x000000018423D060-0x000000018423D290
	// [XID] // 0x0000000189940C80-0x0000000189940CA0
	public void FillUnindexedEmptyEffect(MonoEffectProxy proxy, BaseEntity owner, Vector3? initPos = default, Quaternion? initRot = default, Vector3? initScale = default, Vector3? targetPos = default, BaseEntity targetEntity = null, Transform targetTransform = null, Vector3? targetDir = default, bool async = false /* Metadata: 0x00AFE1D0 */) {} // 0x000000018423E760-0x000000018423E980
	// [XID] // 0x0000000189948640-0x0000000189948660
	private MonoEffectProxy CheckAndCreateEffectProxy(BaseEntity owner, string effectName, Vector3? initPos = default) => default; // 0x000000018423F900-0x000000018423FB60
	// [XID] // 0x000000018994FDD0-0x000000018994FDF0
	private bool SkipCreateOnlineEffect(BaseEntity owner) => default; // 0x0000000184240A50-0x0000000184240BF0
	// [XID] // 0x0000000189957380-0x00000001899573A0
	private bool EntityIsNullOrRecycled(BaseEntity entity) => default; // 0x000000018423E120-0x000000018423E1F0
	// [XID] // 0x000000018995EE10-0x000000018995EE30
	private void InitEntityEffects() {} // 0x000000018423E1F0-0x000000018423E2C0
	// [XID] // 0x00000001899666F0-0x0000000189966710
	private void ClearEntityEffects() {} // 0x0000000184241200-0x0000000184241420
	// [XID] // 0x000000018996DA50-0x000000018996DA70
	public void AddEntityEffects(BaseEntity owner, MonoEffectProxy effect) {} // 0x000000018423F170-0x000000018423F340
	// [XID] // 0x00000001899755F0-0x0000000189975610
	public void RemoveEntityEffects(MonoEffectProxy effect) {} // 0x000000018423FF60-0x0000000184240140
	// [XID] // 0x000000018997C790-0x000000018997C7B0
	public List<MonoEffectProxy> GetEntityEffects(uint entityID) => default; // 0x000000018423EE90-0x000000018423EF80
	// [XID] // 0x00000001899844F0-0x0000000189984510
	private static List<MonoEffectProxy> AllocMonoEffectList() => default; // 0x000000018423ECE0-0x000000018423EE30
	// [XID] // 0x000000018998BF70-0x000000018998BF90
	private static void DeallocMonoEffectList(ref List<MonoEffectProxy> effects) {} // 0x000000018423E030-0x000000018423E120
	[DebuggerHidden] // 0x0000000189993C90-0x0000000189993CD0
	// [XID] // 0x0000000189993C90-0x0000000189993CD0
	public static IEnumerator PreloadAllRes(Action<float> progressFunc) => default; // 0x000000018423F540-0x000000018423F640
	// [XID] // 0x000000018999E6D0-0x000000018999E6F0
	private static void LoadCallBack(int index, ulong hash, bool loadSucceeded, uint handle, GameObject asset) {} // 0x000000018423EF80-0x000000018423F0D0
	// [XID] // 0x00000001899A60B0-0x00000001899A60D0
	public static void DismissAllRes() {} // 0x0000000184240140-0x0000000184240500
	// [XID] // 0x00000001899AD6C0-0x00000001899AD6E0
	public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000184241790-0x0000000184241A20
}

