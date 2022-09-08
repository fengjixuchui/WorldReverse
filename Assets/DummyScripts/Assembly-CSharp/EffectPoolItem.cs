/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EffectPoolItem : AssetLoadBase3<GameObject, string>, IWorldShiftAgent // TypeDefIndex: 19770
{
	// Fields
	private EffectPool _pool; // 0x48
	private string _name; // 0x50
	private GlobalVars.EffectPoolRemoveStrategy _effectPoolRemoveStrategy; // 0x58
	private uint _preinstantiateNumWhenPreload; // 0x5C
	private uint _maxUsedSize; // 0x60
	private HashList<MonoEffect> _occupiedList; // 0x68
	private List<MonoEffect> _avaliableList; // 0x70
	private int _spawnAsyncJobCount; // 0x78
	private List<AsyncJob?> _spawnAsyncJobs; // 0x80
	private SkipEffectCreationCheckerItem _skipCreationChecker; // 0x88
	private Action<MonoEffect> _postPreInstantiateHandler; // 0x90
	private Dictionary<BaseEntity, int> _onCreateRelatedEntities; // 0x98
	private Dictionary<BaseEntity, int> _onCombatRelatedEntities; // 0xA0
	private static StringBuilder _info1; // 0x00
	private static StringBuilder _info2; // 0x08

	// Properties
	private bool HasRelatedEntities { /* [XID] */ /* 0x00000001899A4830-0x00000001899A4850 */ get => default; } // 0x00000001852A2150-0x00000001852A2230 
	private GlobalVars.EffectPoolRemoveStrategy defaultStrategy { /* [XID] */ /* 0x0000000189A05B50-0x0000000189A05B70 */ get => default; } // 0x00000001852A76F0-0x00000001852A7790 
	private Dictionary<string, ConfigSkipUnindexedEffectCreation> skipConfig { /* [XID] */ /* 0x0000000189A66530-0x0000000189A66550 */ get => default; } // 0x00000001852A7630-0x00000001852A76F0 

	// Constructors
	public EffectPoolItem() {} // Dummy constructor
	public EffectPoolItem(string effectName, ulong effectHash, EffectPool pool) {} // 0x00000001852A9140-0x00000001852A9330
	static EffectPoolItem() {} // 0x00000001852A9090-0x00000001852A9140

	// Methods
	// [XID] // 0x0000000189960700-0x0000000189960720
	protected override string Parameter() => default; // 0x00000001852A8230-0x00000001852A82D0
	// [XID] // 0x0000000189795EB0-0x0000000189795ED0
	public void Destroy() {} // 0x00000001852A2230-0x00000001852A2610
	// [XID] // 0x000000018996F260-0x000000018996F280
	public void HandleToBeDeacllocated(List<MonoEffect> effects) {} // 0x00000001852A8640-0x00000001852A8840
	// [XID] // 0x0000000189976EF0-0x0000000189976F10
	public void CheckRemovePool() {} // 0x00000001852A4010-0x00000001852A4110
	// [XID] // 0x0000000189A3A330-0x0000000189A3A350
	public bool CanBeRemove() => default; // 0x00000001852A4110-0x00000001852A41E0
	// [XID] // 0x0000000189985D90-0x0000000189985DB0
	private void AddAvaliableTail(MonoEffect effect) {} // 0x00000001852A66B0-0x00000001852A6800
	// [XID] // 0x000000018998D9E0-0x000000018998DA00
	private MonoEffect RemoveAvaliableTail() => default; // 0x00000001852A3E80-0x00000001852A4010
	// [XID] // 0x0000000189995450-0x0000000189995470
	private bool HasAvaliable() => default; // 0x00000001852A7790-0x00000001852A7850
	// [XID] // 0x0000000189B1BA80-0x0000000189B1BAA0
	public bool HasMoreThanOneAvaliable() => default; // 0x00000001852A2090-0x00000001852A2150
	// [XID] // 0x00000001899AC170-0x00000001899AC190
	private Dictionary<BaseEntity, int> GetRelatedEntities(ConfigPreloadType preloadType, bool withCreate = false /* Metadata: 0x00AFCCFD */) => default; // 0x00000001852A1F30-0x00000001852A2090
	// [XID] // 0x00000001897ACCD0-0x00000001897ACCF0
	private void ClearRelatedEntities() {} // 0x00000001852A4F60-0x00000001852A54D0
	// [XID] // 0x00000001899BAE20-0x00000001899BAE40
	private void RegisterRelatedEntity(ConfigPreloadType preloadType, BaseEntity entity) {} // 0x00000001852A2F30-0x00000001852A32A0
	// [XID] // 0x00000001899C27B0-0x00000001899C27D0
	private void UnregisterRelatedEntity(ConfigPreloadType preloadType, BaseEntity entity) {} // 0x00000001852A3AA0-0x00000001852A3E80
	// [XID] // 0x00000001899852D0-0x00000001899852F0
	private void CheckOneAvaliable() {} // 0x00000001852A6540-0x00000001852A66B0
	// [XID] // 0x00000001899D1760-0x00000001899D1780
	private void Preinstantiate(int count) {} // 0x00000001852A45E0-0x00000001852A4910
	// [XID] // 0x00000001899D8C50-0x00000001899D8C70
	private void PostPreinstantiateHandler(MonoEffect effect) {} // 0x00000001852A54D0-0x00000001852A55D0
	// [XID] // 0x00000001899E02E0-0x00000001899E0300
	public void Preload(ConfigPreloadType preloadType, BaseEntity entity, GlobalVars.EffectPoolRemoveStrategy poolRemoveStrategy) {} // 0x00000001852A2AC0-0x00000001852A2C70
	// [XID] // 0x000000018985A9F0-0x000000018985AA10
	public AsyncJob PreloadAsyncWithJob(ConfigPreloadType preloadType, BaseEntity entity, Action<string> preloadedHandler, GlobalVars.EffectPoolRemoveStrategy poolRemoveStrategy) => default; // 0x00000001852A7850-0x00000001852A7A40
	// [XID] // 0x00000001899EF240-0x00000001899EF260
	public override void AfterFinish() {} // 0x00000001852A7450-0x00000001852A7630
	// [XID] // 0x00000001899F6BB0-0x00000001899F6BD0
	public void ReleasePreloaded(ConfigPreloadType preloadType, BaseEntity entity) {} // 0x00000001852A6410-0x00000001852A64E0
	// [XID] // 0x00000001899FE270-0x00000001899FE290
	private void UpdateEffectPoolRemoveStrategy(GlobalVars.EffectPoolRemoveStrategy poolRemoveStrategy) {} // 0x00000001852A32A0-0x00000001852A3350
	// [XID] // 0x0000000189A0CEA0-0x0000000189A0CEC0
	public MonoEffect Alloc(bool indexed, BaseEntity owner, Vector3 initPos, Quaternion initRot, Vector3 initScale) => default; // 0x00000001852A6030-0x00000001852A6410
	// [XID] // 0x0000000189A146C0-0x0000000189A146E0
	public void AllocAsync(bool indexed, BaseEntity owner, Vector3 initPos, Quaternion initRot, Vector3 initScale, Action<MonoEffect> allocedHandler) {} // 0x00000001852A41E0-0x00000001852A45E0
	// [XID] // 0x0000000189848B40-0x0000000189848B60
	private void PostAllocHandler(bool indexed, BaseEntity owner, MonoEffect effect, Vector3 initPos, Quaternion initRot, Vector3 initScale, Action<MonoEffect> allocedHandler, bool async) {} // 0x00000001852A7D10-0x00000001852A8230
	// [XID] // 0x0000000189A23340-0x0000000189A23360
	private void Dealloc(MonoEffect effect) {} // 0x00000001852A6EE0-0x00000001852A7450
	// [XID] // 0x0000000189A2A580-0x0000000189A2A5A0
	private MonoEffect Spawn() => default; // 0x00000001852A6D50-0x00000001852A6EE0
	// [XID] // 0x0000000189A31AB0-0x0000000189A31AD0
	private void SpawnAsync(Action<MonoEffect> spawnedHandler) {} // 0x00000001852A7A40-0x00000001852A7D10
	// [XID] // 0x0000000189AD6D10-0x0000000189AD6D30
	private MonoEffect PostSpawnHandler(GameObject effectGO, Action<MonoEffect> spawnedHandler) => default; // 0x00000001852A3580-0x00000001852A3990
	// [XID] // 0x0000000189A40D10-0x0000000189A40D30
	private void Despawn(MonoEffect effect) {} // 0x00000001852A8840-0x00000001852A8C80
	// [XID] // 0x00000001899643F0-0x0000000189964410
	private void AddPoolBudgetCount(MonoEffect effect) {} // 0x00000001852A2E20-0x00000001852A2F30
	// [XID] // 0x0000000189A4FCA0-0x0000000189A4FCC0
	private void RemovePoolBudgetCount(MonoEffect effect) {} // 0x00000001852A3990-0x00000001852A3AA0
	// [XID] // 0x0000000189A57190-0x0000000189A571B0
	public bool ReleaseForBudget(bool ignoreOneAvaliable, SliceFrameWatch stopwatch) => default; // 0x00000001852A6800-0x00000001852A6D50
	// [XID] // 0x0000000189A5ED30-0x0000000189A5ED50
	public bool CanSkipCreation(Vector3 initPos) => default; // 0x00000001852A8C80-0x00000001852A8E50
	// [XID] // 0x0000000189A6DD80-0x0000000189A6DDA0
	public void VisitAllAlivedEffects(Action<MonoEffect> callback) {} // 0x00000001852A2C70-0x00000001852A2E20
	// [XID] // 0x0000000189A75350-0x0000000189A75370
	public string Dump() => default; // 0x00000001852A55D0-0x00000001852A6030
	// [IDTag] // 0x0000000189A7D090-0x0000000189A7D0D0
	// [XID] // 0x0000000189A7D090-0x0000000189A7D0D0
	private void CollectEffectsInfo(string header, StringBuilder info, HashList<MonoEffect> list, ref bool collectedInfo, ref int particleSystemCount, ref int animationCount, ref int animatorCount, ref int tickPluginCount, ref int lateTickPluginCount, ref int allPluginCount) {} // 0x00000001852A28A0-0x00000001852A2AC0
	// [IDTag] // 0x0000000189A879E0-0x0000000189A87A20
	// [XID] // 0x0000000189A879E0-0x0000000189A87A20
	private void CollectEffectsInfo(string header, StringBuilder info, List<MonoEffect> list, ref bool collectedInfo, ref int particleSystemCount, ref int animationCount, ref int animatorCount, ref int tickPluginCount, ref int lateTickPluginCount, ref int allPluginCount) {} // 0x00000001852A2610-0x00000001852A28A0
	// [XID] // 0x0000000189A921A0-0x0000000189A921C0
	private void CollectEffectInfo(string header, StringBuilder info, MonoEffect effect, ref bool collectedInfo, ref int particleSystemCount, ref int animationCount, ref int animatorCount, ref int tickPluginCount, ref int lateTickPluginCount, ref int allPluginCount) {} // 0x00000001852A82D0-0x00000001852A8640
	// [XID] // 0x0000000189A99B40-0x0000000189A99B60
	private void CollectPreloadInfo(string header, StringBuilder info, Dictionary<BaseEntity, int> list) {} // 0x00000001852A3350-0x00000001852A3580
	// [XID] // 0x0000000189AA0B00-0x0000000189AA0B20
	public string DumpCSV() => default; // 0x00000001852A4910-0x00000001852A4F60
	// [XID] // 0x0000000189AA81E0-0x0000000189AA8200
	public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x00000001852A8E50-0x00000001852A9090
}

