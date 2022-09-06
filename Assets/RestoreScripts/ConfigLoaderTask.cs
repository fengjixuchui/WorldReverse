/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ConfigLoaderTask : ThreadTask<ConfigLoaderData> // TypeDefIndex: 26584
{
    // Fields
    private const string _taskName = "ConfigLoader"; // Metadata: 0x00B0C5A4
    private Dictionary<int, ConfigLoadAndSerializePattern> _loadingDic; // 0x48
    private Queue<ConfigSerializePattern> _serializeingPatterns; // 0x50
    private Queue<ConfigSerializePattern> _readedPatterns; // 0x58
    public static bool loadExcelFromBin; // 0x00
    public static bool loadInLevelDataFromBin; // 0x01

    // Properties
    public override string taskName { /* [XID] */ /* 0x0000000189AE0720-0x0000000189AE0740 */ get => default; } // 0x00000001812531B0-0x0000000181253260 

    // Constructors
    public ConfigLoaderTask() { } // 0x00000001812530C0-0x00000001812531B0
    static ConfigLoaderTask() { } // 0x0000000181253050-0x00000001812530C0

    // Methods
    // [XID] // 0x0000000189AE7CD0-0x0000000189AE7CF0
    private void AddToLoadingDic(ConfigLoadAndSerializePattern pattern) { } // 0x00000001812528A0-0x0000000181252A90
                                                                            // [XID] // 0x0000000189AEF9B0-0x0000000189AEF9D0
    private void RemoveFromLoadingDic(int index) { } // 0x0000000181251120-0x0000000181251210
                                                     // [XID] // 0x0000000189AF6F10-0x0000000189AF6F30
    private ConfigLoadAndSerializePattern GetLoadingPattern(int index) => default; // 0x00000001812527B0-0x00000001812528A0
                                                                                   // [XID] // 0x0000000189AFE500-0x0000000189AFE520
    public override void Init(int taskId, IGraph graph, IRunnerPool runnerPool, int groupId) { } // 0x0000000181251F00-0x0000000181252080
                                                                                                 // [XID] // 0x0000000189B05C70-0x0000000189B05C90
    private void InitLoadFrom() { } // 0x0000000181251C00-0x0000000181251CA0
                                    // [XID] // 0x0000000189B0D440-0x0000000189B0D460
    public override void Collect() { } // 0x0000000181251320-0x00000001812513F0
                                       // [XID] // 0x0000000189B148E0-0x0000000189B14900
    public void ClearOnLevelDestroy() => _loadingDic.Clear(); // 0x0000000181251270-0x0000000181251320
    // [XID] // 0x0000000189B1C2A0-0x0000000189B1C2C0
    private void DispatchPatternLoad() { } // 0x0000000181251020-0x0000000181251120
                                           // [XID] // 0x0000000189B238B0-0x0000000189B238D0
    private void LoadConfig(ConfigLoadAndSerializePattern pattern) { } // 0x0000000181251CA0-0x0000000181251EA0
                                                                       // [XID] // 0x0000000189B2AB50-0x0000000189B2AB70
    private void LoadConfigFromBin(ulong sourcePath, ConfigLoadAndSerializePattern pattern) { } // 0x0000000181252C00-0x0000000181252E50
                                                                                                // [XID] // 0x0000000189B32080-0x0000000189B320A0
    private void LoadConfigFromBinCallback(int index, ulong requestedPath, bool loadSucceeded, byte[] bytes) { } // 0x00000001812523E0-0x00000001812527B0
                                                                                                                 // [XID] // 0x0000000189B39930-0x0000000189B39950
    private void LoadConfigFromJson(ulong sourcePath, ConfigLoadAndSerializePattern pattern) { } // 0x0000000181252190-0x00000001812523E0
                                                                                                 // [XID] // 0x0000000189B412B0-0x0000000189B412D0
    private void LoadConfigFromJsonCallback(int index, ulong requetedPath, bool loadSucceeded, uint handle, TextAsset asset) { } // 0x00000001812513F0-0x0000000181251610
                                                                                                                                 // [XID] // 0x0000000189B48BC0-0x0000000189B48BE0
    private void DispatchPatternSerialize() { } // 0x0000000181252080-0x0000000181252190
                                                // [XID] // 0x0000000189B50330-0x0000000189B50350
    public override void Execute() { } // 0x0000000181251740-0x00000001812518E0
                                       // [XID] // 0x0000000189B57AE0-0x0000000189B57B00
    private void ReadConfig(ConfigSerializePattern pattern, int threadFlag = 1 /* Metadata: 0x00B0C59C */) { } // 0x0000000181252E50-0x0000000181252F50
                                                                                                               // [XID] // 0x0000000189B5F4B0-0x0000000189B5F4D0
    public override void Flush() { } // 0x00000001812518E0-0x0000000181251C00
                                     // [XID] // 0x0000000189B66B60-0x0000000189B66B80
    protected override void OnDestroy() { } // 0x0000000181252F50-0x0000000181253050
                                            // [XID] // 0x0000000189B55B20-0x0000000189B55B40
    public ConfigLoadAndSerializePattern CreateLoadPattern(Action onFinished, SerializeBinHandler onBinSerialize, SerializeJsonHandler onJsonSerialize, Action<object, ulong> onReaded, SerializationUtils.PackedBinCategory category = SerializationUtils.PackedBinCategory.NONEXCEL /* Metadata: 0x00B0C5A0 */) => default; // 0x0000000181252A90-0x0000000181252C00
}

