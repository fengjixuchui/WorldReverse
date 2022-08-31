/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using MihoyoOptimization;
using UnityEngine;
using UnityEngine.Scripting;
using Debug = UnityEngine.Debug;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
    [TickWithFrameDeltaTime] // 0x0000000189B43A80-0x0000000189B43A90
    public class BaseComponent : ITickBalanceObject, ITokenBudgetComponent // TypeDefIndex: 11642
    {
        // Fields
        [NonSerialized]
        [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
        public uint componentRuntimeID; // 0x10
        [NonSerialized]
        public uint entityRuntimeID; // 0x14
        public bool preTick; // 0x18
        public int order; // 0x1C
        [NonSerialized]
        private ComponentManager _componentManager; // 0x20
        [NonSerialized]
        protected BaseEntity _entity; // 0x28
        [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
        protected bool _isToBeRemoved; // 0x30
        protected bool _enabled; // 0x31
        [NonSerialized]
        [NotSerialized] // 0x00000001899854C0-0x00000001899854F0
        [ShowInInspector] // 0x00000001899854C0-0x00000001899854F0
        public bool hasTick; // 0x32
        [NonSerialized]
        [NotSerialized] // 0x000000018999AFD0-0x000000018999B000
        [ShowInInspector] // 0x000000018999AFD0-0x000000018999B000
        public bool hasLateTick; // 0x33
        protected bool _selfHasTick; // 0x34
        protected bool _selfHasLateTick; // 0x35
        protected bool _managerTick; // 0x36
        protected bool _managerLateTick; // 0x37
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public List<EventID> onEventIDs; // 0x38
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public List<EventID> listenEventIDs; // 0x40
        private EventID[] _selfOnEventIDsCache; // 0x48
        private bool _isSelfOnEventIDsCached; // 0x50
        private EventID[] _selfListenEventIDsCache; // 0x58
        private bool _isSelfListenEventIDsCached; // 0x60
        [NonSerialized]
        public Action preInitCallback; // 0x68
        [NonSerialized]
        public Action initCallback; // 0x70
        private bool _canTickIfDisable; // 0x78
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public bool canTickIfDie; // 0x79
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public bool canHandleEventIfDie; // 0x7A
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public bool canExistMulti; // 0x7B
        private bool _hasEnabledInited; // 0x7C
        protected int _tickIntervalRatio = 1; // 0x80
        private int _lastTickInterval; // 0x84
        private Action<float> _tickMethodForEntityTickManager; // 0x88
        private bool? _isTickableForEntityTickManager; // 0x90
        private Action<float> _lateTickMethodForEntityTickManager; // 0x98
        private bool? _isLateTickableForEntityTickManager; // 0xA0
        [NonSerialized]
        public bool needRetarget; // 0xA2
        [NonSerialized]
        public bool isInited; // 0xA3
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public bool isPreInited; // 0xA4
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public bool hasCallEntityReady; // 0xA5
        [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
        protected bool _isDestroied; // 0xA6
        private static IList<BaseComponentPlugin> EMPTY_PLUGINLIST = default; // 0x00
        protected Dictionary<System.Type, BaseComponentPlugin> _pluginMap; // 0xA8
        [InspectorCollapsedFoldout] // 0x0000000189879680-0x00000001898796B0
        [ShowInInspector] // 0x0000000189879680-0x00000001898796B0
        protected List<BaseComponentPlugin> _pluginList; // 0xB0
        private List<BaseComponentPlugin> _tickPlugins; // 0xB8
        private List<BaseComponentPlugin> _lateTickPlugins; // 0xC0
        private Dictionary<System.Type, int> _disableNoTickPlugins; // 0xC8
        private Dictionary<System.Type, int> _disableNoLateTickPlugins; // 0xD0
        private Dictionary<EventID, BaseComponentPlugin> _onEventPluginMap; // 0xD8
        private Dictionary<EventID, List<BaseComponentPlugin>> _onEventPluginsMap; // 0xE0
        private Dictionary<EventID, BaseComponentPlugin> _listenEventPluginMap; // 0xE8
        private Dictionary<EventID, List<BaseComponentPlugin>> _listenEventPluginsMap; // 0xF0
        private static ScopeCycleCounter? addComponentScopeCounter; // 0x08
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        protected CycleStat _cycleStat; // 0x100

        // Properties
        public bool selfHasTick { /* [XID] */ /* 0x000000018989F4E0-0x000000018989F500 */ get => _selfHasTick; } // 0x000000018526FB10-0x000000018526FBB0 
        public bool selfHasLateTick { /* [XID] */ /* 0x00000001898A70A0-0x00000001898A70C0 */ get => _selfHasLateTick; } // 0x000000018526FA70-0x000000018526FB10 
        public bool managerTick { /* [XID] */ /* 0x00000001898AE980-0x00000001898AE9A0 */ get => _managerTick; } // 0x000000018526F7D0-0x000000018526F870 
        public bool managerLateTick { /* [XID] */ /* 0x00000001899B31D0-0x00000001899B31F0 */ get => _managerLateTick; } // 0x000000018526F730-0x000000018526F7D0 
        public virtual bool canTickIfDisable { /* [XID] */ /* 0x0000000189A7C610-0x0000000189A7C630 */ get => _canTickIfDisable; /* [XID] */ /* 0x0000000189A83F70-0x0000000189A83F90 */ set { _canTickIfDisable = true; } } // 0x000000018526F120-0x000000018526F1C0 0x000000018526FFF0-0x00000001852700A0
        public bool canBeTicked { /* [XID] */ /* 0x0000000189AD8440-0x0000000189AD8460 */ get { return (enabled && canTickIfDisable || canTickIfDie && !(_entity != null || _entity.isAlive)); } } // 0x000000018526F030-0x000000018526F120 
        [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
        public bool enabled
        { /* [XID] */ /* 0x0000000189AAC2D0-0x0000000189AAC2F0 */
            get => _enabled; /* [XID] */ /* 0x0000000189917FC0-0x0000000189917FE0 */
            set
            {
                bool isInit;
                if (_hasEnabledInited && _enabled == value || !isPreInited)
                    isInit = false;
                else
                    isInit = isInited;
                if (_enabled != value)
                {
                    _enabled = value;
                    CheckTickableForEntityTickManager();
                }
                if (isInited)
                {
                    _componentManager.RefreshComponentTicksOnSetEnabled(this);
                    _hasEnabledInited = true;
                    if (value)
                    {
                        if (_pluginList != null)
                        {
                            foreach (var plugin in _pluginList)
                            {
                                plugin.OnEnable();
                            }
                        }
                        OnEnable();
                    }
                }
                else
                {
                    if (_pluginList != null)
                    {
                        foreach (var plugin in _pluginList)
                        {
                            plugin.OnDisable();
                        }
                    }
                    OnDisable();
                }
                _componentManager.GetOwner().OnSetComponentEnableDirty();
            }
        } // 0x000000018526F350-0x000000018526F3F0 0x00000001852700A0-0x0000000185270330
        public virtual int tickIntervalRatio { /* [XID] */ /* 0x0000000189B22FD0-0x0000000189B22FF0 */ get => _tickIntervalRatio; /* [XID] */ /* 0x0000000189676DF0-0x0000000189676E10 */ set { _tickIntervalRatio = value; } } // 0x000000018526FC60-0x000000018526FD00 0x0000000185270500-0x00000001852705B0
        public int lastTickInterval { /* [XID] */ /* 0x000000018993D840-0x000000018993D860 */ get => _lastTickInterval; /* [XID] */ /* 0x0000000189944C90-0x0000000189944CB0 */ set { _lastTickInterval = value; } } // 0x000000018526F690-0x000000018526F730 0x00000001852703A0-0x0000000185270450
        public bool isTickableForEntityManager { /* [XID] */ /* 0x000000018998FD00-0x000000018998FD20 */ get => IsTickableForEntityTickManager(); } // 0x000000018526F530-0x000000018526F5E0 
        public virtual bool canBeDestroied
        { /* [XID] */ /* 0x00000001898E9B30-0x00000001898E9B50 */
            get
            {
                if (isInited)
                {
                    return !IsDestroied();
                }
                return false;
            }
        } // 0x000000018526EDD0-0x000000018526EE90 
        public virtual string alias { /* [XID] */ /* 0x0000000189AD0460-0x0000000189AD0480 */ get => _entity.alias; } // 0x000000018526EB20-0x000000018526EBE0 
        public virtual int categoryType { /* [XID] */ /* 0x0000000189907950-0x0000000189907970 */ get => -1; } // 0x000000018526F1C0-0x000000018526F2A0 
        public int cacheTypeID { /* [XID] */ /* 0x0000000189A83F10-0x0000000189A83F30 */ get => ComponentMetaTypeIDGenerator.GetBaseTypeID(metaTypeID); } // 0x000000018526ED10-0x000000018526EDD0 
        public virtual int metaTypeID
        { /* [XID] */ /* 0x0000000189A9A9A0-0x0000000189A9A9C0 */
            get
            {
                bool flag = IsValid();
                Debug.Log("run OptimizationCodeGenerator to gen the metaTypeID for" + flag + "wiki: http://wiki.mihoyo.com/display/HK4E/OptCodeGenratorComponentIDGenerator");
                return -1;
            }
        } // 0x000000018526F870-0x000000018526F9C0 
        public bool isTickable { /* [XID] */ /* 0x0000000189A5E4A0-0x0000000189A5E4C0 */ get => _entity.isTickable; } // 0x000000018526F5E0-0x000000018526F690 
        public int tickLOD { /* [XID] */ /* 0x0000000189B8E100-0x0000000189B8E120 */ get => _entity.tickLOD; } // 0x000000018526FDB0-0x000000018526FE60 
        public int tickBalanceRemainder { /* [XID] */ /* 0x0000000189B95580-0x0000000189B955A0 */ get => _entity.tickBalanceRemainder; } // 0x000000018526FBB0-0x000000018526FC60 
        public int tickInterval { /* [XID] */ /* 0x0000000189B9CBD0-0x0000000189B9CBF0 */ get => _entity.tickInterval; } // 0x000000018526FD00-0x000000018526FDB0 
        public int requestTickInterval { /* [XID] */ /* 0x0000000189BA4260-0x0000000189BA4280 */ get => _entity.requestTickInterval; } // 0x000000018526F9C0-0x000000018526FA70 
        public bool bIgnoreIntervalTick { /* [XID] */ /* 0x0000000189BAB890-0x0000000189BAB8D0 */ get; /* [XID] */ /* 0x0000000189BB5D30-0x0000000189BB5D70 */ set; } // 0x000000018526EBE0-0x000000018526EC40 0x000000018526FF80-0x000000018526FFF0
        public int greaterToDisableInterval { /* [XID] */ /* 0x0000000189BC0360-0x0000000189BC03A0 */ get; /* [XID] */ /* 0x0000000189BCB320-0x0000000189BCB360 */ set; } // 0x000000018526F3F0-0x000000018526F450 0x0000000185270330-0x00000001852703A0
        public bool canBeTickBalanced { /* [XID] */ /* 0x0000000189BD55D0-0x0000000189BD55F0 */ get => ShouldBeTickBalanced(_entity.canBeTickBalanced, _entity.tickInterval); } // 0x000000018526EE90-0x000000018526EF80 
        public float balanceTickDeltaTime { /* [XID] */ /* 0x000000018982E4D0-0x000000018982E4F0 */ get => _entity.balanceTickDeltaTime; } // 0x000000018526EC40-0x000000018526ED10 
        public bool isForceFullTick { /* [XID] */ /* 0x00000001895F12A0-0x00000001895F12C0 */ get => bIgnoreIntervalTick; } // 0x000000018526F450-0x000000018526F530 
        public bool canBeTickedReadonly { /* [XID] */ /* 0x0000000189A6A660-0x0000000189A6A680 */ get => canBeTicked; } // 0x000000018526EF80-0x000000018526F030 
        public int maxTickInterval { /* [XID] */ /* 0x00000001895F7730-0x00000001895F7750 */ set { } } // 0x0000000185270450-0x0000000185270500
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public CycleStat cycleStat { /* [XID] */ /* 0x0000000189B4E570-0x0000000189B4E590 */ get => _cycleStat; } // 0x000000018526F2A0-0x000000018526F350 

        // Nested types
        public enum HandleEventType // TypeDefIndex: 11643
        {
            OnEvent = 0,
            OnEventResolved = 1,
            ListenEvent = 2
        }

        public struct ScopeStatCreation : IDisposable // TypeDefIndex: 11644
        {
            // Fields
            private BaseComponent comp; // 0x00

            // Constructors
            public ScopeStatCreation(BaseComponent inComp)
            {
                comp = inComp;
            } // 0x000000018528A670-0x000000018528A6F0

            // Methods
            // [XID] // 0x000000018979C850-0x000000018979C870
            public void Dispose()
            {
                OnFinishCreateComponent(comp);
            } // 0x000000018528A600-0x000000018528A670
        }

        // Constructors
        protected BaseComponent()
        {
            _cycleStat = new CycleStat(GetType().FullName, this, 1);
            OnStartCreateComponent(this);
        } // 0x000000018526E980-0x000000018526EB20

        // Methods
        // [XID] // 0x00000001899D82F0-0x00000001899D8310
        protected static Type[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000185269240-0x00000001852692E0
                                                                             // [XID] // 0x00000001899DF900-0x00000001899DF920
        protected static EventID[] GetSelfOnEventIDsRemoveFromBase() => default; // 0x00000001852692E0-0x0000000185269380
                                                                                 // [XID] // 0x00000001896FF710-0x00000001896FF730
        public EventID[] GetSelfOnEventIDs()
        {
            if (_isSelfOnEventIDsCached)
            {
                return _selfOnEventIDsCache;
            }
            else
            {
                _isSelfOnEventIDsCached = true;
                _selfOnEventIDsCache = GetMetaInfo().selfOnEventResolvedIDs;
            }
            return _selfOnEventIDsCache;
        }// 0x0000000185269380-0x0000000185269480
         // [XID] // 0x0000000189A6D2D0-0x0000000189A6D2F0
        protected static System.Type[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001852690A0-0x0000000185269140
                                                                                        // [XID] // 0x00000001898DB500-0x00000001898DB520
        public EventID[] GetSelfListenEventIDs()
        {
            if (_isSelfListenEventIDsCached)
            {
                return _selfListenEventIDsCache;
            }
            else
            {
                _isSelfListenEventIDsCached = true;
                _selfListenEventIDsCache = GetMetaInfo().selfListenEventIDs;
            }
            return _selfListenEventIDsCache;
        }// 0x0000000185269140-0x0000000185269240
         // [XID] // 0x00000001898F2640-0x00000001898F2660
        public virtual bool IsActive()
        {
            if (enabled && IsValid())
            {
                return _entity.IsActive();
            }
            return false;
        }// 0x0000000185269F80-0x000000018526A070
         // [XID] // 0x00000001898F9D80-0x00000001898F9DA0
        public virtual bool IsValid()
        {
            if (_entity != null)
            {
                if (!isInited || _isToBeRemoved || _isDestroied)
                    return false;
                else
                    return _entity.IsValid();
            }
            return false;
        }// 0x000000018526A3A0-0x000000018526A480
         // [XID] // 0x0000000189ABB870-0x0000000189ABB890
        public virtual bool IsEntityReady()
        {
            if (_entity != null && !_entity.IsRecycled)
            {
                return _entity.IsEntityReady();
            }
            return false;
        }// 0x000000018526A120-0x000000018526A1F0
         // [XID] // 0x000000018991F630-0x000000018991F650
        public virtual void OnEnable() { } // 0x000000018526AE80-0x000000018526AF20
                                           // [XID] // 0x00000001896600A0-0x00000001896600C0
        public virtual void OnDisable() { } // 0x000000018526ADE0-0x000000018526AE80
                                            // [XID] // 0x000000018994C2C0-0x000000018994C2E0
        public virtual int GetTickInterval()
        {
            return tickIntervalRatio * tickLOD + 1;
        }// 0x0000000185269540-0x0000000185269610
         // [XID] // 0x0000000189953930-0x0000000189953950
        protected void RegisterTickMethodForEntityTickManager(Action<float> tickMethod)
        {
            if (_tickMethodForEntityTickManager != null)
            {
                _tickMethodForEntityTickManager = tickMethod;
                _isTickableForEntityTickManager = false;
                if (_lateTickMethodForEntityTickManager != null)
                {
                    _entity.RegisterComponentForEntityTickManager(this);
                }
                CheckTickForEntityTickManager();
            }
        } // 0x000000018526C990-0x000000018526CA80
          // [XID] // 0x00000001896D8CF0-0x00000001896D8D10
        protected void UnregisterTickMethodForEntityTickManager()
        {
            if (_tickMethodForEntityTickManager != null)
            {
                CheckTickForEntityTickManager();
                if (_lateTickMethodForEntityTickManager != null)
                {
                    _entity.UnregisterComponentForEntityTickManager(this);
                }
                _isTickableForEntityTickManager = false;
                _tickMethodForEntityTickManager = null;
            }
        } // 0x000000018526E810-0x000000018526E910
          // [XID] // 0x0000000189962E90-0x0000000189962EB0
        private void CheckTickForEntityTickManager(bool? tickable = default)
        {
            if (_tickMethodForEntityTickManager != null)
            {
                bool flag = tickable.HasValue ? tickable.Value : IsTickableForEntityTickManager();
                if (!_isTickableForEntityTickManager.HasValue || _isTickableForEntityTickManager.Value != flag)
                {
                    if (flag)
                    {
                        Singleton<EntityTickManager>.Instance.AddTickMethod(this, _tickMethodForEntityTickManager);
                    }
                }
                else if (_isTickableForEntityTickManager.HasValue)
                {
                    Singleton<EntityTickManager>.Instance.RemoveTickMethod(this, _tickMethodForEntityTickManager);
                }
                _isTickableForEntityTickManager = true;
            }
        } // 0x0000000185266030-0x00000001852662A0
          // [XID] // 0x000000018996A150-0x000000018996A170
        protected void RegisterLateTickMethodForEntityTickManager(Action<float> lateTickMethod)
        {
            if (_lateTickMethodForEntityTickManager != null)
            {
                _lateTickMethodForEntityTickManager = lateTickMethod;
                _isLateTickableForEntityTickManager = false;
                if (_tickMethodForEntityTickManager != null)
                {
                    _entity.RegisterComponentForEntityTickManager(this);
                }
                CheckLateTickForEntityTickManager();
            }
        } // 0x000000018526C8A0-0x000000018526C990
          // [XID] // 0x0000000189971E90-0x0000000189971EB0
        private void UnregisterLateTickMethodForEntityTickManager()
        {
            if (_lateTickMethodForEntityTickManager != null)
            {
                CheckLateTickForEntityTickManager(true);
                if (_tickMethodForEntityTickManager != null)
                {
                    _entity.UnregisterComponentForEntityTickManager(this);
                }
                _isLateTickableForEntityTickManager = false;
                _lateTickMethodForEntityTickManager = null;
            }
        } // 0x000000018526E710-0x000000018526E810
          // [XID] // 0x0000000189979820-0x0000000189979840
        private void CheckLateTickForEntityTickManager(bool? tickable = default)
        {
            if (_lateTickMethodForEntityTickManager != null)
            {
                bool flag = tickable.HasValue ? tickable.Value : IsTickableForEntityTickManager();
                if (!_isLateTickableForEntityTickManager.HasValue || _isLateTickableForEntityTickManager.Value != flag)
                {
                    if (flag)
                    {
                        Singleton<EntityTickManager>.Instance.AddTickMethod(this, _lateTickMethodForEntityTickManager);
                    }
                }
                else if (_isLateTickableForEntityTickManager.HasValue)
                {
                    Singleton<EntityTickManager>.Instance.RemoveTickMethod(this, _lateTickMethodForEntityTickManager);
                }
                _isLateTickableForEntityTickManager = true;
            }
        } // 0x0000000185265DC0-0x0000000185266030
          // [XID] // 0x0000000189AE00E0-0x0000000189AE0100
        public void CheckTickableForEntityTickManager()
        {
            CheckTickForEntityTickManager(IsTickableForEntityTickManager());
            CheckLateTickForEntityTickManager(IsTickableForEntityTickManager());
        } // 0x00000001852662A0-0x00000001852663B0
          // [XID] // 0x0000000189AE7730-0x0000000189AE7750
        protected virtual bool IsTickableForEntityTickManager()
        {
            if (!canBeTicked)
            {
                return false;
            }
            if (!_entity.isTickable)
            {
                return false;
            }
            if (_entity.IsValidLegacy())
            {
                return tickLOD >= 0;
            }
            return false;
        }// 0x000000018526A1F0-0x000000018526A300
         // [XID] // 0x0000000189997630-0x0000000189997650
        public void RetargetRequired(uint newEntityRuntimeID)
        {
            uint oldID = entityRuntimeID;
            entityRuntimeID = newEntityRuntimeID;
            if (_pluginList != null)
            {
                foreach (var plug in _pluginList)
                {
                    plug.Retarget(oldID, newEntityRuntimeID);
                }
            }
        } // 0x000000018526D020-0x000000018526D170
          // [XID] // 0x000000018999F190-0x000000018999F1B0
        public virtual void Retarget() { } // 0x000000018526D170-0x000000018526D210
                                           // [XID] // 0x00000001899A6B90-0x00000001899A6BB0
        public void PreReInit()
        {
            _isToBeRemoved = false;
            _isDestroied = false;
        } // 0x000000018526BC60-0x000000018526BD00
          // [XID] // 0x00000001899AE430-0x00000001899AE450
        public virtual void ReInit(BaseEntity.ReInitReason reason)
        {
            entityRuntimeID = _entity.runtimeID;
        } // 0x000000018526BDC0-0x000000018526BE90
          // [XID] // 0x00000001899B5A60-0x00000001899B5A80
        public virtual void PostReInit() { } // 0x000000018526BA70-0x000000018526BB10
                                             // [XID] // 0x00000001899BD2C0-0x00000001899BD2E0
        public void PreClear()
        {
            _isToBeRemoved = false;
            _isDestroied = false;
            needRetarget = false;
        } // 0x000000018526BB10-0x000000018526BBC0
          // [XID] // 0x00000001899C4CB0-0x00000001899C4CD0
        public virtual void Clear(BaseEntity.ClearReason clearReason) { } // 0x00000001852668B0-0x0000000185266960
                                                                          // [XID] // 0x00000001899CC310-0x00000001899CC330
        public virtual void PreInit() { } // 0x000000018526BBC0-0x000000018526BC60
                                          // [XID] // 0x00000001899D3A60-0x00000001899D3A80
        public virtual void Init() { } // 0x0000000185269EE0-0x0000000185269F80
                                       // [XID] // 0x00000001899DB020-0x00000001899DB040
        public virtual void OnEntityReady() { } // 0x000000018526AF20-0x000000018526AFC0
                                                // [XID] // 0x00000001899E27A0-0x00000001899E27C0
        public virtual void OnSafeDispatch() { } // 0x000000018526B760-0x000000018526B800
                                                 // [XID] // 0x000000018979A550-0x000000018979A570
        public virtual bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => true; // 0x000000018526D6C0-0x000000018526D7B0
                                                                                    // [XID] // 0x00000001897A24C0-0x00000001897A24E0
        protected virtual void Tick(float inDeltaTime) { } // 0x000000018526DBD0-0x000000018526DC80
                                                           // [XID] // 0x00000001899F8DF0-0x00000001899F8E10
        protected virtual void LateTick(float inDeltaTime) { } // 0x000000018526A730-0x000000018526A7E0
                                                               // [XID] // 0x0000000189A003F0-0x0000000189A00410
        private void DestroyRequired()
        {
            if (!_isDestroied)
            {
                enabled = false;
                needRetarget = false;
                if (_componentManager != null)
                {
                    _componentManager.RemoveComponentActions(this);
                }
                if (_pluginList != null)
                {
                    foreach (var plug in _pluginList)
                    {
                        plug.Destroy();
                    }
                }
                ClearPluginList();
                _componentManager = null;
                _isDestroied = true;
            }
        } // 0x0000000185266960-0x0000000185266C90
          // [XID] // 0x0000000189A07AE0-0x0000000189A07B00
        protected virtual void ClearPluginList()
        {
            _pluginList.Clear();
            ObjectPoolUtility.Deallocate(_pluginList);
            _pluginMap.Clear();
            ObjectPoolUtility.Deallocate(_pluginMap);
            _tickPlugins.Clear();
            ObjectPoolUtility.Deallocate(_tickPlugins);
            _disableNoTickPlugins.Clear();
            ObjectPoolUtility.Deallocate(_disableNoTickPlugins);
            _lateTickPlugins.Clear();
            ObjectPoolUtility.Deallocate(_lateTickPlugins);
            _disableNoLateTickPlugins.Clear();
            ObjectPoolUtility.Deallocate(_disableNoLateTickPlugins);
            _onEventPluginMap.Clear();
            ObjectPoolUtility.Deallocate(_onEventPluginMap);
            foreach (List<BaseComponentPlugin> plug in _onEventPluginsMap.Values)
            {
                plug.Clear();
                ObjectPoolUtility.Deallocate(plug);
            }
            _onEventPluginsMap.Clear();
            ObjectPoolUtility.Deallocate(_onEventPluginsMap);
            _listenEventPluginMap.Clear();
            ObjectPoolUtility.Deallocate(_listenEventPluginMap);
            foreach (List<BaseComponentPlugin> plug in _listenEventPluginsMap.Values)
            {
                plug.Clear();
                ObjectPoolUtility.Deallocate(plug);
            }
            _listenEventPluginsMap.Clear();
            ObjectPoolUtility.Deallocate(_listenEventPluginsMap);
        } // 0x00000001852663B0-0x00000001852668B0
          // [XID] // 0x0000000189A0F180-0x0000000189A0F1A0
        public virtual void Destroy()
        {
            onEventIDs.Clear();
            ObjectPoolUtility.Deallocate(onEventIDs);
            listenEventIDs.Clear();
            ObjectPoolUtility.Deallocate(listenEventIDs);
            UnregisterTickMethodForEntityTickManager();
            UnregisterLateTickMethodForEntityTickManager();
        } // 0x0000000185266E60-0x0000000185266F70
          // [XID] // 0x0000000189A167E0-0x0000000189A16800
        public void DestroySelf()
        {
            if (canBeDestroied)
            {
                DestroyRequired();
                Destroy();
            }
            else
            {
                SetIsDestroied();
            }
        } // 0x0000000185266C90-0x0000000185266E60
          // [XID] // 0x0000000189A1DC60-0x0000000189A1DC80
        public bool IsDestroied() => _isDestroied; // 0x000000018526A070-0x000000018526A120
                                                   // [XID] // 0x0000000189A25310-0x0000000189A25330
        private void SetIsDestroied()
        {
            _isDestroied = true;
        } // 0x000000018526D460-0x000000018526D500
          // [XID] // 0x0000000189A33F80-0x0000000189A33FA0
        public void SetComponentManager(ComponentManager component)
        {
            _componentManager = component;
        } // 0x000000018526D210-0x000000018526D2C0
          // [XID] // 0x0000000189A3B6F0-0x0000000189A3B710
        public virtual void ReInitByConfigID(BaseEntity.ReInitReason reason)
        {
            ReInit(reason);
        } // 0x000000018526BD00-0x000000018526BDC0
          // [XID] // 0x000000018978B9F0-0x000000018978BA10
        public bool IsToBeRemove() => _isToBeRemoved; // 0x000000018526A300-0x000000018526A3A0
                                                      // [XID] // 0x00000001898F0FC0-0x00000001898F0FE0
        public void SetToBeRemoved()
        {
            enabled = false;
            _isToBeRemoved = true;
            _componentManager.SetHasComponentsRemoved();
            _componentManager.GetOwner().OnRemoveComponent(this);
        } // 0x000000018526D5E0-0x000000018526D6C0
          // [XID] // 0x0000000189B516C0-0x0000000189B516E0
        public void SetRemovedImmediately()
        {
            _componentManager.GetOwner().OnRemoveComponent(this);
            _componentManager.RemoveComponentImmediately(this);
        } // 0x000000018526D500-0x000000018526D5E0
          // [XID] // 0x0000000189AC2FD0-0x0000000189AC2FF0
        protected virtual bool OnEvent(BaseEvent e) => false; // 0x000000018526B460-0x000000018526B510
                                                              // [XID] // 0x0000000189A61070-0x0000000189A61090
        protected virtual bool ListenEvent(BaseEvent e) => false; // 0x000000018526AC80-0x000000018526AD30
                                                                  // [XID] // 0x0000000189A68ED0-0x0000000189A68EF0
        public bool CanHandleEvent(BaseEvent evt)
        {
            if (!_isToBeRemoved && !_isDestroied)
            {
                if (canHandleEventIfDie || _entity.isAlive)
                    return true;
            }
            return false;
        }// 0x0000000185265CD0-0x0000000185265DC0
         // [XID] // 0x0000000189A70180-0x0000000189A701A0
        public bool HasPlugin(System.Type type) => _pluginMap.ContainsKey(type); // 0x0000000185269BD0-0x0000000185269CA0
                                                                                 // [XID] // 0x0000000189A779A0-0x0000000189A779C0
        public BaseComponentPlugin GetPlugin(System.Type type)
        {
            BaseComponentPlugin value;
            _pluginMap.TryGetValue(type, out value);
            return value;
        }// 0x0000000185268FB0-0x00000001852690A0
        public T GetPlugin<T>() where T : BaseComponentPlugin => default;
        public T GetPluginSupportBase<T>() where T : BaseComponentPlugin => default;
        // [XID] // 0x00000001896874C0-0x00000001896874E0
        public void AddPlugin(BaseComponentPlugin plugin)
        {
            if (_pluginMap != null || !_pluginMap.ContainsKey(GetType()))
            {
                if (_pluginList == null)
                {
                    _pluginList = ObjectPoolUtility.Allocate<List<BaseComponentPlugin>>();
                }
                if (_pluginMap == null)
                {
                    _pluginMap = ObjectPoolUtility.Allocate<Dictionary<System.Type, BaseComponentPlugin>>();
                }
                _pluginList.Add(plugin);
                _pluginMap.Add(GetType(), plugin);
                plugin.SetOwner(this);
                isInited = true;
                plugin.Init();
                if (_hasEnabledInited)
                {
                    if (enabled)
                    {
                        plugin.OnEnable();
                    }
                    else
                    {
                        plugin.OnDisable();
                    }
                }
                HandlePluginActions(plugin);
                AddPluginActions(plugin);
                _componentManager.RefreshComponentActions(this);
            }
        } // 0x0000000185265960-0x0000000185265CD0
          // [IDTag] // 0x0000000189A86A20-0x0000000189A86A60
          // [XID] // 0x0000000189A86A20-0x0000000189A86A60
        public void RemovePlugin(System.Type type)
        {
            if (_pluginMap.ContainsKey(type))
            {
                var value = _pluginMap[type];
                _pluginMap.Remove(type);
                if (_pluginList.Contains(value))
                {
                    _pluginList.Remove(value);
                }
                RemovePluginActions(value);
                canTickIfDisable = true;
                RestoreActions();
            }
            else
            {
                Debug.LogWarning("正在移除不存在的插件" + type);
            }
        } // 0x000000018526CCE0-0x000000018526CF30
        public void RemovePlugin<T>() { }
        // [IDTag] // 0x0000000189A91480-0x0000000189A914C0
        // [XID] // 0x0000000189A91480-0x0000000189A914C0
        public void RemovePlugin(BaseComponentPlugin plugin)
        {
            RemovePlugin(plugin.GetType());
        } // 0x000000018526CC10-0x000000018526CCE0
          // [XID] // 0x000000018998CE00-0x000000018998CE20
        private void HandlePluginsActions()
        {
            foreach (var plugin in _pluginList)
            {
                HandlePluginActions(plugin);
            }
        } // 0x0000000185269730-0x0000000185269840
          // [XID] // 0x0000000189AA3080-0x0000000189AA30A0
        protected virtual void HandlePluginActions(BaseComponentPlugin plugin)
        {
            var meta = GetMetaInfo();
            if (managerTick != false && meta.hasTick)
            {
                hasTick = true;
                plugin.hasTick = true;
            }
            if (managerLateTick != false && meta.hasTick)
            {
                hasLateTick = true;
                plugin.hasLateTick = true;
            }
        } // 0x0000000185269610-0x0000000185269730
          // [XID] // 0x00000001899D8270-0x00000001899D8290
        public IList<BaseComponentPlugin> GetAllPlugins() => _pluginList; // 0x0000000185268560-0x0000000185268640
                                                                          // [XID] // 0x0000000189AB23F0-0x0000000189AB2410
        public BaseEntity GetEntity() => _entity; // 0x0000000185268B60-0x0000000185268C00
                                                  // [XID] // 0x00000001899B3150-0x00000001899B3170
        public BaseEntity GetEntityByRuntimeID()
        {
            if (_entity != null || _entity.runtimeID == entityRuntimeID)
                return _entity;
            Debug.LogError("错误:找不到实体");
            return null;
        }// 0x0000000185268730-0x00000001852687F0
         // [XID] // 0x0000000189AC1410-0x0000000189AC1430
        public void SetEntity(BaseEntity entity)
        {
            _entity = entity;
        } // 0x000000018526D3B0-0x000000018526D460
          // [XID] // 0x0000000189AC8CE0-0x0000000189AC8D00
        public void SetEntityToBeRemoved()
        {
            _entity.SetToBeRemoved(ref _entity);
        } // 0x000000018526D2C0-0x000000018526D3B0
        public T GetLogicComponent<T>(int inMetaTypeID)
            where T : LCBase => default;
        public T GetVisualComponent<T>(int inMetaTypeID)
            where T : VCBase => default;
        // [XID] // 0x0000000189AD8130-0x0000000189AD8150
        public virtual void HandleSelfComponentActions()
        {
            var meta = GetMetaInfo();
            if (managerTick != false && meta.hasTick)
            {
                hasTick = true;
                _selfHasTick = true;
            }
            if (managerLateTick != false && meta.hasTick)
            {
                hasLateTick = true;
                _selfHasLateTick = true;
            }
            InitComponentEventIDs();
        } // 0x0000000185269840-0x0000000185269950
          // [XID] // 0x00000001899852F0-0x0000000189985310
        protected void InitComponentEventIDs()
        {
            onEventIDs.Clear();
            var selfOnEventIDs = GetSelfOnEventIDs();
            if (selfOnEventIDs != null)
            {
                if (onEventIDs == null)
                {
                    onEventIDs = ObjectPoolUtility.Allocate<List<EventID>>();
                    ExtensionMethods.EnsureCapacity(onEventIDs, onEventIDs.Count + selfOnEventIDs.Length);
                    foreach (var cnm in selfOnEventIDs)
                    {
                        onEventIDs.Add(cnm);
                    }
                }
            }
            listenEventIDs.Clear();
            var selfOnEventIDs2 = GetSelfOnEventIDs();
            if (selfOnEventIDs2 != null)
            {
                if (listenEventIDs == null)
                {
                    listenEventIDs = ObjectPoolUtility.Allocate<List<EventID>>();
                    ExtensionMethods.EnsureCapacity(listenEventIDs, listenEventIDs.Count + selfOnEventIDs2.Length);
                    foreach (var cnm in selfOnEventIDs2)
                    {
                        listenEventIDs.Add(cnm);
                    }
                }
            }
        } // 0x0000000185269CA0-0x0000000185269EE0
          // [XID] // 0x0000000189AE74A0-0x0000000189AE74C0
        public virtual void RestoreActions()
        {
            hasTick = false;
            onEventIDs.Clear();
            _selfHasTick = false;
            HandleSelfComponentActions();
            HandlePluginsActions();
            _componentManager.RefreshComponentActions(this);
        } // 0x000000018526CF30-0x000000018526D020
          // [XID] // 0x0000000189AEF230-0x0000000189AEF250
        protected virtual void AddPluginActions(BaseComponentPlugin plugin)
        {
            if (plugin.hasTick)
            {
                if (_tickPlugins == null)
                {
                    _tickPlugins = ObjectPoolUtility.Allocate<List<BaseComponentPlugin>>();
                }
                if (!_tickPlugins.Contains(plugin))
                {
                    _tickPlugins.Add(plugin);
                }
            }
            if (plugin.hasLateTick)
            {
                if (_lateTickPlugins == null)
                {
                    _lateTickPlugins = ObjectPoolUtility.Allocate<List<BaseComponentPlugin>>();
                }
                if (!_lateTickPlugins.Contains(plugin))
                {
                    _lateTickPlugins.Add(plugin);
                }
            }
            TryToAddEventPlugin(plugin, HandleEventType.OnEvent);
            TryToAddEventPlugin(plugin, HandleEventType.ListenEvent);
        } // 0x00000001852657A0-0x0000000185265960
          // [XID] // 0x0000000189994B40-0x0000000189994B60
        private void TryToAddEventPlugin(BaseComponentPlugin plugin, HandleEventType handleEventType)
        {
            EventID[] pluginEventIDs;
            if (handleEventType >= HandleEventType.OnEventResolved)
            {
                if (handleEventType >= HandleEventType.ListenEvent)
                {
                    SuperDebug.Assert(false, "handleEventType is not valid On TryToAddEventPlugin");
                }
                pluginEventIDs = plugin.GetSelfListenEventIDs();
            }
            else
            {
                pluginEventIDs = plugin.GetSelfOnEventIDs();
            }
            if (pluginEventIDs != null)
            {
                var selfEventIDs = listenEventIDs;
                var selfListenPluginMap = _listenEventPluginMap;
                var selfEventPlguinsMap = _listenEventPluginsMap;
                if (pluginEventIDs != null)
                {
                    if (handleEventType >= HandleEventType.OnEventResolved)
                        if (listenEventIDs == null)
                            listenEventIDs = ObjectPoolUtility.Allocate<List<EventID>>();
                    selfEventIDs = listenEventIDs;
                    selfListenPluginMap = _listenEventPluginMap;
                    selfEventPlguinsMap = _listenEventPluginsMap;

                }
                else
                {
                    if (onEventIDs == null)
                        onEventIDs = ObjectPoolUtility.Allocate<List<EventID>>();
                    selfEventIDs = onEventIDs;
                    selfListenPluginMap = _onEventPluginMap;
                    selfEventPlguinsMap = _onEventPluginsMap;
                }
                if (pluginEventIDs.Length > 0)
                {
                    foreach (var pluginID in pluginEventIDs)
                    {
                        if (!selfEventIDs.Contains(pluginID))
                        {
                            selfEventIDs.Add(pluginID);
                        }
                    }
                    foreach (var pluginID in pluginEventIDs)
                    {
                        if (selfEventPlguinsMap != null && selfEventPlguinsMap.ContainsKey(pluginID))
                        {
                            var componentPlugin = selfEventPlguinsMap[pluginID];
                            if (componentPlugin == null)
                            {
                                componentPlugin = ObjectPoolUtility.Allocate<List<BaseComponentPlugin>>();
                            }
                            if (componentPlugin.Contains(plugin))
                            {
                                componentPlugin.Add(plugin);
                                continue;
                            }
                        }
                        else
                        {
                            if (selfListenPluginMap == null)
                            {
                                selfListenPluginMap = ObjectPoolUtility.Allocate<Dictionary<EventID, BaseComponentPlugin>>();
                                if (handleEventType >= HandleEventType.OnEventResolved)
                                    _listenEventPluginMap = selfListenPluginMap;
                                else
                                    _onEventPluginMap = selfListenPluginMap;

                                selfListenPluginMap.Add(pluginID, plugin);
                                continue;
                            }
                            if (!selfListenPluginMap.ContainsKey(pluginID))
                            {
                                selfListenPluginMap.Add(pluginID, plugin);
                                continue;
                            }
                            if (selfListenPluginMap[pluginID] != plugin)
                            {
                                var temp = selfListenPluginMap[pluginID];
                                selfListenPluginMap.Remove(pluginID);

                                if (selfEventPlguinsMap == null)
                                {
                                    selfEventPlguinsMap = ObjectPoolUtility.Allocate<Dictionary<EventID, List<BaseComponentPlugin>>>();
                                    if (handleEventType >= HandleEventType.OnEventResolved)
                                        _listenEventPluginsMap = selfEventPlguinsMap;
                                    else
                                        _onEventPluginsMap = selfEventPlguinsMap;

                                    if (selfEventPlguinsMap.ContainsKey(pluginID))
                                    {
                                        SuperDebug.Assert(false, "eventPluginsMap should not eventID" + _entity.ToString() + " " + pluginID + " " + plugin.ToString());
                                    }
                                    else
                                    {
                                        var basePluginList = ObjectPoolUtility.Allocate<List<BaseComponentPlugin>>();
                                        selfEventPlguinsMap.Add(pluginID, basePluginList);
                                        basePluginList.Add(temp);
                                        basePluginList.Add(plugin);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        } // 0x000000018526DC80-0x000000018526E370
          // [XID] // 0x000000018999C3A0-0x000000018999C3C0
        private void TryToRemoveEventPlugin(BaseComponentPlugin plugin, HandleEventType handleEventType)
        {
            EventID[] eventID;
            if (handleEventType >= HandleEventType.OnEventResolved)
            {
                eventID = plugin.GetSelfListenEventIDs();
            }
            else
            {
                eventID = plugin.GetSelfOnEventIDs();
            }
            if (eventID != null)
            {
                var pluginMap = (handleEventType >= HandleEventType.OnEventResolved ? _listenEventPluginMap : _onEventPluginMap);
                foreach (var id in eventID)
                {
                    pluginMap.Remove(id);
                    TryToRemovePluginFromEventPluginsMap(id, plugin, handleEventType);
                }
            }
        } // 0x000000018526E370-0x000000018526E550
          // [XID] // 0x000000018997D770-0x000000018997D790
        private void TryToRemovePluginFromEventPluginsMap(EventID eventID, BaseComponentPlugin plugin, HandleEventType handleEventType)
        {
            var pluginMap = (handleEventType >= HandleEventType.OnEventResolved ? _listenEventPluginsMap : _onEventPluginsMap);
            pluginMap.TryGetValue(eventID, out var plugins);
            if (plugins != null)
            {
                for (int i = 0; i < plugins.Count; i++)
                {
                    if (plugins[i] == plugin)
                    {
                        plugins[i] = null;
                        break;
                    }
                }
                if (ExtensionMethods.CheckIsAllNulls(plugins))
                {
                    pluginMap.Remove(eventID);
                }
            }
        } // 0x000000018526E550-0x000000018526E710
          // [XID] // 0x0000000189B0CA80-0x0000000189B0CAA0
        protected virtual void RemovePluginActions(BaseComponentPlugin plugin)
        {
            if (plugin != null)
            {
                if (plugin.hasTick)
                {
                    _tickPlugins.Remove(plugin);
                    _disableNoTickPlugins.Remove(plugin.GetType());
                }
                if (plugin.hasLateTick)
                {
                    _lateTickPlugins.Remove(plugin);
                    _disableNoLateTickPlugins.Remove(plugin.GetType());
                }
            }
            TryToRemoveEventPlugin(plugin, HandleEventType.OnEvent);
            TryToRemoveEventPlugin(plugin, HandleEventType.ListenEvent);
        } // 0x000000018526CA80-0x000000018526CC10
          // [XID] // 0x0000000189B14000-0x0000000189B14020
        protected virtual ComponentHelper.ComponentMetaInfo GetMetaInfo()
        {
            ComponentHelper.ComponentMetaInfo retMeta = new ComponentHelper.ComponentMetaInfo();
            ComponentHelper.ComponentMetaInfo metaInfo;
            if (ComponentHelper.HasMetaInfo(GetType()))
            {
                metaInfo = ComponentHelper.GetMetaInfo(GetType());
                retMeta.hasTick = metaInfo.hasTick;
                retMeta.selfOnEventResolvedIDs = metaInfo.selfOnEventResolvedIDs;
                retMeta.scriptDataFieldInfos = metaInfo.scriptDataFieldInfos;
            }
            else
            {
                var handle = System.Type.GetTypeFromHandle(System.Type.GetTypeHandle(this));
                metaInfo = ComponentHelper.FillComponentMetaInfo(GetType(), handle);
                retMeta.hasTick = metaInfo.hasTick;
                retMeta.selfOnEventResolvedIDs = metaInfo.selfOnEventResolvedIDs;
                retMeta.scriptDataFieldInfos = metaInfo.scriptDataFieldInfos;
                ComponentHelper.AddMetaInfo(GetType(), retMeta);
            }
            return retMeta;
        }// 0x0000000185268C00-0x0000000185268EA0
         // [XID] // 0x00000001899C1E90-0x00000001899C1EB0
        public void RefreshPluginTicksOnSetEnabled(BaseComponentPlugin plugin)
        {
            if (!_entity.IsValid()) return;
            var pluginType = plugin.GetType();
            if (plugin != null)
            {
                if (plugin.enabled)
                {
                    if (plugin.hasTick)
                    {
                        if (_tickPlugins != null)
                        {
                            _tickPlugins[_disableNoTickPlugins[pluginType]] = plugin;
                        }
                    }
                    if (plugin.hasLateTick)
                    {
                        if (_lateTickPlugins != null)
                        {
                            _lateTickPlugins[_disableNoLateTickPlugins[pluginType]] = plugin;
                        }
                    }
                    _componentManager.RefreshComponentTicksOnSetPluginEnabled(this, plugin.enabled, plugin.hasTick, plugin.hasLateTick);
                    return;
                }
            }
            if (plugin.enabled)
            {
                _componentManager.RefreshComponentTicksOnSetPluginEnabled(this, plugin.enabled, plugin.hasTick, plugin.hasLateTick);
                return;
            }
            int pluginIndex;
            if (plugin.hasTick)
            {
                pluginIndex = GetPluginIndex(_tickPlugins, plugin);
                if (pluginIndex == -1) return;
                if (_disableNoTickPlugins == null)
                {
                    _disableNoTickPlugins = ObjectPoolUtility.Allocate<Dictionary<System.Type, int>>();
                }
                _disableNoTickPlugins[pluginType] = pluginIndex;
                _tickPlugins[pluginIndex] = null;
            }
            if (plugin.hasLateTick)
            {
                pluginIndex = GetPluginIndex(_tickPlugins, plugin);
                if (pluginIndex != -1)
                {
                    if (_disableNoLateTickPlugins == null)
                    {
                        _disableNoLateTickPlugins = ObjectPoolUtility.Allocate<Dictionary<System.Type, int>>();
                    }
                    _disableNoLateTickPlugins[pluginType] = pluginIndex;
                    _lateTickPlugins[pluginIndex] = null;
                }
            }
            _componentManager.RefreshComponentTicksOnSetPluginEnabled(this, plugin.enabled, plugin.hasTick, plugin.hasLateTick);
        } // 0x000000018526BE90-0x000000018526C8A0
          // [XID] // 0x0000000189B22E30-0x0000000189B22E50
        private int GetPluginIndex(IList<BaseComponentPlugin> plugins, BaseComponentPlugin plugin)
        {
            for (int i = 0; i < plugins.Count; i++)
            {
                if (plugins[i] == plugin)
                {
                    return i;
                }
            }
            return -1;
        } // 0x0000000185268EA0-0x0000000185268FB0
          // [XID] // 0x0000000189B2A4A0-0x0000000189B2A4C0
        public bool HasAnyTickPlugin()
        {
            bool flag = false;
            if (_tickPlugins == null || _tickPlugins.Count == 0) return false;
            foreach (var plugin in _tickPlugins)
            {
                if (plugin.enabled)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }// 0x0000000185269A90-0x0000000185269BD0
         // [XID] // 0x0000000189B319E0-0x0000000189B31A00
        public bool HasAnyLateTickPlugin()
        {
            bool flag = false;
            if (_lateTickPlugins == null || _lateTickPlugins.Count == 0) return false;
            foreach (var plugin in _lateTickPlugins)
            {
                if (plugin.enabled)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }// 0x0000000185269950-0x0000000185269A90
         // [XID] // 0x0000000189B38E30-0x0000000189B38E50
        public void TickAction(float inDeltaTime)
        {
            if (_tickPlugins != null)
            {
                foreach (var plugin in _tickPlugins)
                {
                    if (plugin.enabled)
                    {
                        plugin.Tick(inDeltaTime);
                    }
                }
            }
            if (_selfHasTick)
            {
                Tick(inDeltaTime);
            }
        } // 0x000000018526D920-0x000000018526DBD0
          // [XID] // 0x0000000189B40A10-0x0000000189B40A30
        public void LateTickAction(float inDeltaTime)
        {
            if (_lateTickPlugins != null)
            {
                foreach (var plugin in _lateTickPlugins)
                {
                    if (plugin.enabled)
                    {
                        plugin.LateTick(inDeltaTime);
                    }
                }
            }
            if (_selfHasLateTick)
            {
                LateTick(inDeltaTime);
            }
        } // 0x000000018526A480-0x000000018526A730
          // [XID] // 0x0000000189B482D0-0x0000000189B482F0
        public bool OnEventAction(BaseEvent evt)
        {
            bool flag = false;
            if (_onEventPluginMap != null && _onEventPluginMap.TryGetValue(evt.eventID, out var plugin))
            {
                flag |= plugin.OnEvent(evt);
            }
            else
            {
                if (_onEventPluginsMap != null && _onEventPluginsMap.TryGetValue(evt.eventID, out var plugins))
                {
                    foreach (var p in plugins)
                    {
                        flag |= p.OnEvent(evt);
                    }
                }
            }
            if (ExtensionMethods.Contains(GetSelfOnEventIDs(), evt.eventID))
            {
                flag |= OnEvent(evt);
            }
            return flag;
        }// 0x000000018526AFC0-0x000000018526B460
         // [XID] // 0x000000018975EE90-0x000000018975EEB0
        public bool ListenEventAction(BaseEvent evt)
        {
            bool flag = false;
            if (_listenEventPluginMap != null && _listenEventPluginMap.TryGetValue(evt.eventID, out var plugin))
            {
                flag |= plugin.ListenEvent(evt);
            }
            else
            {
                if (_listenEventPluginsMap != null && _listenEventPluginsMap.TryGetValue(evt.eventID, out var plugins))
                {
                    foreach (var p in plugins)
                    {
                        flag |= p.ListenEvent(evt);
                    }
                }
            }
            if (ExtensionMethods.Contains(GetSelfListenEventIDs(), evt.eventID))
            {
                flag |= ListenEvent(evt);
            }
            return flag;
        }// 0x000000018526A7E0-0x000000018526AC80
         // [XID] // 0x0000000189B57220-0x0000000189B57240
        public virtual void OnComponentInitFinish(object compData) { } // 0x000000018526AD30-0x000000018526ADE0
        [Preserve] // 0x0000000189B5EC40-0x0000000189B5EC80
                   // [XID] // 0x0000000189B5EC40-0x0000000189B5EC80
        public virtual string Dump() => default; // 0x0000000185266F70-0x0000000185268290
                                                 // [XID] // 0x0000000189B7F380-0x0000000189B7F3A0
        public bool isTargetType(int inMetaTypeID)
        {
            bool flag = false;
            int typeID = ComponentMetaTypeIDGenerator.GetBaseTypeID(metaTypeID);
            int inTypeID = ComponentMetaTypeIDGenerator.GetBaseTypeID(inMetaTypeID);
            if (typeID == inTypeID)
            {
                bool lc = ComponentMetaTypeIDGenerator.IsLC(metaTypeID);
                bool inlc = ComponentMetaTypeIDGenerator.IsLC(inMetaTypeID);
                flag = lc == inlc;
            }
            return flag;
        }// 0x000000018526FE60-0x000000018526FF80
         // [XID] // 0x0000000189BDD190-0x0000000189BDD1B00x000000018526FE60
        public bool ShouldBeTickBalanced(bool entityCanBeTickedBalanced, int entityTickInterval)
        {
            bool flag = false;
            if (bIgnoreIntervalTick)
            {
                flag = true;
            }
            else if (greaterToDisableInterval > 0 && entityTickInterval > greaterToDisableInterval)
            {
                flag = false;
            }
            return flag;
        }// 0x000000018526D7B0-0x000000018526D920
         // [XID] // 0x0000000189B1A0D0-0x0000000189B1A0F0
        public static void OnStartCreateComponent(BaseComponent inComponent) // ShiyumeWarning : I'm not sure if this code is correctly reversed
        {
            if (inComponent != null)
            {
                addComponentScopeCounter = default;
            }
        } // 0x000000018526B800-0x000000018526BA70
          // [XID] // 0x000000018960F390-0x000000018960F3B0
        public static void OnFinishCreateComponent(BaseComponent inComponent) // ShiyumeWarning : I'm not sure if this code is correctly reversed
        {
            if (inComponent != null)
            {
                addComponentScopeCounter = default;
            }
        } // 0x000000018526B510-0x000000018526B760
          // [XID] // 0x0000000189616930-0x0000000189616950
        public string GetStatName() => _cycleStat.statID; // 0x0000000185269480-0x0000000185269540
                                                          // [XID] // 0x0000000189A69080-0x0000000189A690A0
        public string GetEntityName() => _entity.cycleStat.statID; // 0x0000000185268990-0x0000000185268A60
                                                                   // [XID] // 0x00000001896DBCA0-0x00000001896DBCC0
        public uint GetEntityConfigID() => _entity.configID; // 0x00000001852687F0-0x00000001852688A0
                                                             // [XID] // 0x00000001897B1370-0x00000001897B1390
        public Vector3 GetEntityPosition() => _entity.GetAbsolutePosition(); // 0x0000000185268A60-0x0000000185268B60
                                                                             // [XID] // 0x0000000189634B60-0x0000000189634B80
        public int GetEntityAppearedFrame() => LevelModule.GetEntiyStateInfo(_entity.runtimeID).frameAppear; // 0x0000000185268640-0x0000000185268730
                                                                                                             // [XID] // 0x000000018963C260-0x000000018963C280
        public int GetEntityCreatedFrame() => LevelModule.GetEntiyStateInfo(_entity.runtimeID).frameCreated; // 0x00000001852688A0-0x0000000185268990

        // 逆向log没有意义
        // [XID] // 0x000000018964AF20-0x000000018964AF40
        //public CycleStatLogNode GenerateThisFrameTickStatLog() => default; // 0x0000000185268290-0x00000001852684B0
        // [XID] // 0x000000018968D740-0x000000018968D760
        //public string GenerateTickStatLog() => default; // 0x00000001852684B0-0x0000000185268560
    }
}