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
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCBaseModel : VCBase // TypeDefIndex: 11819
{
	// Fields
	public bool useInstancedMaterialGroups; // 0x108
	protected Renderer[] _renderers; // 0x110
	protected MotionVectorGenerationMode[] _renderersInitialMVmode; // 0x118
	protected bool _hasResetMVMode; // 0x120
	private Bounds _rendersBound; // 0x124
	protected ShaderLerpPlugin _shaderLerpPlugin; // 0x140
	protected MaterialGroup _instancedMaterialGroup; // 0x148
	protected MaterialGroup _defaultGroup; // 0x150
	protected bool _haveInitialShadowCubeSize; // 0x158
	protected float _shadowCubeSize; // 0x15C
	protected Dictionary<string, uint> _changedRendererNames; // 0x160
	public Action<bool> setChildrenVisibleCB; // 0x168
	protected Dictionary<string, AttachCache> _attachDic; // 0x170
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private bool _isVisible; // 0x178
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private SimpleFixedBitStack _allIsVisiable; // 0x180
	private SimpleFixedBitStack[] _rendererVisiable; // 0x188
	private EntityRendererChangedInfo _renderInfoChangeAuthority; // 0x190
	private int _attachEffectIndex; // 0x198
	private Dictionary<int, bool> _cachedAttachEffectBoolParams; // 0x1A0
	private Dictionary<int, int> _cachedAttachEffectIntParams; // 0x1A8
	private int _hideShadowbilitCount; // 0x1B0
	private Dictionary<string, SequenceBakeData> _emotionDataCache; // 0x1B8
	private Dictionary<string, uint> _emotionHandlerCache; // 0x1C0
	private Dictionary<ulong, string> _emotionPathCache; // 0x1C8
	private int _emotionCacheCnt; // 0x1D0
	protected bool _hasAoMesh; // 0x1D4
	protected bool _forceHideAoMesh; // 0x1D5
	private float _defaultLodTransitionTime; // 0x1D8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B360D0-0x0000000189B360F0 */ get => default; } // 0x00000001837623A0-0x0000000183762440 
	public ShaderLerpPlugin shaderLerpPlugin { /* [XID] */ /* 0x00000001897C8940-0x00000001897C8960 */ get => default; } // 0x0000000183758290-0x0000000183758340 
	public EntityRendererChangedInfo renderInfoChangeAuthority { /* [XID] */ /* 0x0000000189791610-0x0000000189791630 */ get => default; /* [XID] */ /* 0x000000018968D3F0-0x000000018968D410 */ set {} } // 0x0000000183761550-0x0000000183761600 0x000000018375FFE0-0x00000001837600E0
	public bool IsCastShadow { /* [XID] */ /* 0x0000000189716D50-0x0000000189716D70 */ get => default; } // 0x000000018375BF60-0x000000018375C010 
	public bool forceHideAoMesh { /* [XID] */ /* 0x0000000189B6C110-0x0000000189B6C130 */ get => default; /* [XID] */ /* 0x00000001897ACAA0-0x00000001897ACAC0 */ set {} } // 0x000000018375D320-0x000000018375D3D0 0x000000018375E500-0x000000018375E5C0

	// Nested types
	public class AttachCache // TypeDefIndex: 11820
	{
		// Fields
		public GameObject go; // 0x10
		public uint handler; // 0x18
		public bool isSpawned; // 0x1C
		public bool isSpawning; // 0x1D

		// Constructors
		public AttachCache() {} // 0x00000001837721A0-0x0000000183772200
	}

	// Constructors
	public VCBaseModel() {} // 0x0000000183762280-0x00000001837623A0

	// Methods
	// [XID] // 0x0000000189B45620-0x0000000189B45640
	public override void PreInit() {} // 0x0000000183761870-0x0000000183761950
	// [XID] // 0x0000000189BA7330-0x0000000189BA7350
	public override void Init() {} // 0x000000018375BA50-0x000000018375BF60
	// [XID] // 0x0000000189BAE440-0x0000000189BAE460
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183761950-0x0000000183762280
	// [XID] // 0x00000001895ECDA0-0x00000001895ECDC0
	public override void Destroy() {} // 0x00000001837598E0-0x0000000183759A70
	// [XID] // 0x0000000189BBD350-0x0000000189BBD370
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001837591C0-0x0000000183759330
	// [XID] // 0x000000018960C440-0x000000018960C460
	public override void OnEnable() {} // 0x0000000183760FD0-0x0000000183761090
	// [XID] // 0x0000000189BCCA80-0x0000000189BCCAA0
	public override void OnDisable() {} // 0x0000000183760F10-0x0000000183760FD0
	// [XID] // 0x0000000189BD4130-0x0000000189BD4150
	public override void OnEntityReady() {} // 0x0000000183761090-0x0000000183761550
	// [XID] // 0x0000000189BDBA50-0x0000000189BDBA70
	protected static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x000000018375A800-0x000000018375A8E0
	// [XID] // 0x00000001895E8310-0x00000001895E8330
	protected override bool ListenEvent(BaseEvent e) => default; // 0x000000018375E180-0x000000018375E270
	// [XID] // 0x00000001895EFC00-0x00000001895EFC20
	private void ClearEvent() {} // 0x000000018375E270-0x000000018375E360
	// [XID] // 0x0000000189BBA420-0x0000000189BBA440
	private void InitEvent() {} // 0x0000000183758A90-0x0000000183758B80
	// [XID] // 0x00000001895FE950-0x00000001895FE970
	private bool CheckAndTryCreateRenderers() => default; // 0x000000018375F130-0x000000018375FE10
	// [XID] // 0x0000000189901950-0x0000000189901970
	public void SetAllFloat(int nameID, float value) {} // 0x000000018375B390-0x000000018375B680
	// [XID] // 0x000000018960DB50-0x000000018960DB70
	public void SetAllColor(int nameID, Color value) {} // 0x000000018375DD40-0x000000018375DF60
	// [XID] // 0x0000000189615330-0x0000000189615350
	public void SetAllTexture(int nameID, Texture value, ref Texture[] lastTextures, bool forceMatBlock = false /* Metadata: 0x00AEAC43 */) {} // 0x000000018375EA40-0x000000018375EDF0
	// [XID] // 0x000000018961CA80-0x000000018961CAA0
	public void ClearVectorProperty(int nameId) {} // 0x000000018375AAD0-0x000000018375ACC0
	// [XID] // 0x0000000189623FA0-0x0000000189623FC0
	public void ClearColorProperty(int nameId) {} // 0x000000018375A8E0-0x000000018375AAD0
	// [XID] // 0x000000018962B710-0x000000018962B730
	public void SetAllVectorArray(int nameID, Vector4[] values) {} // 0x0000000183758FA0-0x00000001837591C0
	// [XID] // 0x0000000189632F30-0x0000000189632F50
	public void SetAllVector(int nameID, Vector4 value) {} // 0x000000018375CF50-0x000000018375D170
	// [XID] // 0x00000001896A9C30-0x00000001896A9C50
	public Renderer[] GetRenderers() => default; // 0x0000000183761700-0x00000001837617B0
	// [XID] // 0x0000000189642150-0x0000000189642170
	public Renderer GetRendereByName(string name, out int index) {
		index = default;
		return default;
	} // 0x000000018375C1C0-0x000000018375C490
	// [XID] // 0x00000001896B8630-0x00000001896B8650
	public void SetRenderersEnableFromServer(uint visibleCount, Dictionary<string, uint> rendererList, bool isCached) {} // 0x0000000183759330-0x00000001837596A0
	// [XID] // 0x00000001896BF720-0x00000001896BF740
	private uint FilterSyncStack(uint baseStack, uint input) => default; // 0x00000001837606D0-0x00000001837607A0
	// [XID] // 0x0000000189AFC540-0x0000000189AFC560
	public bool IsVisible() => default; // 0x00000001837581E0-0x0000000183758290
	// [XID] // 0x0000000189764920-0x0000000189764940
	public void SetRenderersEnable(string[] names, bool enable, int reason) {} // 0x0000000183760390-0x00000001837606D0
	// [XID] // 0x00000001896678C0-0x00000001896678E0
	public void SetVisibleCount(bool visible, int reason) {} // 0x000000018375A350-0x000000018375A4C0
	// [XID] // 0x000000018966F0C0-0x000000018966F0E0
	protected virtual bool CheckVisible() => default; // 0x00000001837617B0-0x0000000183761870
	// [XID] // 0x0000000189B49E80-0x0000000189B49EA0
	protected virtual void UpdateVisible(bool isForce = false /* Metadata: 0x00AEAC44 */) {} // 0x0000000183761600-0x0000000183761700
	// [XID] // 0x000000018967E2C0-0x000000018967E2E0
	private void RefreshVisible() {} // 0x000000018375EDF0-0x000000018375F130
	// [XID] // 0x0000000189695000-0x0000000189695020
	public void ChangeAuthority() {} // 0x000000018375CB90-0x000000018375CCF0
	// [XID] // 0x0000000189805DF0-0x0000000189805E10
	public Bounds GetAllRendersBoundingBox() => default; // 0x000000018375C740-0x000000018375CA70
	// [XID] // 0x0000000189B0E5B0-0x0000000189B0E5D0
	public void SetShaderData(E_ShaderData dataType, bool bEnable, bool recoverOriginalShader = false /* Metadata: 0x00AEAC45 */, float enableDurationTime = -0.1f /* Metadata: 0x00AEAC46 */, float disableDurationTime = -0.1f /* Metadata: 0x00AEAC4A */) {} // 0x000000018375C490-0x000000018375C740
	// [XID] // 0x00000001896AB060-0x00000001896AB080
	public void RecoverOriginalShaders() {} // 0x0000000183759D20-0x0000000183759DD0
	// [IDTag] // 0x00000001896B2150-0x00000001896B2190
	// [XID] // 0x00000001896B2150-0x00000001896B2190
	public void StartShaderPlus(E_ShaderPlus plusType, Renderer[] renderers, BodyMaterialType? bodyType, Color? color, float? param1, float? param2, ElementType? element) {} // 0x0000000183759F50-0x000000018375A100
	// [IDTag] // 0x00000001896BC940-0x00000001896BC980
	// [XID] // 0x00000001896BC940-0x00000001896BC980
	public void StartShaderPlus(E_ShaderPlus plusType, BodyMaterialType? bodyType, Color? color, float? param1, float? param2, ElementType? element) {} // 0x0000000183759DD0-0x0000000183759F50
	// [IDTag] // 0x00000001896C6FD0-0x00000001896C7010
	// [XID] // 0x00000001896C6FD0-0x00000001896C7010
	public void StopShaderPlus(E_ShaderPlus plusType, Renderer[] renderers) {} // 0x000000018375E360-0x000000018375E440
	// [IDTag] // 0x0000000189870590-0x00000001898705D0
	// [XID] // 0x0000000189870590-0x00000001898705D0
	public void StopShaderPlus(E_ShaderPlus plusType) {} // 0x000000018375E440-0x000000018375E500
	// [XID] // 0x0000000189B956A0-0x0000000189B956C0
	public void RefreshDefaultMaterialGroup() {} // 0x000000018375D6E0-0x000000018375D820
	// [XID] // 0x00000001896E3100-0x00000001896E3120
	protected virtual void SetupGraphic() {} // 0x000000018375A5C0-0x000000018375A800
	// [XID] // 0x00000001896EA6A0-0x00000001896EA6C0
	public void TryCacheAttachEffectAnimatorParams(string effectName, SendEffectTrigger config) {} // 0x0000000183760920-0x0000000183760CA0
	// [XID] // 0x00000001896F1690-0x00000001896F16B0
	private void ClearAttachEffect(BaseEntity.ClearReason clearReason) {} // 0x000000018375E970-0x000000018375EA40
	// [XID] // 0x00000001896F9060-0x00000001896F9080
	private void AttachAttachEffect() {} // 0x000000018375D820-0x000000018375DD40
	private void CopyDic<T1, T2>(Dictionary<T1, T2> source, Dictionary<T1, T2> target) {}
	// [XID] // 0x0000000189603500-0x0000000189603520
	private void DetachAttachEffect() {} // 0x000000018375CCF0-0x000000018375CE60
	// [XID] // 0x00000001897080E0-0x0000000189708100
	private bool HandleEvtStageReady(EvtStageReady evtStageReady) => default; // 0x000000018375B980-0x000000018375BA50
	// [XID] // 0x000000018970FB70-0x000000018970FB90
	public void SetEffectVisible(bool enable) {} // 0x00000001837583A0-0x00000001837584C0
	// [XID] // 0x000000018971E780-0x000000018971E7A0
	public void SetCastShadow(bool enable) {} // 0x000000018375CE60-0x000000018375CF50
	// [XID] // 0x0000000189725F20-0x0000000189725F40
	private void SetCastShadowConfirm(bool enable) {} // 0x000000018375E630-0x000000018375E970
	// [XID] // 0x000000018972D490-0x000000018972D4B0
	public bool IsInScreen() => default; // 0x0000000183758B80-0x0000000183758DD0
	// [XID] // 0x0000000189734B50-0x0000000189734B70
	public MaterialGroup GetInstancedMaterialGroup() => default; // 0x000000018375D630-0x000000018375D6E0
	// [XID] // 0x000000018973C760-0x000000018973C780
	public MaterialGroup.RendererMaterials GetInstedMatGrpEntryByRendererName(string rendererName) => default; // 0x00000001837596A0-0x0000000183759880
	// [XID] // 0x00000001895EB6F0-0x00000001895EB710
	public void SetMotionVectorMode(MotionVectorGenerationMode mode) {} // 0x0000000183760150-0x0000000183760390
	// [XID] // 0x0000000189910560-0x0000000189910580
	public void ResetMotionVectorMode() {} // 0x0000000183760CA0-0x0000000183760F10
	// [XID] // 0x0000000189BC2400-0x0000000189BC2420
	public void SetPerObjectShadowGroupID(uint groupID) {} // 0x000000018375D490-0x000000018375D630
	// [XID] // 0x0000000189759F60-0x0000000189759F80
	public float GetShadowCubeSize() => default; // 0x000000018375CA70-0x000000018375CB90
	// [XID] // 0x0000000189761CE0-0x0000000189761D00
	private void OnRendererVisibleChanged() {} // 0x00000001837607A0-0x0000000183760920
	// [XID] // 0x0000000189769090-0x00000001897690B0
	public void SpawnAttach(string attachName) {} // 0x0000000183758530-0x00000001837588F0
	// [XID] // 0x0000000189B67D50-0x0000000189B67D70
	protected void SpawnAttachInternal(GameObject go, Transform slotTrans) {} // 0x000000018375A4C0-0x000000018375A5C0
	// [XID] // 0x0000000189777F50-0x0000000189777F70
	public void UnspawnAttach(string attachName) {} // 0x00000001837588F0-0x0000000183758A90
	// [XID] // 0x0000000189B83FE0-0x0000000189B84000
	public SequenceBakeData GetSequenceData(string path) => default; // 0x000000018375D1D0-0x000000018375D2C0
	// [XID] // 0x0000000189786EC0-0x0000000189786EE0
	public void LoadEmotionData(ConfigEntity cfg) {} // 0x000000018375AFC0-0x000000018375B390
	// [XID] // 0x000000018978E540-0x000000018978E560
	private void EmotionLoadHandler(ulong hash, bool loadSucceeded, uint handle, SequenceBakeData asset) {} // 0x000000018375C010-0x000000018375C1C0
	// [XID] // 0x0000000189795C20-0x0000000189795C40
	private void CheckEmotionLoadFinish() {} // 0x000000018375D3D0-0x000000018375D490
	// [XID] // 0x00000001896301D0-0x00000001896301F0
	public void ClearEmotionData() {} // 0x000000018375DF60-0x000000018375E180
	// [IDTag] // 0x00000001897B4800-0x00000001897B4840
	// [XID] // 0x00000001897B4800-0x00000001897B4840
	protected void UpdateAOMesh() {} // 0x000000018375B680-0x000000018375B770
	// [IDTag] // 0x00000001897BF8A0-0x00000001897BF8E0
	// [XID] // 0x00000001897BF8A0-0x00000001897BF8E0
	protected void UpdateAOMesh(int ix) {} // 0x000000018375B770-0x000000018375B980
	// [XID] // 0x00000001897C9C00-0x00000001897C9C20
	protected virtual void InitAOMesh() {} // 0x000000018375AD30-0x000000018375AFC0
	// [XID] // 0x000000018986F140-0x000000018986F160
	public void SetLodTransitionTime(float lodTransitionTime) {} // 0x000000018375A1E0-0x000000018375A350
	// [XID] // 0x00000001897D92B0-0x00000001897D92D0
	public void SetDefaultLodTransitionTime() {} // 0x000000018375FE70-0x000000018375FFE0
	// [XID] // 0x00000001897E05A0-0x00000001897E05C0
	public override string Dump() => default; // 0x0000000183759A70-0x0000000183759D20
}

