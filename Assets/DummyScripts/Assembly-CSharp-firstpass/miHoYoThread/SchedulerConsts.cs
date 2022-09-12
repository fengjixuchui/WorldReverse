/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699
/// <summary>
/// 已完成-计划更新类型构造
/// 2022/09/13
/// </summary>
namespace miHoYoThread
{
    public class SchedulerConsts // TypeDefIndex: 9046
    {
        // Fields
        private string[] SchedulerTypeEntryNames; // 0x10
        private string[] SchedulerTypeMainEntryNames; // 0x18
        private string[] SchedulerTypeWaitNames; // 0x20
        private string[] SchedulerTypeFlushNames; // 0x28
        private int[] SchedulerPrioritys; // 0x30

        // Constructors
        public SchedulerConsts()
        {
            SchedulerTypeEntryNames = new string[9];
            SchedulerTypeEntryNames[0] = "SchedulerEntry_Update";
            SchedulerTypeEntryNames[1] = "SchedulerEntry_LatePreUpdate";
            SchedulerTypeEntryNames[2] = "SchedulerEntry_LatePostUpdate";
            SchedulerTypeEntryNames[3] = "SchedulerEntry_AfterResToUpdateEnd";
            SchedulerTypeEntryNames[4] = "SchedulerEntry_LatePostToNextBeforeLateUpdate";
            SchedulerTypeEntryNames[5] = "SchedulerEntry_RenderToNextBeforeRes";
            SchedulerTypeEntryNames[6] = "SchedulerEntry_RenderToNextBeforeLateUpdate";
            SchedulerTypeEntryNames[7] = "SchedulerEntry_RenderToNextNetwork";
            SchedulerTypeEntryNames[8] = "SchedulerEntry_AfterNetworkToRender";

            SchedulerTypeMainEntryNames = new string[9];
            SchedulerTypeMainEntryNames[0] = "SchedulerMainEntry_Update";
            SchedulerTypeMainEntryNames[1] = "SchedulerMainEntry_LatePreUpdate";
            SchedulerTypeMainEntryNames[2] = "SchedulerMainEntry_LatePostUpdate";
            SchedulerTypeMainEntryNames[3] = "SchedulerMainEntry_AfterResToUpdateEnd";
            SchedulerTypeMainEntryNames[4] = "SchedulerMainEntry_LatePostToNextBeforeLateUpdate";
            SchedulerTypeMainEntryNames[5] = "SchedulerMainEntry_RenderToNextBeforeRes";
            SchedulerTypeMainEntryNames[6] = "SchedulerMainEntry_RenderToNextBeforeLateUpdate";
            SchedulerTypeMainEntryNames[7] = "SchedulerMainEntry_RenderToNextNetwork";
            SchedulerTypeMainEntryNames[8] = "SchedulerMainEntry_AfterNetworkToRender";

            SchedulerTypeWaitNames = new string[9];
            SchedulerTypeWaitNames[0] = "SchedulerWait_Update";
            SchedulerTypeWaitNames[1] = "SchedulerWait_LatePreUpdate";
            SchedulerTypeWaitNames[2] = "SchedulerWait_LatePostUpdate";
            SchedulerTypeWaitNames[3] = "SchedulerWait_AfterResToUpdateEnd";
            SchedulerTypeWaitNames[4] = "SchedulerWait_LatePostToNextBeforeLateUpdate";
            SchedulerTypeWaitNames[5] = "SchedulerWait_RenderToNextBeforeRes";
            SchedulerTypeWaitNames[6] = "SchedulerWait_RenderToNextBeforeLateUpdate";
            SchedulerTypeWaitNames[7] = "SchedulerWait_RenderToNextNetwork";
            SchedulerTypeWaitNames[8] = "SchedulerWait_AfterNetworkToRender";

            SchedulerTypeFlushNames = new string[9];
            SchedulerTypeFlushNames[0] = "SchedulerFlush_Update";
            SchedulerTypeFlushNames[1] = "SchedulerFlush_LatePreUpdate";
            SchedulerTypeFlushNames[2] = "SchedulerFlush_LatePostUpdate";
            SchedulerTypeFlushNames[3] = "SchedulerFlush_AfterResToUpdateEnd";
            SchedulerTypeFlushNames[4] = "SchedulerFlush_LatePostToNextBeforeLateUpdate";
            SchedulerTypeFlushNames[5] = "SchedulerFlush_RenderToNextBeforeRes";
            SchedulerTypeFlushNames[6] = "SchedulerFlush_RenderToNextBeforeLateUpdate";
            SchedulerTypeFlushNames[7] = "SchedulerFlush_RenderToNextNetwork";
            SchedulerTypeFlushNames[8] = "SchedulerFlush_AfterNetworkToRender";
            SchedulerPrioritys = new int[9];
        } // 0x0000000187634320-0x0000000187634FF0

        // Methods
        // [XID] // 0x000000018964F5B0-0x000000018964F5D0
        public virtual string SchedulerTypeEntryName(int schedulerType) => SchedulerTypeEntryNames[schedulerType]; // 0x0000000187633FA0-0x0000000187634080
                                                                                                                   // [XID] // 0x000000018975D040-0x000000018975D060
        public virtual string SchedulerTypeMainEntryName(int schedulerType) => SchedulerTypeMainEntryNames[schedulerType]; // 0x0000000187634160-0x0000000187634240
                                                                                                                           // [XID] // 0x0000000189A9A940-0x0000000189A9A960
        public virtual string SchedulerTypeWaitName(int schedulerType) => SchedulerTypeWaitNames[schedulerType]; // 0x0000000187634240-0x0000000187634320
                                                                                                                 // [XID] // 0x0000000189AA19B0-0x0000000189AA19D0
        public virtual string SchedulerTypeFlushName(int schedulerType) => SchedulerTypeFlushNames[schedulerType]; // 0x0000000187634080-0x0000000187634160
                                                                                                                   // [XID] // 0x0000000189AA8F90-0x0000000189AA8FB0
        public virtual int SchedulerPriority(int schedulerType) => SchedulerPrioritys[schedulerType]; // 0x0000000187633ED0-0x0000000187633FA0
    }
}
