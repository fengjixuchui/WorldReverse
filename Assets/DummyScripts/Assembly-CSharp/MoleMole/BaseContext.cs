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
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public abstract class BaseContext // TypeDefIndex: 28423
	{
		// Fields
		public ContextPattern config; // 0x10
		public UIType uiType; // 0x18
		public ContextQueueType queueType; // 0x1C
		public CanvasType canvasType; // 0x20
		protected ContextLoadState _loadState; // 0x24
		protected ContextViewState _viewState; // 0x28
		public int layerOrder; // 0x2C
		protected Queue<Notify> _notifyQueue; // 0x30
		protected Queue<Notify> _eternalNotifyQueue; // 0x38
		protected MonoUIProxy _monoProxy; // 0x48
		private List<UnityEventBase> _bindedEvents; // 0x58
		private List<MonoEventTrigger> _eventTriggers; // 0x60
		private List<Coroutine> _bindedCoroutines; // 0x68
		protected Coroutine _fadeOutCoroutine; // 0x70
		public Action<BaseContext> onLoadFinish; // 0x78
		public Action closeCallback; // 0x80
		public Action releaseCallback; // 0x88
		public Action fadeOutCallback; // 0x90
		protected bool _setViewAsLast; // 0x98
		protected bool _setViewAsFirst; // 0x99
		private List<BaseContextComponent> _baseComponentList; // 0xA0
		private List<BaseContextComponent> _tickComponentList; // 0xA8
		private Dictionary<int, List<BaseContextComponent>> _baseComponentNotifyRegister; // 0xB0
		private Dictionary<int, List<BaseContextComponent>> _baseComponentPacketRegister; // 0xB8
		private Dictionary<int, List<BaseContextComponent>> _baseComponentActionEventRegister; // 0xC0
		private uint _pageHandler; // 0xC8
		private bool _isIndependentLoaded; // 0xCC
		private const uint NOTIFY_REPORT_COUNT = 10; // Metadata: 0x00B0D7A3
		private HashSet<ushort> handlePacketSet; // 0xD0
		private ConfigBaseContext _jsonConfig; // 0xD8
		private int _stateID; // 0xE0
		private InputActionEvent[] _inputEvents; // 0xE8
		private bool _useCustomInputEvent; // 0xF0
		private List<InputActionEvent> _customeInputEvent; // 0xF8
		protected bool _enableJoypadVirtualCursor; // 0x100
		protected bool? _forceEnableJoypadVirtualCursor; // 0x101
		private bool _handledInputEvents; // 0x103
		protected InputMode _inputMode; // 0x104
		protected uint _keySettingID; // 0x108
		protected List<IJoypadController> _joypadControllerCache; // 0x110
		protected bool _needResolveJoypadController; // 0x118
		protected bool _needResolveKeyMouseController; // 0x119
		private Dictionary<string, IJoypadController> _name2JoypadController; // 0x120
		private PCCursorMode _pcCursorMode; // 0x128
		private bool _updateJoypadUIModule; // 0x12C
		private bool _contextClosed; // 0x12D
		private List<JoypadUIModulesList> _joypadUIModules; // 0x130
		private List<MonoJoypadUIModule> _modulesToBeAdd; // 0x138
		private List<MonoJoypadUIModule> _modulesToBeRemove; // 0x140
		private List<MonoJoypadUIModule> _joypadUIModuleCache; // 0x148
		private List<MonoJoypadNavRegionBase> _navRegionCache; // 0x150
		protected bool _changeClimateLen; // 0x158
		protected bool _showClimateLenEff; // 0x159
		protected bool _immedialteClimateLenEff; // 0x15A
		private SpriteLoadProxy _spriteLoadProxy; // 0x160
	
		// Properties
		public GameObject view { /* [XID] */ /* 0x0000000189B44470-0x0000000189B444B0 */ get; /* [XID] */ /* 0x0000000189B4EB60-0x0000000189B4EBA0 */ protected set; } // 0x0000000185289FB0-0x000000018528A010 0x000000018528A4D0-0x000000018528A600
		public UIMetaInfo metaInfo { /* [XID] */ /* 0x0000000189B594B0-0x0000000189B594F0 */ get; /* [XID] */ /* 0x0000000189B63B20-0x0000000189B63B60 */ protected set; } // 0x0000000185289C00-0x0000000185289C60 0x000000018528A2C0-0x000000018528A320
		public bool setViewAsLast { /* [XID] */ /* 0x0000000189B6DFA0-0x0000000189B6DFC0 */ get; } // 0x0000000185289DB0-0x0000000185289E60 
		public bool setViewAsFirst { /* [XID] */ /* 0x0000000189B75650-0x0000000189B75670 */ get; } // 0x0000000185289D00-0x0000000185289DB0 
		public bool Initialized { /* [XID] */ /* 0x00000001895EA610-0x00000001895EA630 */ get; } // 0x0000000185288EF0-0x0000000185288FA0 
		public bool IsLoading { /* [XID] */ /* 0x00000001895F1AD0-0x00000001895F1AF0 */ get; } // 0x00000001852891B0-0x0000000185289260 
		public bool IsLoaded { /* [XID] */ /* 0x00000001895F9490-0x00000001895F94B0 */ get; } // 0x0000000185289100-0x00000001852891B0 
		public bool IsUnLoading { /* [XID] */ /* 0x0000000189600AC0-0x0000000189600AE0 */ get; } // 0x0000000185289260-0x0000000185289310 
		public bool IsActive { /* [XID] */ /* 0x0000000189608440-0x0000000189608460 */ get; } // 0x0000000185288FA0-0x0000000185289050 
		public bool IsHiding { /* [XID] */ /* 0x000000018960FD40-0x000000018960FD60 */ get; } // 0x0000000185289050-0x0000000185289100 
		public string LoadStateName { /* [XID] */ /* 0x0000000189617020-0x0000000189617040 */ get; } // 0x0000000185289310-0x0000000185289410 
		protected bool UIResolutionChanged { get; /* [XID] */ /* 0x00000001896EF4B0-0x00000001896EF4F0 */ set; } // 0x0000000185289410-0x0000000185289470 0x000000018528A010-0x000000018528A080
		public bool landFromBack { /* [XID] */ /* 0x00000001897012B0-0x00000001897012F0 */ get; /* [XID] */ /* 0x000000018970BA20-0x000000018970BA60 */ set; } // 0x0000000185289B40-0x0000000185289BA0 0x000000018528A1E0-0x000000018528A250
		protected bool layoutVersionChanged { get; /* [XID] */ /* 0x0000000189724DF0-0x0000000189724E30 */ set; } // 0x0000000185289BA0-0x0000000185289C00 0x000000018528A250-0x000000018528A2C0
		protected int stateID { /* [XID] */ /* 0x0000000189A62920-0x0000000189A62940 */ get; /* [XID] */ /* 0x0000000189A6A6A0-0x0000000189A6A6C0 */ set; } // 0x0000000185289F10-0x0000000185289FB0 0x000000018528A3D0-0x000000018528A4D0
		public InputActionEvent[] inputEvents { /* [XID] */ /* 0x00000001898FEE00-0x00000001898FEE20 */ get; } // 0x0000000185289860-0x0000000185289930 
		public virtual bool enableInputPenetrate { /* [XID] */ /* 0x000000018973AE90-0x000000018973AEB0 */ get; } // 0x0000000185289520-0x00000001852895E0 
		public bool enableJoypadVirtualCursor { /* [XID] */ /* 0x000000018990DFA0-0x000000018990DFC0 */ get; } // 0x00000001852895E0-0x0000000185289700 
		public bool handledInputEvents { /* [XID] */ /* 0x0000000189B247B0-0x0000000189B247D0 */ get; /* [XID] */ /* 0x0000000189924A10-0x0000000189924A30 */ set; } // 0x0000000185289700-0x00000001852897B0 0x000000018528A080-0x000000018528A130
		public virtual InputMode inputMode { /* [XID] */ /* 0x000000018993B000-0x000000018993B020 */ get; /* [XID] */ /* 0x0000000189942150-0x0000000189942170 */ protected set; } // 0x0000000185289930-0x00000001852899E0 0x000000018528A130-0x000000018528A1E0
		public PCCursorMode pcCursorMode { /* [XID] */ /* 0x00000001899C0A10-0x00000001899C0A30 */ get; /* [XID] */ /* 0x00000001899C8220-0x00000001899C8240 */ protected set; } // 0x0000000185289C60-0x0000000185289D00 0x000000018528A320-0x000000018528A3D0
		public List<JoypadUIModulesList> joypadUIModules { /* [XID] */ /* 0x00000001899FDDB0-0x00000001899FDDD0 */ get; } // 0x0000000185289A90-0x0000000185289B40 
		public List<MonoJoypadUIModule> joypadUIModuleCaches { /* [XID] */ /* 0x0000000189A05790-0x0000000189A057B0 */ get; } // 0x00000001852899E0-0x0000000185289A90 
		public bool changeClimateLen { /* [XID] */ /* 0x000000018974A270-0x000000018974A290 */ get; } // 0x0000000185289470-0x0000000185289520 
		public bool showClimateLenEff { /* [XID] */ /* 0x0000000189AA2130-0x0000000189AA2150 */ get; } // 0x0000000185289E60-0x0000000185289F10 
		public bool immidateClimateLenEff { /* [XID] */ /* 0x0000000189AA9610-0x0000000189AA9630 */ get; } // 0x00000001852897B0-0x0000000185289860 
	
		// Nested types
		public struct JoypadUIModulesList // TypeDefIndex: 28424
		{
			// Fields
			public uint priority; // 0x00
			public List<MonoJoypadUIModule> uiModules; // 0x08
	
			// Constructors
			public JoypadUIModulesList(uint priority) {
				this.priority = default;
				uiModules = default;
			} // 0x0000000181AEC110-0x0000000181AEC140
			public JoypadUIModulesList(uint priority, MonoJoypadUIModule module) {
				this.priority = default;
				uiModules = default;
			} // 0x0000000181AEC070-0x0000000181AEC110
		}
	
		// Constructors
		public BaseContext() {} // 0x0000000185288C70-0x0000000185288EF0
	
		// Methods
		protected T AddContextComponent<T>(GameObject parent = null, bool enableMultiTimesAdd = false /* Metadata: 0x00B0D787 */)
			where T : BaseContextComponent, new() => default;
		protected T GetContextComponent<T>()
			where T : BaseContextComponent => default;
		protected void RemoveContextComponent<T>()
			where T : BaseContextComponent, new() {}
		// [XID] // 0x0000000189B7CAA0-0x0000000189B7CAC0
		private void UpdateViewComponents() {} // 0x0000000185288A90-0x0000000185288BD0
		// [XID] // 0x0000000189B84940-0x0000000189B84960
		private void OnEnableComponents() {} // 0x0000000185281AA0-0x0000000185281BE0
		// [XID] // 0x0000000189B8B790-0x0000000189B8B7B0
		private void OnDisableComponents() {} // 0x0000000185281820-0x0000000185281960
		// [XID] // 0x0000000189B92EC0-0x0000000189B92EE0
		private void BindViewCallbacksComponents() {} // 0x0000000185271DF0-0x0000000185271F30
		// [XID] // 0x0000000189B9A4E0-0x0000000189B9A500
		public void RegisterNotfiy(NotifyTypes type, BaseContextComponent com) {} // 0x0000000185283A60-0x0000000185283C60
		// [XID] // 0x0000000189BA1B90-0x0000000189BA1BB0
		public void UnregisterNotfiy(NotifyTypes type, BaseContextComponent com) {} // 0x00000001852885F0-0x0000000185288760
		// [XID] // 0x0000000189BA9050-0x0000000189BA9070
		private bool OnNotifyComponents(Notify ntf) => default; // 0x0000000185282700-0x00000001852828C0
		// [XID] // 0x0000000189BB0780-0x0000000189BB07A0
		public void RegisterPacket(int cmdid, BaseContextComponent com) {} // 0x0000000185283C60-0x0000000185283E60
		// [XID] // 0x00000001897AE550-0x00000001897AE570
		public void UnregisterPacket(int cmdid, BaseContextComponent com) {} // 0x0000000185288760-0x00000001852888D0
		// [XID] // 0x0000000189BBF120-0x0000000189BBF140
		private bool OnPacketComponents(Packet packet) => default; // 0x0000000185282990-0x0000000185282B60
		// [XID] // 0x0000000189BC6DF0-0x0000000189BC6E10
		public void RegisterActionEvent(InputEventType evt, BaseContextComponent com) {} // 0x00000001852836B0-0x00000001852838B0
		// [XID] // 0x00000001898B02E0-0x00000001898B0300
		public void UnregisterActionEvent(InputEventType evt, BaseContextComponent com) {} // 0x0000000185288380-0x00000001852884F0
		// [XID] // 0x0000000189BD5D80-0x0000000189BD5DA0
		private bool HandleInputActionEventComponents(InputActionEvent actionEvent) => default; // 0x000000018527DCA0-0x000000018527DE80
		// [XID] // 0x0000000189BDDA50-0x0000000189BDDA70
		private void ClearBaseComponents() {} // 0x0000000185272DF0-0x0000000185272FC0
		// [XID] // 0x000000018961EBA0-0x000000018961EBC0
		public virtual void Init() {} // 0x000000018527FD90-0x0000000185280190
		// [XID] // 0x00000001899ACF90-0x00000001899ACFB0
		public virtual void Destroy() {} // 0x0000000185273C30-0x0000000185273F10
		// [XID] // 0x000000018962D960-0x000000018962D980
		public virtual void DestroyForce() {} // 0x0000000185273930-0x0000000185273C30
		// [XID] // 0x00000001896354E0-0x0000000189635500
		public virtual bool Cached() => default; // 0x0000000185272210-0x00000001852722D0
		// [XID] // 0x000000018963CC00-0x000000018963CC20
		public virtual bool PopCached() => default; // 0x0000000185282D90-0x0000000185282EF0
		// [XID] // 0x0000000189644200-0x0000000189644220
		public void TrySkipFadingOut() {} // 0x0000000185287940-0x0000000185287A10
		// [XID] // 0x0000000189848BC0-0x0000000189848BE0
		public void ChangeContextState(ContextViewState targetLoadState) {} // 0x00000001852722D0-0x0000000185272430
		// [XID] // 0x0000000189653140-0x0000000189653160
		public virtual void SetActive(bool enabled) {} // 0x0000000185285400-0x0000000185285500
		// [XID] // 0x000000018965A800-0x000000018965A820
		public virtual void Hide() {} // 0x000000018527F6C0-0x000000018527F7B0
		// [XID] // 0x0000000189661E70-0x0000000189661E90
		public virtual void Close() {} // 0x00000001852735C0-0x0000000185273810
		// [XID] // 0x000000018982B820-0x000000018982B840
		protected virtual void InstantiateView() {} // 0x0000000185280190-0x00000001852802E0
		// [XID] // 0x00000001896715C0-0x00000001896715E0
		protected virtual void ReleaseView() {} // 0x0000000185284030-0x00000001852843D0
		// [XID] // 0x0000000189678E00-0x0000000189678E20
		protected void ReleaseMonoUIProxy() {} // 0x0000000185283E60-0x0000000185283F60
		// [XID] // 0x00000001896805D0-0x00000001896805F0
		public void Tick() {} // 0x0000000185287700-0x00000001852877E0
		// [XID] // 0x0000000189688030-0x0000000189688050
		public void LateTick() {} // 0x00000001852810B0-0x0000000185281180
		// [XID] // 0x00000001897AB040-0x00000001897AB060
		private UIMetaInfo GetUIContextMetaInfo(System.Type t, System.Type baseType) => default; // 0x000000018527D9D0-0x000000018527DB30
		// [XID] // 0x0000000189697450-0x0000000189697470
		protected virtual void OnLoadedView(GameObject instantiatedView) {} // 0x0000000185282160-0x00000001852825A0
		// [XID] // 0x000000018969E9A0-0x000000018969E9C0
		private bool CheckViewHasLoaded(GameObject instantiatedView) => default; // 0x0000000185272B90-0x0000000185272DF0
		// [XID] // 0x00000001896A59F0-0x00000001896A5A10
		private void Setup() {} // 0x0000000185286960-0x0000000185286DB0
		// [XID] // 0x00000001896AD230-0x00000001896AD250
		protected virtual void PostSetupView() {} // 0x00000001852832C0-0x0000000185283430
		// [XID] // 0x00000001896B4880-0x00000001896B48A0
		private void InitMonoProxy() {} // 0x000000018527FB70-0x000000018527FCC0
		// [XID] // 0x00000001896BBB10-0x00000001896BBB30
		protected virtual void FadeOut() {} // 0x0000000185274420-0x00000001852745D0
		// [XID] // 0x000000018984BEF0-0x000000018984BF10
		protected virtual void PostClose() {} // 0x0000000185282EF0-0x00000001852830B0
		// [XID] // 0x00000001896CA460-0x00000001896CA480
		protected void OnFadeOutFinish() {} // 0x0000000185281C80-0x0000000185281D80
		// [XID] // 0x00000001896D1AD0-0x00000001896D1AF0
		private void ForceStopFadeout() {} // 0x00000001852745D0-0x00000001852746C0
		// [XID] // 0x00000001896D9300-0x00000001896D9320
		private void HandleSetActiveEnabled(ContextViewState lastViewState) {} // 0x000000018527F0D0-0x000000018527F4B0
		// [XID] // 0x000000018998CE60-0x000000018998CE80
		private void HandleSetActiveDisabled() {} // 0x000000018527ED50-0x000000018527F0D0
		// [XID] // 0x0000000189BC7F30-0x0000000189BC7F50
		public virtual void SetUIResolutionChanged() {} // 0x0000000185285C90-0x0000000185285D90
		// [XID] // 0x0000000189715F30-0x0000000189715F50
		public void SetLandFromBack() {} // 0x0000000185285500-0x00000001852855E0
		// [XID] // 0x0000000189609600-0x0000000189609620
		public virtual void SetLayoutVersionChanged() {} // 0x00000001852855E0-0x00000001852856E0
		// [XID] // 0x0000000189A690A0-0x0000000189A690C0
		private void ClearOnEnableFlags() {} // 0x00000001852733C0-0x0000000185273520
		// [XID] // 0x00000001896AE270-0x00000001896AE290
		protected virtual void OnPostSetActive() {} // 0x0000000185282C10-0x0000000185282D90
		// [XID] // 0x00000001896A6B90-0x00000001896A6BB0
		protected virtual void PostProcessOfSetActive() {} // 0x00000001852830B0-0x0000000185283190
		// [XID] // 0x000000018974D8D0-0x000000018974D8F0
		protected virtual void ProcessNotifyQueueImpl(Queue<Notify> tarQueue) {} // 0x0000000185283430-0x00000001852836B0
		// [XID] // 0x0000000189754F10-0x0000000189754F30
		protected virtual void Unregister() {} // 0x00000001852888D0-0x0000000185288A90
		// [XID] // 0x000000018975C0A0-0x000000018975C0C0
		protected virtual void PostReleaseView() {} // 0x0000000185283190-0x00000001852832C0
		// [XID] // 0x0000000189763A70-0x0000000189763A90
		public virtual void SetupView() {} // 0x00000001852868C0-0x0000000185286960
		// [XID] // 0x000000018976B230-0x000000018976B250
		public virtual void UpdateView() {} // 0x0000000185288BD0-0x0000000185288C70
		// [XID] // 0x0000000189772880-0x00000001897728A0
		public virtual void LateUpdateView() {} // 0x0000000185281180-0x0000000185281220
		// [XID] // 0x0000000189779F70-0x0000000189779F90
		public virtual void ClearView() {} // 0x0000000185273520-0x00000001852735C0
		// [XID] // 0x0000000189781B10-0x0000000189781B30
		public virtual void OnDisconnect() {} // 0x0000000185281A00-0x0000000185281AA0
		// [XID] // 0x0000000189690CE0-0x0000000189690D00
		protected virtual void OnEnable() {} // 0x0000000185281BE0-0x0000000185281C80
		// [XID] // 0x0000000189790600-0x0000000189790620
		protected virtual void OnDisable() {} // 0x0000000185281960-0x0000000185281A00
		// [XID] // 0x0000000189797FF0-0x0000000189798010
		protected virtual void RegisterHandlePacket() {} // 0x00000001852838B0-0x0000000185283950
		// [XID] // 0x000000018979FD50-0x000000018979FD70
		protected virtual void ClearOnDestroy() {} // 0x0000000185273320-0x00000001852733C0
		// [XID] // 0x00000001897A72B0-0x00000001897A72D0
		protected bool DoHandleNotify(Notify cmd) => default; // 0x0000000185273F10-0x00000001852740A0
		// [XID] // 0x00000001897AECC0-0x00000001897AECE0
		private bool CheckCachePacket(Packet pkt) => default; // 0x0000000185272630-0x0000000185272840
		// [XID] // 0x00000001897B6AD0-0x00000001897B6AF0
		private void CheckCacheNotify(Notify cmd, bool canCache, bool isEternal) {} // 0x0000000185272430-0x0000000185272630
		// [XID] // 0x00000001897BE8F0-0x00000001897BE910
		private void CheckSameNotifyCount(Notify cmd) {} // 0x0000000185272920-0x0000000185272B90
		// [XID] // 0x0000000189BAFEA0-0x0000000189BAFEC0
		private bool CheckNotifyQueue() => default; // 0x0000000185272840-0x0000000185272920
		// [XID] // 0x00000001897CD860-0x00000001897CD880
		protected void AddHandlePacket(ushort cmdID) {} // 0x00000001852706B0-0x0000000185270780
		// [XID] // 0x00000001897D4D80-0x00000001897D4DA0
		public bool HandlePacket(Packet pkt, out bool hasCached) {
			hasCached = default;
			return default;
		} // 0x000000018527EBC0-0x000000018527ED50
		// [XID] // 0x0000000189B61980-0x0000000189B619A0
		public bool HandleNotify(Notify cmd, bool canCache = true /* Metadata: 0x00B0D788 */, bool isEternal = false /* Metadata: 0x00B0D789 */) => default; // 0x000000018527E9F0-0x000000018527EBC0
		// [XID] // 0x0000000189B78050-0x0000000189B78070
		public bool DoNotify(Notify ntf) => default; // 0x0000000185274220-0x0000000185274340
		// [XID] // 0x00000001897EBA20-0x00000001897EBA40
		public bool DoPacket(Packet packet) => default; // 0x0000000185274340-0x0000000185274420
		// [XID] // 0x00000001897F3360-0x00000001897F3380
		public virtual bool OnNotify(Notify ntf) => default; // 0x00000001852828C0-0x0000000185282990
		// [XID] // 0x00000001897FAB90-0x00000001897FABB0
		public virtual bool OnPacket(Packet packet) => default; // 0x0000000185282B60-0x0000000185282C10
		// [XID] // 0x0000000189802140-0x0000000189802160
		private void UnbindView() {} // 0x0000000185287FA0-0x0000000185288380
		// [XID] // 0x0000000189809610-0x0000000189809630
		protected virtual void BindViewCallbacks() {} // 0x0000000185271F30-0x0000000185271FD0
		// [IDTag] // 0x0000000189810E00-0x0000000189810E40
		// [XID] // 0x0000000189810E00-0x0000000189810E40
		public void BindViewCallback(Button button, UnityAction callback) {} // 0x00000001852713B0-0x00000001852715F0
		// [IDTag] // 0x000000018981B6D0-0x000000018981B710
		// [XID] // 0x000000018981B6D0-0x000000018981B710
		public void BindViewCallback(UIDButton button, UnityAction<uint> callback) {} // 0x0000000185270F70-0x00000001852711B0
		// [IDTag] // 0x0000000189825C10-0x0000000189825C50
		// [XID] // 0x0000000189825C10-0x0000000189825C50
		public void BindViewContainerButtonCallback(MonoUIContainer container, UnityAction<uint> callback) {} // 0x00000001852720F0-0x0000000185272210
		// [IDTag] // 0x0000000189830220-0x0000000189830260
		// [XID] // 0x0000000189830220-0x0000000189830260
		public void BindViewContainerButtonCallback(MonoUIContainer container, UnityAction callback) {} // 0x0000000185271FD0-0x00000001852720F0
		// [IDTag] // 0x000000018983A800-0x000000018983A840
		// [XID] // 0x000000018983A800-0x000000018983A840
		public void BindViewCallback(InputField inputfield, UnityAction<string> callback) {} // 0x00000001852715F0-0x0000000185271800
		// [IDTag] // 0x0000000189844F70-0x0000000189844FB0
		// [XID] // 0x0000000189844F70-0x0000000189844FB0
		public void BindViewCallback(Dropdown dropdown, UnityAction<int> callback) {} // 0x0000000185270D60-0x0000000185270F70
		// [IDTag] // 0x000000018984F3A0-0x000000018984F3E0
		// [XID] // 0x000000018984F3A0-0x000000018984F3E0
		public void BindViewCallback(Toggle toggle, UnityAction<bool> callback) {} // 0x00000001852711B0-0x00000001852713B0
		// [IDTag] // 0x0000000189859900-0x0000000189859940
		// [XID] // 0x0000000189859900-0x0000000189859940
		public void BindViewCallback(Slider slider, UnityAction<float> callback) {} // 0x0000000185271BE0-0x0000000185271DF0
		// [IDTag] // 0x0000000189863EE0-0x0000000189863F20
		// [XID] // 0x0000000189863EE0-0x0000000189863F20
		public void BindViewCallback(Transform trans, UnityEngine.EventSystems.EventTriggerType eventType, Action<BaseEventData> callback, bool clearTriggers = false /* Metadata: 0x00B0D78A */) {} // 0x0000000185271800-0x0000000185271AE0
		// [IDTag] // 0x000000018986E0B0-0x000000018986E0F0
		// [XID] // 0x000000018986E0B0-0x000000018986E0F0
		public void BindViewCallback(UnityEvent evt, UnityAction callback) {} // 0x0000000185271AE0-0x0000000185271BE0
		public void BindViewCallback<T0>(UnityEvent<T0> evt, UnityAction<T0> callback) {}
		// [IDTag] // 0x0000000189878640-0x0000000189878680
		// [XID] // 0x0000000189878640-0x0000000189878680
		public void UnbindViewCallback(Button button) {} // 0x0000000185287D50-0x0000000185287E80
		// [IDTag] // 0x0000000189882810-0x0000000189882850
		// [XID] // 0x0000000189882810-0x0000000189882850
		public void UnbindViewCallback(Dropdown dropdown) {} // 0x0000000185287AF0-0x0000000185287C20
		// [IDTag] // 0x000000018988CEC0-0x000000018988CF00
		// [XID] // 0x000000018988CEC0-0x000000018988CF00
		public void UnbindViewCallback(InputField input) {} // 0x0000000185287C20-0x0000000185287D50
		// [IDTag] // 0x0000000189897180-0x00000001898971C0
		// [XID] // 0x0000000189897180-0x00000001898971C0
		public void UnbindViewCallback(Toggle toggle) {} // 0x0000000185287E80-0x0000000185287FA0
		// [IDTag] // 0x00000001898A16B0-0x00000001898A16F0
		// [XID] // 0x00000001898A16B0-0x00000001898A16F0
		public void UnbindViewCallback(UnityEventBase evt) {} // 0x0000000185287A10-0x0000000185287AF0
		// [XID] // 0x00000001898ABDC0-0x00000001898ABDE0
		private void BindCoroutine(Coroutine coroutine) {} // 0x0000000185270A40-0x0000000185270B20
		// [XID] // 0x00000001898B3550-0x00000001898B3570
		public Coroutine StartCoroutine(IEnumerator routine) => default; // 0x0000000185286FE0-0x00000001852870F0
		// [XID] // 0x00000001898BB1B0-0x00000001898BB1D0
		public Coroutine Invoke(float duration, Action callback) => default; // 0x0000000185280640-0x0000000185280770
		// [XID] // 0x00000001898C25C0-0x00000001898C25E0
		public Coroutine InvokeAfterSplashScreen(float duration, Action callback) => default; // 0x0000000185280400-0x0000000185280530
		// [XID] // 0x00000001898C9FE0-0x00000001898CA000
		public Coroutine InvokeNextFrame(Action callback) => default; // 0x0000000185280530-0x0000000185280640
		// [XID] // 0x00000001898D16E0-0x00000001898D1700
		public Coroutine InvokeAfterFrames(int frames, Action callback) => default; // 0x00000001852802E0-0x0000000185280400
		// [XID] // 0x00000001898D8E60-0x00000001898D8E80
		public void StopCoroutine(Coroutine coroutine) {} // 0x00000001852870F0-0x0000000185287200
		// [XID] // 0x0000000189994BA0-0x0000000189994BC0
		protected virtual void BindRedPoints() {} // 0x0000000185270CC0-0x0000000185270D60
		// [XID] // 0x00000001898E86D0-0x00000001898E86F0
		public void BindRedPoint(Transform trans, uint redPointId, RedPointType type, uint parentId = 0 /* Metadata: 0x00B0D78B */) {} // 0x0000000185270B20-0x0000000185270CC0
		// [XID] // 0x0000000189915710-0x0000000189915730
		private InputActionEvent[] GetActionGrp(int stateID, InputDeviceType? hint = default) => default; // 0x0000000185274C60-0x0000000185274FD0
		// [XID] // 0x000000018992BFA0-0x000000018992BFC0
		public bool ContextHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000185273810-0x0000000185273930
		// [XID] // 0x0000000189933470-0x0000000189933490
		public virtual bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018527DE80-0x000000018527E220
		// [XID] // 0x0000000189733600-0x0000000189733620
		public virtual void ClearInputState() {} // 0x0000000185272FC0-0x0000000185273060
		// [XID] // 0x0000000189A5B0C0-0x0000000189A5B0E0
		public virtual void OnInputDeviceChanged() {} // 0x0000000185281D80-0x0000000185281E40
		// [XID] // 0x0000000189ABB8B0-0x0000000189ABB8D0
		protected void ResolveAllIcons() {} // 0x0000000185284580-0x0000000185284770
		// [XID] // 0x0000000189960230-0x0000000189960250
		public virtual void SwitchToCustomInputState(string[] customEvents, string[] customContextEvents, SimpleSafeInt32[] priorityList) {} // 0x00000001852872C0-0x0000000185287700
		// [XID] // 0x0000000189B6F100-0x0000000189B6F120
		public virtual void SwitchBackCustomInputState() {} // 0x0000000185287200-0x00000001852872C0
		// [XID] // 0x0000000189B2BCA0-0x0000000189B2BCC0
		protected void ResolveJoypadController(bool forceResolve = false /* Metadata: 0x00B0D78F */) {} // 0x0000000185285270-0x0000000185285400
		// [XID] // 0x0000000189976AD0-0x0000000189976AF0
		public void TryResolveGameObjectJoypadController(GameObject gameObject, bool forceResolve = false /* Metadata: 0x00B0D790 */) {} // 0x00000001852877E0-0x0000000185287940
		// [IDTag] // 0x000000018997DF10-0x000000018997DF50
		// [XID] // 0x000000018997DF10-0x000000018997DF50
		private void ResolveGameObjectJoypadControllers(bool forceResolve = false /* Metadata: 0x00B0D791 */) {} // 0x0000000185284AD0-0x0000000185284E70
		// [IDTag] // 0x0000000189988D80-0x0000000189988DC0
		// [XID] // 0x0000000189988D80-0x0000000189988DC0
		public void ResolveGameObjectJoypadControllers(GameObject gameObject, bool forceResolve = false /* Metadata: 0x00B0D792 */) {} // 0x0000000185284770-0x0000000185284AD0
		// [XID] // 0x00000001899939A0-0x00000001899939C0
		public void RemoveGameObjectJoypadController(IJoypadController controller) {} // 0x00000001852843D0-0x00000001852844A0
		// [XID] // 0x000000018999B2A0-0x000000018999B2C0
		public void ResolveGameObjectKeyMouse(bool forceResolve = false /* Metadata: 0x00B0D793 */) {} // 0x0000000185284E70-0x0000000185285270
		// [XID] // 0x00000001899A2AA0-0x00000001899A2AC0
		public void RegisterJoypadController(string name, IJoypadController controller) {} // 0x0000000185283950-0x0000000185283A60
		// [XID] // 0x00000001899AA3A0-0x00000001899AA3C0
		public void UnregisterJoypadController(string name) {} // 0x00000001852884F0-0x00000001852885F0
		// [XID] // 0x00000001899B1DF0-0x00000001899B1E10
		public bool DoJoypadControllerAction(string name, JoypadControllerActionType action, object param = null) => default; // 0x00000001852740A0-0x0000000185274220
		// [XID] // 0x00000001899B9170-0x00000001899B9190
		public bool HasJoypadController(string name) => default; // 0x000000018527F4B0-0x000000018527F6C0
		// [XID] // 0x00000001899CFC00-0x00000001899CFC20
		protected void SetupControlElementByKeyCode(MonoControlElement controlElement, KeyCode keyCode) {} // 0x0000000185285D90-0x0000000185285F70
		// [IDTag] // 0x00000001899D6FD0-0x00000001899D7010
		// [XID] // 0x00000001899D6FD0-0x00000001899D7010
		protected void SetupControllerIconByActionType(MonoUIContainer container, InputEventType inputEventType) {} // 0x00000001852864C0-0x00000001852866B0
		// [IDTag] // 0x00000001899E19F0-0x00000001899E1A30
		// [XID] // 0x00000001899E19F0-0x00000001899E1A30
		protected void SetupControllerIconByActionType(MonoUIContainer container, InputActionType actionType) {} // 0x0000000185285F70-0x0000000185286090
		// [IDTag] // 0x00000001899EBE60-0x00000001899EBEA0
		// [XID] // 0x00000001899EBE60-0x00000001899EBEA0
		protected void SetupControllerIconByActionType(MonoControlElement controlElement, InputActionType actionType) {} // 0x0000000185286090-0x00000001852864C0
		// [XID] // 0x0000000189A0AD70-0x0000000189A0AD90
		protected bool IsJoypadInput() => default; // 0x0000000185280770-0x0000000185280890
		// [XID] // 0x0000000189A0CA10-0x0000000189A0CA30
		private void InitJoypadUIModules() {} // 0x000000018527F7B0-0x000000018527FB70
		// [XID] // 0x0000000189A14360-0x0000000189A14380
		public void AddJoypadUIModuleToCache(MonoJoypadUIModule newModule) {} // 0x0000000185270780-0x0000000185270A40
		// [XID] // 0x0000000189A1B610-0x0000000189A1B630
		public void RemoveJoypadUIModuleToCache(MonoJoypadUIModule revModule) {} // 0x00000001852844A0-0x0000000185284580
		// [XID] // 0x0000000189A22F90-0x0000000189A22FB0
		protected void SetupJoypadUIModule() {} // 0x00000001852866B0-0x00000001852868C0
		// [XID] // 0x0000000189A2A220-0x0000000189A2A240
		protected void ClearJoypadUIModule() {} // 0x0000000185273060-0x0000000185273320
		// [XID] // 0x0000000189A31680-0x0000000189A316A0
		public void JoypadUIModuleFocus(MonoJoypadUIModule newModule) {} // 0x0000000185280C40-0x00000001852810B0
		// [XID] // 0x0000000189A39190-0x0000000189A391B0
		public void JoypadModuleLostFocus(MonoJoypadUIModule revModule) {} // 0x0000000185280890-0x0000000185280C40
		// [XID] // 0x0000000189A40950-0x0000000189A40970
		protected void HandleJoypadUIModuleRegister() {} // 0x000000018527E3F0-0x000000018527E9F0
		// [XID] // 0x0000000189A47F90-0x0000000189A47FB0
		public uint GetUIModulePriority() => default; // 0x000000018527DB30-0x000000018527DCA0
		// [XID] // 0x0000000189A4F790-0x0000000189A4F7B0
		protected bool HandleJoypadUIModuleInput(InputActionEvent inputEvent) => default; // 0x000000018527E220-0x000000018527E3F0
		// [XID] // 0x0000000189A56E70-0x0000000189A56E90
		protected void SetRegionFocus(string regionName, bool focus) {} // 0x00000001852856E0-0x00000001852859A0
		// [XID] // 0x0000000189A5E9E0-0x0000000189A5EA00
		protected void SetUIModuleFocusByName(string moduleName, bool focus) {} // 0x00000001852859A0-0x0000000185285C90
		// [XID] // 0x0000000189A66160-0x0000000189A66180
		public void SimulateJoypadUIModuleEnable(bool enable) {} // 0x0000000185286DB0-0x0000000185286FE0
		// [XID] // 0x0000000189A6D830-0x0000000189A6D850
		public virtual void OnNavRegionFocus(MonoJoypadNavRegionBase focusRegoin) {} // 0x00000001852825A0-0x0000000185282650
		// [XID] // 0x0000000189A74F50-0x0000000189A74F70
		public virtual void OnNavRegionLostFocus(MonoJoypadNavRegionBase focusRegion) {} // 0x0000000185282650-0x0000000185282700
		// [XID] // 0x0000000189A7CB80-0x0000000189A7CBA0
		public virtual void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x0000000185281F20-0x0000000185281FD0
		// [XID] // 0x0000000189A844C0-0x0000000189A844E0
		public virtual void OnJoypadUIModuleLostFocus(MonoJoypadUIModule focusModule) {} // 0x0000000185281FD0-0x0000000185282080
		// [XID] // 0x0000000189A8BDF0-0x0000000189A8BE10
		public virtual void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0D794 */) {} // 0x0000000185282080-0x0000000185282160
		// [XID] // 0x0000000189A93340-0x0000000189A93360
		public virtual void OnJoypadUIModuleDeSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0D798 */) {} // 0x0000000185281E40-0x0000000185281F20
		// [XID] // 0x0000000189AB14D0-0x0000000189AB14F0
		protected void InitSpriteHandlers() {} // 0x000000018527FCC0-0x000000018527FD90
		// [XID] // 0x0000000189816800-0x0000000189816820
		protected void ReleaseSpriteHandlers() {} // 0x0000000185283F60-0x0000000185284030
		// [IDTag] // 0x0000000189AC0450-0x0000000189AC0490
		// [XID] // 0x0000000189AC0450-0x0000000189AC0490
		public Sprite LoadSprite(ulong path) => default; // 0x0000000185281670-0x0000000185281740
		// [IDTag] // 0x0000000189ACAE50-0x0000000189ACAE90
		// [XID] // 0x0000000189ACAE50-0x0000000189ACAE90
		public Sprite LoadSprite(string name, string path) => default; // 0x0000000185281740-0x0000000185281820
		// [XID] // 0x0000000189AD5C00-0x0000000189AD5C20
		public Sprite GetAchievementIcon(string iconName) => default; // 0x00000001852748C0-0x0000000185274990
		// [XID] // 0x0000000189ADD5D0-0x0000000189ADD5F0
		public Sprite GetAchievementSmallIcon(string iconName) => default; // 0x0000000185274B90-0x0000000185274C60
		// [XID] // 0x0000000189AE4D30-0x0000000189AE4D50
		public Sprite GetItemSprite(string iconName) => default; // 0x00000001852797E0-0x00000001852798B0
		// [XID] // 0x0000000189AEC410-0x0000000189AEC430
		public Sprite GetSmallItemIconSprite(string iconName) => default; // 0x000000018527CAF0-0x000000018527CBC0
		// [IDTag] // 0x0000000189AF3E50-0x0000000189AF3E90
		// [XID] // 0x0000000189AF3E50-0x0000000189AF3E90
		public Sprite GetMonsterItemSprite(string iconName) => default; // 0x000000018527AA40-0x000000018527AB10
		// [XID] // 0x0000000189AFE4A0-0x0000000189AFE4C0
		public Sprite GetItemImageSprite(string iconName) => default; // 0x00000001852793D0-0x00000001852794A0
		// [XID] // 0x0000000189B05BD0-0x0000000189B05BF0
		public Sprite GetAvatarSprite(string iconName) => default; // 0x0000000185275780-0x0000000185275850
		// [XID] // 0x0000000189B0D3E0-0x0000000189B0D400
		public Sprite GetSkillIcon(string iconName) => default; // 0x000000018527C820-0x000000018527C8F0
		// [XID] // 0x0000000189B148C0-0x0000000189B148E0
		public Sprite GetGachaIcon(string iconName) => default; // 0x0000000185277E10-0x0000000185277EE0
		// [XID] // 0x0000000189B1C200-0x0000000189B1C220
		public Sprite GetElementBuffIcon(string iconName) => default; // 0x00000001852770D0-0x00000001852771A0
		// [XID] // 0x0000000189B23890-0x0000000189B238B0
		public Sprite GetMapMarkIcon(string iconName) => default; // 0x000000018527A060-0x000000018527A130
		// [XID] // 0x0000000189B2AB30-0x0000000189B2AB50
		public Sprite GetItemtipsBgSprite(QualityType qualityType) => default; // 0x0000000185279AB0-0x0000000185279B80
		// [XID] // 0x0000000189B32060-0x0000000189B32080
		public Sprite GetPendantIconSprite(ElementType elemType) => default; // 0x000000018527B770-0x000000018527B840
		// [XID] // 0x0000000189B398A0-0x0000000189B398C0
		public Sprite GetInteeIconSprite(string iconName) => default; // 0x0000000185278E30-0x0000000185278F00
		// [XID] // 0x0000000189B41250-0x0000000189B41270
		public Sprite GetBagTabIconSprite(string iconName) => default; // 0x0000000185275A50-0x0000000185275B20
		// [XID] // 0x0000000189B48AC0-0x0000000189B48AE0
		public Sprite GetReadPicSprite(string iconName) => default; // 0x000000018527C2B0-0x000000018527C380
		// [XID] // 0x0000000189B50290-0x0000000189B502B0
		public Sprite GetTutorialImageSprite(string iconName) => default; // 0x000000018527D900-0x000000018527D9D0
		// [XID] // 0x0000000189B57A80-0x0000000189B57AA0
		public Sprite GetTalentIconSprite(string iconName) => default; // 0x000000018527D090-0x000000018527D160
		// [XID] // 0x0000000189B5F430-0x0000000189B5F450
		public Sprite GetInputKeyIconSprite(string iconName) => default; // 0x0000000185278B60-0x0000000185278C30
		// [XID] // 0x0000000189B669E0-0x0000000189B66A00
		public Sprite GetGoddessUnlockIcon(string iconName) => default; // 0x00000001852783B0-0x0000000185278480
		// [XID] // 0x0000000189B6DF80-0x0000000189B6DFA0
		public Sprite GetNpcTopIcon(string iconName) => default; // 0x000000018527B4A0-0x000000018527B570
		// [XID] // 0x0000000189B75630-0x0000000189B75650
		public Sprite GetPlayerIcon(bool isMale) => default; // 0x000000018527BA40-0x000000018527BB10
		// [XID] // 0x0000000189B7CA80-0x0000000189B7CAA0
		public Sprite GetButtonIcon(string iconName) => default; // 0x00000001852760F0-0x00000001852761C0
		// [XID] // 0x0000000189B84920-0x0000000189B84940
		public Sprite GetTerrainSprite(string iconName) => default; // 0x000000018527D360-0x000000018527D430
		// [XID] // 0x0000000189B8B770-0x0000000189B8B790
		public Sprite GetDungeonTypeSprite(string iconName) => default; // 0x0000000185276DF0-0x0000000185276EC0
		// [XID] // 0x0000000189B92EA0-0x0000000189B92EC0
		public Sprite GetExploreBgSprite(string iconName) => default; // 0x0000000185277870-0x0000000185277940
		// [IDTag] // 0x0000000189B9A4A0-0x0000000189B9A4E0
		// [XID] // 0x0000000189B9A4A0-0x0000000189B9A4E0
		public Sprite GetMonsterItemSprite(string iconName, bool smallIcon = false /* Metadata: 0x00B0D79C */) => default; // 0x000000018527AB10-0x000000018527AC00
		// [XID] // 0x0000000189BA4C70-0x0000000189BA4C90
		public Sprite GetActivityBgSprite(string iconName) => default; // 0x00000001852751D0-0x00000001852752A0
		// [XID] // 0x0000000189BABF90-0x0000000189BABFB0
		public Sprite GetLoadingBgSprite(string iconName) => default; // 0x0000000185279D80-0x0000000185279E50
		// [XID] // 0x0000000189BB3640-0x0000000189BB3660
		public Sprite GetFriendTabIconSprite(string iconName) => default; // 0x0000000185277B40-0x0000000185277C10
		// [XID] // 0x0000000189BBAC60-0x0000000189BBAC80
		public Sprite GetInvestigationImage(string iconName) => default; // 0x0000000185279100-0x00000001852791D0
		// [XID] // 0x0000000189BC2C30-0x0000000189BC2C50
		public Sprite GetMessagePushIcon(string iconName) => default; // 0x000000018527A530-0x000000018527A600
		// [XID] // 0x0000000189BCA340-0x0000000189BCA360
		public Sprite GetTowerFloorItemImage(string iconName) => default; // 0x000000018527D630-0x000000018527D700
		// [XID] // 0x0000000189BD19D0-0x0000000189BD19F0
		public Sprite GetSystemOpenUIIconSprite(string iconName) => default; // 0x000000018527CDC0-0x000000018527CE90
		// [XID] // 0x0000000189BD8FC0-0x0000000189BD8FE0
		public Sprite GetDungeonEntryImage(string iconName) => default; // 0x0000000185276850-0x0000000185276920
		// [XID] // 0x00000001895E5B40-0x00000001895E5B60
		public Sprite GetBattlePassPreviewImage(string iconName) => default; // 0x0000000185275D20-0x0000000185275DF0
		// [XID] // 0x00000001895ED4B0-0x00000001895ED4D0
		public Sprite GetElementIcon(string iconName) => default; // 0x00000001852773A0-0x0000000185277470
		// [XID] // 0x00000001895F4B90-0x00000001895F4BB0
		public Sprite GetHomeworldTabIcon(string iconName) => default; // 0x0000000185278890-0x0000000185278960
		// [XID] // 0x00000001895FC2E0-0x00000001895FC300
		public Sprite GetHomeworldItemIcon(string iconName) => default; // 0x0000000185278550-0x0000000185278620
		// [XID] // 0x0000000189603CA0-0x0000000189603CC0
		public Sprite GetHomeworldSuiteItemIcon(string iconName) => default; // 0x00000001852787C0-0x0000000185278890
		// [XID] // 0x000000018960B5E0-0x000000018960B600
		public Sprite GetHomeworldAnimalItemIcon(string iconName) => default; // 0x0000000185278480-0x0000000185278550
		// [XID] // 0x0000000189612A10-0x0000000189612A30
		public Sprite GetHomeworldModuleSprite(string spriteName) => default; // 0x00000001852786F0-0x00000001852787C0
		// [XID] // 0x000000018961A340-0x000000018961A360
		public Sprite GetHomeworldModulePic(string picName) => default; // 0x0000000185278620-0x00000001852786F0
		// [XID] // 0x00000001896218D0-0x00000001896218F0
		public Sprite GetNameCardPic(string iconName) => default; // 0x000000018527AE20-0x000000018527AEF0
		// [XID] // 0x0000000189629160-0x0000000189629180
		public Sprite GetGachaSlotImg(string iconName) => default; // 0x00000001852780E0-0x00000001852781B0
		// [XID] // 0x0000000189630B00-0x0000000189630B20
		public Sprite GetNetStateImg(string iconName) => default; // 0x000000018527B0F0-0x000000018527B1C0
		// [XID] // 0x00000001896385E0-0x0000000189638600
		public Sprite GetPropertyIconSprite(string iconName) => default; // 0x000000018527BD10-0x000000018527BDE0
		// [XID] // 0x000000018963F9C0-0x000000018963F9E0
		public Sprite GetDungeonTypeSpriteByDungeonType(DungeonType dungeonType) => default; // 0x0000000185276D20-0x0000000185276DF0
		// [XID] // 0x00000001896471E0-0x0000000189647200
		public Sprite GetChapterIconSprite(string iconName) => default; // 0x00000001852763C0-0x0000000185276490
		// [XID] // 0x000000018964E890-0x000000018964E8B0
		public Sprite GetQuestTabIconSprite(string iconName) => default; // 0x000000018527BFE0-0x000000018527C0B0
		// [IDTag] // 0x00000001896560C0-0x0000000189656100
		// [XID] // 0x00000001896560C0-0x0000000189656100
		public AsyncJob LoadSpriteAsync(string name, string path, Action<Sprite> onResult) => default; // 0x0000000185281440-0x0000000185281580
		// [IDTag] // 0x0000000189660720-0x0000000189660760
		// [XID] // 0x0000000189660720-0x0000000189660760
		public AsyncJob LoadSpriteAsync(ulong path, Action<Sprite> onResult) => default; // 0x0000000185281220-0x0000000185281340
		// [IDTag] // 0x000000018966B130-0x000000018966B170
		// [XID] // 0x000000018966B130-0x000000018966B170
		public void LoadSpriteAsync(string name, string path, Image image) {} // 0x0000000185281340-0x0000000185281440
		// [IDTag] // 0x0000000189675C20-0x0000000189675C60
		// [XID] // 0x0000000189675C20-0x0000000189675C60
		public void LoadSpriteAsync(ulong path, Image image) {} // 0x0000000185281580-0x0000000185281670
		// [IDTag] // 0x0000000189680590-0x00000001896805D0
		// [XID] // 0x0000000189680590-0x00000001896805D0
		public AsyncJob GetPropertyIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527BBF0-0x000000018527BD10
		// [IDTag] // 0x000000018968AEA0-0x000000018968AEE0
		// [XID] // 0x000000018968AEA0-0x000000018968AEE0
		public AsyncJob GetMonsterItemSpriteAsync(string iconName, Action<Sprite> onResult, bool smallIcon = false /* Metadata: 0x00B0D79D */) => default; // 0x000000018527A600-0x000000018527A740
		// [IDTag] // 0x00000001896959A0-0x00000001896959E0
		// [XID] // 0x00000001896959A0-0x00000001896959E0
		public AsyncJob GetActivityBgSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001852750B0-0x00000001852751D0
		// [IDTag] // 0x000000018969FF50-0x000000018969FF90
		// [XID] // 0x000000018969FF50-0x000000018969FF90
		public AsyncJob GetLoadingBgSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185279B80-0x0000000185279CA0
		// [IDTag] // 0x00000001896AA300-0x00000001896AA340
		// [XID] // 0x00000001896AA300-0x00000001896AA340
		public AsyncJob GetFriendTabIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185277A20-0x0000000185277B40
		// [IDTag] // 0x00000001896B4840-0x00000001896B4880
		// [XID] // 0x00000001896B4840-0x00000001896B4880
		public AsyncJob GetInvestigationImageAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185278F00-0x0000000185279020
		// [IDTag] // 0x00000001896BE700-0x00000001896BE740
		// [XID] // 0x00000001896BE700-0x00000001896BE740
		public AsyncJob GetMessagePushIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527A410-0x000000018527A530
		// [IDTag] // 0x00000001896C8B90-0x00000001896C8BD0
		// [XID] // 0x00000001896C8B90-0x00000001896C8BD0
		public AsyncJob GetTowerFloorItemImageAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527D510-0x000000018527D630
		// [IDTag] // 0x00000001896D2FD0-0x00000001896D3010
		// [XID] // 0x00000001896D2FD0-0x00000001896D3010
		public AsyncJob GetSystemOpenUIIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527CCA0-0x000000018527CDC0
		// [IDTag] // 0x00000001896DDA10-0x00000001896DDA50
		// [XID] // 0x00000001896DDA10-0x00000001896DDA50
		public AsyncJob GetDungeonEntryImageAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185276650-0x0000000185276770
		// [IDTag] // 0x00000001896E7D80-0x00000001896E7DC0
		// [XID] // 0x00000001896E7D80-0x00000001896E7DC0
		public AsyncJob GetBattlePassPreviewImageAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185275C00-0x0000000185275D20
		// [IDTag] // 0x00000001896F2080-0x00000001896F20C0
		// [XID] // 0x00000001896F2080-0x00000001896F20C0
		public AsyncJob GetElementIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185277280-0x00000001852773A0
		// [IDTag] // 0x00000001896FCCB0-0x00000001896FCCF0
		// [XID] // 0x00000001896FCCB0-0x00000001896FCCF0
		public AsyncJob GetNameCardPicAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527AC00-0x000000018527AD20
		// [IDTag] // 0x00000001897072B0-0x00000001897072F0
		// [XID] // 0x00000001897072B0-0x00000001897072F0
		public AsyncJob GetGachaSlotImgAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185277EE0-0x0000000185278000
		// [IDTag] // 0x0000000189711E70-0x0000000189711EB0
		// [XID] // 0x0000000189711E70-0x0000000189711EB0
		public AsyncJob GetNetStateImgAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527AFD0-0x000000018527B0F0
		// [IDTag] // 0x000000018971C290-0x000000018971C2D0
		// [XID] // 0x000000018971C290-0x000000018971C2D0
		public AsyncJob GetAchievementIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001852746C0-0x00000001852747E0
		// [IDTag] // 0x0000000189726750-0x0000000189726790
		// [XID] // 0x0000000189726750-0x0000000189726790
		public AsyncJob GetAchievementSmallIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185274A70-0x0000000185274B90
		// [IDTag] // 0x0000000189730D20-0x0000000189730D60
		// [XID] // 0x0000000189730D20-0x0000000189730D60
		public AsyncJob GetItemSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001852796C0-0x00000001852797E0
		// [IDTag] // 0x000000018973B3E0-0x000000018973B420
		// [XID] // 0x000000018973B3E0-0x000000018973B420
		public AsyncJob GetItemSpriteAsync(ItemConfig itemConfig, Action<Sprite> onResult) => default; // 0x00000001852795A0-0x00000001852796C0
		// [IDTag] // 0x0000000189745E20-0x0000000189745E60
		// [XID] // 0x0000000189745E20-0x0000000189745E60
		public AsyncJob GetMonsterItemSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527A740-0x000000018527A860
		// [IDTag] // 0x0000000189750630-0x0000000189750670
		// [XID] // 0x0000000189750630-0x0000000189750670
		public AsyncJob GetItemImageSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001852791D0-0x00000001852792F0
		// [IDTag] // 0x000000018975A7F0-0x000000018975A830
		// [XID] // 0x000000018975A7F0-0x000000018975A830
		public AsyncJob GetAvatarSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185275580-0x00000001852756A0
		// [IDTag] // 0x0000000189764FF0-0x0000000189765030
		// [XID] // 0x0000000189764FF0-0x0000000189765030
		public AsyncJob GetSkillIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527C620-0x000000018527C740
		// [IDTag] // 0x000000018976F6C0-0x000000018976F700
		// [XID] // 0x000000018976F6C0-0x000000018976F700
		public AsyncJob GetGachaIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185277CF0-0x0000000185277E10
		// [IDTag] // 0x0000000189779F30-0x0000000189779F70
		// [XID] // 0x0000000189779F30-0x0000000189779F70
		public AsyncJob GetElementBuffIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185276FB0-0x00000001852770D0
		// [IDTag] // 0x0000000189784A30-0x0000000189784A70
		// [XID] // 0x0000000189784A30-0x0000000189784A70
		public AsyncJob GetMapMarkIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185279E50-0x0000000185279F70
		// [IDTag] // 0x000000018978EDB0-0x000000018978EDF0
		// [XID] // 0x000000018978EDB0-0x000000018978EDF0
		public AsyncJob GetItemtipsBgSpriteAsync(QualityType qualityType, Action<Sprite> onResult) => default; // 0x0000000185279990-0x0000000185279AB0
		// [IDTag] // 0x0000000189799410-0x0000000189799450
		// [XID] // 0x0000000189799410-0x0000000189799450
		public AsyncJob GetPendantIconSpriteAsync(ElementType elemType, Action<Sprite> onResult) => default; // 0x000000018527B570-0x000000018527B690
		// [IDTag] // 0x00000001897A4240-0x00000001897A4280
		// [XID] // 0x00000001897A4240-0x00000001897A4280
		public AsyncJob GetInteeIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185278D10-0x0000000185278E30
		// [IDTag] // 0x00000001897AEC80-0x00000001897AECC0
		// [XID] // 0x00000001897AEC80-0x00000001897AECC0
		public AsyncJob GetBagTabIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185275930-0x0000000185275A50
		// [IDTag] // 0x00000001897B9510-0x00000001897B9550
		// [XID] // 0x00000001897B9510-0x00000001897B9550
		public AsyncJob GetQuestTabIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527BDE0-0x000000018527BF00
		// [IDTag] // 0x00000001897C4400-0x00000001897C4440
		// [XID] // 0x00000001897C4400-0x00000001897C4440
		public AsyncJob GetReadPicSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527C0B0-0x000000018527C1D0
		// [IDTag] // 0x00000001897CECE0-0x00000001897CED20
		// [XID] // 0x00000001897CECE0-0x00000001897CED20
		public AsyncJob GetTutorialImageSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527D7E0-0x000000018527D900
		// [IDTag] // 0x00000001897D9A70-0x00000001897D9AB0
		// [XID] // 0x00000001897D9A70-0x00000001897D9AB0
		public AsyncJob GetTalentIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527CE90-0x000000018527CFB0
		// [IDTag] // 0x00000001897E3ED0-0x00000001897E3F10
		// [XID] // 0x00000001897E3ED0-0x00000001897E3F10
		public AsyncJob GetInputKeyIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185278A40-0x0000000185278B60
		// [IDTag] // 0x00000001897EE910-0x00000001897EE950
		// [XID] // 0x00000001897EE910-0x00000001897EE950
		public AsyncJob GetGoddessUnlockIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001852781B0-0x00000001852782D0
		// [IDTag] // 0x00000001897F9320-0x00000001897F9360
		// [XID] // 0x00000001897F9320-0x00000001897F9360
		public AsyncJob GetNpcTopIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527B2A0-0x000000018527B3C0
		// [IDTag] // 0x0000000189803910-0x0000000189803950
		// [XID] // 0x0000000189803910-0x0000000189803950
		public AsyncJob GetPlayerIconAsync(bool isMale, Action<Sprite> onResult) => default; // 0x000000018527B920-0x000000018527BA40
		// [IDTag] // 0x000000018980DE30-0x000000018980DE70
		// [XID] // 0x000000018980DE30-0x000000018980DE70
		public AsyncJob GetButtonIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185275FD0-0x00000001852760F0
		// [IDTag] // 0x00000001898188B0-0x00000001898188F0
		// [XID] // 0x00000001898188B0-0x00000001898188F0
		public AsyncJob GetDungeonTypeSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185276920-0x0000000185276A40
		// [IDTag] // 0x0000000189822CC0-0x0000000189822D00
		// [XID] // 0x0000000189822CC0-0x0000000189822D00
		public AsyncJob GetDungeonTypeSpriteByDungeonTypeAsync(DungeonType dungeonType, Action<Sprite> onResult) => default; // 0x0000000185276B20-0x0000000185276C40
		// [IDTag] // 0x000000018982D360-0x000000018982D3A0
		// [XID] // 0x000000018982D360-0x000000018982D3A0
		public AsyncJob GetEventIconAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185277470-0x0000000185277590
		// [IDTag] // 0x00000001898379E0-0x0000000189837A20
		// [XID] // 0x00000001898379E0-0x0000000189837A20
		public AsyncJob GetChapterIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x00000001852762A0-0x00000001852763C0
		// [IDTag] // 0x0000000189841E80-0x0000000189841EC0
		// [XID] // 0x0000000189841E80-0x0000000189841EC0
		public AsyncJob GetTerrainSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527D160-0x000000018527D280
		// [IDTag] // 0x000000018984C460-0x000000018984C4A0
		// [XID] // 0x000000018984C460-0x000000018984C4A0
		public AsyncJob GetExploreBgSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185277670-0x0000000185277790
		// [IDTag] // 0x0000000189856520-0x0000000189856560
		// [XID] // 0x0000000189856520-0x0000000189856560
		public AsyncJob GetSmallItemIconSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x000000018527C9D0-0x000000018527CAF0
		// [XID] // 0x0000000189860A80-0x0000000189860AA0
		public AsyncJob GetActivityBuffSpriteAsync(string iconName, Action<Sprite> onResult) => default; // 0x0000000185275380-0x00000001852754A0
		// [IDTag] // 0x0000000189868170-0x00000001898681B0
		// [XID] // 0x0000000189868170-0x00000001898681B0
		public void GetPropertyIconSpriteAsync(string iconName, Image image) {} // 0x000000018527BB10-0x000000018527BBF0
		// [IDTag] // 0x00000001898725A0-0x00000001898725E0
		// [XID] // 0x00000001898725A0-0x00000001898725E0
		public void GetMonsterItemSpriteAsync(string iconName, Image image, bool smallIcon = false /* Metadata: 0x00B0D79E */) {} // 0x000000018527A860-0x000000018527A960
		// [XID] // 0x000000018987D010-0x000000018987D030
		public void GetBlossomItemSpriteAsync(string iconName, Image image, bool smallIcon = false /* Metadata: 0x00B0D79F */) {} // 0x0000000185275DF0-0x0000000185275EF0
		// [IDTag] // 0x0000000189883FD0-0x0000000189884010
		// [XID] // 0x0000000189883FD0-0x0000000189884010
		public void GetActivityBgSpriteAsync(string iconName, Image image) {} // 0x0000000185274FD0-0x00000001852750B0
		// [IDTag] // 0x000000018988E2F0-0x000000018988E330
		// [XID] // 0x000000018988E2F0-0x000000018988E330
		public void GetLoadingBgSpriteAsync(string iconName, Image image) {} // 0x0000000185279CA0-0x0000000185279D80
		// [IDTag] // 0x0000000189898B10-0x0000000189898B50
		// [XID] // 0x0000000189898B10-0x0000000189898B50
		public void GetFriendTabIconSpriteAsync(string iconName, Image image) {} // 0x0000000185277940-0x0000000185277A20
		// [IDTag] // 0x00000001898A3030-0x00000001898A3070
		// [XID] // 0x00000001898A3030-0x00000001898A3070
		public void GetInvestigationImageAsync(string iconName, Image image) {} // 0x0000000185279020-0x0000000185279100
		// [IDTag] // 0x00000001898AD850-0x00000001898AD890
		// [XID] // 0x00000001898AD850-0x00000001898AD890
		public void GetMessagePushIconAsync(string iconName, Image image) {} // 0x000000018527A330-0x000000018527A410
		// [IDTag] // 0x00000001898B7EF0-0x00000001898B7F30
		// [XID] // 0x00000001898B7EF0-0x00000001898B7F30
		public void GetTowerFloorItemImageAsync(string iconName, Image image) {} // 0x000000018527D430-0x000000018527D510
		// [IDTag] // 0x00000001898C2580-0x00000001898C25C0
		// [XID] // 0x00000001898C2580-0x00000001898C25C0
		public void GetSystemOpenUIIconSpriteAsync(string iconName, Image image) {} // 0x000000018527CBC0-0x000000018527CCA0
		// [IDTag] // 0x00000001898CCBE0-0x00000001898CCC20
		// [XID] // 0x00000001898CCBE0-0x00000001898CCC20
		public void GetDungeonEntryImageAsync(string iconName, Image image) {} // 0x0000000185276770-0x0000000185276850
		// [IDTag] // 0x00000001898D7830-0x00000001898D7870
		// [XID] // 0x00000001898D7830-0x00000001898D7870
		public void GetBattlePassPreviewImageAsync(string iconName, Image image) {} // 0x0000000185275B20-0x0000000185275C00
		// [IDTag] // 0x00000001898E23F0-0x00000001898E2430
		// [XID] // 0x00000001898E23F0-0x00000001898E2430
		public void GetElementIconAsync(string iconName, Image image) {} // 0x00000001852771A0-0x0000000185277280
		// [IDTag] // 0x00000001898ECBA0-0x00000001898ECBE0
		// [XID] // 0x00000001898ECBA0-0x00000001898ECBE0
		public void GetNameCardPicAsync(string iconName, Image image, bool hideWhileLoading = false /* Metadata: 0x00B0D7A0 */) {} // 0x000000018527AD20-0x000000018527AE20
		// [IDTag] // 0x00000001898F76B0-0x00000001898F76F0
		// [XID] // 0x00000001898F76B0-0x00000001898F76F0
		public void GetGachaSlotImgAsync(string iconName, Image image) {} // 0x0000000185278000-0x00000001852780E0
		// [IDTag] // 0x0000000189901EA0-0x0000000189901EE0
		// [XID] // 0x0000000189901EA0-0x0000000189901EE0
		public void GetNetStateImgAsync(string iconName, Image image) {} // 0x000000018527AEF0-0x000000018527AFD0
		// [IDTag] // 0x000000018990C7E0-0x000000018990C820
		// [XID] // 0x000000018990C7E0-0x000000018990C820
		public void GetAchievementIconAsync(string iconName, Image image) {} // 0x00000001852747E0-0x00000001852748C0
		// [IDTag] // 0x0000000189917270-0x00000001899172B0
		// [XID] // 0x0000000189917270-0x00000001899172B0
		public void GetAchievementSmallIconAsync(string iconName, Image image) {} // 0x0000000185274990-0x0000000185274A70
		// [IDTag] // 0x0000000189921AA0-0x0000000189921AE0
		// [XID] // 0x0000000189921AA0-0x0000000189921AE0
		public void GetItemSpriteAsync(string iconName, Image image, bool hideWhileLoading = false /* Metadata: 0x00B0D7A1 */) {} // 0x00000001852794A0-0x00000001852795A0
		// [IDTag] // 0x000000018992BF60-0x000000018992BFA0
		// [XID] // 0x000000018992BF60-0x000000018992BFA0
		public void GetMonsterItemSpriteAsync(string iconName, Image image) {} // 0x000000018527A960-0x000000018527AA40
		// [XID] // 0x00000001899363B0-0x00000001899363D0
		public void GetAnimalItemSpriteAsync(string iconName, Image image) {} // 0x00000001852754A0-0x0000000185275580
		// [IDTag] // 0x000000018993DD90-0x000000018993DDD0
		// [XID] // 0x000000018993DD90-0x000000018993DDD0
		public void GetItemImageSpriteAsync(string iconName, Image image) {} // 0x00000001852792F0-0x00000001852793D0
		// [XID] // 0x0000000189948410-0x0000000189948430
		public void GetRomanNumImageSpriteAsync(string iconName, Image image) {} // 0x000000018527C540-0x000000018527C620
		// [IDTag] // 0x000000018994FAF0-0x000000018994FB30
		// [XID] // 0x000000018994FAF0-0x000000018994FB30
		public void GetAvatarSpriteAsync(string iconName, Image image) {} // 0x00000001852756A0-0x0000000185275780
		// [IDTag] // 0x000000018995A2F0-0x000000018995A330
		// [XID] // 0x000000018995A2F0-0x000000018995A330
		public void GetSkillIconAsync(string iconName, Image image) {} // 0x000000018527C740-0x000000018527C820
		// [IDTag] // 0x0000000189964BE0-0x0000000189964C20
		// [XID] // 0x0000000189964BE0-0x0000000189964C20
		public void GetGachaIconAsync(string iconName, Image image) {} // 0x0000000185277C10-0x0000000185277CF0
		// [IDTag] // 0x000000018996EEF0-0x000000018996EF30
		// [XID] // 0x000000018996EEF0-0x000000018996EF30
		public void GetElementBuffIconAsync(string iconName, Image image) {} // 0x0000000185276EC0-0x0000000185276FB0
		// [IDTag] // 0x0000000189979DE0-0x0000000189979E20
		// [XID] // 0x0000000189979DE0-0x0000000189979E20
		public void GetMapMarkIconAsync(string iconName, Image image) {} // 0x0000000185279F70-0x000000018527A060
		// [IDTag] // 0x00000001899842A0-0x00000001899842E0
		// [XID] // 0x00000001899842A0-0x00000001899842E0
		public void GetItemtipsBgSpriteAsync(QualityType qualityType, Image image) {} // 0x00000001852798B0-0x0000000185279990
		// [IDTag] // 0x000000018998ED50-0x000000018998ED90
		// [XID] // 0x000000018998ED50-0x000000018998ED90
		public void GetPendantIconSpriteAsync(ElementType elemType, Image image) {} // 0x000000018527B690-0x000000018527B770
		// [IDTag] // 0x0000000189999BF0-0x0000000189999C30
		// [XID] // 0x0000000189999BF0-0x0000000189999C30
		public void GetInteeIconSpriteAsync(string iconName, Image image) {} // 0x0000000185278C30-0x0000000185278D10
		// [IDTag] // 0x00000001899A4460-0x00000001899A44A0
		// [XID] // 0x00000001899A4460-0x00000001899A44A0
		public void GetBagTabIconSpriteAsync(string iconName, Image image) {} // 0x0000000185275850-0x0000000185275930
		// [IDTag] // 0x00000001899AED80-0x00000001899AEDC0
		// [XID] // 0x00000001899AED80-0x00000001899AEDC0
		public void GetQuestTabIconSpriteAsync(string iconName, Image image) {} // 0x000000018527BF00-0x000000018527BFE0
		// [IDTag] // 0x00000001899B9130-0x00000001899B9170
		// [XID] // 0x00000001899B9130-0x00000001899B9170
		public void GetReadPicSpriteAsync(string iconName, Image image) {} // 0x000000018527C1D0-0x000000018527C2B0
		// [IDTag] // 0x00000001899C3D50-0x00000001899C3D90
		// [XID] // 0x00000001899C3D50-0x00000001899C3D90
		public void GetTutorialImageSpriteAsync(string iconName, Image image) {} // 0x000000018527D700-0x000000018527D7E0
		// [XID] // 0x00000001899CE2C0-0x00000001899CE2E0
		public void GetCodexViewImageSpriteAsync(string iconName, Image image) {} // 0x0000000185276490-0x0000000185276570
		// [XID] // 0x00000001899D5A80-0x00000001899D5AA0
		public void GetCodexViewPicSpriteAsync(string iconName, Image image) {} // 0x0000000185276570-0x0000000185276650
		// [IDTag] // 0x00000001899DCE10-0x00000001899DCE50
		// [XID] // 0x00000001899DCE10-0x00000001899DCE50
		public void GetTalentIconSpriteAsync(string iconName, Image image) {} // 0x000000018527CFB0-0x000000018527D090
		// [IDTag] // 0x00000001899E79A0-0x00000001899E79E0
		// [XID] // 0x00000001899E79A0-0x00000001899E79E0
		public void GetInputKeyIconSpriteAsync(string iconName, Image image) {} // 0x0000000185278960-0x0000000185278A40
		// [IDTag] // 0x00000001899F2100-0x00000001899F2140
		// [XID] // 0x00000001899F2100-0x00000001899F2140
		public void GetGoddessUnlockIconAsync(string iconName, Image image) {} // 0x00000001852782D0-0x00000001852783B0
		// [IDTag] // 0x00000001899FC730-0x00000001899FC770
		// [XID] // 0x00000001899FC730-0x00000001899FC770
		public void GetNpcTopIconAsync(string iconName, Image image) {} // 0x000000018527B3C0-0x000000018527B4A0
		// [IDTag] // 0x0000000189A06DD0-0x0000000189A06E10
		// [XID] // 0x0000000189A06DD0-0x0000000189A06E10
		public void GetPlayerIconAsync(bool isMale, Image image) {} // 0x000000018527B840-0x000000018527B920
		// [IDTag] // 0x0000000189A113F0-0x0000000189A11430
		// [XID] // 0x0000000189A113F0-0x0000000189A11430
		public void GetButtonIconAsync(string iconName, Image image) {} // 0x0000000185275EF0-0x0000000185275FD0
		// [IDTag] // 0x0000000189A1B5D0-0x0000000189A1B610
		// [XID] // 0x0000000189A1B5D0-0x0000000189A1B610
		public void GetDungeonTypeSpriteAsync(string iconName, Image image) {} // 0x0000000185276A40-0x0000000185276B20
		// [IDTag] // 0x0000000189A25D00-0x0000000189A25D40
		// [XID] // 0x0000000189A25D00-0x0000000189A25D40
		public void GetDungeonTypeSpriteByDungeonTypeAsync(DungeonType dungeonType, Image image) {} // 0x0000000185276C40-0x0000000185276D20
		// [IDTag] // 0x0000000189A30070-0x0000000189A300B0
		// [XID] // 0x0000000189A30070-0x0000000189A300B0
		public void GetEventIconAsync(string iconName, Image image) {} // 0x0000000185277590-0x0000000185277670
		// [IDTag] // 0x0000000189A3A7F0-0x0000000189A3A830
		// [XID] // 0x0000000189A3A7F0-0x0000000189A3A830
		public void GetChapterIconSpriteAsync(string iconName, Image image) {} // 0x00000001852761C0-0x00000001852762A0
		// [IDTag] // 0x0000000189A45040-0x0000000189A45080
		// [XID] // 0x0000000189A45040-0x0000000189A45080
		public void GetTerrainSpriteAsync(string iconName, Image image) {} // 0x000000018527D280-0x000000018527D360
		// [IDTag] // 0x0000000189A4F750-0x0000000189A4F790
		// [XID] // 0x0000000189A4F750-0x0000000189A4F790
		public void GetExploreBgSpriteAsync(string iconName, Image image) {} // 0x0000000185277790-0x0000000185277870
		// [IDTag] // 0x0000000189A5A020-0x0000000189A5A060
		// [XID] // 0x0000000189A5A020-0x0000000189A5A060
		public void GetSmallItemIconSpriteAsync(string iconName, Image image) {} // 0x000000018527C8F0-0x000000018527C9D0
		// [XID] // 0x0000000189A649F0-0x0000000189A64A10
		public void GetActivityBuffIconSpriteAsync(string iconName, Image image) {} // 0x00000001852752A0-0x0000000185275380
		// [XID] // 0x0000000189A6C1D0-0x0000000189A6C1F0
		public void GetReputationPicSpriteAsync(string iconName, Image image) {} // 0x000000018527C460-0x000000018527C540
		// [XID] // 0x0000000189A73980-0x0000000189A739A0
		public void GetReputationBgSpriteAsync(string iconName, Image image) {} // 0x000000018527C380-0x000000018527C460
		// [XID] // 0x0000000189A7B4C0-0x0000000189A7B4E0
		public void GetNpcIconSpriteAsync(string iconName, Image image) {} // 0x000000018527B1C0-0x000000018527B2A0
		// [XID] // 0x0000000189A82B80-0x0000000189A82BA0
		public void GetMechanicusMapSpriteAsync(string iconName, Image image, bool smallIcon) {} // 0x000000018527A230-0x000000018527A330
		// [XID] // 0x0000000189A8A590-0x0000000189A8A5B0
		public void GetMechanicusCardIconSpriteAsync(string iconName, Image image, bool hideWhileLoading = false /* Metadata: 0x00B0D7A2 */) {} // 0x000000018527A130-0x000000018527A230
	}
}
