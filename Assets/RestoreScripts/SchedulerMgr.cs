/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.Scripting;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
    public class SchedulerMgr : ISchedulerMgr // TypeDefIndex: 9050
    {
        // Fields
        private static SchedulerMgr _inst; // 0x00
        protected SchedulerConsts _consts; // 0x10
        protected PoolType _poolType = PoolType.INVALID; // 0x18
        protected IRunnerPool _multiThreadPool; // 0x20
        protected IRunnerPool _mainThreadPool; // 0x28
        protected IRunnerPool _runnerPool; // 0x30
        protected IScheduler[] _schedulers; // 0x38
        protected bool _multiThread = true; // 0x40
        protected bool _isStarting; // 0x41
        protected bool _isFinishing; // 0x42
        protected bool _isStarted; // 0x43

        // Properties
        public static SchedulerMgr Inst { /* [XID] */ /* 0x00000001898F00A0-0x00000001898F00C0 */ get => _inst; } // 0x0000000187638BC0-0x0000000187638C90 
        public bool IsMultiThread { /* [XID] */ /* 0x0000000189628A40-0x0000000189628A60 */ get => _multiThread; } // 0x0000000187638C90-0x0000000187638D30 
        public bool isStarted { /* [XID] */ /* 0x0000000189638000-0x0000000189638020 */ get => _isStarted; } // 0x0000000187638D30-0x0000000187638DD0 

        // Methods
        // [XID] // 0x00000001895ECE60-0x00000001895ECE80
        public static void Create()
        {
            JobProxy.Init();
            _inst = new SchedulerMgr();
            _inst.Init();
        } // 0x0000000187636D90-0x0000000187636EC0
          // [XID] // 0x00000001895FBCF0-0x00000001895FBD10
        public static void SwitchThread(bool value)
        {
            if (_inst != null)
            {
                _inst.SwitchMultiThread(value);
            }
        } // 0x00000001876388C0-0x00000001876389D0
          // [XID] // 0x0000000189603580-0x00000001896035A0
        public static void PreDispose()
        {
            if (_inst != null)
            {
                _inst.Finish();
            }
        } // 0x0000000187637850-0x0000000187637950
          // [XID] // 0x000000018974B830-0x000000018974B850
        public static void Dispose()
        {
            if (_inst != null)
            {
                _inst.Finish();
                _inst.Destroy();
                _inst = null;
            }
        } // 0x00000001876370B0-0x00000001876371F0
          // [XID] // 0x00000001896123E0-0x0000000189612400
        public IRunnerPool GetRunnerPool() => _runnerPool; // 0x0000000187637600-0x00000001876376A0
                                                           // [XID] // 0x0000000189619D30-0x0000000189619D50
        public IGraph GetGraph(int schedulerType) => (IGraph)_schedulers[schedulerType]; // 0x0000000187637510-0x0000000187637600
                                                                                         // [XID] // 0x00000001896211D0-0x00000001896211F0
        public IGraph GetBackgroundGraph() => default; // 0x0000000187637470-0x0000000187637510
                                                       // [XID] // 0x00000001896302F0-0x0000000189630310
        public void SwitchMultiThread(bool value)
        {
            _multiThread = value;
        } // 0x00000001876385D0-0x0000000187638680
          // [XID] // 0x0000000189954FC0-0x0000000189954FE0
        public void Start()
        {
            _isStarting = true;
        } // 0x0000000187638530-0x00000001876385D0
          // [XID] // 0x0000000189646A40-0x0000000189646A60
        public void CheckStarted()
        {
            if (_isStarting)
            {
                _isStarted = true;
            }
            else if (_isFinishing)
            {
                _isFinishing = false;
            }
        } // 0x0000000187636CE0-0x0000000187636D90
          // [XID] // 0x000000018964E280-0x000000018964E2A0
        public void Finish()
        {
            _isStarting = false;
        } // 0x00000001876373D0-0x0000000187637470
          // [XID] // 0x0000000189ACE2D0-0x0000000189ACE2F0
        public virtual void Init()
        {
            _consts = new SchedulerConsts();
            _schedulers = new IScheduler[9];
            for (int i = 0; i < _schedulers.Length, i++)
            {
                _schedulers[i] = Scheduler.Create((SchedulerType)i, _consts.SchedulerPriority(i));
            }
            SwitchRunner(PoolType.MULTI_THREAD, Environment.ProcessorCount - 1);
        } // 0x00000001876376A0-0x0000000187637850
          // [XID] // 0x0000000189A61380-0x0000000189A613A0
        protected void CheckRunner() { } // 0x0000000187636C00-0x0000000187636CE0
                                         // [XID] // 0x0000000189664910-0x0000000189664930
        public virtual void SwitchRunner(PoolType poolType, int threadNum) { } // 0x0000000187638680-0x00000001876388C0
                                                                               // [XID] // 0x00000001899CB790-0x00000001899CB7B0
        public void SpawnScheduleTask(ISchedulerTask task) { } // 0x0000000187638420-0x0000000187638530
                                                               // [XID] // 0x0000000189673D60-0x0000000189673D80
        public void UnSpawnScheduleTask(ISchedulerTask task) { } // 0x00000001876389D0-0x0000000187638AE0
                                                                 // [XID] // 0x000000018967B580-0x000000018967B5A0
        public void SchedulePause(int schedulerType) { } // 0x0000000187637F60-0x0000000187638050
                                                         // [XID] // 0x0000000189682CD0-0x0000000189682CF0
        public void ScheduleResume(int schedulerType) { } // 0x0000000187638050-0x0000000187638140
                                                          // [XID] // 0x0000000189A58DA0-0x0000000189A58DC0
        public virtual void ScheduleBackgroundPause() { } // 0x0000000187637950-0x00000001876379F0
                                                          // [XID] // 0x0000000189A68510-0x0000000189A68530
        public virtual void ScheduleBackgroundResume() { } // 0x00000001876379F0-0x0000000187637A90
                                                           // [XID] // 0x0000000189699910-0x0000000189699930
        public void ScheduleEntry(int schedulerType, bool lockScene) { } // 0x0000000187637B30-0x0000000187637C90
                                                                         // [XID] // 0x00000001896A0F30-0x00000001896A0F50
        public void ScheduleMainThreadEntry(int schedulerType) { } // 0x0000000187637E30-0x0000000187637F60
                                                                   // [XID] // 0x00000001896A8390-0x00000001896A83B0
        public void ScheduleWaitAllFinished(int schedulerType) { } // 0x00000001876381E0-0x0000000187638310
                                                                   // [XID] // 0x0000000189A77010-0x0000000189A77030
        public void ScheduleWaitAllTypeFinished() { } // 0x0000000187638310-0x0000000187638420
                                                      // [XID] // 0x0000000189673A60-0x0000000189673A80
        public void ScheduleFlush(int schedulerType, bool lockScene) { } // 0x0000000187637C90-0x0000000187637E30
                                                                         // [XID] // 0x0000000189A862D0-0x0000000189A862F0
        public void ScheduleBackground() { } // 0x0000000187637A90-0x0000000187637B30
                                             // [XID] // 0x00000001896C5930-0x00000001896C5950
        public void ScheduleWaitAllBackgroundFinished() { } // 0x0000000187638140-0x00000001876381E0
                                                            // [XID] // 0x00000001898D25B0-0x00000001898D25D0
        public virtual void Destroy() { } // 0x0000000187636EC0-0x00000001876370B0
        [Preserve] // 0x00000001896D43A0-0x00000001896D43E0
                   // [XID] // 0x00000001896D43A0-0x00000001896D43E0
        public virtual string Dump() => default; // 0x00000001876371F0-0x00000001876373D0
    }
}
