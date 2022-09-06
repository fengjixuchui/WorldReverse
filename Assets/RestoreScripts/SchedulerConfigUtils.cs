/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SchedulerConfigUtils // TypeDefIndex: 19477
{
    // Fields
    private const int DEFAULT_INDEX = 0; // Metadata: 0x00AFC8DC
    private static Dictionary<SimpleSafeInt32, ConfigJob> _jobConfigDic; // 0x00
    private static ConfigLoaderTask _configLoaderTask; // 0x08
    private static ConfigValidationTask _configValidationTask; // 0x10

    // Properties
    private static string _configPath { /* [XID] */ /* 0x000000018975DD30-0x000000018975DD50 */ get => default; } // 0x00000001816FE500-0x00000001816FE5A0 

    // Constructors
    public SchedulerConfigUtils() { } // 0x00000001816FE650-0x00000001816FE6B0
    static SchedulerConfigUtils() { } // 0x00000001816FE5A0-0x00000001816FE650

    // Methods
    // [XID] // 0x0000000189765390-0x00000001897653B0
    public static void LoadScheduleConfig() { } // 0x00000001816FDF10-0x00000001816FDFD0
                                                // [XID] // 0x000000018976CDE0-0x000000018976CE00
    public static void ReloadFromFile() { } // 0x00000001816FDE50-0x00000001816FDF10
                                            // [XID] // 0x00000001897741F0-0x0000000189774210
    private static void LoadJobConfigData() { } // 0x00000001816FD8B0-0x00000001816FDBA0
                                                // [XID] // 0x0000000189BBBD90-0x0000000189BBBDB0
    public static ConfigJob GetJobConfig(int id) => default; // 0x00000001816FDD10-0x00000001816FDE50
                                                             // [XID] // 0x0000000189783430-0x0000000189783450
    public static void StartConfigThreadTasks() { } // 0x00000001816FE100-0x00000001816FE240
                                                    // [XID] // 0x000000018978AA60-0x000000018978AA80
    public static void StopConfigThreadTasks() { } // 0x00000001816FE240-0x00000001816FE380
                                                   // [XID] // 0x0000000189792100-0x0000000189792120
    public static void ClearOnLevelDestroy()
    {
        if (_configLoaderTask)
        {
            _configLoaderTask.ClearOnLevelDestroy();
        }
        if (_configValidationTask)
        {
            _configValidationTask.ClearOnLevelDestroy();
        }
    } // 0x00000001816FDBA0-0x00000001816FDD10
      // [XID] // 0x0000000189A88640-0x0000000189A88660
    public static ConfigLoadAndSerializePattern CreateLoadPattern(Action onFinished, SerializeBinHandler onBinSerialize, SerializeJsonHandler onJsonSerialize, Action<object, ulong> onReaded, SerializationUtils.PackedBinCategory category = SerializationUtils.PackedBinCategory.NONEXCEL /* Metadata: 0x00AFC8D8 */) => default; // 0x00000001816FE380-0x00000001816FE500
                                                                                                                                                                                                                                                                                                                                     // [XID] // 0x0000000189B379C0-0x0000000189B379E0
    public static ConfigHashValidationPattern CreateValidationPattern(ConfigHashGetter hashGetter, Action<uint, int, object, uint> onHashCalculated) => default; // 0x00000001816FDFD0-0x00000001816FE100
}

