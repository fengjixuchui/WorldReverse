/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MihoyoOptimization;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
    [TickWithFrameDeltaTime] // 0x0000000189B43A80-0x0000000189B43A90
    public class BaseComponentPlugin : ITokenBudgetComponent // TypeDefIndex: 11664
    {
        // Fields
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        protected BaseComponent owner; // 0x10
        [NonSerialized]
        public bool isInited; // 0x18
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public bool hasTick; // 0x19
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public bool hasLateTick; // 0x1A
        private int[] _selfOnEventIDsCache; // 0x20
        private bool _isSelfOnEventIDsCached; // 0x28
        private int[] _selfOnEventResolvedIDsCache; // 0x30
        private bool _isSelfOnEventResolvedIDsCached; // 0x38
        private int[] _selfListenEventIDsCache; // 0x40
        private bool _isSelfListenEventIDsCached; // 0x48
        private bool _enabled; // 0x49
        private bool _hasEnabledInited; // 0x4A
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        protected CycleStat _cycleStat; // 0x50

        // Properties
        public virtual int metaTypeID { /* [XID] */ /* 0x000000018995CC20-0x000000018995CC40 */ get => default; } // 0x0000000185265570-0x00000001852656B0 
        public bool enabled { /* [XID] */ /* 0x0000000189748AA0-0x0000000189748AC0 */ get => default; /* [XID] */ /* 0x0000000189A92E90-0x0000000189A92EB0 */ set { } } // 0x0000000185265420-0x00000001852654C0 0x00000001852656B0-0x00000001852657A0
        public bool isForceFullTick { /* [XID] */ /* 0x0000000189637D80-0x0000000189637DA0 */ get => default; } // 0x00000001852654C0-0x0000000185265570 
        public bool canBeTickedReadonly { /* [XID] */ /* 0x000000018963EFD0-0x000000018963EFF0 */ get => default; } // 0x00000001852652D0-0x0000000185265380 
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public CycleStat cycleStat { /* [XID] */ /* 0x0000000189646900-0x0000000189646920 */ get => default; } // 0x0000000185265380-0x0000000185265420 

        // Constructors
        protected BaseComponentPlugin() { } // 0x00000001852651C0-0x00000001852652D0

        // Methods
        // [XID] // 0x0000000189A7C550-0x0000000189A7C570
        protected static System.Type[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000185264550-0x00000001852645F0
                                                                                    // [XID] // 0x0000000189B77D20-0x0000000189B77D40
        public EventID[] GetSelfOnEventIDs() => default; // 0x00000001852645F0-0x00000001852646E0
                                                         // [XID] // 0x0000000189B7F360-0x0000000189B7F380
        protected static System.Type[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x00000001852646E0-0x0000000185264780
                                                                                            // [XID] // 0x0000000189B86F50-0x0000000189B86F70
        public int[] GetSelfOnEventResolvedIDs() => default; // 0x0000000185264780-0x0000000185264860
                                                             // [XID] // 0x0000000189B8E0E0-0x0000000189B8E100
        protected static System.Type[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001852643C0-0x0000000185264460
                                                                                        // [XID] // 0x0000000189950F10-0x0000000189950F30
        public EventID[] GetSelfListenEventIDs() => default; // 0x0000000185264460-0x0000000185264550
                                                             // [XID] // 0x000000018969E300-0x000000018969E320
        public virtual void Init() { } // 0x0000000185264860-0x0000000185264900
                                       // [XID] // 0x00000001896A5380-0x00000001896A53A0
        public void SetOwner(BaseComponent owner) { } // 0x0000000185265060-0x0000000185265110
                                                      // [XID] // 0x0000000189BBA1E0-0x0000000189BBA200
        public virtual void OnEntityReady() { } // 0x0000000185264BA0-0x0000000185264C40
                                                // [XID] // 0x0000000189BC2300-0x0000000189BC2320
        public virtual void Retarget(uint oldEntityRuntimeID, uint newEntityRuntimeID) { } // 0x0000000185264FA0-0x0000000185265060
                                                                                           // [XID] // 0x0000000189BC98D0-0x0000000189BC98F0
        public virtual void ReInit(BaseEntity.ReInitReason reason) { } // 0x0000000185264EF0-0x0000000185264FA0
                                                                       // [XID] // 0x0000000189BD1050-0x0000000189BD1070
        public virtual void PostReInit() { } // 0x0000000185264E50-0x0000000185264EF0
                                             // [XID] // 0x000000018964B100-0x000000018964B120
        public virtual void Clear(BaseEntity.ClearReason clearReason) { } // 0x0000000185263D70-0x0000000185263E20
                                                                          // [XID] // 0x0000000189BA8980-0x0000000189BA89A0
        public virtual void OnEnable() { } // 0x0000000185264B00-0x0000000185264BA0
                                           // [XID] // 0x00000001895ECCA0-0x00000001895ECCC0
        public virtual void OnDisable() { } // 0x0000000185264A60-0x0000000185264B00
                                            // [XID] // 0x00000001898B45A0-0x00000001898B45C0
        public virtual void Tick(float deltaTime) { } // 0x0000000185265110-0x00000001852651C0
                                                      // [XID] // 0x00000001895FBAE0-0x00000001895FBB00
        public virtual void LateTick(float deltaTime) { } // 0x0000000185264900-0x00000001852649B0
                                                          // [XID] // 0x0000000189603280-0x00000001896032A0
        public virtual void Destroy() { } // 0x0000000185263E20-0x0000000185263EC0
                                          // [XID] // 0x000000018960AC40-0x000000018960AC60
        public virtual bool OnEvent(BaseEvent evt) => default; // 0x0000000185264CF0-0x0000000185264DA0
                                                               // [XID] // 0x0000000189A9A960-0x0000000189A9A980
        public virtual bool OnRemoteEvtBeingHit(BaseEvent evt) => default; // 0x0000000185264DA0-0x0000000185264E50
                                                                           // [XID] // 0x0000000189619B90-0x0000000189619BB0
        public virtual bool OnEventResolved(BaseEvent evt) => default; // 0x0000000185264C40-0x0000000185264CF0
                                                                       // [XID] // 0x0000000189A56840-0x0000000189A56860
        public virtual bool ListenEvent(BaseEvent evt) => default; // 0x00000001852649B0-0x0000000185264A60
                                                                   // [XID] // 0x000000018975F010-0x000000018975F030
        public virtual BaseEntity GetEntity() => default; // 0x0000000185264070-0x0000000185264120
                                                          // [XID] // 0x00000001896ACC00-0x00000001896ACC20
        public ComponentHelper.ComponentMetaInfo GetMetaInfo() => default; // 0x0000000185264120-0x00000001852643C0
                                                                           // [XID] // 0x000000018964E040-0x000000018964E060
        public CycleStatLogNode GenerateThisFrameTickStatLog() => default; // 0x0000000185263EC0-0x0000000185263FC0
                                                                           // [XID] // 0x0000000189655930-0x0000000189655950
        public string GenerateTickStatLog() => default; // 0x0000000185263FC0-0x0000000185264070
    }
}
